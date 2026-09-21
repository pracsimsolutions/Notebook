---
title: Board
summary: "Track work as cards on a board of columns and priority rows, and edit each card in a side panel."
section: tabs
order: 3
---

The Board tab is a simple task board for the model you are working on. Cards sit in columns (for example To Do, In Progress, Review and Closed), and each column is split into three priority rows: High, Med and Low. A card's position on the board tells you both where it is in your workflow and how urgent it is.

Everything on the board is saved inside the model file, so the cards travel with the model.

## The board layout

A new board starts with four columns named To Do, In Progress, Review and Closed, and no cards. The three priority rows (High, Med, Low) run across the board, with a row label pinned at the left edge. The column headers stay pinned at the top as you scroll, so you always know which column you are looking at.

Across the top of the tab you will find:

- **Undo** and **Redo** buttons (see [Undoing changes](#undoing-changes)).
- **+ Add card**, which creates a card and opens it for editing.
- **+ Add column**, which adds a column on the right.

Each card on the board shows only its title. Everything else about a card is edited in the card panel.

## Adding and editing cards

Click **+ Add card**. A new card titled "Untitled" appears in the first column, in the Med row, at the bottom of that cell. The card panel opens on the right with the title selected, so you can type the real title straight away.

Click any card to select it and open its panel. The selected card is highlighted on the board. The panel has these parts:

| Field | What it does |
| --- | --- |
| Title | The name shown on the card. Press Enter or click elsewhere to save it. An empty title becomes "Untitled". |
| Column | Moves the card to another column. It lands at the bottom of that column's row. |
| Priority | Moves the card to the High, Med or Low row. It lands at the bottom of that row. |
| Body | A rich text area for the details of the card. It has the same formatting toolbar as notes, and you can paste images into it. |
| Delete card | Removes the card after you confirm. |

The body saves automatically as you type. See [Format text and paste images](../how-to/format-text-and-paste-images.md) for what the toolbar offers.

To close the panel, click the **×** in its header or press **Esc**. To make more room for the body, drag the divider between the board and the panel: dragging left widens the panel and dragging right narrows it. The width is limited to a sensible range and is remembered with the model.

> [!TIP]
> If you click a different card while you are typing in the panel, your typing is saved first, so nothing is lost.

## Moving cards

You can move a card in two ways:

- **Drag and drop.** Drag a card to any cell, meaning any combination of column and priority row. The cell highlights as a drop target. Where you release decides the card's place inside the cell: it goes above the first card whose middle is below your pointer, or at the bottom if there is none. You can also drag inside a cell to reorder cards.
- **The card panel.** Change the Column or Priority fields. This is handy for moving a card across a large board without dragging.

## Managing columns

Rename a column by clicking its name in the header, typing, and pressing Enter or clicking away. An empty name becomes "Untitled column".

Click **+ Add column** to add a new column named "New column" on the right. Its name field is focused and selected so you can rename it immediately.

Click the **×** in a column header to delete it. If the column holds cards, you are asked to confirm, and the cards in that column are deleted with it. A board always keeps at least two columns, so the delete buttons are dimmed and disabled when only two remain.

> [!NOTE]
> Columns stay in the order they were created. There is no drag control for reordering columns.

## Undoing changes

The **Undo** and **Redo** buttons at the top of the tab step back and forward through your board changes: adding, moving, renaming and deleting cards and columns, and edits to a card's title, column and priority. Each tab keeps its own history, so undoing on the Board never changes your notes or canvases.

> [!IMPORTANT]
> The keyboard shortcut Ctrl+Z is not available inside the Notebook panel, because FlexSim intercepts it before the panel sees it. Use the Undo and Redo buttons instead.

Undo history is kept only while the panel is open, and holds a limited number of recent steps.

## Related pages

- [Notes](notes.md) uses the same body editor as card bodies.
- [Scoping](scoping.md) and [Validation](validation.md) are the other tabs in the Notebook.
- [Getting started](../getting-started.md) shows how to open the Notebook panel.
