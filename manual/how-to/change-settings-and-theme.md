---
title: Change settings and theme
summary: Switch between dark and light, tune how quickly edits are saved, and find the About window and save status.
section: how-to
order: 4
---

The Notebook's window-wide commands live in a menu at the top right, behind the round button with three dots. Click it to open the menu. Click anywhere else, or press Esc, to close it.

The menu holds Export as HTML, Export data (JSON) and Import data (JSON) (see [Export and import](export-and-import.md)), then a divider, then **Settings** and **About**.

## Change the theme

1. Open the three-dot menu and choose **Settings**.
2. Under **Theme**, click **Dark** or **Light**.

The whole Notebook switches immediately, and the button for the current theme is highlighted. Your choice is saved with the Notebook and is used the next time you open it. It is also used for HTML exports.

Click anywhere outside the Settings box to close it.

## Change the autosave delay

The Notebook saves as you type. The autosave delay is how long it waits after you stop typing before it saves.

1. Open **Settings**.
2. Under **Autosave delay**, type a number of milliseconds in the box. The allowed range is 200 to 10000.
3. Press Enter or click away to apply it.

A shorter delay saves sooner. A longer delay saves less often while you are typing. If you type a number outside the range, it is adjusted to the nearest allowed value.

Some actions, such as adding or deleting an item or switching tabs, save right away regardless of this setting.

## Read the save status

Next to the three-dot button is a small status message:

| Message | Meaning |
| --- | --- |
| Saved 12s ago | Everything is saved. The time counts up as you go. |
| Unsaved changes | You have edited something and the save has not happened yet. |
| Saving | The Notebook is writing your changes now. |
| Save failed, Retry | A save did not go through. Click **Retry** to try again. |

If you close the panel while changes are waiting, the Notebook briefly shows a Saving box and saves them first.

## Open the About window

Choose **About** from the three-dot menu. The window shows the module name and logo, the license, a contact address and the project's GitHub address. The two addresses are plain text you can select and copy, not clickable links.

Click **Close**, click outside the window, or press Esc to close it.

## When the panel is narrow

The row of tabs (Scoping, Notes, Board, Canvases and Validation) sits on the left of the top bar. The save status and the three-dot button stay fixed on the right.

If the panel is too narrow to show every tab, the tabs scroll sideways instead of running under the menu button. Scroll with the mouse wheel or trackpad over the tab row, or use the thin scroll bar that appears under the tabs when you hover over them. The three-dot button is always reachable, so the commands above are available at any width.

> [!TIP]
> If you cannot see the tab you want, scroll the tab row sideways. The Notebook remembers which tab you were on when you last used it.
