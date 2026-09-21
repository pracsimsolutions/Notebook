---
title: Using the tabs
summary: What each tab is for and the behavior worth knowing about.
order: 2
---

Most of the Notebook is self-explanatory. This page covers what each tab is for and the parts that
are not obvious. All of it is saved in the model file.

## Scoping

A structured scope document for a project: business questions, objectives, deliverables,
stakeholders, assumptions, risks and more. Each project gets its own scope, listed on the left, and
you can drag scopes to reorder them.

- Leave any section empty. Nothing has to be filled in.
- Three groups collapse: **Simulation add-ons** (open by default), **Training and knowledge
  transfer** and **Change order log** (closed by default). Each scope remembers what you left open.
- Each row in **Process diagrams** can point at a canvas. Pick one and click the arrow to jump to it
  on the Canvases tab.
- In bullet lists, Enter starts a new bullet, Shift+Enter adds a line inside the current one, and
  Backspace on an empty bullet removes it.

## Notes

Any number of named, formatted notes, for meeting minutes, decisions or scratch work. New notes are
added at the bottom of the list, and you can drag to reorder.

- The delete confirmation defaults to **No**, so Enter and Esc cancel it.
- Pasted text arrives as plain text, without the formatting of where it came from. Pasted images are
  stored in the model.

## Board

A task board. Cards sit in columns (To Do, In Progress, Review and Closed to start), and every
column is split into High, Med and Low priority rows. Click a card to edit it in the side panel,
and drag cards to any column and priority.

- A board keeps at least two columns. Deleting a column deletes the cards in it, after you confirm.
- Columns cannot be reordered.
- Drag the divider between the board and the card panel to resize the panel.

## Canvases

Unlimited drawing surfaces for layouts, process flows and annotations. A model always keeps at least
one canvas, and each canvas remembers its own position and zoom.

| To do this | Do this |
| --- | --- |
| Pan | Hold Space and drag, or drag with the middle mouse button. |
| Zoom | Mouse wheel, which zooms around the pointer. |
| Fit everything on screen | Ctrl+Shift+F, or right-click empty canvas and choose **Fit to Screen**. |

The gear at the right of the toolbar turns on a grid and snapping. Right-click a shape for layering,
grouping, alignment and copy options. If the panel is narrow, toolbar items that do not fit move
into a **More tools** menu.

## Validation

A logbook of interactive model runs. **Snapshot** records the model's current parameter values and
performance measures as a new run, and you add the changes you made by hand plus your observations,
analysis and next steps. It is for single runs. For multi-replication work, use FlexSim's
Experimenter.

- The model needs a Model Parameter Table and a Performance Measure Table (Toolbox, then Add), or
  Snapshot has nothing to record. Run the model first if you want meaningful outputs.
- The camera button in the Inputs or Outputs header re-snapshots just that table for the open run.
- Click a value to correct it. Editing does not change your model. Rows cannot be added or
  deleted individually, so snapshot the table again to refresh it.
- **+ Add empty run** creates a run with no tables, useful for notes and manual changes only.
