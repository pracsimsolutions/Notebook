---
title: Capture a validation run
summary: Snapshot your model's parameters and results into a run, then record what changed and what you learned.
section: how-to
order: 2
---

This guide walks through recording one run of your model in the [Validation](../tabs/validation.md) tab.

## Before you start

The Snapshot button reads your model's parameter tables and performance measure tables. If your model has neither, Snapshot shows an alert instead of creating a run. To add them, open the Toolbox, choose Add, and add a Model Parameter Table and a Performance Measure Table.

Run your model for as long as you need before you snapshot, because the outputs are recorded as they stand at that moment.

## Capture the run

1. Open the **Validation** tab.
2. Click **Snapshot** above the list of runs. A new run appears at the top of the list and opens on the right. It holds every parameter under Inputs and every performance measure under Outputs.
3. The run's name is already selected, named "Run" followed by a number. Type a name that will mean something later, such as "Baseline, 4 operators", and press Enter.
4. Look over the Inputs and Outputs tables. If a unit label or description is wrong or missing, click the cell, correct it and press Enter.

## Record what you changed by hand

If you changed something that a parameter cannot capture, note it under **MANUAL CHANGES**.

1. Click **+ Add change** and type the change, for example "moved the machines to a different location".
2. Press Enter to add another line, or click elsewhere when you are finished.
3. To remove a line, hover over it and click the X, or press Backspace in an empty line.

## Write down what you learned

Fill in the three text sections under the tables:

- **OBSERVATIONS**: what you saw in this run.
- **ANALYSIS**: why you think it happened.
- **NEXT STEPS**: what you will try next.

Use the toolbar above each section for headings, lists, links and pasted images. See [Format text and paste images](format-text-and-paste-images.md).

Everything saves automatically. The status at the top right changes from "Unsaved changes" to "Saved" once your typing is stored.

## Capture the next run

Change your model, run it again and click **Snapshot** again. The new run goes to the top of the list, and your earlier runs stay as they were. Click any run in the list to compare its tables and notes with the one you are looking at.

## Fix a run after the fact

- To refresh only the outputs after a correction, click the camera button in the **OUTPUTS** header. If the table has rows, you are asked to confirm before it is replaced. The same button in the **INPUTS** header refreshes the parameters. Your notes and manual changes are not touched.
- To start a run before the model is ready, click **+ Add empty run**, name it, and add notes. Snapshot the tables later using the camera buttons.
- To remove a run, click **Delete run** and confirm. If you delete one by mistake, click **Undo** at the top of the tab.

> [!TIP]
> If your run list gets long, type part of a run name in the search box above the list to narrow it down.

> [!NOTE]
> The Validation tab records interactive single runs. For multi-replication batch experiments, use FlexSim's Experimenter.

## Share or back up your runs

Runs are part of the Notebook's data. To keep a copy or send it to someone, see [Export and import](export-and-import.md).
