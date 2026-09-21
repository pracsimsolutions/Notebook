---
title: PracSim Notebook
summary: A tabbed notebook docked inside FlexSim's 3D modeler, saved inside your model file.
order: 1
---

PracSim Notebook keeps your project notes next to the model they describe. It is a panel docked
beside the 3D view with five tabs: Scoping, Notes, Board, Canvases and Validation. Everything you
write is saved inside the `.fsm` model file, so the notes travel with the model. There is no
telemetry and no network access. See [Using the tabs](tabs.md) for what each tab is for.

## Open the Notebook

1. Open any model in FlexSim.
2. Open the **Toolbox**.
3. Double-click **Notebook**.

The panel docks next to your 3D view. Drag its tab to dock it wherever you like. It reopens
automatically when you reload the model.

## Saving and undo

Changes are saved into the model as you work, and a status message at the top right shows when a
save is pending or done. Save the model in FlexSim as usual to keep them in the file.

Each tab has its own **Undo** and **Redo** buttons. Ctrl+Z does not work inside the panel, because
FlexSim intercepts it, so use the buttons.

## The menu

The three-dot button at the top right holds the commands that apply to the whole Notebook.

| Command | What it does |
| --- | --- |
| Export as HTML | Saves a read-only web page of every tab, to read or share with people who do not have the Notebook. |
| Export data (JSON) | Saves everything in one file, for backup or to move your notes to another model. |
| Import data (JSON) | Loads a data file exported earlier. |
| Settings | Choose the Dark or Light theme and how long the Notebook waits after you stop typing before it saves. |
| About | License and contact details. |

> [!WARNING]
> Import replaces everything in the Notebook, including your settings, and cannot be undone. Export
> your current data first if you might want it back.
