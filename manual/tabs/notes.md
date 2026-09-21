---
title: Notes
summary: Keep any number of named, formatted notes inside your model, for meeting minutes, decisions, reminders, or anything else that should travel with it.
section: tabs
order: 2
---

The Notes tab is a place for free-form writing. Each note has a name and a body, and you can keep as many as you like. Notes are saved in the model file, so they stay with the model and are there for anyone who opens it.

Use Notes for anything that does not need the structure of a [Scoping](scoping.md) document or the tracking of a [Board](board.md) card: meeting minutes, a session log, modeling decisions, links, or scratch work.

## The note list

The left side of the tab lists every note by name. A new model starts with no notes, and nothing is created for you.

| Action | What it does |
| --- | --- |
| **+ Add note** | Creates a note named `Untitled` at the bottom of the list, opens it, and selects its name so you can type a new one right away. |
| Click a note | Opens that note in the editor. |
| Drag a note up or down | Reorders the list. A line shows where the note will land when you release. |
| **×** on a note | Asks `Delete note "name"?` and deletes it if you answer Yes. |

The delete confirmation defaults to **No**, so pressing Enter or Escape cancels it. You have to click **Yes** deliberately. If you delete the note you have open, the first note in the list opens instead. If you delete the last note, the editor shows the empty state.

When there are no notes, the editor area reads **No notes yet. Click + Add note to create one.**

## Editing a note

The editor has three parts: the note's name, a formatting toolbar, and the body.

### Name

Click the name at the top to change it. The new name is applied when you press Enter or click away. If you clear the name and leave it empty, the note is renamed `Untitled`. Note names do not have to be unique.

### Body

The body is a free-form text area. Press Enter for a new paragraph, and use the toolbar above it for formatting: bold, italic, underline, strikethrough, text color, highlight, bullet and numbered lists, alignment, three heading sizes, links, inline code, and images. The toolbar and pasting are covered in [Format text and paste images](../how-to/format-text-and-paste-images.md).

Two things to know about pasting:

- Pasting text brings in plain text only. Formatting from the source, such as web page styling, is dropped, so use the toolbar to format after pasting.
- Pasting an image from the clipboard inserts it at the cursor and stores it in the model, so it is saved along with the note.

## Undo and redo

The **Undo** and **Redo** buttons at the top of the tab step through structural changes: adding a note, renaming one, deleting one, and reordering. They are greyed out when there is nothing to step through. The tab remembers up to 60 steps, and the history is cleared when you close the panel.

Typing in a note body is not tracked keystroke by keystroke, so undo does not rewind what you type.

> [!NOTE]
> FlexSim intercepts Ctrl+Z before Notebook sees it, so use the Undo and Redo buttons rather than the keyboard shortcut.

## Saving

You do not need to save notes yourself. Your text is saved shortly after you stop typing, right away when you click out of the editor, and immediately after a rename, an add, a delete, or a paste of an image. The save status at the top right of the panel shows when a save is pending or done.

Because notes live in the model file, they are saved when you save the model. To move notes to another model or keep a copy outside FlexSim, see [Export and import](../how-to/export-and-import.md).
