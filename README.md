# PracSim Notebook

> **WORK IN PROGRESS — NO STABLE VERSION YET.** Every part of this repo is in active flux. APIs change, files move, features get reworked or removed between commits. There is no tagged release, no documented stable surface, and no compatibility promise. If you clone and build right now, expect rough edges and breaking changes. Treat the `main` branch as a moving target.
>
> **About this project** — PracSim Notebook was built by an AI assistant (Claude) working under direction from Josh at **[Practical Simulation Solutions](https://pracsimsolutions.com)**, as a hobby project. Released as MIT-licensed open source for anyone who finds it useful, interesting, or fun to fork.
>
> **Curious? Have a suggestion? Found a bug?** Email Josh at **<josh@pracsimsolutions.com>** — happy to hear from you.

A tabbed notebook that lives inside FlexSim's 3D modeler. Five tabs — **Scoping**, **Notes**, **Board** (Kanban), **Canvases** (drawing surface), and **Validation** (per-run capture of model inputs/outputs/observations) — all docked next to your 3D view. Everything you write persists inside the `.fsm` model file, so your notes travel with the model.

> **Supported FlexSim version:** this branch currently targets **FlexSim 2026**. Support for other versions will live on separate branches as they're added — for now, `main` is the 2026 branch.

**Released under the [MIT License](LICENSE.txt) — clone, build, modify, ship. No installer, no activation, no telemetry.**

| | |
|---|---|
| **Status** | Working — five tabs (Scoping, Notes, Board, Canvases, Validation), per-tab undo, JSON export/import, HTML export. |
| **License** | MIT |
| **Platform** | Windows-only (FlexSim required). |
| **Build** | Visual Studio 2022 (C++ desktop workload) + Node.js 20+. |

---

## Is this for me?

This walkthrough is written assuming you've used FlexSim before but are not a daily software developer. If you've never touched Git, never opened Visual Studio, never typed in PowerShell — that's fine. Each step explains what's happening and what success looks like.

You'll get the most out of Notebook if you:
- Use **FlexSim** for actual modeling work (see the supported-version note above).
- Are comfortable installing Windows applications (you'll install three).
- Are willing to read a screen of plain text now and then.
- Have **about 30 minutes** for first-time setup. (There's no AI-provider account step here, so this is shorter than ModelerAI's setup.)

You don't need to know C++, JavaScript, or anything about FlexSim's internals. The build step is "press a button in Visual Studio." There is no command-line wizardry.

---

## What you're going to do, in plain English

1. Install some free Windows software (about 20 minutes).
2. Download the Notebook source code into FlexSim's modules folder.
3. Press a button in Visual Studio to compile the DLL (about 2 minutes).
4. (Only if you edit the UI later) Re-embed the HTML with one Node command.
5. Open FlexSim, type one command in a panel called the FlexScript Console, and the Notebook panel appears docked next to your model.

When you finish, the Notebook will look like a normal docked panel inside FlexSim — five tabs across the top, your notes saved into the model file.

---

## Architecture in one paragraph (skip if you're not curious)

Notebook is a small C++ DLL plus a plain HTML viewer. The C++ DLL ([`NotebookDLL/`](NotebookDLL/)) owns persistence and the JS↔DLL bridge — it knows how to read and write tab data into FlexSim's model tree, how to garbage-collect orphaned pasted images, and how to snapshot the model's parameters and performance measures. The panel UI is plain HTML in [`webview/`](webview/) that gets embedded into [`Notebook.fsx`](Notebook.fsx) by [`tools/embed.js`](tools/embed.js). All notebook data lives inside the `.fsm` model file under `Tools/Notebook/` — nothing in `%APPDATA%`, no network calls, no telemetry.

---

## Setup — full step-by-step from nothing to running

### Step 1 — Install the free Windows software you'll need

Install these in any order. Skip any you already have.

- **FlexSim** (the version this branch supports — see the note at the top) — get it from [flexsim.com](https://www.flexsim.com/) and install it. You need a working FlexSim license to use FlexSim itself; Notebook doesn't get in the middle of that.
- **Visual Studio 2022 — Community Edition** is free. Get it from [visualstudio.microsoft.com/vs/community](https://visualstudio.microsoft.com/vs/community/).
  - When the installer asks **which workloads to install**, tick **"Desktop development with C++"**. That's the box you need. Don't tick Visual Studio Code — that's a different smaller program; we need the full Visual Studio 2022.
  - The C++ workload is ~10 GB. Make sure you have room.
- **Node.js (version 20 or newer)** — get it from [nodejs.org](https://nodejs.org/). Pick the LTS (long-term support) installer. Accept all the defaults during install.
- **Git** — get it from [git-scm.com/download/win](https://git-scm.com/download/win). Accept all defaults during install.

After installing these, **restart your computer once.** This isn't always strictly necessary, but it makes sure the new programs are visible from PowerShell, which we'll use in Step 2.

### Step 2 — Download the Notebook source code

Notebook's source code lives on GitHub. We're going to copy it onto your computer using a program called Git. This is called *cloning* a repo.

Open **PowerShell**. (Hit Windows key, type "powershell", hit Enter.) A black window opens. Don't worry about it — we'll type three short commands.

Type or paste this line and press Enter:

```powershell
cd "C:\Program Files\FlexSim 2026\modules"
```

This moves PowerShell to the folder where FlexSim looks for installed modules. Nothing visible will happen — it'll just show a new prompt.

Then this:

```powershell
git clone https://github.com/pracsimsolutions/Notebook.git
```

You'll see Git print a bunch of text about "Cloning..." and "Receiving objects..." That's normal — it's downloading the source code. Takes about 15 seconds.

Then:

```powershell
cd Notebook
```

You're now inside the Notebook folder.

**A sanity check:** type `ls` (lowercase L, lowercase S) and press Enter. You should see a list including `Notebook.fsx`, `NotebookDLL`, `webview`, and `tools`. If you see those, you're good.

**If PowerShell says** "Access denied" **or** "permission denied" **when running** `git clone`: the `C:\Program Files\FlexSim 2026\modules` folder needs your user to be able to write to it. On a default FlexSim install it's already owned by you, but some installs are stricter. Right-click PowerShell in the Start menu and choose "Run as administrator", then redo the three commands above.

### Step 3 — Build the DLL in Visual Studio

This is the part that turns the C++ source code into a `.dll` file FlexSim can load.

In PowerShell, type:

```powershell
cd NotebookDLL
start NotebookDLL.sln
```

That opens the Visual Studio solution. Visual Studio takes 15–30 seconds to load the first time.

Once Visual Studio is open:

1. **Look at the top toolbar.** There's a dropdown that says either "x86" or "x64". Make sure it says **x64**.
2. Press **Ctrl + Shift + B** to build. (Or use the menu: Build → Build Solution.)
3. Watch the bottom-left status bar. You'll see "Build started..." and then a progress indicator.
4. After 30 seconds to 2 minutes, the bottom-left should say **"Build: 1 succeeded, 0 failed."** That's the green light.

**A new Notebook.dll file is now sitting at the top of the Notebook folder.** That's what FlexSim will load.

**If you see a giant red squiggly mess in the editor:** that's IntelliSense, Visual Studio's live code-analysis. It often shows false errors on first open while it's still indexing. Look at the Build output (bottom panel) — if it says "Build: 1 succeeded," you're fine. Ignore the squigglies.

**If the build fails with** `LNK1104: cannot open file 'Notebook.dll'`: FlexSim is currently running and has the previous Notebook.dll loaded, so the linker can't overwrite it. Close FlexSim entirely (not just the model — the whole application), then press Ctrl + Shift + B again.

**If the build fails with** `cannot open source file BasicMacros.h`: the source code isn't inside a FlexSim install. Make sure your folder really is `C:\Program Files\FlexSim 2026\modules\Notebook\` and not somewhere else.

If something else goes wrong, [email Josh](mailto:josh@pracsimsolutions.com) — happy to help.

### Step 4 — Open FlexSim and start the panel

1. Launch **FlexSim** the normal way.
2. Open or create any model — even a brand-new empty one is fine for a first test.
3. From the menu bar, go to **View → Other → FlexScript Console** (the menu name might be slightly different in your FlexSim version; look for "FlexScript Console" anywhere in View / Tools / Window).
4. A small window appears with a text area. Click in it, type:
   ```
   addnotebook
   ```
   ...and press **Enter**. (Just the word, no slash, no parentheses.)
5. A new docked panel appears with the Notebook UI: a top tab strip with Scoping / Notes / Board / Canvases / Validation. You can drag its tab to dock it wherever you like (next to the 3D view, full-width across the bottom, etc.).

Once you've run `addnotebook` on a model, the Notebook panel **automatically reopens** every time you load that model. You only need to type the command once per model.

---

## Where data is stored

Everything you type, draw, or capture inside Notebook lives inside the `.fsm` model file itself, under a tree node at `Tools/Notebook/`. Save the model and your notes go with it; copy the `.fsm` to another machine and the notes come along.

No files get written to `%APPDATA%`. No network calls. No telemetry. No "phone home." Notebook never talks to anything outside your FlexSim process.

---

## Optional: pre-built binaries

If you'd rather not build from source, contributors can distribute their own builds as `Notebook.dll` + `Notebook.t` (the FlexSim-compiled tree) — those files are gitignored so each fork ships its own copy. Drop them into `C:\Program Files\FlexSim 2026\modules\Notebook\` next to `Notebook.fsx` and you're good. There's no official binary release channel; this is just a note that the artifacts are portable if a friend builds them for you.

---

## Development loop (if you start editing things)

Once everything works, this is the rhythm for changes:

| What you change | What to run | Reload how |
|---|---|---|
| C++ code under `NotebookDLL/` | Press Ctrl + Shift + B in Visual Studio | **Close FlexSim entirely**, then reopen (Windows pins DLLs to the running process — reloading the model alone isn't enough) |
| HTML / JS / CSS under `webview/` | `node tools/embed.js` in PowerShell from the repo root | Close + reopen the Notebook panel (no FlexSim restart needed) |
| FlexScript inside `Notebook.fsx` directly | (just save the file) | Reload the model |

The non-obvious step is the embed: FlexSim doesn't read `webview/index.html` directly — it reads the copy baked into `Notebook.fsx`. If you forget to re-embed after an HTML edit, your change won't appear.

---

## Working on the code

If you want to extend Notebook — whether by hand or with an AI assistant helping you — start with [`AGENTS.md`](AGENTS.md). It documents the build pipeline (especially the non-obvious `webview/index.html` → `tools/embed.js` → `Notebook.fsx` flow), the JS↔DLL bridge architecture, where each kind of thing lives in the source tree, recipes for the common extension tasks (add a tab, add a persistent field, add a new bridge command), and the FlexScript/HTML gotchas that previous contributors have paid for in blood.

---

## Questions, suggestions, or just curious?

Email Josh at **<josh@pracsimsolutions.com>** — happy to hear from you. Whether you want to share a use case, suggest a feature, report something weird, or just chat, the inbox is open.

More about the company that built this: [pracsimsolutions.com](https://pracsimsolutions.com).

---

## License

[MIT](LICENSE.txt). Copyright (c) 2026 Practical Simulation Solutions. Provided "as is," no warranty.
