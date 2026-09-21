---
title: Scoping
summary: Write down what a project is for, what is in and out, what gets delivered, and what could go wrong, in a structured scope document that lives inside your model.
section: tabs
order: 1
---

The Scoping tab is a structured place to write down what a modeling project is meant to do. Each project gets its own scope document, with sections for the questions the model must answer, the deliverables, the risks, the people involved, and more. Everything you write is saved in the model file, so the scope travels with the model.

A scope is a working reference, not a form you have to complete. Leave any section empty and fill in only what helps.

## The scope list

The left side of the tab lists every scope in the model. Each entry shows the scope's title and a short summary of what it contains, such as `3 Q · 2 obj · 1 deliv · 2 people`. The abbreviations count business questions, objectives, deliverables, people (stakeholders), open questions, and change orders. A scope with none of these shows `empty`. The summary and title update as you type.

| Action | What it does |
| --- | --- |
| **+ New** | Creates a new scope at the top of the list, opens it, and selects its title so you can type a name straight away. |
| Click a scope | Opens that scope in the main area. |
| Drag a scope up or down | Reorders the list. A line shows where it will land when you release. |
| **×** on a scope | Deletes it after a confirmation prompt. If you delete the open scope, the first remaining scope opens. |

New scopes start completely empty and named `Untitled scope`. Nothing is filled in for you.

When the model has no scopes, the main area shows **No scope selected.** with a **+ Create one** button.

## Undo and redo

The **Undo** and **Redo** buttons at the top of the tab step back and forward through structural changes: adding or removing a scope, adding or removing a row or bullet, and reordering the list. They stay greyed out when there is nothing to step through. The tab remembers up to 60 steps, and the history is cleared when you close the panel.

Ordinary typing is not tracked step by step, so undo does not rewind individual keystrokes.

> [!NOTE]
> FlexSim intercepts Ctrl+Z before Notebook sees it, so use the Undo and Redo buttons rather than the keyboard shortcut.

## Working with the sections

Most sections use one of a few layouts, and each has an **+ Add ...** button next to its heading (for example **+ Add objective**). New rows are added at the end and the cursor moves into them.

### Bullet lists

Business questions, objectives, in scope, out of scope, delivery criteria, business success, assumptions, open questions, and several of the simulation add-on sections are simple bullet lists. Each bullet is a text box that grows to fit what you type.

| Key | What it does |
| --- | --- |
| Enter | Starts a new bullet directly below the current one. |
| Shift+Enter | Adds a new line inside the current bullet. |
| Backspace on an empty bullet | Removes it and moves to the bullet above. |

Each bullet also has an **✕** button on its right to remove it.

### Tables and rows

Stakeholders, data parameters, data requirements, scenarios, and change orders are tables with one row per item. Milestones, deliverables, risks, and process diagrams are rows of fields. Every row has an **✕** to delete it. Deleting does not ask for confirmation, but you can undo it.

### Rich text areas

Seven sections are free-form text with a formatting toolbar above them: Background, Project Acceptance, Model Boundary, Fidelity Level, Validation Acceptance, Post-Delivery Support, and Notes. You can format text, insert links, and paste images into them. See [Format text and paste images](../how-to/format-text-and-paste-images.md).

## The header

At the top of every scope are four fields.

| Field | What it holds |
| --- | --- |
| Project title | The name shown in the scope list. Leaving it blank shows the scope as `Untitled` in the list. |
| One-line summary | A single sentence describing the project. |
| Engagement | The kind of work: Model Building, Support Hours, Module Development, Internal, or Other. |
| Status | Draft, Active, Archived, or Superseded. The dropdown is colored to match the current status. |

## Core sections

These sections appear in every scope, in this order.

| Section | What it is for |
| --- | --- |
| Business questions | The specific decisions or questions the model exists to inform. |
| Background | Why the project exists and the context around it (rich text). |
| Objectives | Measurable outcomes that define success. |
| Scope | Two columns: **In scope** and **Out of scope**, each with its own **+ Add** button. |
| Deliverables | What gets handed over. Each deliverable has a title, a due date, and its acceptance criteria (how you and the stakeholder will agree it is done). |
| Delivery criteria | The technical bar for "the model is delivered", such as runs on the client's computer or all scenarios modeled. |
| Business success | What the model lets the business decide. |
| Assumptions | What you are assuming to be true. The project is at risk if these turn out wrong. |
| Constraints | Three single-line fields: Timeline, Budget, and Data. |
| Stakeholders | A table with Name, Role, and Contact. Roles are Project Manager, Point of Contact, Decision Maker, Subject Matter Expert, and Other. Contact is free text for an email, phone number, or notes. |
| Milestones | Key dates. Each row has a date and a label. |
| Risks | Known risks. Each has a severity of Low, Med, or High, which sets its color, and a description. New risks start at Med. |
| Open questions | Things still unresolved. |
| Project acceptance | The overall bar for "this is done", separate from each deliverable's own acceptance criteria (rich text). |
| Notes | Free-form notes that do not fit anywhere else (rich text). |

> [!NOTE]
> A stakeholder whose role is not one of the five listed keeps their role in the dropdown, so older entries are never silently changed. New stakeholders start with the role Reviewer, which appears in the list alongside the five standard roles until you pick another.

## Simulation add-ons

Below Project acceptance is a collapsible group called **Simulation add-ons**, for scoping that is specific to building a simulation model. Click its heading to expand or collapse it. It starts expanded, and each scope remembers whether you left it open or closed.

| Section | What it is for |
| --- | --- |
| Model boundary | What is inside the model and what is treated as an outside input (rich text). |
| Process diagrams | Links to the drawings on the [Canvases](canvases.md) tab. See below. |
| Fidelity level | How detailed the model representation is (rich text). |
| Data-driven parameters | A table of numeric inputs that drive model behavior: Name, Current value, Range or distribution, and Notes. |
| What-if parameters | A table of scenario knobs: Name, Kind, Detail, and Notes. Kind is Discrete swap, Range sweep, or Qualitative. |
| Validation criteria | Bullet list of specific checks that prove the model reflects reality. See also the [Validation](validation.md) tab. |
| Validation timeline | Two single-line fields: Historical data window and Target validation time. |
| Validation acceptance | What "validated" means and the threshold for declaring it done (rich text). |
| Data sources | A quick bullet list of where inputs come from. |
| Data requirements | A table of what must be provided before modeling can proceed: Type, Format, Due date, Purpose, and Status. Status is Pending, Received, Partial, or Waived, and the dropdown is colored to match. New rows start at Pending. |
| Data gaps | Bullet list of what was asked for and not received. |
| Metrics reported | Bullet list of the output measurements the model produces. |
| Charts and dashboards | Bullet list of the visual reports built on those metrics. |
| Scenarios | A table with one row per scenario: a **Base** radio button, Name, Description, and Key changes from baseline. Only one row can be the baseline at a time. |

A scope written in an older layout that kept scenarios as a plain bullet list and has no scenarios table rows shows an extra **Scenarios (legacy bullets)** section, so those entries are not lost. Once the table has rows, that list is hidden.

### Linking a process diagram to a canvas

Each row in Process diagrams has a dropdown of the canvases in the model, a text box describing what the diagram shows, an **↗** button, and an **✕** button. Pick a canvas, then click **↗** to jump to it on the Canvases tab. If no canvas is picked you are asked to pick one first, and if the canvas has since been deleted you are told it no longer exists. A row that points at a deleted canvas is not removed for you.

## Training and knowledge transfer

A second collapsible group, **Training and knowledge transfer**, records how the client learns to use what was built. It starts collapsed.

| Section | What it is for |
| --- | --- |
| Training method | Choose one: Documentation only, Virtual workshop, On-site workshop, Docs + virtual session, or Other. Choosing Other reveals a text box to describe it. |
| Training content | Bullet list of the topics covered. |
| Post-delivery support | What happens after handoff (rich text). |

## Change order log

A third collapsible group, **Change order log**, keeps a running list of scope changes during the project. It starts collapsed. The **Change orders** table has one row per request.

| Column | What it holds |
| --- | --- |
| Date | Defaults to today when you add a row. |
| Description | What changed and why. |
| Hours impact | Free text such as `+8`, `-2`, or `TBD`. |
| Status | Pending, Approved, Rejected, or Cancelled. The dropdown is colored to match. New rows start at Pending. |

The number of change orders (`CO`) appears in the scope's summary line in the scope list.

## Saving

Changes are saved as you work, and the status at the top right of the panel shows when a save is pending or complete. Scopes are stored in the model file, so they are saved with the model and are available to anyone who opens it. To share scopes outside the model, or bring them into another one, see [Export and import](../how-to/export-and-import.md).
