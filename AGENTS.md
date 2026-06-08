# AGENTS.md — guide for anyone (human or AI) extending PracSim Notebook

> If you're an AI assistant working in this repo, read this file first. If you're a human picking this up to keep extending it, same. This is the deep-dive for everyone past the README — it documents the build pipeline (especially the non-obvious `webview → embed.js → .fsx` flow), the JS↔DLL bridge architecture, where each kind of thing lives in the source tree, recipes for common extension tasks, and the FlexScript/HTML gotchas that previous contributors have paid for in blood.
>
> Keep this file up to date as you make changes. If you introduce a new convention, gotcha, or extension pattern, add it here.

---

## 1. What this is

PracSim Notebook is a FlexSim 2026 module: a tabbed notebook (Scoping / Notes / Board / Canvases / Validation) that lives inside the FlexSim 3D modeler. Its UI is HTML/JS/CSS embedded inside a FlexSim "WebPanel" (Chromium Embedded Framework). All state persists in the FlexSim tree under per-tab nodes (`>variables/tabs/<name>` plus `>variables/settings`), so the notebook travels with the `.fsm` file. Export/Import JSON moves content between models.

This file documents how the pieces fit together and how to add new functionality without breaking the existing assumptions.

---

## 2. Build pipeline

Two artifacts get produced from source: the embedded webview (baked into `Notebook.fsx`) and `Notebook.dll`. Each has its own pipeline.

```
webview/index.html  ──(node tools/embed.js)──>  XML-escaped string  ──injected into──>  Notebook.fsx
                                                                                            │
                                                                                            ▼
                                                                       FlexSim loads .fsx, regenerates .t,
                                                                       CEF reads the variables/html string,
                                                                       unescapes it, renders the panel.
```

```
NotebookDLL/*.cpp ──(Visual Studio 2022, x64)──> Notebook.dll
                                                      │
                                                      ▼
                                            FlexSim loads it on startup;
                                            DLL registers Notebook_* commands
                                            via add_nodefunctions.
```

### Key constraints

- **Never hand-edit the embedded HTML inside `Notebook.fsx`.** It's XML-escaped (`<` → `&lt;` etc.) and ~400 KB on one logical line. Always edit `webview/index.html` and re-run `node tools/embed.js`.
- **`.fsx` takes precedence over `.t` in dev.** When both are present in the module folder, FlexSim prefers `.fsx`; `.t` is the fallback. The dev iteration loop is just `edit webview/index.html` → `node tools/embed.js` → reopen the panel. No Save Defaults required in dev.
- **C++ DLL changes** require a Visual Studio rebuild AND a full FlexSim restart. Windows pins loaded DLLs to the running process — reloading the model alone won't pick up new code. If the linker fails with `LNK1104 cannot open file 'Notebook.dll'`, FlexSim is still running and holding the old DLL.

### Edit / build / reload cycle by change type

| What you change | What to run | Reload how |
|---|---|---|
| C++ code under `NotebookDLL/` | Press Ctrl+Shift+B in Visual Studio | **Close FlexSim entirely**, then reopen |
| `webview/index.html` | `node tools/embed.js` from the repo root | Close + reopen the Notebook panel (no FlexSim restart needed) |
| FlexScript inside `Notebook.fsx` directly | (just save the file) | Reload the model |

---

## 3. Repo layout

```
.gitignore             — excludes build artifacts (Notebook.dll, Notebook.t, dist/, etc.)
AGENTS.md              — this file
LICENSE.txt            — MIT
README.md              — user-facing setup walkthrough
Notebook.fsx           — the FlexSim module (XML tree with embedded HTML — generated; do not hand-edit)
Notebook.png           — 16×16 toolbox bitmap
Notebook.ico           — Windows icon for installers (kept for forks that want to ship binaries)

webview/
  index.html           — editable source of the entire UI

tools/
  embed.js             — Node helper: index.html → escaped → injected into .fsx

NotebookDLL/
  NotebookDLL.sln        — Visual Studio solution
  NotebookDLL.vcxproj    — project file
  exports.cpp            — registers Notebook_* commands via add_nodefunctions
  module.cpp             — DLL init/shutdown stubs
  tab_storage.{h,cpp}    — Notebook_saveTab, Notebook_loadTab, Notebook_loadAllTabs (+ orphan-image GC)
  image_storage.{h,cpp}  — Notebook_saveImage, Notebook_loadImages
  snapshot.{h,cpp}       — Notebook_snapshotModelState (reads Model.parameters + Model.performanceMeasures)
  tree_io.{h,cpp}        — helpers for walking >variables tree nodes
  flexsimcontent/        — FlexSim SDK headers + libs (gitignored — copied locally by copyheaders.bat)
```

---

## 4. Architecture

### Per-tab persistence model

Each tab serializes to its own tree node so editing one tab doesn't rewrite the others. The JS bridge calls one-line FlexScript event-function shims under `>html>eventfunctions/`, which immediately delegate to the DLL via `applicationcommand("Notebook_*", ...)`.

| Data | Tree-node path | Bridge call |
|---|---|---|
| Scoping | `>variables/tabs/scoping` | `Notebook_loadTab` / `Notebook_saveTab` |
| Notes | `>variables/tabs/notes` | same |
| Board | `>variables/tabs/board` | same |
| Canvases | `>variables/tabs/canvases` | same |
| Validation | `>variables/tabs/validation` | same |
| App-wide settings | `>variables/settings` | same with `name="settings"` |
| Pasted images (base64) | `>variables/images/<id>` | `Notebook_saveImage` / `Notebook_loadImages` |

The path has "Notebook" twice in the actual tree (`Tools/Notebook/Notebook`) because `addnotebook` clones the library template into a container of the same name. The DLL looks it up via `Model.find("Tools/Notebook/Notebook")` then `tool.find(">variables")` (the NavAssist idiom).

### JS ↔ DLL bridge

`fireFlexsimEvent(name, args)` from JS looks `name` up in `>html>eventfunctions/` (FlexSim's WebPanel-event namespace), invokes the FlexScript shim there, which calls `applicationcommand("Notebook_*", ...)` to reach the DLL function registered under `add_nodefunctions`. The shims are one-liners; all real work happens in the DLL. The shim layer exists purely because `fireFlexsimEvent` from JS doesn't search the `add_nodefunctions` namespace — it only sees event-function names.

### Registered DLL commands

- `Notebook_loadTab(name)` → that tab's JSON string (or empty)
- `Notebook_saveTab(name, json, aliveImgIdsCSV)` → `"ok"`; also GCs orphaned images by sweeping `>variables/images/*` against the alive list
- `Notebook_loadAllTabs()` → one JSON object `{tabName: tabJson, ...}` (batch read at startup; empty tabs come back as `null`)
- `Notebook_saveImage(id, base64)` → `"ok"`
- `Notebook_loadImages(idsCSV)` → JSON `{id: base64, ...}`
- `Notebook_snapshotModelState()` → JSON `{parameters: [...], performanceMeasures: [...]}` reading the model's current parameter and performance-measure tables. Captures both `.value` (raw) and `.evaluate()` (resolved) for parameters. Called by the Validation tab's Snapshot button.

### Save lifecycle

A **dirty-tabs set** tracks which tabs have unsaved edits. Edits call `saveDebounced(tabName)` or `saveImmediate(tabName)` — if no tab name is passed, the helpers default to `state.settings.activeTab` (correct ~always since edits happen in the visible tab's handlers).

- `saveImmediate(tab)` clears any pending timer, then writes only the dirty tabs (one bridge call per tab). Used for discrete actions: add/delete, drag-end on mouseup, blur with pending changes, paste, theme change, tab switch.
- `saveDebounced(tab)` resets a 500 ms timer (default `autoSaveDelay`) — used for free-form typing in contenteditables.
- `flushSaveOnClose` on `beforeunload` / `pagehide` / `visibilitychange` synchronously flushes the dirty set and shows a "Saving…" overlay so closing the panel mid-typing doesn't lose the last keystrokes.
- Pan/zoom is debounced — view-only state, doesn't affect content.

Every persistent state mutation triggers a save in the same tick. Drag-end (board cards, canvas shapes, canvas multi-select group, resize) saves once on `mouseup`, never mid-drag.

### Image GC

On every per-tab save the JS passes an "alive IDs" list (computed across the whole state) to `Notebook_saveTab`; the DLL walks the images node and destroys orphaned ones. This keeps the model file from accumulating dead pasted-image blobs as users delete notes/cards/shapes.

### Canvas infinite-view model

- SVG `viewBox` tracks the wrap's actual rect via `getCanvasViewSize()` — no fixed virtual stage size.
- `.cnv-stage-wrap` is `overflow: hidden` — no scrollbars; pan and zoom only.
- `updateCanvasViewBox()` patches the viewBox in place on window resize and after first-render (since the wrap doesn't exist during the initial innerHTML pass).
- Pan: hold Space (or middle-mouse) and drag.
- Zoom: wheel (zooms around cursor), `+`/`−` buttons, `Ctrl+Shift+F` fit-to-shapes, right-click → Reset Zoom.

### Toolbar overflow (Google-Slides pattern)

`applyToolbarOverflow()` measures the toolbar after render. If it's wider than its container, trailing items are **moved** (not cloned, preserving listeners) into a body-attached popover behind a `…` button. Re-fires on window resize.

### Inline prompt (replaces `window.prompt`)

CEF renders native `prompt()` as a text-only dialog with no input field. The custom `inlinePrompt(message, default, anchorRect)` returns `Promise<string|null>` and renders a small popover anchored near the trigger element (e.g. the link button in the toolbar).

### Export & import

The Export ▾ menu (top nav) exposes three actions:

- **Export as HTML** — self-contained readable HTML document with every tab's content. Open in a browser, print to PDF, archive.
- **Export data (JSON)** — single JSON payload with every per-tab node + the image cache. Restore later via Import.
- **Import data (JSON)** — replaces all tabs + images with a previously-exported JSON. Destructive — confirms first.

The JSON export format is versioned (`format: "pracsim-notebook"`, `formatVersion: 1`) so future imports can detect/upgrade older exports.

---

## 5. Recipes

### Add a new tab

1. Add the tab's tree-node lookup to `tab_storage.cpp` — match the existing pattern for `scoping`/`notes`/`board`/`canvases`/`validation`. The DLL routes `Notebook_loadTab("yourtab")` and `Notebook_saveTab("yourtab", ...)` to the matching `>variables/tabs/yourtab` node.
2. In `webview/index.html`, add a tab button to the top tab strip, a tab panel section, and a state slice in the JS state object.
3. Wire the tab's edit handlers to call `saveDebounced("yourtab")` or `saveImmediate("yourtab")`.
4. Add the tab to the initial `loadAllTabs` parse in JS.
5. Run `node tools/embed.js` from the repo root.
6. Reopen the Notebook panel in FlexSim.

### Add a new persistent field to an existing tab

1. Extend the tab's JSON shape in the JS state model (e.g. a new property on each Note).
2. Wire the new field's UI to call the tab's existing save path (`saveDebounced(tab)` for free-form typing, `saveImmediate(tab)` for discrete actions).
3. No DLL changes — tab JSON is opaque to the DLL.
4. Re-embed and reload.

### Add a new bridge command (JS calls into DLL)

1. Add a one-liner FlexScript shim under `>html>eventfunctions/` in `Notebook.fsx`:
   ```xml
   <node f="442" dt="2"><name>Notebook_yourCommand</name><data>return applicationcommand("Notebook_yourCommand", param(1));</data></node>
   ```
   And a matching `add_nodefunctions` registration:
   ```xml
   <node f="1000042" dt="2"><name>Notebook_yourCommand</name><data>dll:"module:Notebook" func:"Notebook_yourCommand"</data></node>
   ```
2. Add the C++ function in a new or existing translation unit under `NotebookDLL/` and register it via `add_nodefunctions` (see `exports.cpp` for the pattern).
3. Call from JS: `fireFlexsimEvent('Notebook_yourCommand', [arg1])`.
4. Rebuild the DLL in Visual Studio. Close FlexSim entirely and reopen.

---

## 6. FlexScript gotchas (paid for in blood)

- `length` is a property, not a method. Use `arr.length`, not `arr.length()`.
- `destroyobject(node)`, not `destroynode`.
- Tree-node path lookup: use `Model.find(...)` + `tool.find(">attr")`, not raw `node("path>attr")`.
- For GC sweeps: `String.split(",")` + `Array.indexOf` (FlexScript has no `find` method).
- Empty `<data>` cells in the `.fsx` XML template must NOT carry `dt="2"` — FlexSim refuses to open. Use `nodeadddata(n, DATATYPE_STRING)` in event functions to populate them at runtime.

---

## 7. JS/HTML gotchas

- A literal `</script>` inside a JS string aborts HTML parsing. Write `<\/script>`.
- `String.replace(re, "$1...")` with a string second argument interprets `$1`/`$2` as backreferences. `tools/embed.js` uses the function form for that reason.
- `formatBlock('h1')` inside a `<li>` wraps the heading inside the list item. The toolbar handler detects an ancestor list, toggles it off, then formats.
- Inline code button uses `execCommand('insertHTML', '<code>…</code>')` in a try/catch — custom Range manipulation was unreliable in CEF.
- FlexSim's host intercepts `Ctrl+Z` (and likely `Ctrl+Y/S/A`) in WebPanels before CEF sees them. Notebook's undo is button-driven for that reason — don't rely on keyboard undo handlers inside the webview.

---

## 8. When you finish a non-trivial change

Update this file. Specifically:

- If you added a new extension recipe pattern, add it under "Recipes."
- If you hit a non-obvious constraint and worked around it, add it under "FlexScript gotchas" or "JS/HTML gotchas" so the next person doesn't rediscover it.
- If you added a new DLL command, add it under "Registered DLL commands."
- If you changed where something lives in the tree, update "Per-tab persistence model."

The goal: this file should be the place an AI session can read once and have enough context to make a safe, well-shaped change without rediscovering everything by grep.
