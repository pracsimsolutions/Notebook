---
title: Validation
summary: Record each interactive run of your model, with its inputs, outputs, manual changes and your conclusions.
section: tabs
order: 7
---

The Validation tab is a logbook for runs of your model. Each entry, called a run, holds a copy of your model's parameter values, the performance measures it produced, a list of changes you made by hand, and three written sections for what you saw, why you think it happened, and what to try next.

Use it when you are tuning or checking a model by running it yourself and want a dated record of what you changed and what came out. To capture your first run, see [Capture a validation run](../how-to/capture-a-validation-run.md).

> [!NOTE]
> The Validation tab is for interactive single runs. For multi-replication batch experiments, use FlexSim's Experimenter.

## The layout

The tab has a list of runs on the left and the selected run on the right. Above the list are two buttons and a search box:

- **+ Add empty run** creates a blank run that you fill in by hand.
- **Snapshot** creates a new run from the model as it is right now.
- **Search runs** narrows the list to runs whose names contain what you type. It matches names only, and it does not change the run that is open.

New runs are added at the top of the list and become the selected run. Each entry in the list shows the run name, the date and time it was created, and how many parameters it holds (or "empty" if it holds none). Click an entry to open it.

At the top of the tab you will also find **Undo** and **Redo** buttons, described under "Deleting a run" below.

If there are no runs yet, the right side tells you so and reminds you of the two ways to create one.

## What a run contains

Every run has a name at the top. New runs are named "Run 1", "Run 2" and so on. Click the name to rename it; press Enter when you are done. The sidebar updates as you type.

Under the name, a line shows when the run was created, when it was last snapshotted, and (once you have edited it) when it was last modified.

Below that are six sections.

### Inputs: model parameters

A table of the model's parameters with four columns: Name, Value, Units and Description. This is the model's parameters as they were at snapshot time.

### Outputs: performance measures

A table of the model's performance measures with the same four columns, as they were at snapshot time.

### Manual changes

A list for changes that are not captured by the parameter table, for example "moved the machines to a different location". See "Manual changes list" below for how to edit it.

### Observations, Analysis and Next steps

Three text areas for your own notes: what you observed in this run, your interpretation of why it happened, and what you will try next. Each has the same formatting toolbar as the other tabs. See [Format text and paste images](../how-to/format-text-and-paste-images.md).

## Taking a snapshot

**Snapshot** reads every parameter in the model's parameter tables and every performance measure in its performance measure tables, and stores them as a new run. The button briefly reads "Snapshotting" while it works.

If the model has no parameter tables or performance measures, an alert explains that you need to add a Model Parameter Table and a Performance Measure Table from the Toolbox (Toolbox, then Add), and no run is created.

Because Snapshot records the model at that instant, run the model first if you want meaningful outputs.

## Empty runs

**+ Add empty run** creates a run with empty Inputs and Outputs tables. Its list entry says "empty". The tables show a message pointing you to the snapshot button in the section header. Rows cannot be typed into an empty table, so an empty run is mostly useful for its name, manual changes and the three text sections. To fill the tables later, use the per-table snapshot described next.

## Re-snapshotting one table

Each of the Inputs and Outputs sections has a small camera button in its header. It replaces just that table with the model's current values. Nothing else in the run changes, and the run's snapshot time is updated.

If the table already has rows, you are asked to confirm the replacement first. This is handy when you have corrected the model and want fresh outputs for the same run without touching your notes.

## Editing cells

You can edit any cell in the Inputs and Outputs tables by clicking it and typing. Press Enter, or click elsewhere, to keep the change. Cells save as soon as you finish editing.

Edits are for correcting or annotating a record, for example fixing a unit label or adding to a description. They do not change your model.

In the Value column, what you type is interpreted like this:

- A plain number such as `12` or `-3.5` is stored as a number.
- `true` or `false` is stored as a true or false value.
- Text that starts with `{`, `[` or a double quote is read as structured data if it is valid, and kept as text otherwise.
- Anything else is stored as text.

You cannot add or delete individual rows. To refresh the whole table, snapshot it again.

## Manual changes list

Use this list to note changes that a parameter table does not capture.

- Click **+ Add change** to add a line at the bottom. The cursor moves into it.
- Press Enter in a line to add a new line below it.
- Press Shift+Enter to break a line without starting a new one.
- Press Backspace in an empty line to remove it.
- Hover over a line and click the X at its right to remove it.

## Deleting a run

Click **Delete run** at the top right of the run. You are asked to confirm, and the run is removed. The next run in the list becomes the selected one.

Deleting a run does not go to a trash, but you can bring it back with the **Undo** button at the top of the tab. Undo and Redo also step back through snapshots, added runs and changes-list edits. FlexSim can intercept Ctrl+Z before the Notebook sees it, so use the buttons.

## Saving

Changes save automatically. The save status at the top right of the window shows "Unsaved changes" and then "Saved" shortly after you stop typing. See [Change settings and theme](../how-to/change-settings-and-theme.md).

## Exporting

Runs are included when you export the Notebook as HTML or as data. In the HTML export, runs can still be browsed from the list, but the search box, the Snapshot and Add buttons and the Delete button are left out. See [Export and import](../how-to/export-and-import.md).

## Related pages

- [Scoping](scoping.md) for recording what the model is meant to answer.
- [Notes](notes.md) for free-form notes.
- [Board](board.md) and [Canvases](canvases.md) for tracking work and sketching.
