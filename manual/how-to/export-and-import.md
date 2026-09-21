---
title: Export and import
summary: Share your Notebook as a read-only web page, or back it up and restore it as a data file.
section: how-to
order: 1
---

The Export and Import commands are in the menu at the top right of the Notebook, behind the round button with three dots. Click it to open the menu, and click anywhere else (or press Esc) to close it.

The menu offers three ways to move your work in or out:

| Command | What it does |
| --- | --- |
| Export as HTML | Saves a read-only web page you can open and share. |
| Export data (JSON) | Saves all of your Notebook data in one file, for backup or moving to another model. |
| Import data (JSON) | Replaces everything in the Notebook with the contents of a data file. |

## Export as HTML

Use this to share your notes and results with people who do not have the Notebook.

1. Click the three-dot button at the top right and choose **Export as HTML**.
2. When a save dialog appears, pick a folder and name. The suggested name is "notebook" followed by the date and time. If no dialog appears, the file is saved as a download instead.
3. Open the saved file in any web browser.

The page looks like the Notebook, with tabs for Scoping, Notes, Board, Canvases and Validation, and it keeps your current light or dark appearance. It is read-only:

- You can switch between tabs, and click items in the side lists (scopes, notes, runs, canvases) to read them.
- You can click a Board card to see its details, and zoom a canvas with the mouse wheel. To pan a canvas, drag with the middle mouse button, or hold Shift or Space while dragging.
- Images are included inside the file, so nothing else needs to travel with it.
- There are no editing controls, undo buttons, add or delete buttons, formatting toolbars, or search boxes, and the save status and menu are left out.

The export reflects what is on screen right now. Your own Notebook returns to the tab and items you were viewing when the export finishes.

> [!NOTE]
> The HTML export is for reading. You cannot import it back into the Notebook. Use Export data (JSON) for that.

## Export data (JSON)

Use this to back up your Notebook or to move it to another model.

1. Click the three-dot button and choose **Export data (JSON)**.
2. Choose where to save the file in the dialog. The suggested name is "notebook-data" followed by the date and time.

Any edits still waiting to save are saved first, so the file matches what you see. The file holds everything: scoping documents, notes, the board, canvases, validation runs, your settings and all pasted images.

## Import data (JSON)

Use this to restore a backup or to load a Notebook exported from another model.

> [!WARNING]
> Importing replaces all of the Notebook's current data with the file's contents, including your settings such as the theme. It cannot be undone. Export your current data first if you might want it back.

1. Click the three-dot button and choose **Import data (JSON)**.
2. Choose a file that was created by **Export data (JSON)**.
3. If the file is not a Notebook export, you are told so and nothing changes.
4. Otherwise, you are asked to confirm that you want to replace all current Notebook data. Confirm to continue, or cancel to leave everything as it is.
5. The Notebook loads the imported data, saves it, and shows the tab that was active when the file was exported.

If something goes wrong while reading the file, you see a message that the import failed.

For safety, script-like content inside imported text (such as embedded scripts and event handlers) is removed as the file is loaded, in case the file came from somewhere you do not fully trust.

## Related pages

- [Change settings and theme](change-settings-and-theme.md) for the other commands in the same menu.
- [Getting started](../getting-started.md) for an overview of the Notebook.
