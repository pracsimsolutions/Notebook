# PracSim Notebook

A tabbed notebook docked inside FlexSim's 3D modeler — **Scoping**, **Notes**, **Board** (Kanban), **Canvases** (drawing), and **Validation** (per-run input/output capture). Everything you write persists inside the `.fsm` model file, so notes travel with the model. No installer, no telemetry, no network calls.

> **Work in progress — `main` is a moving target.** No tagged releases, no stable API, no compatibility promise. Expect breaking changes between commits.
>
> **Supported FlexSim version:** this branch targets **FlexSim 2026**. Other versions will live on sibling branches.
>
> Built by an AI assistant (Claude) for Josh at [Practical Simulation Solutions](https://pracsimsolutions.com), released as MIT open source. Questions/bugs/ideas: **<josh@pracsimsolutions.com>**.

## Requirements

- **FlexSim 2026** (Windows) with a valid FlexSim license
- **Visual Studio 2022** with the *Desktop development with C++* workload
- **Node.js 20+**
- **Git**

## Setup

```powershell
cd "C:\Program Files\FlexSim 2026\modules"
git clone https://github.com/pracsimsolutions/Notebook.git
cd Notebook\NotebookDLL
start NotebookDLL.sln
```

In Visual Studio: set the configuration to **x64**, then **Ctrl+Shift+B** to build. This produces `Notebook.dll` at the repo root.

Then launch FlexSim, open any model, open the **FlexScript Console** (View → Other), type `addnotebook`, and press Enter. The panel appears docked next to your 3D view; drag its tab to dock wherever. It reopens automatically when you reload that model.

**Permission denied on `git clone`?** Run PowerShell as administrator.
**`LNK1104: cannot open file 'Notebook.dll'`?** FlexSim is holding the old DLL — close FlexSim entirely and rebuild.
**`cannot open source file BasicMacros.h`?** The repo isn't inside a FlexSim install directory — clone it into `…\FlexSim 2026\modules\`.

## Development loop

| What changed | Run | Reload |
|---|---|---|
| C++ in `NotebookDLL/` | Ctrl+Shift+B in VS | Close FlexSim entirely, reopen |
| HTML/JS/CSS in `webview/` | `node tools/embed.js` | Close + reopen the panel |
| FlexScript in `Notebook.fsx` | (save) | Reload the model |

Non-obvious bit: FlexSim doesn't read `webview/index.html` directly — it reads the copy baked into `Notebook.fsx` by `tools/embed.js`. Forget the embed and your HTML changes won't show up.

For architecture, the JS↔DLL bridge, and extension recipes, see [AGENTS.md](AGENTS.md).

## Where data lives

Inside the `.fsm` model file, under `Tools/Notebook/`. Copy the `.fsm` and the notes come along. Nothing in `%APPDATA%`, no network calls.

## License

[MIT](LICENSE.txt) — Copyright (c) 2026 Practical Simulation Solutions. Provided "as is," no warranty.
