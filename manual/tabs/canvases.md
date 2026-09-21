---
title: Canvases
summary: "Sketch diagrams, layouts and annotations on an unlimited drawing surface, with as many canvases as you need."
section: tabs
order: 4
---

The Canvases tab is a drawing surface for the model you are working on. Use it to sketch a layout, draw a process flow, annotate a screenshot or collect ideas visually. Each canvas is an unlimited surface that you pan and zoom, so you never run out of space.

Everything you draw is saved inside the model file, including the pictures you add.

This page covers the tab itself. The details of drawing and arranging are on two companion pages:

- [Shapes and drawing tools](canvases-shapes-and-tools.md): every tool, colors, text and images, resizing and rotating.
- [Selecting and arranging](canvases-arranging.md): selection, copy and paste, layering, grouping, aligning, the right-click menu and a table of keyboard shortcuts.

## The canvas list

The left side of the tab lists your canvases. A new model starts with one canvas named "Canvas 1".

| Control | What it does |
| --- | --- |
| **+ Add canvas** | Creates a new empty canvas named "Canvas 2", "Canvas 3" and so on, and switches to it. |
| Click a name | Switches to that canvas. Its own view (position and zoom) is restored. |
| Pencil button | Renames the canvas. |
| **×** button | Deletes the canvas and everything on it, after you confirm. |

A model always keeps at least one canvas, so the last remaining canvas cannot be deleted.

## The toolbar

Along the top of the drawing area is the toolbar. From left to right it holds:

1. **Undo** and **Redo** arrows.
2. The **Select** tool.
3. The six shape tools, then the line, arrow, pen, text and image tools.
4. Stroke color, fill color, fill opacity and stroke width.
5. Zoom buttons, and the settings gear.

If the window is too narrow to show everything, the toolbar items that do not fit move into a **More tools** menu, marked with three dots at the right end. The items in that menu work exactly the same.

Below the toolbar is a second bar for the current selection. When nothing is selected it shows a hint. When shapes are selected it shows how many are selected and offers Duplicate, layering, alignment and grouping buttons. It is always present, so the drawing area does not jump around as you select and deselect.

## Moving around the canvas

The canvas has no scroll bars. You move around it by panning and zooming.

| To do this | Do this |
| --- | --- |
| Pan | Hold Space and drag, or drag with the middle mouse button. Panning works with any tool active. |
| Zoom in or out | Turn the mouse wheel over the canvas. The point under your pointer stays where it is. |
| Zoom in or out from the center | Click **+** or **-** in the toolbar. |
| Return to 100% | Click the percentage button between **-** and **+**. This also moves the view back to the origin. |
| Fit everything on screen | Right-click empty canvas and choose **Fit to Screen**, or press Ctrl+Shift+F. |

Zoom ranges from 5% to 800%. Each canvas remembers its own position and zoom.

> [!TIP]
> Lost your drawing after a big zoom or pan? Use **Fit to Screen** to bring every shape back into view. It is disabled on an empty canvas.

## Undo and redo

The arrows at the far left of the toolbar undo and redo your last drawing actions on the Canvases tab: creating, moving, resizing, rotating, deleting, restyling, layering, grouping, aligning, renaming and adding or deleting canvases. Panning and zooming are not part of the history. Undoing clears the current selection.

> [!IMPORTANT]
> The keyboard shortcut Ctrl+Z is not available inside the Notebook panel, because FlexSim intercepts it before the panel sees it. Use the Undo and Redo buttons in the toolbar instead.

Each tab keeps its own history, so undoing on Canvases never changes your notes, board or scoping. The history holds a limited number of recent steps and lasts only while the panel is open.

## Canvas settings

Click the gear at the right end of the toolbar to open the settings menu. Each option is an Off/On switch or a set of choices.

| Setting | Choices | What it does |
| --- | --- | --- |
| Show grid | Off, On | Shows a grid of dots as a drawing guide. On by default. |
| Snap to grid | Off, On | Makes shapes you draw, move and resize land on grid points. Off by default. |
| Grid size | 10px, 20px, 40px | The spacing of the grid, and of snapping when it is on. |
| Show dimensions while drawing | Off, On | Shows the width and height (or the rotation angle) next to the pointer while you draw, resize or rotate. On by default. |
| Smooth free-draw on commit | Off, On | Evens out wobbles in a pen stroke when you release the mouse. Off by default. |

These settings apply to all canvases in the model. Click anywhere outside the menu to close it.

## Saving

Your canvases save automatically as you work, into the model file. Save the model in FlexSim as you normally would to keep your changes. Nothing is stored anywhere except inside the model, so a canvas is always available to anyone who opens the model.

## Related pages

- [Notes](notes.md) and [Board](board.md) are the other free-form tabs.
- [Format text and paste images](../how-to/format-text-and-paste-images.md) covers the formatting toolbar you use for text inside shapes.
- [Getting started](../getting-started.md) shows how to open the Notebook panel.
