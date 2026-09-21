---
title: Selecting and arranging
summary: "Select shapes, copy and paste them, change their layering, group them, align and distribute them, and use the keyboard shortcuts."
section: tabs
order: 6
---

This page covers working with shapes that are already on a [canvas](canvases.md): selecting them, copying them, and arranging them. To create and style shapes, see [Shapes and drawing tools](canvases-shapes-and-tools.md).

## Selecting shapes

Use the Select tool. Selected shapes show a highlight.

| To do this | Do this |
| --- | --- |
| Select one shape | Click it. |
| Add or remove a shape from the selection | Hold Shift and click it. |
| Select everything on the canvas | Press Ctrl+A. |
| Clear the selection | Click empty canvas. |

There is no drag box for selecting several shapes at once. Use Shift+click or Ctrl+A.

When shapes are selected, the bar under the toolbar shows how many are selected and offers the actions described below. Dragging any selected shape moves the whole selection together.

## Copy, paste and duplicate

| Action | How | Result |
| --- | --- | --- |
| Copy | Ctrl+C | Remembers the selected shapes. |
| Paste | Ctrl+V | Adds copies to the active canvas, offset slightly down and to the right so they are easy to tell from the originals. The new copies become the selection. |
| Duplicate | Ctrl+D, the **Duplicate** button, or right-click then **Duplicate** | Copies and pastes in one step. |

Because paste always goes to the canvas you are looking at, you can copy on one canvas, switch to another in the list, and paste there. Pasting a grouped selection creates a new, separate group, so the copy is not joined to the original. The copied shapes are kept only while the panel is open.

## Layering

Shapes stack in the order they were made, with the newest on top. Use the **Order** buttons in the selection bar, or the right-click menu, to change that.

| Action | Shortcut | What it does |
| --- | --- | --- |
| Front | Ctrl+Shift+] | Moves the selection above every other shape. |
| Forward | Ctrl+] | Moves the selection up one step. |
| Backward | Ctrl+[ | Moves the selection down one step. |
| Back | Ctrl+Shift+[ | Moves the selection below every other shape. |

## Grouping

Grouping ties several shapes together so they behave as one. Clicking any shape in a group selects the whole group, and Shift+click adds or removes the whole group.

- To group, select two or more shapes and click **Group** or press Ctrl+G.
- To ungroup, select a group and click **Ungroup** or press Ctrl+Shift+G. The Ungroup button appears only when the selection includes a grouped shape.

## Aligning and distributing

These buttons appear in the selection bar when enough shapes are selected.

| Action | Needs | What it does |
| --- | --- | --- |
| Align horizontal: L, C, R | 2 or more shapes | Lines the shapes up by their left edges, their centers, or their right edges. |
| Align vertical: T, M, B | 2 or more shapes | Lines the shapes up by their top edges, their middles, or their bottom edges. |
| Distribute: H, V | 3 or more shapes | Spaces the shapes evenly, horizontally or vertically. The outermost two stay where they are and the ones between are spread out. |

Alignment is measured against the combined outer edges of the selected shapes.

## The right-click menu

Right-click a shape to open a menu of actions for it. If the shape was not selected, right-clicking selects it (and its whole group) first.

| Menu item | Notes |
| --- | --- |
| Duplicate, Delete | Delete removes the selected shapes. |
| Bring to Front, Bring Forward, Send Backward, Send to Back | Same as the layering actions. |
| Group, Ungroup | Group needs two or more selected shapes. Ungroup is enabled when the selection contains a grouped shape. |
| Align and Distribute items | Shown only when enough shapes are selected. |

Right-click empty canvas for a small view menu instead: **Fit to Screen** (disabled when the canvas is empty) and **Reset Zoom (100%)**.

If a drawing tool is active, right-click does not open a menu. It switches you back to the Select tool.

## Keyboard and mouse shortcuts

Keyboard shortcuts on the Canvases tab work when the canvas is showing and you are not typing in a text box.

| Shortcut | What it does |
| --- | --- |
| Ctrl+C | Copy the selected shapes. |
| Ctrl+V | Paste copied shapes. |
| Ctrl+D | Duplicate the selection. |
| Ctrl+A | Select all shapes on the canvas. |
| Ctrl+G | Group the selection. |
| Ctrl+Shift+G | Ungroup the selection. |
| Ctrl+] and Ctrl+Shift+] | Bring forward, bring to front. |
| Ctrl+[ and Ctrl+Shift+[ | Send backward, send to back. |
| Ctrl+Shift+F | Fit the whole drawing on screen. |
| Delete or Backspace | Delete the selected shapes. |
| Esc | Return to the Select tool. While editing text, finish the text. |
| Space (hold) and drag | Pan the canvas. |
| Middle mouse button and drag | Pan the canvas. |
| Mouse wheel | Zoom in and out around the pointer. |
| Shift and click | Add or remove a shape from the selection. |
| Right-click | Open the context menu, or return to Select if a drawing tool is active. |
| Double-click a shape or text box | Edit its text. |

> [!IMPORTANT]
> Ctrl+Z (undo) is not available inside the Notebook panel, because FlexSim intercepts it before the panel sees it. Use the Undo and Redo buttons at the left end of the toolbar.
