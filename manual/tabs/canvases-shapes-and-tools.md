---
title: Shapes and drawing tools
summary: "Draw shapes, lines, arrows, freehand strokes, text and images on a canvas, then style, resize and rotate them."
section: tabs
order: 5
---

This page covers everything you can put on a [canvas](canvases.md) and how to change how it looks. For selecting, copying, layering and aligning, see [Selecting and arranging](canvases-arranging.md).

## The tools

Pick a tool from the toolbar by clicking its icon. The active tool is highlighted.

| Tool | What it draws |
| --- | --- |
| Select | Not a drawing tool. Click shapes to select and move them. |
| Rectangle | A rectangle. |
| Rounded rectangle | A rectangle with rounded corners. |
| Ellipse | An ellipse, or a circle if you draw it with equal width and height. |
| Diamond | A diamond, useful for decision points in a flow. |
| Triangle | A triangle pointing up. |
| Hexagon | A six-sided shape. |
| Line | A straight line. |
| Arrow | A straight line with an arrowhead at the end where you release the mouse. |
| Free draw (pen) | A freehand stroke that follows your mouse. |
| Text | A free-floating text box. |
| Insert image | Opens a file picker so you can add a picture. |

### Drawing shapes, lines and strokes

With a shape, line, arrow or pen tool active, press the mouse on the canvas and drag. The shape grows as you drag and is finished when you let go. Clicking a shape tool without dragging still gives you a usable shape (a default-sized box).

A drawing tool stays active after you finish a shape, so you can draw several in a row. To go back to the Select tool, press **Esc** or right-click the canvas.

While you draw, resize or rotate, a small label shows the size (or angle) if **Show dimensions while drawing** is on in the [canvas settings](canvases.md#canvas-settings). If **Snap to grid** is on, points snap to the grid as you draw.

> [!TIP]
> If your free-draw strokes come out shaky, turn on **Smooth free-draw on commit** in the canvas settings. The stroke is smoothed when you release the mouse.

### Text boxes

Choose the Text tool and click where you want the text. A text box appears there and opens for typing straight away, and the tool switches back to Select. Type your text and press **Esc**, or click outside the box, to finish. The box grows taller as you add lines, and it never shrinks on its own, so a height you set by dragging a handle is kept. To edit a text box later, double-click it.

Text boxes use the same formatting toolbar as notes, so you can use bold, italics, lists, headings, colors and links. The toolbar appears above the box while you edit. See [Format text and paste images](../how-to/format-text-and-paste-images.md).

### Text inside shapes

Any of the six closed shapes (rectangle, rounded rectangle, ellipse, diamond, triangle and hexagon) can hold a text label. Double-click the shape to type in it. The text is centered inside the shape and uses the same formatting toolbar as a text box. Press **Esc** or click outside to finish.

Lines, arrows and pen strokes cannot hold text.

### Images

Choose the Insert image tool and pick a picture file. The image is placed in the middle of the current view at a default size, and the tool returns to Select. Resize it with the corner handles afterward. Images are stored inside the model file.

## Colors, opacity and width

The toolbar holds the style controls. They work in two ways: they set the look of the next shapes you draw, and if shapes are selected they also change those shapes straight away.

| Control | Choices | Applies to |
| --- | --- | --- |
| Stroke | Black, red, orange, yellow, green, blue, purple, white | The outline of shapes, and lines, arrows and pen strokes. |
| Fill | None (the striped swatch), white, red, orange, yellow, green, blue, purple | The inside of the six closed shapes. |
| Opacity | A slider from 0% to 100% in steps of 5% | The fill only. Lower it to turn a solid fill into a tint. |
| Width | 1 px, 2 px, 4 px, 7 px | The stroke thickness. |

The default stroke color follows the light or dark theme (white in dark mode, black in light mode) until you click a stroke swatch. After that, your choice stays.

> [!NOTE]
> Arrowheads take the color of their line.

## Resizing and rotating

Select a single rectangle, rounded rectangle, ellipse, diamond, triangle, hexagon, text box or image and handles appear around it.

| Handle | What it does |
| --- | --- |
| Square corner handles | Drag to resize. Hold Shift to keep the original proportions. |
| Round handle above the top edge | Drag to rotate around the center. Hold Shift to snap to 15 degree steps. |

Shapes have a minimum size, so they cannot be squashed to nothing. Resizing a rotated shape works along the shape's own edges. With **Snap to grid** on, resized sizes and positions snap to the grid.

Lines, arrows and pen strokes have no handles. You can move them, but not resize or rotate them, so redraw them if you need a different length.

## Moving shapes

With the Select tool, drag any shape to move it. If several shapes are selected, they all move together. A plain click on a shape does not change it, so you can click freely without disturbing your drawing.

## Deleting shapes

Select one or more shapes and press **Delete** or **Backspace**, or right-click and choose **Delete**. Use Undo to bring them back.
