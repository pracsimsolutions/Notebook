<?xml version="1.0" encoding="UTF-8"?>
<flexsim-tree version="4" treetype="tree">
<node f="42"><name>Notebook</name>
 <node f="40"><name></name></node>
 <node f="42"><name>installdata</name>
  <node f="40"><name></name></node>
  <node f="42" dt="2"><name>add_modules</name><data>VIEW:/modules</data>
   <node f="40"><name></name></node>
   <node f="42" dt="3"><name>Notebook</name><data><coupling>null</coupling></data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>rank</name><data>0000000000000000</data></node>
    <node f="42"><name>after</name></node>
    <node f="42" dt="1"><name>into object</name><data>0000000000000000</data></node>
    <node f="42"><name>data</name>
     <node f="40"><name></name></node>
     <node f="42"><name>Notebook</name>
      <node f="40"><name></name></node>
      <node f="42" dt="4"><name>Notebook</name><data>
       <node f="40"><name>object</name></node>
       <node f="42" dt="3"><name>viewfocus</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="3"><name>objectfocus</name><data><coupling>null</coupling></data></node>
       <node f="42"><name>undohistory</name>
        <node f="40"><name></name></node>
        <node f="42" dt="1"><name>undo limit</name><data>0000000040900000</data></node>
        <node f="42" dt="3"><name>history</name><data><coupling>null</coupling></data>
         <node f="40"><name></name></node></node>
        <node f="42" dt="1"><name>bin</name><data>0000000000000000</data></node>
       </node>
       <node f="42" dt="1"><name>viewwindowtype</name><data>0000000040598000</data>
        <node f="40"><name></name></node>
        <node f="42" dt="2"><name>Notebook</name><data>VIEW:/active&gt;Documents/Notebook</data>
         <node f="40"><name></name></node></node>
        <node f="42" dt="2"><name>ClickListener</name><data>VIEW:/active&gt;DocListeners/Click</data></node>
       </node>
       <node f="42" dt="2"><name>documentwindow</name><data>Notebook</data></node>
       <node f="42"><name>variables</name>
        <node f="40"><name></name></node></node>
       <node f="42"><name>spatial</name>
        <node f="40"><name></name></node>
        <node f="42" dt="1"><name>spatialx</name><data>0000000040900000</data></node>
        <node f="42" dt="1"><name>spatialy</name><data>0000000040590000</data></node>
        <node f="42" dt="1"><name>spatialsx</name><data>00000000407af000</data>
         <node f="40"><name></name></node>
         <node f="42" dt="1"><name>min</name><data>0000000040590000</data></node>
         <node f="42" dt="1"><name>fixed</name><data>000000003ff00000</data></node>
         <node f="42" dt="1"><name>desired</name><data>00000000407af000</data></node>
        </node>
        <node f="42" dt="1"><name>spatialsy</name><data>0000000040830000</data>
         <node f="40"><name></name></node>
         <node f="42" dt="1"><name>min</name><data>0000000040590000</data></node>
         <node f="42" dt="1"><name>fixed</name><data>000000003ff00000</data></node>
         <node f="42" dt="1"><name>desired</name><data>0000000040790000</data></node>
        </node>
       </node>
       <node f="42" dt="2"><name>windowtitle</name><data>Notebook</data></node>
       <node f="42" dt="1"><name>tabwindow</name><data>0000000040594000</data>
        <node f="40"><name></name></node>
        <node f="42" dt="2"><name>OnDropWindow</name><data>// dragging from a window to another window
if (objectexists(i)) 
	applicationcommand("dockwindow", i, c, eventcode);
// dragging a tab out of a window
else return applicationcommand("undockwindow", c, 0, dropx(), dropy());</data></node>
       </node>
       <node f="42" dt="2"><name>bitmap</name><data>modules\Notebook\Notebook.png</data></node>
      </data>
       <node f="40"><name></name></node>
       <node f="42" dt="4"><name>html</name><data>
        <node f="40"><name>object</name></node>
        <node f="42" dt="1"><name>viewwindowtype</name><data>00000000405f0000</data></node>
        <node f="42" dt="1"><name>spatialx</name><data>0000000000000000</data></node>
        <node f="42" dt="1"><name>spatialy</name><data>0000000000000000</data></node>
        <node f="42" dt="1"><name>spatialsx</name><data>00000000405e0000</data></node>
        <node f="42" dt="1"><name>spatialsy</name><data>00000000405e0000</data></node>
        <node f="42" dt="2"><name>coldlink</name><data>..&gt;variables/html</data></node>
        <node f="42" dt="1"><name>alignrightmargin</name><data>0000000000000000</data></node>
        <node f="42" dt="1"><name>alignbottommargin</name><data>0000000000000000</data></node>
        <node f="42"><name>variables</name>
         <node f="40"><name></name></node>
         <node f="42" dt="2"><name>html</name><data>&lt;!DOCTYPE html&gt;
&lt;html&gt;
&lt;head&gt;
  &lt;meta charset="utf-8" /&gt;
  &lt;title&gt;PracSim Notebook&lt;/title&gt;
  &lt;link rel="stylesheet" type="text/css" href="flexsimweb/default.css" /&gt;
  &lt;script src="flexsimweb/common.js"&gt;&lt;/script&gt;
  &lt;style&gt;
    :root {
      --bg:          #0b1224;
      --bg-elevated: #1e293b;
      --bg-input:    #0f172a;
      --border:      #334155;
      --border-soft: #1e293b;
      --text:        #e2e8f0;
      --text-muted:  #94a3b8;
      --text-dim:    #64748b;
      --accent:      #60a5fa;
      --accent-hover:#93c5fd;
      --success-fg:  #4ade80;
      --warning-fg:  #facc15;
      --error-fg:    #f87171;
      /* color-scheme tells CEF/Chromium to render native form-control
         widgets (dropdown popups, scrollbars, date pickers) in the
         matching mode. Without this, an unstyled &lt;select&gt;'s open
         dropdown panel falls back to OS light styling and the dark
         --text on a white panel becomes unreadable. */
      color-scheme: dark;
    }

    /* Light theme — applied to &lt;html&gt; so the override happens at the
       :root level and cascades to every element (including html itself,
       which has its own background that would otherwise stay dark). */
    html.light {
      --bg:          #ffffff;
      --bg-elevated: #f8fafc;
      --bg-input:    #ffffff;
      --border:      #cbd5e1;
      --border-soft: #e2e8f0;
      --text:        #0f172a;
      --text-muted:  #475569;
      --text-dim:    #94a3b8;
      --accent:      #2563eb;
      --accent-hover:#1d4ed8;
      --success-fg:  #16a34a;
      --warning-fg:  #ca8a04;
      --error-fg:    #dc2626;
      color-scheme: light;
    }

    /* Belt-and-suspenders explicit option styling for the few engines
       that don't fully honor color-scheme on &lt;select&gt; popup options.
       Targets every &lt;select&gt; in the app uniformly. */
    select option {
      background: var(--bg-elevated);
      color: var(--text);
    }

    * { box-sizing: border-box; }

    html, body {
      background: var(--bg);
      color: var(--text);
      margin: 0;
      height: 100vh;
      overflow: hidden;   /* page itself doesn't scroll — each tab pane manages its own */
    }

    body {
      font-family: -apple-system, "Segoe UI", system-ui, sans-serif;
      font-size: 13px;
      line-height: 1.4;
      display: flex;
      flex-direction: column;
    }
    nav.main-tabs { flex-shrink: 0; }

    /* Main tab strip — real tab-look. Inactive tabs sit below the page
       border; active tab "joins" the content area by hiding its own
       bottom edge so it appears to be on the same surface. */
    nav.main-tabs {
      display: flex;
      gap: 4px;
      border-bottom: 1px solid var(--border);
      padding: 6px 12px 0 12px;
      align-items: stretch;
    }
    nav.main-tabs button {
      background: var(--bg-elevated);
      border: 1px solid var(--border-soft);
      border-bottom: 1px solid var(--border);
      border-radius: 6px 6px 0 0;
      color: var(--text-muted);
      padding: 7px 18px 8px 18px;
      font-size: 13px;
      font-weight: 600;
      cursor: pointer;
      margin-bottom: -1px;     /* overlap nav's bottom border so active tab can hide it */
      position: relative;
      transition: color 0.1s, background 0.1s, border-color 0.1s;
    }
    nav.main-tabs button[data-tab]:hover {
      color: var(--text);
      background: var(--bg-input);
    }
    nav.main-tabs button.active[data-tab] {
      background: var(--bg);
      color: var(--accent);
      border-color: var(--border);
      border-bottom-color: var(--bg);   /* hides the strip below to fuse with content */
      box-shadow: 0 -2px 0 var(--accent) inset;
    }
    /* Tab scroll area — tabs scroll horizontally when the panel is too
       narrow to fit them all, so they never overflow into the overflow
       menu's space. The save-status + ⋯ button stay anchored on the right. */
    nav.main-tabs .tab-scroll-area {
      display: flex;
      gap: 4px;
      overflow-x: auto;
      overflow-y: hidden;       /* never show a vertical scrollbar */
      flex: 1;
      min-width: 0;
      align-items: flex-end;    /* match the tab-bar baseline of the surrounding nav */
      scrollbar-width: thin;
    }
    nav.main-tabs .tab-scroll-area::-webkit-scrollbar { height: 6px; }
    nav.main-tabs .tab-scroll-area::-webkit-scrollbar-track { background: transparent; }
    nav.main-tabs .tab-scroll-area::-webkit-scrollbar-thumb {
      background: var(--border-soft);
      border-radius: 3px;
    }
    nav.main-tabs .tab-scroll-area::-webkit-scrollbar-thumb:hover { background: var(--border); }
    /* Hide the entire scrollbar when content fits — no idle visual noise. */
    nav.main-tabs .tab-scroll-area:not(:hover)::-webkit-scrollbar-thumb { background: transparent; }
    nav.main-tabs .tab-scroll-area &gt; button { flex-shrink: 0; white-space: nowrap; }

    /* Overflow ⋯ circle button. Specificity bumped via nav.main-tabs
       prefix so we override the generic `nav.main-tabs button` rules
       above (which would otherwise re-impose tab-button padding and
       square corners). Solid accent background makes it read as the
       obvious "more options" affordance — not a hover state. */
    nav.main-tabs .nav-overflow-btn {
      width: 34px; height: 34px;
      min-width: 34px;
      padding: 0;
      border-radius: 50%;
      background: var(--accent);
      border: 1px solid var(--accent);
      color: #fff;
      cursor: pointer;
      display: inline-flex;
      align-items: center;
      justify-content: center;
      margin: 4px 6px 6px 8px;
      flex-shrink: 0;
      box-shadow: 0 0 0 2px rgba(96, 165, 250, 0.18);
      transition: background 0.1s, border-color 0.1s, color 0.1s, transform 0.1s, box-shadow 0.1s;
    }
    nav.main-tabs .nav-overflow-btn:hover {
      transform: scale(1.08);
      box-shadow: 0 0 0 3px rgba(96, 165, 250, 0.3);
    }
    nav.main-tabs .nav-overflow-btn[aria-expanded="true"] {
      transform: scale(1.05);
      box-shadow: 0 0 0 3px rgba(96, 165, 250, 0.45);
    }
    html.light nav.main-tabs .nav-overflow-btn {
      box-shadow: 0 0 0 2px rgba(37, 99, 235, 0.15);
    }
    html.light nav.main-tabs .nav-overflow-btn:hover {
      box-shadow: 0 0 0 3px rgba(37, 99, 235, 0.25);
    }
    .nav-overflow-menu {
      position: fixed;
      background: var(--bg-elevated);
      border: 1px solid var(--border);
      border-radius: 6px;
      box-shadow: 0 6px 18px rgba(0,0,0,0.25);
      padding: 4px;
      min-width: 200px;
      z-index: 9500;
      display: none;
      flex-direction: column;
      gap: 1px;
    }
    .nav-overflow-menu.open { display: flex; }
    .nav-overflow-menu .menu-item {
      background: transparent;
      border: none;
      color: var(--text);
      padding: 8px 14px;
      text-align: left;
      cursor: pointer;
      border-radius: 4px;
      font-size: 13px;
      font-family: inherit;
      display: flex;
      align-items: center;
      gap: 10px;
    }
    .nav-overflow-menu .menu-item:hover {
      background: var(--bg-input);
      color: var(--accent);
    }
    .nav-overflow-menu .menu-sep {
      height: 1px;
      background: var(--border-soft);
      margin: 4px 6px;
    }
    .nav-overflow-menu .menu-item svg {
      flex-shrink: 0;
    }

    /* Tab panes — only the active pane is in the layout, and it owns its
       own scroll. The body itself doesn't scroll. */
    .tab-pane { display: none; padding: 12px; }
    .tab-pane.active {
      /* Flex column so the per-tab undo bar at the top stays pinned and
         the inner layout (scoping-layout / notes-layout / etc.) fills
         the remaining vertical space without overflowing. */
      display: flex;
      flex-direction: column;
      flex: 1;
      min-height: 0;
      overflow: hidden;   /* each tab's own layout owns its internal scrolling */
    }
    .tab-pane.active &gt; .scoping-layout,
    .tab-pane.active &gt; .notes-layout,
    .tab-pane.active &gt; .board-layout,
    .tab-pane.active &gt; .val-layout,
    .tab-pane.active &gt; .cnv-layout {
      flex: 1;
      min-height: 0;
    }

    /* ========== Per-tab Undo/Redo bar (top of every tab pane) ========== */
    /* FlexSim's WebPanel host swallows Ctrl+Z, so buttons are the ONLY
       undo path. Make them obvious and pinned so they never scroll
       off-screen with the tab content. */
    .tab-undo-bar {
      display: flex;
      gap: 4px;
      padding: 4px 8px 4px 0;
      margin-bottom: 6px;
      border-bottom: 1px solid var(--border-soft);
      flex-shrink: 0;
    }
    .tab-undo-bar button {
      background: var(--bg-elevated);
      border: 1px solid var(--border);
      color: var(--text);
      padding: 4px 10px;
      border-radius: 4px;
      font-size: 12px;
      cursor: pointer;
      font-family: inherit;
    }
    .tab-undo-bar button:hover:not(:disabled) {
      border-color: var(--accent);
      color: var(--accent);
    }
    .tab-undo-bar button:disabled {
      opacity: 0.4;
      cursor: default;
    }


    /* Save status indicator */
    .save-status {
      color: var(--text-dim);
      font-size: 11px;
      margin-left: auto;
      padding: 8px 12px;
      align-self: center;
    }
    .save-status.pending { color: var(--warning-fg); }
    .save-status.saving  { color: var(--accent); }
    .save-status.error   { color: var(--error-fg); }
    .save-status a {
      color: var(--accent);
      text-decoration: underline;
    }

    /* Notes tab */
    .notes-layout {
      display: grid;
      grid-template-columns: 160px 1fr;
      gap: 12px;
      height: 100%;
      min-height: 0;
    }
    .notes-sidebar {
      background: var(--bg-elevated);
      border: 1px solid var(--border);
      border-radius: 6px;
      padding: 6px;
      overflow-y: auto;
    }
    .note-item {
      display: flex;
      align-items: center;
      padding: 6px 8px;
      color: var(--text);
      border-radius: 4px;
      cursor: pointer;
      margin-bottom: 2px;
    }
    .note-item:hover { background: var(--bg-input); }
    .note-item.active {
      background: var(--accent);
      color: var(--bg);
      font-weight: 600;
    }
    .note-item .name { flex: 1; }
    .note-item .menu-btn {
      background: transparent;
      border: none;
      color: inherit;
      font-size: 13px;
      cursor: pointer;
      opacity: 0;
      padding: 0 4px;
    }
    .note-item:hover .menu-btn { opacity: 0.6; }
    .note-item .menu-btn:hover { opacity: 1; }
    .add-note-btn {
      display: block;
      width: 100%;
      background: transparent;
      color: var(--accent);
      border: 1px dashed var(--border);
      border-radius: 4px;
      padding: 6px;
      font-weight: 600;
      cursor: pointer;
      margin-bottom: 6px;
    }
    .notes-editor {
      display: flex;
      flex-direction: column;
      min-height: 0;
    }
    .note-header {
      display: flex;
      align-items: center;
      margin-bottom: 6px;
    }
    .note-name-input {
      background: transparent;
      border: 1px solid transparent;
      color: var(--text);
      font-size: 15px;
      font-weight: 700;
      padding: 4px 6px;
      border-radius: 4px;
      flex: 1;
    }
    .note-name-input:focus,
    .note-name-input:hover {
      background: var(--bg-input);
      border-color: var(--border);
      outline: none;
    }
    .note-body {
      flex: 1;
      background: var(--bg-input);
      color: var(--text);
      border: 1px solid var(--border);
      border-radius: 4px;
      padding: 10px;
      font-family: 'Consolas', 'Monaco', monospace;
      font-size: 13px;
      overflow-y: auto;
      white-space: pre-wrap;
      word-wrap: break-word;
    }
    .note-body:focus { outline: none; border-color: var(--accent); }
    .note-body:empty::before {
      content: 'Start typing… (paste images with Ctrl+V)';
      color: var(--text-dim);
      pointer-events: none;
    }
    .empty-state {
      color: var(--text-muted);
      padding: 20px;
      text-align: center;
    }

    /* Inline prompt popover (replaces window.prompt) */
    .inline-prompt {
      position: fixed;
      background: var(--bg-elevated);
      border: 1px solid var(--border);
      border-radius: 6px;
      padding: 12px 14px;
      width: 280px;
      z-index: 400;
      box-shadow: 0 12px 28px rgba(0, 0, 0, 0.6);
    }
    .inline-prompt .ip-label {
      font-size: 11px;
      text-transform: uppercase;
      letter-spacing: 0.04em;
      color: var(--text-muted);
      font-weight: 700;
      margin-bottom: 6px;
    }
    .inline-prompt .ip-input {
      width: 100%;
      background: var(--bg-input);
      color: var(--text);
      border: 1px solid var(--border);
      border-radius: 4px;
      padding: 6px 8px;
      font-size: 13px;
      font-family: inherit;
      margin-bottom: 10px;
    }
    .inline-prompt .ip-input:focus { outline: none; border-color: var(--accent); }
    .inline-prompt .ip-actions {
      display: flex;
      justify-content: flex-end;
      gap: 6px;
    }
    .inline-prompt .ip-actions button {
      background: var(--bg-input);
      color: var(--text);
      border: 1px solid var(--border);
      border-radius: 4px;
      padding: 4px 14px;
      font-size: 12px;
      font-weight: 700;
      cursor: pointer;
    }
    .inline-prompt .ip-actions .ip-ok {
      background: var(--accent);
      color: var(--bg);
      border-color: var(--accent);
    }

    /* Confirm dialog */
    .confirm-backdrop {
      position: fixed;
      inset: 0;
      background: rgba(0, 0, 0, 0.5);
      display: flex;
      align-items: center;
      justify-content: center;
      z-index: 100;
    }
    .confirm-box {
      background: var(--bg-elevated);
      border: 1px solid var(--border);
      border-radius: 6px;
      padding: 16px 18px;
      min-width: 320px;
      max-width: 480px;
    }
    .confirm-msg {
      color: var(--text);
      font-size: 14px;
      margin-bottom: 14px;
    }
    .confirm-actions {
      display: flex;
      justify-content: flex-end;
      gap: 8px;
    }
    .confirm-actions button {
      background: var(--bg-input);
      color: var(--text);
      border: 1px solid var(--border);
      border-radius: 4px;
      padding: 6px 14px;
      font-weight: 600;
      cursor: pointer;
    }
    .confirm-actions button.primary {
      background: var(--accent);
      color: var(--bg);
      border-color: var(--accent);
    }
    .confirm-actions button:focus { outline: 2px solid var(--accent-hover); }

    /* Saving overlay (shown while flushing on panel close) */
    .saving-overlay {
      position: fixed;
      inset: 0;
      background: rgba(0, 0, 0, 0.7);
      display: flex;
      align-items: center;
      justify-content: center;
      z-index: 1000;
    }
    .saving-overlay .saving-box {
      background: var(--bg-elevated);
      border: 1px solid var(--border);
      border-radius: 6px;
      padding: 18px 26px;
      color: var(--text);
      font-size: 14px;
      font-weight: 600;
    }

    /* Lightbox (image enlarge) */
    .lightbox-overlay {
      position: fixed;
      inset: 0;
      background: rgba(0, 0, 0, 0.88);
      display: flex;
      align-items: center;
      justify-content: center;
      z-index: 200;
      cursor: zoom-out;
    }
    .lightbox-overlay img {
      max-width: 92vw;
      max-height: 92vh;
      border-radius: 4px;
      box-shadow: 0 8px 24px rgba(0, 0, 0, 0.6);
    }

    /* Inline images inside contenteditable bodies */
    .note-body img,
    .panel-body-editor img {
      max-width: 100%;
      border-radius: 4px;
      cursor: zoom-in;
      display: block;
      margin: 6px 0;
      border: 1px solid var(--border);
    }

    /* Board layout — board on the left, optional properties panel on the
       right separated by a draggable divider. Board-main owns its own
       horizontal/vertical scrolling so the panel stays put even when the
       column grid overflows. */
    .board-layout {
      display: grid;
      grid-template-columns: 1fr;
      gap: 0;
      height: 100%;
      min-height: 0;
    }
    .board-layout.with-panel {
      grid-template-columns: 1fr 6px var(--panel-w, 320px);
      gap: 0;
    }
    .board-main {
      min-width: 0;
      min-height: 0;
      display: flex;
      flex-direction: column;
      overflow: hidden;   /* scroll lives on .board-scroll below */
    }
    /* Controls bar — always visible, never scrolls with the grid. */
    .board-main &gt; .board-controls {
      flex-shrink: 0;
      padding: 12px 12px 8px;
      margin: 0;
    }
    /* The grid's own scroll container. No padding-left/top so sticky
       row-heads / col-heads pin flush to the viewport edge (avoids the
       gap where cards would peek through behind the headers on scroll). */
    .board-scroll {
      flex: 1;
      min-height: 0;
      min-width: 0;
      overflow: auto;
      padding: 0;
    }

    /* Drag handle between board-main and board-panel */
    .board-divider {
      background: var(--border);
      cursor: col-resize;
      transition: background 0.1s;
    }
    .board-divider:hover,
    .board-divider.dragging { background: var(--accent); }

    /* Properties panel (right side) */
    .board-panel {
      background: var(--bg-elevated);
      border: none;
      border-left: 1px solid var(--border);
      border-radius: 0;
      padding: 12px 14px;
      height: 100%;
      min-height: 0;
      overflow-y: auto;
      display: none;
    }
    .board-layout.with-panel .board-panel { display: block; }
    .panel-header {
      display: flex;
      align-items: center;
      justify-content: space-between;
      color: var(--text-muted);
      font-size: 11px;
      text-transform: uppercase;
      letter-spacing: 0.04em;
      margin-bottom: 10px;
    }
    .panel-close {
      background: transparent;
      border: none;
      color: var(--text-dim);
      font-size: 16px;
      cursor: pointer;
      padding: 0 4px;
    }
    .panel-close:hover { color: var(--error-fg); }
    .panel-label {
      display: block;
      color: var(--text-muted);
      font-size: 10px;
      text-transform: uppercase;
      letter-spacing: 0.04em;
      margin: 10px 0 4px;
      font-weight: 700;
    }
    .panel-input,
    .board-panel select {
      width: 100%;
      background: var(--bg-input);
      color: var(--text);
      border: 1px solid var(--border);
      border-radius: 4px;
      padding: 6px 8px;
      font-size: 13px;
    }
    .panel-input:focus,
    .board-panel select:focus { outline: none; border-color: var(--accent); }
    .panel-row {
      display: grid;
      grid-template-columns: 1fr 1fr;
      gap: 8px;
    }
    .panel-body-editor {
      width: 100%;
      min-height: 120px;
      max-height: 50vh;
      overflow-y: auto;
      background: var(--bg-input);
      color: var(--text);
      border: 1px solid var(--border);
      border-radius: 4px;
      padding: 8px 10px;
      font-family: 'Consolas', 'Monaco', monospace;
      font-size: 12px;
      line-height: 1.45;
      white-space: pre-wrap;
      word-wrap: break-word;
    }
    .panel-body-editor:focus { outline: none; border-color: var(--accent); }
    .panel-body-editor:empty::before {
      content: 'Add notes, paste images…';
      color: var(--text-dim);
      pointer-events: none;
    }
    .panel-delete {
      margin-top: 14px;
      background: transparent;
      color: var(--error-fg);
      border: 1px solid rgba(248, 113, 113, 0.4);
      border-radius: 4px;
      padding: 6px 12px;
      font-weight: 600;
      cursor: pointer;
      width: 100%;
    }
    .panel-delete:hover { background: rgba(248, 113, 113, 0.12); }

    /* Card on board — title-only label, draggable */
    .card.selected {
      outline: 2px solid var(--accent);
      outline-offset: -1px;
    }
    .card-title-display {
      color: var(--text);
      font-size: 12px;
      font-weight: 600;
      word-wrap: break-word;
      cursor: grab;
    }
    .card.dragging .card-title-display { cursor: grabbing; }

    /* Top-right action buttons (theme + export) — prominent, real-button look */
    .top-action {
      background: var(--bg-elevated);
      border: 1px solid var(--border);
      color: var(--text);
      cursor: pointer;
      font-size: 14px;
      font-weight: 600;
      padding: 6px 12px;
      border-radius: 4px;
      margin: 4px 4px 4px 0;
      align-self: center;
      min-width: 38px;
      min-height: 30px;
      display: inline-flex;
      align-items: center;
      justify-content: center;
      gap: 4px;
    }
    .top-action:hover {
      background: var(--accent);
      color: var(--bg);
      border-color: var(--accent);
    }
    .top-action:active { transform: translateY(1px); }

    /* Formatting toolbar (sits above every contenteditable body editor) */
    .format-toolbar {
      display: flex;
      align-items: center;
      flex-wrap: wrap;
      gap: 1px;
      background: var(--bg-elevated);
      border: 1px solid var(--border);
      border-bottom: none;
      border-radius: 4px 4px 0 0;
      padding: 3px 4px;
    }
    .format-toolbar button {
      background: transparent;
      border: none;
      color: var(--text-muted);
      padding: 4px 7px;
      font-size: 12px;
      cursor: pointer;
      border-radius: 3px;
      min-width: 22px;
      font-weight: 600;
      line-height: 1;
      display: inline-flex;
      align-items: center;
      justify-content: center;
    }
    .format-toolbar button svg { display: block; }
    .format-toolbar button:hover {
      background: var(--bg-input);
      color: var(--text);
    }
    .format-toolbar button.active {
      background: var(--bg-input);
      color: var(--accent);
    }
    .format-toolbar .sep {
      width: 1px;
      height: 16px;
      background: var(--border);
      margin: 0 4px;
      flex-shrink: 0;
    }
    /* When the body sits below a toolbar, drop the body's top border-radius
       so they look like one stacked block. */
    .format-toolbar + .note-body,
    .format-toolbar + .panel-body-editor {
      border-top-left-radius: 0;
      border-top-right-radius: 0;
    }

    /* Image selection inside contenteditables — click an image to select
       it, then Delete/Backspace removes it. */
    .note-body img.img-selected,
    .panel-body-editor img.img-selected {
      outline: 2px solid var(--accent);
      outline-offset: -2px;
    }

    /* Explicit heading sizes inside the contenteditable bodies so H1/H2/H3
       are visibly distinct (without this, the editor's small font-size
       compressed them to near-identical sizes). */
    .note-body h1, .panel-body-editor h1 {
      font-size: 1.85em; font-weight: 700; margin: 12px 0 6px; color: var(--text);
    }
    .note-body h2, .panel-body-editor h2 {
      font-size: 1.45em; font-weight: 700; margin: 10px 0 6px; color: var(--text);
    }
    .note-body h3, .panel-body-editor h3 {
      font-size: 1.15em; font-weight: 600; margin: 8px 0 4px; color: var(--text);
    }

    /* Inline &lt;code&gt; styling inside contenteditables */
    .note-body code, .panel-body-editor code {
      background: var(--bg-elevated);
      padding: 1px 5px;
      border-radius: 3px;
      font-family: 'Consolas', 'Monaco', monospace;
      font-size: 0.9em;
      border: 1px solid var(--border);
    }

    /* Color / highlight popover */
    .color-popover {
      background: var(--bg-elevated);
      border: 1px solid var(--border);
      border-radius: 6px;
      padding: 6px;
      display: flex;
      gap: 4px;
      z-index: 150;
      box-shadow: 0 6px 18px rgba(0, 0, 0, 0.4);
    }
    .color-swatch {
      width: 22px;
      height: 22px;
      border-radius: 4px;
      cursor: pointer;
      border: 1px solid var(--border);
      padding: 0;
      transition: transform 0.08s;
    }
    .color-swatch:hover { transform: scale(1.12); }
    .color-swatch.reset {
      background: transparent;
      position: relative;
    }
    .color-swatch.reset::before {
      content: '\2715';
      position: absolute;
      inset: 0;
      display: flex;
      align-items: center;
      justify-content: center;
      color: var(--text-muted);
      font-size: 12px;
    }

    /* Color-button indicators in the toolbar */
    .format-toolbar .color-indicator {
      border-bottom: 2px solid var(--error-fg);
      padding-bottom: 1px;
      font-weight: 700;
    }
    .format-toolbar .hi-indicator {
      background: #fef3c7;
      color: #0f172a;
      padding: 0 3px;
      border-radius: 2px;
      font-weight: 700;
    }

    /* Editor font-size classes — applied to body so they cascade */
    body.font-small .note-body, body.font-small .panel-body-editor { font-size: 11px; }
    body.font-medium .note-body, body.font-medium .panel-body-editor { font-size: 13px; }
    body.font-large .note-body, body.font-large .panel-body-editor { font-size: 16px; }

    /* Settings dropdown */
    .settings-dropdown {
      position: fixed;
      background: var(--bg-elevated);
      border: 1px solid var(--border);
      border-radius: 6px;
      padding: 14px 16px;
      width: 280px;
      z-index: 200;
      box-shadow: 0 8px 24px rgba(0, 0, 0, 0.5);
    }
    .settings-dropdown h4 {
      margin: 0 0 4px;
      font-size: 11px;
      text-transform: uppercase;
      letter-spacing: 0.04em;
      color: var(--text-muted);
      font-weight: 700;
    }
    .settings-row { margin-bottom: 14px; }
    .settings-row:last-child { margin-bottom: 0; }
    .settings-row .options {
      display: flex;
      gap: 4px;
      margin-top: 4px;
    }
    .settings-row .opt {
      flex: 1;
      background: var(--bg-input);
      color: var(--text-muted);
      border: 1px solid var(--border);
      border-radius: 4px;
      padding: 5px 8px;
      font-size: 12px;
      font-weight: 600;
      cursor: pointer;
      text-align: center;
    }
    .settings-row .opt:hover { color: var(--text); }
    .settings-row .opt.active {
      background: var(--accent);
      color: var(--bg);
      border-color: var(--accent);
    }
    .settings-row input[type="range"] {
      width: 100%;
      margin-top: 4px;
    }
    .settings-row .settings-num {
      background: var(--bg-input);
      color: var(--text);
      border: 1px solid var(--border);
      border-radius: 4px;
      padding: 5px 8px;
      font-size: 12px;
      width: 90px;
    }
    .settings-row .settings-num:focus { outline: none; border-color: var(--accent); }
    .settings-row .settings-suffix { color: var(--text-muted); font-size: 12px; }
    .settings-row .settings-hint {
      color: var(--text-dim);
      font-size: 11px;
      margin-top: 6px;
    }
    .settings-row .range-label {
      font-size: 11px;
      color: var(--text-dim);
      text-align: right;
    }

    /* About modal */
    .about-backdrop {
      position: fixed;
      inset: 0;
      background: rgba(0, 0, 0, 0.55);
      display: flex;
      align-items: center;
      justify-content: center;
      z-index: 250;
    }
    .about-box {
      background: var(--bg-elevated);
      border: 1px solid var(--border);
      border-radius: 8px;
      padding: 28px 32px;
      width: 380px;
      text-align: center;
      box-shadow: 0 12px 36px rgba(0, 0, 0, 0.5);
    }
    .about-logo {
      width: 180px;
      height: auto;
      margin: 0 auto 8px;
      display: block;
    }
    .about-logo path { fill: #2563eb; }
    html.light .about-logo path { fill: #1d4ed8; }
    .about-tagline {
      color: var(--text-muted);
      font-size: 13px;
      margin-bottom: 18px;
    }
    .about-product {
      font-size: 17px;
      font-weight: 700;
      color: var(--text);
      margin-bottom: 2px;
    }
    .about-version {
      color: var(--text-dim);
      font-size: 11px;
      margin-bottom: 18px;
    }
    .about-link {
      color: #2563eb;
      text-decoration: none;
      font-size: 12px;
      font-weight: 600;
    }
    .about-link:hover { text-decoration: underline; }
    .about-email {
      font-size: 12px;
      color: var(--text-muted);
      margin-bottom: 4px;
      user-select: text;
    }
    .about-email .about-email-addr {
      color: var(--text);
      font-weight: 600;
      user-select: all;
      cursor: text;
    }
    .about-close {
      margin-top: 16px;
      background: var(--accent);
      color: var(--bg);
      border: none;
      border-radius: 4px;
      padding: 8px 22px;
      font-weight: 700;
      cursor: pointer;
    }
    .about-field {
      text-align: left;
      margin-bottom: 10px;
    }
    .about-label {
      font-size: 11px;
      font-weight: 700;
      text-transform: uppercase;
      letter-spacing: 0.4px;
      color: var(--text-dim);
      margin-right: 6px;
    }
    .about-value {
      font-size: 12px;
      color: var(--text);
    }
    .about-divider {
      border: none;
      border-top: 1px solid var(--border);
      margin: 14px 0;
    }
    .about-footer       { color: var(--text-dim); font-size: 11px; text-align: center; margin-top: 8px; }

    /* ====== Canvases tab ====== */
    .cnv-layout {
      display: grid;
      /* minmax(0, 1fr) lets the main column shrink below the toolbar's
         intrinsic width so applyToolbarOverflow() can correctly detect
         and collapse the trailing items into a … menu. */
      grid-template-columns: 160px minmax(0, 1fr);
      gap: 8px;
      height: 100%;
      min-height: 0;
    }
    .cnv-sidebar {
      background: var(--bg-elevated);
      border: 1px solid var(--border);
      border-radius: 6px;
      padding: 6px;
      overflow-y: auto;
      display: flex;
      flex-direction: column;
    }
    .cnv-list-item {
      display: flex;
      align-items: center;
      padding: 6px 8px;
      color: var(--text);
      border-radius: 4px;
      cursor: pointer;
      margin-bottom: 2px;
      font-size: 12px;
    }
    .cnv-list-item:hover { background: var(--bg-input); }
    .cnv-list-item.active { background: var(--accent); color: var(--bg); font-weight: 700; }
    .cnv-list-item .name { flex: 1; overflow: hidden; text-overflow: ellipsis; white-space: nowrap; }
    .cnv-list-item .menu-btn {
      background: transparent;
      border: none;
      color: inherit;
      font-size: 12px;
      cursor: pointer;
      opacity: 0;
      padding: 0 4px;
    }
    .cnv-list-item:hover .menu-btn { opacity: 0.7; }
    .cnv-list-item .menu-btn:hover { opacity: 1; }
    .cnv-add-btn {
      background: transparent;
      color: var(--accent);
      border: 1px dashed var(--border);
      border-radius: 4px;
      padding: 6px;
      cursor: pointer;
      font-weight: 600;
      font-size: 12px;
      margin-top: 4px;
    }

    .cnv-main {
      display: flex;
      flex-direction: column;
      min-height: 0;
      min-width: 0;   /* allow the toolbar overflow detector to see clip */
    }
    .cnv-toolbar {
      display: flex;
      align-items: center;
      flex-wrap: nowrap;
      gap: 4px;
      background: var(--bg-elevated);
      border: 1px solid var(--border);
      border-radius: 6px 6px 0 0;
      border-bottom: none;
      padding: 4px 6px;
      overflow: hidden;
    }

    /* Toolbar overflow menu (appears when toolbar can't fit all items) */
    .cnv-overflow-menu {
      position: fixed;
      background: var(--bg-elevated);
      border: 1px solid var(--border);
      border-radius: 6px;
      padding: 6px;
      display: flex;
      flex-wrap: wrap;
      gap: 4px;
      z-index: 250;
      box-shadow: 0 8px 24px rgba(0, 0, 0, 0.55);
      max-width: 280px;
      align-content: flex-start;
    }
    .cnv-overflow-menu .cnv-sep {
      width: 100%;
      height: 1px;
      margin: 4px 0;
      background: var(--border);
    }
    /* Mini-separators still look noisy in the popover, but section
       labels (Stroke / Fill / Opacity / Width) are needed for the
       user to understand what each control is when collapsed. */
    .cnv-overflow-menu .cnv-mini-sep { display: none; }
    .cnv-overflow-menu .cnv-label {
      width: 100%;
      margin: 6px 4px 2px;
      font-size: 10px;
      color: var(--text-muted);
      text-transform: uppercase;
      letter-spacing: 0.04em;
      font-weight: 700;
    }
    .cnv-tool {
      background: transparent;
      color: var(--text-muted);
      border: 1px solid transparent;
      border-radius: 4px;
      padding: 4px 8px;
      cursor: pointer;
      font-size: 12px;
      min-width: 26px;
      font-weight: 600;
    }
    .cnv-tool:hover { color: var(--text); background: var(--bg-input); }
    .cnv-tool.active {
      background: var(--accent);
      color: var(--bg);
      border-color: var(--accent);
    }
    .cnv-tool.icon-btn {
      width: 30px;
      height: 30px;
      padding: 0;
      display: inline-flex;
      align-items: center;
      justify-content: center;
    }
    .cnv-tool svg { width: 16px; height: 16px; display: block; }
    .cnv-sep { width: 1px; height: 18px; background: var(--border); margin: 0 4px; }
    .cnv-swatch {
      width: 20px; height: 20px;
      border-radius: 3px;
      border: 1px solid var(--border);
      cursor: pointer;
      padding: 0;
      flex-shrink: 0;   /* don't squish to a line when the toolbar narrows */
    }
    .cnv-swatch.active { outline: 2px solid var(--accent); outline-offset: 1px; }
    .cnv-thick {
      background: transparent;
      border: 1px solid var(--border);
      color: var(--text-muted);
      border-radius: 3px;
      padding: 2px 8px;
      cursor: pointer;
      font-weight: 700;
      font-size: 11px;
      flex-shrink: 0;   /* keep buttons rectangular under flex pressure */
    }
    /* Same protection for everything else that lives in the toolbar */
    .cnv-toolbar .cnv-tool,
    .cnv-toolbar .cnv-sep,
    .cnv-toolbar .cnv-label { flex-shrink: 0; }
    .cnv-thick.active { background: var(--accent); color: var(--bg); border-color: var(--accent); }
    /* Fill opacity slider — short and inline alongside the swatches */
    .cnv-toolbar .cnv-opacity {
      width: 70px;
      flex-shrink: 0;
      accent-color: var(--accent);
      vertical-align: middle;
    }
    .cnv-toolbar .cnv-opacity-val {
      font-size: 10px;
      color: var(--text-dim);
      min-width: 28px;
      text-align: right;
      flex-shrink: 0;
    }
    .cnv-label {
      font-size: 10px;
      color: var(--text-dim);
      text-transform: uppercase;
      letter-spacing: 0.04em;
      margin: 0 6px 0 4px;
      font-weight: 700;
    }

    .cnv-stage-wrap {
      flex: 1;
      background: var(--bg-input);
      border: 1px solid var(--border);
      border-radius: 0 0 6px 6px;
      overflow: hidden;   /* no scroll bars — pan + zoom only (truly infinite canvas) */
      position: relative;
    }
    .cnv-stage {
      display: block;
      width: 100%;
      height: 100%;
      /* Grid pattern uses fill="currentColor" — pick a tone for each
         theme so the dots stay visible against the canvas background. */
      color: rgba(255, 255, 255, 0.18);
    }
    html.light .cnv-stage { color: rgba(15, 23, 42, 0.28); }
    .cnv-stage.tool-rect, .cnv-stage.tool-roundrect, .cnv-stage.tool-ellipse,
    .cnv-stage.tool-diamond, .cnv-stage.tool-triangle, .cnv-stage.tool-hexagon,
    .cnv-stage.tool-line, .cnv-stage.tool-arrow, .cnv-stage.tool-text {
      cursor: crosshair;
    }
    .cnv-stage.tool-freedraw { cursor: crosshair; }
    .cnv-stage.tool-select { cursor: default; }
    .cnv-stage .shape { cursor: move; }
    .cnv-stage .shape.selected { filter: drop-shadow(0 0 0 var(--accent)); outline: 2px dashed var(--accent); }
    .cnv-stage .shape text { pointer-events: none; user-select: none; }

    /* Rich text inside a shape (rect / ellipse / ...). Rendered via
       &lt;foreignObject&gt;. pointer-events:none in display mode so clicks
       pass through to the shape (drag/select); flips to auto when the
       div becomes contenteditable for editing. */
    .cnv-shape-text {
      width: 100%;
      height: 100%;
      display: flex;
      flex-direction: column;
      justify-content: center;
      font-family: -apple-system, "Segoe UI", sans-serif;
      font-size: 14px;
      color: #0f172a;
      line-height: 1.35;
      word-break: break-word;
      overflow: hidden;
      pointer-events: none;
    }
    .cnv-shape-text p           { margin: 0; }
    .cnv-shape-text ul,
    .cnv-shape-text ol          { margin: 4px 0; padding-left: 22px; }
    .cnv-shape-text h1          { font-size: 1.4em; margin: 4px 0; font-weight: 700; }
    .cnv-shape-text h2          { font-size: 1.2em; margin: 4px 0; font-weight: 700; }
    .cnv-shape-text h3          { font-size: 1.05em; margin: 4px 0; font-weight: 700; }
    .cnv-shape-text code        { background: rgba(0,0,0,0.07); padding: 1px 4px; border-radius: 3px; font-family: Consolas, Menlo, monospace; }
    .cnv-shape-text a           { color: var(--accent); text-decoration: underline; }
    .cnv-shape-text img         { max-width: 100%; height: auto; }
    .cnv-shape-text[contenteditable="true"] {
      pointer-events: auto;
      outline: 2px solid var(--accent);
      background: rgba(255,255,255,0.96);
      cursor: text;
      overflow: auto;
    }

    /* Free-floating text shape (no enclosing shape) — same idea but
       left-aligned by default and inherits color/font-size from style. */
    .cnv-text-shape {
      width: 100%;
      height: 100%;
      font-family: -apple-system, "Segoe UI", sans-serif;
      line-height: 1.3;
      word-break: break-word;
      overflow: hidden;
      pointer-events: none;
    }
    .cnv-text-shape p           { margin: 0; }
    .cnv-text-shape ul,
    .cnv-text-shape ol          { margin: 4px 0; padding-left: 22px; }
    .cnv-text-shape a           { color: var(--accent); text-decoration: underline; }
    .cnv-text-shape[contenteditable="true"] {
      pointer-events: auto;
      outline: 2px solid var(--accent);
      background: rgba(255,255,255,0.96);
      cursor: text;
      overflow: auto;
    }

    /* Floating format toolbar shown above the shape being edited. */
    #cnv-text-toolbar-wrap {
      position: fixed;
      z-index: 250;
      background: var(--bg-elevated);
      border: 1px solid var(--border);
      border-radius: 6px;
      box-shadow: 0 8px 24px rgba(0, 0, 0, 0.45);
      padding: 4px;
    }
    #cnv-text-toolbar-wrap .format-toolbar { border: none; margin: 0; box-shadow: none; background: transparent; }

    /* Stage cursor while Space is held (pan mode) */
    .cnv-stage-wrap.panning { cursor: grab; }
    .cnv-stage-wrap.panning:active { cursor: grabbing; }
    .cnv-stage-wrap.panning .cnv-stage { cursor: grab; }

    /* Resize handle squares */
    .cnv-handle { cursor: nwse-resize; }
    .cnv-handle[data-handle="ne"], .cnv-handle[data-handle="sw"] { cursor: nesw-resize; }
    .cnv-handle.cnv-rot-handle { cursor: grab; }
    .cnv-handle.cnv-rot-handle:active { cursor: grabbing; }

    /* Contextual selection toolbar — always rendered (with empty-state
       placeholder) so the canvas doesn't shift when selection changes. */
    .cnv-sel-toolbar {
      display: flex;
      align-items: center;
      gap: 2px;
      background: var(--bg-input);
      border: 1px solid var(--border);
      border-top: none;
      padding: 4px 6px;
      min-height: 40px;
    }
    .cnv-sel-toolbar.empty {
      justify-content: center;
    }
    .cnv-sel-toolbar .cnv-sep { background: var(--border); }
    .cnv-sel-toolbar .cnv-mini-sep {
      width: 1px;
      height: 14px;
      background: var(--border-soft);
      margin: 0 2px;
      opacity: 0.6;
      flex-shrink: 0;
    }
    .cnv-sel-toolbar .cnv-tool {
      background: transparent;
      color: var(--text);
      border: 1px solid transparent;
      border-radius: 4px;
      padding: 3px 8px;
      cursor: pointer;
      font-size: 12px;
      min-width: 26px;
      font-weight: 700;
    }
    .cnv-sel-toolbar .cnv-tool:hover { background: var(--bg-elevated); }
    .cnv-sel-count {
      color: var(--text-muted);
      font-size: 11px;
      font-weight: 700;
      text-transform: uppercase;
      letter-spacing: 0.04em;
      padding: 0 6px;
    }
    .cnv-sel-toolbar .cnv-tool.wide {
      padding: 3px 10px;
      min-width: auto;
    }
    .cnv-sel-toolbar .cnv-hint {
      color: var(--text-dim);
      font-size: 11px;
      font-style: italic;
      margin-left: auto;
      padding: 0 6px;
    }

    /* Right-click context menu */
    .cnv-context-menu {
      position: fixed;
      background: var(--bg-elevated);
      border: 1px solid var(--border);
      border-radius: 5px;
      padding: 4px;
      z-index: 300;
      box-shadow: 0 8px 24px rgba(0, 0, 0, 0.5);
      min-width: 220px;
      user-select: none;
    }
    .cnv-context-menu button {
      width: 100%;
      text-align: left;
      background: transparent;
      color: var(--text);
      border: none;
      padding: 6px 12px;
      font-size: 13px;
      cursor: pointer;
      display: flex;
      align-items: center;
      gap: 12px;
      border-radius: 3px;
      font-family: inherit;
    }
    .cnv-context-menu button:hover:not([disabled]) {
      background: var(--accent);
      color: var(--bg);
    }
    .cnv-context-menu button[disabled] {
      opacity: 0.35;
      cursor: not-allowed;
    }
    .cnv-context-menu button .label { flex: 1; }
    .cnv-context-menu button .shortcut {
      color: var(--text-dim);
      font-size: 11px;
      font-family: 'Consolas', monospace;
    }
    .cnv-context-menu button:hover:not([disabled]) .shortcut { color: var(--bg); opacity: 0.7; }
    .cnv-context-menu hr {
      border: none;
      border-top: 1px solid var(--border);
      margin: 4px 0;
    }

    /* Dimensions overlay while drawing / resizing */
    .cnv-dim-label {
      position: absolute;
      top: 8px;
      left: 8px;
      background: rgba(15, 23, 42, 0.85);
      color: #fff;
      font-size: 11px;
      font-family: 'Consolas', monospace;
      padding: 3px 6px;
      border-radius: 3px;
      pointer-events: none;
      z-index: 5;
    }

    /* Board tab */
    .board-controls {
      display: flex;
      gap: 8px;
      margin-bottom: 8px;
    }
    .board-controls button {
      background: transparent;
      color: var(--accent);
      border: 1px dashed var(--border);
      border-radius: 4px;
      padding: 6px 12px;
      font-weight: 600;
      cursor: pointer;
    }
    .board-controls button:hover { background: var(--bg-input); }

    .board-grid {
      display: grid;
      grid-template-columns: 60px repeat(var(--col-count, 4), minmax(140px, 1fr));
      gap: 6px;
      /* internal padding lives here, not on the scroll container, so
         sticky elements can pin to the viewport edge */
      padding: 8px 12px 12px 8px;
    }
    /* Sticky board headers/labels — col-heads pin to the top, row labels
       pin to the left, the empty corner pins to both. Lets the user scroll
       a wide/tall board and always see context. */
    .board-grid &gt; .col-head { position: sticky; top: 0;  z-index: 2; }
    .board-grid &gt; .row-head { position: sticky; left: 0; z-index: 2; }
    .board-grid &gt; .corner {
      position: sticky;
      top: 0; left: 0;
      z-index: 3;
      background: var(--bg-elevated);
      border: 1px solid var(--border);
      border-radius: 4px;
    }
    .col-head, .row-head {
      background: var(--bg-elevated);
      border: 1px solid var(--border);
      border-radius: 4px;
      padding: 6px 8px;
      font-size: 11px;
      font-weight: 700;
      text-transform: uppercase;
      color: var(--text-muted);
      display: flex;
      align-items: center;
    }
    .col-head { justify-content: space-between; }
    .col-head .name-input {
      flex: 1;
      background: transparent;
      color: var(--text-muted);
      border: 1px solid transparent;
      border-radius: 3px;
      font-size: 11px;
      font-weight: 700;
      text-transform: uppercase;
      padding: 2px 4px;
    }
    .col-head .name-input:focus,
    .col-head .name-input:hover {
      background: var(--bg-input);
      border-color: var(--border);
      color: var(--text);
      outline: none;
    }
    .col-head .col-menu {
      background: transparent;
      color: var(--text-dim);
      border: none;
      cursor: pointer;
      font-size: 14px;
      padding: 0 4px;
    }
    .row-head { justify-content: flex-end; color: var(--text-muted); }
    .row-head.high { color: var(--error-fg); }
    .row-head.med  { color: var(--warning-fg); }
    .row-head.low  { color: var(--success-fg); }

    .cell {
      background: var(--bg-input);
      border: 1px dashed var(--border);
      border-radius: 4px;
      padding: 4px;
      min-height: 60px;
    }
    .cell.drop-target { border-color: var(--accent); background: rgba(96, 165, 250, 0.06); }

    .card {
      background: var(--bg-elevated);
      border: 1px solid var(--border);
      border-left: 3px solid var(--accent);
      border-radius: 4px;
      padding: 6px 8px;
      margin-bottom: 4px;
      cursor: grab;
    }
    .card.priority-high { border-left-color: var(--error-fg); }
    .card.priority-med  { border-left-color: var(--warning-fg); }
    .card.priority-low  { border-left-color: var(--success-fg); }
    .card.dragging { opacity: 0.5; }
    .card-row {
      display: flex;
      align-items: center;
      gap: 4px;
    }
    .card-title-input {
      flex: 1;
      background: transparent;
      color: var(--text);
      border: 1px solid transparent;
      border-radius: 3px;
      padding: 2px 4px;
      font-size: 13px;
      font-weight: 600;
    }
    .card-title-input:focus,
    .card-title-input:hover {
      background: var(--bg-input);
      border-color: var(--border);
      outline: none;
    }
    .card-chev, .card-del {
      background: transparent;
      border: none;
      cursor: pointer;
      font-size: 12px;
      color: var(--text-dim);
      padding: 0 4px;
    }
    .card-del:hover { color: var(--error-fg); }
    .card-body {
      margin-top: 4px;
      padding-top: 4px;
      border-top: 1px solid var(--border);
    }
    .card-body textarea {
      width: 100%;
      background: var(--bg-input);
      color: var(--text);
      border: 1px solid var(--border);
      border-radius: 3px;
      padding: 6px;
      font-family: 'Consolas', 'Monaco', monospace;
      font-size: 12px;
      resize: vertical;
      min-height: 50px;
    }
    .card-body textarea:focus { outline: none; border-color: var(--accent); }

    .add-card-bar {
      margin-top: 10px;
      display: flex;
      gap: 8px;
    }
    .add-card-bar button {
      background: transparent;
      color: var(--accent);
      border: 1px dashed var(--border);
      border-radius: 4px;
      padding: 8px 14px;
      font-weight: 600;
      cursor: pointer;
    }
    .add-card-bar .grow { flex: 1; }

    /* Add-card inline form */
    .add-card-form {
      background: var(--bg-elevated);
      border: 1px solid var(--border);
      border-radius: 6px;
      padding: 12px;
      margin-top: 10px;
      display: grid;
      grid-template-columns: 2fr 1fr 1fr auto auto;
      gap: 8px;
      align-items: center;
    }
    .add-card-form input,
    .add-card-form select {
      background: var(--bg-input);
      color: var(--text);
      border: 1px solid var(--border);
      border-radius: 4px;
      padding: 6px 8px;
      font-size: 13px;
    }
    .add-card-form button.primary {
      background: var(--accent);
      color: var(--bg);
      border: none;
      border-radius: 4px;
      padding: 6px 14px;
      font-weight: 600;
      cursor: pointer;
    }
    .add-card-form button.cancel {
      background: transparent;
      color: var(--text-muted);
      border: 1px solid var(--border);
      border-radius: 4px;
      padding: 6px 14px;
      cursor: pointer;
    }

    /* ===== Scoping tab ===== */
    .scoping-layout {
      display: grid;
      grid-template-columns: 200px 1fr;
      height: 100%;
      min-height: 0;
    }
    .scoping-sidebar {
      background: var(--bg-elevated);
      border-right: 1px solid var(--border);
      display: flex; flex-direction: column;
      overflow: hidden;
    }
    .scoping-sidebar .sidebar-head {
      padding: 8px 12px;
      border-bottom: 1px solid var(--border-soft);
      display: flex; align-items: center; gap: 6px;
      flex-shrink: 0;
    }
    .scoping-sidebar .sidebar-head h3 {
      font-size: 10px; margin: 0;
      text-transform: uppercase; letter-spacing: 0.5px;
      color: var(--text-dim); font-weight: 700;
      flex: 1;
    }
    .scoping-sidebar .scope-list {
      flex: 1; overflow-y: auto; padding: 4px;
    }
    .scope-item {
      /* Right padding leaves clear space for the absolute del-btn so it
         doesn't overlap the title ellipsis area when the scope name is
         long. */
      padding: 8px 28px 8px 10px;
      border-radius: 4px;
      cursor: pointer;
      color: var(--text-muted);
      border-left: 3px solid transparent;
      margin-bottom: 2px;
      position: relative;
    }
    .scope-item:hover { background: var(--bg-input); color: var(--text); }
    .scope-item.active {
      background: var(--bg-input);
      color: var(--text);
      border-left-color: var(--accent);
    }
    .scope-item .title {
      font-size: 12px; font-weight: 600;
      white-space: nowrap; overflow: hidden; text-overflow: ellipsis;
    }
    .scope-item .meta {
      font-size: 10px; color: var(--text-dim);
      margin-top: 2px;
      white-space: nowrap; overflow: hidden; text-overflow: ellipsis;
    }
    .scope-item .del-btn {
      position: absolute; top: 6px; right: 6px;
      background: transparent; border: none;
      color: var(--text-dim); cursor: pointer;
      font-size: 12px; padding: 0 4px;
      opacity: 0; transition: opacity 0.1s;
    }
    .scope-item:hover .del-btn,
    .scope-item.active .del-btn { opacity: 1; }
    .scope-item .del-btn:hover { color: var(--error-fg); }

    .scope-doc {
      overflow-y: auto;
      padding: 18px 28px 60px 28px;
      min-width: 0;
    }
    .scope-doc.empty {
      display: flex; align-items: center; justify-content: center;
      color: var(--text-dim); font-style: italic;
    }
    .scope-doc-empty {
      display: flex; flex-direction: column; align-items: center;
      justify-content: center; height: 100%; gap: 12px;
      color: var(--text-dim);
    }
    .scope-doc-empty .big { font-size: 32px; opacity: 0.4; }

    .scope-doc .doc-title-input {
      background: transparent; border: none;
      color: var(--text); font-size: 20px; font-weight: 600;
      outline: none; width: 100%; padding: 4px 0;
      margin-bottom: 4px;
    }
    .scope-doc .doc-title-input:focus { background: var(--bg-input); padding: 4px 8px; border-radius: 4px; }
    .scope-doc .doc-oneliner-input {
      background: transparent; border: none;
      color: var(--text-muted); font-size: 13px;
      outline: none; width: 100%; padding: 2px 0;
      margin-bottom: 16px; font-style: italic;
    }
    .scope-doc .doc-oneliner-input:focus { background: var(--bg-input); padding: 2px 8px; border-radius: 4px; font-style: normal; }

    .scope-section {
      margin-bottom: 18px;
      padding: 6px 0;
      border-top: 1px solid var(--border-soft);
    }
    .scope-section-header {
      display: flex; align-items: center; gap: 8px;
      margin-bottom: 6px;
      padding-top: 4px;
      flex-wrap: wrap;
    }
    .scope-section-header h2 {
      font-size: 11px;
      font-weight: 700; text-transform: uppercase; letter-spacing: 0.6px;
      color: var(--text-muted);
      margin: 0;
    }
    .scope-section-header .desc {
      font-size: 11px; color: var(--text-dim);
      font-style: italic;
    }
    /* Add button sits immediately to the right of the section title — close
       to where the user reads "Objectives" so the action is unambiguous. */
    .scope-section-header .add-btn {
      background: var(--bg-elevated);
      border: 1px solid var(--border);
      color: var(--text-muted);
      padding: 2px 8px;
      border-radius: 3px;
      cursor: pointer;
      font-size: 10px;
      font-family: inherit;
      font-weight: 600;
      letter-spacing: 0.3px;
    }
    .scope-section-header .add-btn:hover { color: var(--accent); border-color: var(--accent); }

    .scope-section .rich-edit {
      background: transparent; border: 1px dashed transparent;
      color: var(--text); font-size: 13px; line-height: 1.5;
      padding: 6px 8px; border-radius: 4px;
      outline: none; min-height: 32px;
    }
    .scope-section .rich-edit:focus { background: var(--bg-input); border-color: var(--border); }
    .scope-section .rich-edit:empty:before {
      content: attr(data-placeholder);
      color: var(--text-dim); font-style: italic;
    }

    /* In-scope / Out-of-scope two-column */
    .scope-two-col {
      display: grid; grid-template-columns: 1fr 1fr; gap: 16px;
    }
    .scope-two-col &gt; div { display: flex; flex-direction: column; gap: 6px; }
    .scope-two-col .col-label {
      font-size: 10px; font-weight: 700; text-transform: uppercase;
      letter-spacing: 0.5px; color: var(--text-dim);
      display: flex; align-items: center;
    }
    .scope-two-col .col-label.in   { color: var(--success-fg); }
    .scope-two-col .col-label.out  { color: var(--error-fg); }
    .scope-two-col .col-label .add-btn {
      margin-left: 8px;
      background: var(--bg-elevated);
      border: 1px solid var(--border);
      color: var(--text-muted);
      padding: 2px 8px;
      border-radius: 3px;
      cursor: pointer;
      font-size: 10px;
      font-family: inherit;
      font-weight: 600;
      letter-spacing: 0.3px;
    }
    .scope-two-col .col-label .add-btn:hover { color: var(--accent); border-color: var(--accent); }

    /* Bullet list (used in many sections) */
    .scope-bullet-list { display: flex; flex-direction: column; gap: 2px; }
    .scope-bullet {
      display: flex; align-items: flex-start; gap: 6px;
      padding: 3px 4px;
      border-radius: 3px;
    }
    .scope-bullet:hover { background: var(--bg-input); }
    .scope-bullet .bullet {
      color: var(--text-dim);
      margin-top: 4px;
      width: 14px; text-align: center;
    }
    .scope-bullet .bullet-text {
      flex: 1; background: transparent; border: none; color: var(--text);
      padding: 2px 0; outline: none; font-size: 13px;
      font-family: inherit; line-height: 1.4;
      /* Auto-grow textarea: never show a scrollbar, height is driven by
         JS (autoGrowEl) on each input event. */
      resize: none; overflow: hidden;
    }
    .scope-bullet .del {
      background: transparent; border: none; color: var(--text-dim);
      cursor: pointer; padding: 0 4px; font-size: 13px;
      opacity: 0; transition: opacity 0.1s;
    }
    .scope-bullet:hover .del { opacity: 1; }
    .scope-bullet .del:hover { color: var(--error-fg); }

    /* Deliverable cards */
    .scope-deliverable-list { display: flex; flex-direction: column; gap: 8px; }
    .scope-deliverable {
      background: var(--bg-input);
      border: 1px solid var(--border-soft);
      border-radius: 5px;
      /* Extra right padding leaves clear space for the absolute delete-x
         so it doesn't collide with the date input's native calendar
         icon in the head row. */
      padding: 8px 28px 8px 10px;
      position: relative;
    }
    .scope-deliverable-head {
      display: flex; gap: 8px; align-items: center; margin-bottom: 4px;
    }
    .scope-deliverable .d-title {
      flex: 1; background: transparent; border: none;
      color: var(--text); font-size: 13px; font-weight: 500;
      outline: none; padding: 2px 0; font-family: inherit;
    }
    .scope-deliverable .d-due {
      width: 150px;
      background: transparent; border: none;
      color: var(--text-muted); font-size: 12px;
      outline: none; font-family: inherit;
    }
    .scope-deliverable .d-due:focus { background: var(--bg-elevated); padding: 2px 4px; border-radius: 3px; }
    .scope-deliverable .d-accept {
      background: transparent; border: none;
      color: var(--text-muted); font-size: 12px; font-style: italic;
      outline: none; width: 100%; padding: 2px 0;
      resize: none; font-family: inherit; line-height: 1.4;
      /* Auto-grow: scrollbar hidden, height set in JS so the box
         expands to fit the criteria text instead of scrolling. */
      overflow: hidden;
    }
    /* Acceptance-criteria label sits on its own line above the textarea
       — putting it inline (next to the text) made it look like part of
       the description and obscured what the field was for. */
    .scope-deliverable .d-accept-label {
      display: block;
      font-size: 10px; color: var(--text-dim);
      text-transform: uppercase; letter-spacing: 0.5px; font-weight: 700;
      margin-top: 8px; margin-bottom: 2px;
    }
    .scope-deliverable .delete-x {
      position: absolute; top: 4px; right: 6px;
      background: transparent; border: none; color: var(--text-dim);
      cursor: pointer; font-size: 12px;
      opacity: 0;
    }
    .scope-deliverable:hover .delete-x { opacity: 1; }
    .scope-deliverable .delete-x:hover { color: var(--error-fg); }

    /* Constraints key-value */
    .scope-kv-grid {
      display: grid;
      grid-template-columns: 1fr 1fr 1fr;
      gap: 8px;
    }
    .scope-kv { display: flex; flex-direction: column; gap: 3px; }
    .scope-kv label {
      font-size: 10px; color: var(--text-dim); font-weight: 600;
      text-transform: uppercase; letter-spacing: 0.4px;
    }
    .scope-kv input {
      background: var(--bg-input); border: 1px solid var(--border);
      color: var(--text); padding: 5px 8px; border-radius: 4px;
      font-size: 12px; font-family: inherit; width: 100%;
    }
    .scope-kv input:focus { outline: none; border-color: var(--accent); }

    /* Stakeholders table */
    .scope-stakeholder-table {
      width: 100%; border-collapse: collapse; font-size: 12px;
    }
    .scope-stakeholder-table th {
      text-align: left; padding: 6px 8px;
      background: var(--bg-elevated); color: var(--text-muted);
      font-weight: 600; font-size: 10px;
      text-transform: uppercase; letter-spacing: 0.4px;
      border-bottom: 1px solid var(--border-soft);
    }
    .scope-stakeholder-table td {
      padding: 4px 8px;
      border-bottom: 1px solid var(--border-soft);
    }
    .scope-stakeholder-table td input,
    .scope-stakeholder-table td select {
      background: transparent; border: none; color: var(--text);
      outline: none; width: 100%; padding: 4px 2px;
      font-family: inherit; font-size: 12px;
    }
    /* Row hover uses a faint accent tint so it doesn't collide with the
       header row's --bg-elevated background. */
    .scope-stakeholder-table tbody tr:hover td { background: rgba(96, 165, 250, 0.07); }
    html.light .scope-stakeholder-table tbody tr:hover td { background: rgba(37, 99, 235, 0.06); }
    .scope-stakeholder-table td.del-cell { width: 30px; text-align: center; }
    .scope-stakeholder-table td.del-cell button {
      background: transparent; border: none; color: var(--text-dim);
      cursor: pointer; opacity: 0; padding: 0 2px; font-size: 13px;
    }
    .scope-stakeholder-table tr:hover td.del-cell button { opacity: 1; }
    .scope-stakeholder-table td.del-cell button:hover { color: var(--error-fg); }

    /* Milestones */
    .scope-milestone-list { display: flex; flex-direction: column; gap: 4px; }
    .scope-milestone {
      display: flex; align-items: center; gap: 8px;
      padding: 4px 6px; border-radius: 3px;
    }
    .scope-milestone:hover { background: var(--bg-input); }
    .scope-milestone .m-date {
      width: 150px;
      background: transparent; border: none;
      color: var(--text-muted); font-size: 12px;
      outline: none; font-family: inherit;
    }
    .scope-milestone .m-date:focus { background: var(--bg-elevated); padding: 2px 4px; border-radius: 3px; }
    .scope-milestone .m-label {
      flex: 1; background: transparent; border: none; color: var(--text);
      padding: 2px 0; outline: none; font-size: 13px; font-family: inherit;
    }
    .scope-milestone .del {
      background: transparent; border: none; color: var(--text-dim);
      cursor: pointer; padding: 0 4px; font-size: 13px;
      opacity: 0;
    }
    .scope-milestone:hover .del { opacity: 1; }
    .scope-milestone .del:hover { color: var(--error-fg); }

    /* Risks */
    .scope-risk {
      display: flex; align-items: flex-start; gap: 6px;
      padding: 3px 4px; border-radius: 3px;
    }
    .scope-risk:hover { background: var(--bg-input); }
    .scope-risk select.severity {
      width: 80px;
      background: var(--bg-input); border: 1px solid var(--border);
      color: var(--text); padding: 2px 4px; border-radius: 3px;
      font-size: 10px; text-transform: uppercase; letter-spacing: 0.4px;
      font-weight: 600; font-family: inherit;
    }
    .scope-risk select.severity.low  { color: var(--text-dim); }
    .scope-risk select.severity.med  { color: var(--warning-fg); }
    .scope-risk select.severity.high { color: var(--error-fg); }
    .scope-risk .r-text {
      flex: 1; background: transparent; border: none; color: var(--text);
      padding: 2px 0; outline: none; font-size: 13px; font-family: inherit;
      line-height: 1.4;
      /* Auto-grow textarea: scrollbar hidden, height set in JS. */
      resize: none; overflow: hidden;
    }
    .scope-risk .del {
      background: transparent; border: none; color: var(--text-dim);
      cursor: pointer; padding: 0 4px; font-size: 13px;
      opacity: 0;
    }
    .scope-risk:hover .del { opacity: 1; }
    .scope-risk .del:hover { color: var(--error-fg); }

    /* Sim add-ons (collapsible group) */
    .scope-sim-group {
      margin-top: 24px;
      border-top: 2px solid var(--border);
      padding-top: 8px;
    }
    .scope-sim-group-header {
      display: flex; align-items: center; gap: 8px;
      cursor: pointer;
      padding: 8px 0;
    }
    .scope-sim-group-header h2 {
      font-size: 11px;
      font-weight: 700; text-transform: uppercase; letter-spacing: 0.6px;
      color: var(--accent);
      margin: 0;
    }
    .scope-sim-group-header .desc {
      font-size: 11px; color: var(--text-dim); font-style: italic;
    }
    .scope-sim-group-header .toggle {
      margin-left: auto;
      color: var(--text-dim);
      transition: transform 0.1s;
    }
    .scope-sim-group:not(.collapsed) .scope-sim-group-header .toggle {
      transform: rotate(90deg);
    }
    .scope-sim-group.collapsed .scope-sim-content { display: none; }

    /* ====== Scope additions (2026-06-01: SOW-inspired sections) ====== */
    .scope-meta-row {
      display: flex;
      gap: 12px;
      margin: 4px 0 16px 0;
      flex-wrap: wrap;
    }
    .scope-meta-cell {
      display: flex;
      flex-direction: column;
      gap: 2px;
      min-width: 160px;
    }
    .scope-meta-cell .lbl {
      font-size: 10px;
      text-transform: uppercase;
      letter-spacing: 0.04em;
      color: var(--text-dim);
    }
    .scope-meta-cell select {
      padding: 4px 6px;
      background: var(--bg-input);
      color: var(--text);
      border: 1px solid var(--border);
      border-radius: 3px;
      font-size: 12px;
    }
    .scope-meta-cell select.status-draft       { color: var(--text-dim); }
    .scope-meta-cell select.status-active      { color: var(--success-fg); }
    .scope-meta-cell select.status-archived    { color: var(--text-dim); opacity: 0.6; }
    .scope-meta-cell select.status-superseded  { color: var(--warning-fg); text-decoration: line-through; }

    /* Process Diagrams (canvas links) */
    .scope-process-list { display: flex; flex-direction: column; gap: 4px; }
    .scope-process-row {
      display: grid;
      grid-template-columns: minmax(140px, 1fr) 2fr auto auto;
      gap: 6px;
      align-items: center;
      padding: 4px;
      border-radius: 3px;
    }
    .scope-process-row:hover { background: var(--bg-input); }
    .scope-process-row select,
    .scope-process-row input {
      padding: 3px 6px;
      background: var(--bg-input);
      color: var(--text);
      border: 1px solid var(--border);
      border-radius: 3px;
      font-size: 12px;
    }
    .scope-process-row .pd-open,
    .scope-process-row .del {
      background: transparent;
      border: 1px solid var(--border);
      color: var(--text-dim);
      cursor: pointer;
      padding: 3px 8px;
      border-radius: 3px;
      font-size: 12px;
    }
    .scope-process-row .pd-open:hover { color: var(--accent); border-color: var(--accent); }
    .scope-process-row .del:hover { color: var(--error-fg); border-color: var(--error-fg); }

    /* Generic table styling for the new parameter / data-req / scenario / change-order tables */
    .scope-param-table,
    .scope-datareq-table,
    .scope-scenario-table,
    .scope-co-table {
      width: 100%;
      border-collapse: collapse;
      font-size: 12px;
    }
    .scope-param-table th,
    .scope-datareq-table th,
    .scope-scenario-table th,
    .scope-co-table th {
      text-align: left;
      padding: 4px 6px;
      font-size: 10px;
      text-transform: uppercase;
      letter-spacing: 0.04em;
      color: var(--text-dim);
      border-bottom: 1px solid var(--border);
      font-weight: 600;
    }
    .scope-param-table td,
    .scope-datareq-table td,
    .scope-scenario-table td,
    .scope-co-table td {
      padding: 3px 4px;
      vertical-align: middle;
    }
    .scope-param-table tbody tr:hover td,
    .scope-datareq-table tbody tr:hover td,
    .scope-scenario-table tbody tr:hover td,
    .scope-co-table tbody tr:hover td {
      background: rgba(96, 165, 250, 0.07);
    }
    html.light .scope-param-table tbody tr:hover td,
    html.light .scope-datareq-table tbody tr:hover td,
    html.light .scope-scenario-table tbody tr:hover td,
    html.light .scope-co-table tbody tr:hover td {
      background: rgba(37, 99, 235, 0.06);
    }
    .scope-param-table td input,
    .scope-param-table td select,
    .scope-datareq-table td input,
    .scope-datareq-table td select,
    .scope-scenario-table td input,
    .scope-co-table td input,
    .scope-co-table td select {
      width: 100%;
      padding: 3px 6px;
      background: transparent;
      color: var(--text);
      border: 1px solid transparent;
      border-radius: 3px;
      font-size: 12px;
      font-family: inherit;
    }
    .scope-param-table td input:focus,
    .scope-param-table td select:focus,
    .scope-datareq-table td input:focus,
    .scope-datareq-table td select:focus,
    .scope-scenario-table td input:focus,
    .scope-co-table td input:focus,
    .scope-co-table td select:focus {
      outline: none;
      background: var(--bg-input);
      border-color: var(--accent);
    }
    .scope-param-table td.del-cell,
    .scope-datareq-table td.del-cell,
    .scope-scenario-table td.del-cell,
    .scope-co-table td.del-cell { width: 30px; text-align: center; }
    .scope-param-table td.del-cell button,
    .scope-datareq-table td.del-cell button,
    .scope-scenario-table td.del-cell button,
    .scope-co-table td.del-cell button {
      background: transparent;
      border: none;
      color: var(--text-dim);
      cursor: pointer;
      opacity: 0;
      transition: opacity 0.1s;
      padding: 2px 4px;
    }
    .scope-param-table tr:hover td.del-cell button,
    .scope-datareq-table tr:hover td.del-cell button,
    .scope-scenario-table tr:hover td.del-cell button,
    .scope-co-table tr:hover td.del-cell button { opacity: 1; }
    .scope-param-table td.del-cell button:hover,
    .scope-datareq-table td.del-cell button:hover,
    .scope-scenario-table td.del-cell button:hover,
    .scope-co-table td.del-cell button:hover { color: var(--error-fg); }

    /* Data-requirements status pill colors */
    .dr-status.dr-status-pending  { color: var(--warning-fg); }
    .dr-status.dr-status-received { color: var(--success-fg); }
    .dr-status.dr-status-partial  { color: var(--accent); }
    .dr-status.dr-status-waived   { color: var(--text-dim); }

    /* Change-order status pill colors */
    .co-status.co-status-pending   { color: var(--warning-fg); }
    .co-status.co-status-approved  { color: var(--success-fg); }
    .co-status.co-status-rejected  { color: var(--error-fg); }
    .co-status.co-status-cancelled { color: var(--text-dim); }

    /* Scenarios-table baseline radio cell */
    .scope-scenario-table td.base-cell {
      text-align: center;
      width: 32px;
    }
    .scope-scenario-table td.base-cell input[type="radio"] {
      width: 14px;
      height: 14px;
      cursor: pointer;
    }

    /* Training method radio block */
    .scope-training-method {
      display: flex;
      flex-direction: column;
      gap: 4px;
    }
    .scope-training-method .tm-radio {
      display: flex;
      align-items: center;
      gap: 6px;
      padding: 4px 6px;
      border-radius: 3px;
      cursor: pointer;
      font-size: 12px;
    }
    .scope-training-method .tm-radio:hover { background: var(--bg-input); }
    .scope-training-method .tm-radio input[type="radio"] {
      width: 14px;
      height: 14px;
      cursor: pointer;
    }
    .scope-training-method .tm-other {
      margin-top: 4px;
      padding: 5px 8px;
      background: var(--bg-input);
      color: var(--text);
      border: 1px solid var(--border);
      border-radius: 3px;
      font-size: 12px;
      font-family: inherit;
    }

    /* ====== Fast tooltip (replaces slow native title=""") ====== */
    .fast-tip {
      position: fixed;
      z-index: 9998;
      background: var(--bg-elevated);
      color: var(--text);
      border: 1px solid var(--border);
      padding: 5px 9px;
      border-radius: 4px;
      font-size: 12px;
      font-family: inherit;
      line-height: 1.35;
      pointer-events: none;
      max-width: 320px;
      white-space: pre-line;
      box-shadow: 0 2px 8px rgba(0, 0, 0, 0.25);
      display: none;
    }

    /* ====== Link hover tooltip (rich-text editors) ====== */
    .link-hover-tip {
      position: fixed;
      z-index: 9999;
      background: var(--bg-elevated);
      color: var(--text);
      border: 1px solid var(--border);
      padding: 6px 10px;
      border-radius: 4px;
      font-size: 12px;
      font-family: inherit;
      line-height: 1.35;
      pointer-events: none;
      max-width: 460px;
      word-break: break-all;
      box-shadow: 0 2px 8px rgba(0, 0, 0, 0.25);
      display: none;
    }
    .link-hover-tip .link-hover-tip-hint {
      opacity: 0.7; font-size: 11px; margin-bottom: 2px;
      text-transform: uppercase; letter-spacing: 0.4px; font-weight: 600;
    }
    .link-hover-tip .link-hover-tip-url { color: var(--accent); }

    /* ====== Drag-reorder visual states (Scopes + Notes sidebars) ======
       Inset box-shadow is used instead of border to avoid layout shift
       (the items have fixed borders already, and adding a top/bottom
       border would nudge sibling rows). */
    .scope-item.dragging,
    .note-item.dragging  { opacity: 0.5; cursor: grabbing; }
    .scope-item.drop-above,
    .note-item.drop-above { box-shadow: inset 0 2px 0 0 var(--accent); }
    .scope-item.drop-below,
    .note-item.drop-below { box-shadow: inset 0 -2px 0 0 var(--accent); }
    .scope-item, .note-item { cursor: grab; }
    .scope-item:active, .note-item:active { cursor: grabbing; }

    /* ====== +2px font-size bump for the entire Scoping tab ======
       Added 2026-05-23. Mirrors every scope-* font-size declared above
       and overrides it with the same value + 2px. Placed at the end of
       the stylesheet so it wins on equal-specificity selectors. If you
       adjust an original font-size above, update the matching rule here
       too (or remove the override if a global rebase is preferred). */
    .scope-item .title { font-size: 14px; }
    .scope-item .meta { font-size: 12px; }
    .scope-item .del-btn { font-size: 14px; }
    .scope-doc-empty .big { font-size: 34px; }
    .scope-doc .doc-title-input { font-size: 22px; }
    .scope-doc .doc-oneliner-input { font-size: 15px; }
    .scope-section-header h2 { font-size: 13px; }
    .scope-section-header .desc { font-size: 13px; }
    .scope-section-header .add-btn { font-size: 12px; }
    .scope-section .rich-edit { font-size: 15px; }
    .scope-two-col .col-label { font-size: 12px; }
    .scope-two-col .col-label .add-btn { font-size: 12px; }
    .scope-bullet .bullet-text { font-size: 15px; }
    .scope-bullet .del { font-size: 15px; }
    .scope-deliverable .d-title { font-size: 15px; }
    .scope-deliverable .d-due { font-size: 14px; }
    .scope-deliverable .d-accept { font-size: 14px; }
    .scope-deliverable .d-accept-label { font-size: 11px; }
    .scope-deliverable .delete-x { font-size: 14px; }
    .scope-kv label { font-size: 12px; }
    .scope-kv input { font-size: 14px; }
    .scope-stakeholder-table { font-size: 14px; }
    .scope-stakeholder-table th { font-size: 12px; }
    .scope-stakeholder-table td input,
    .scope-stakeholder-table td select { font-size: 14px; }
    .scope-stakeholder-table td.del-cell button { font-size: 15px; }
    .scope-milestone .m-date { font-size: 14px; }
    .scope-milestone .m-label { font-size: 15px; }
    .scope-milestone .del { font-size: 15px; }
    .scope-risk select.severity { font-size: 12px; }
    .scope-risk .r-text { font-size: 15px; }
    .scope-risk .del { font-size: 15px; }
    .scope-sim-group-header h2 { font-size: 13px; }
    .scope-sim-group-header .desc { font-size: 13px; }

    /* ============ Validation tab ============ */
    .val-layout {
      display: grid;
      grid-template-columns: 200px 1fr;
      gap: 0;
      height: 100%;
      min-height: 0;
    }
    .val-sidebar {
      background: var(--bg-elevated);
      border-right: 1px solid var(--border-soft);
      display: flex; flex-direction: column;
      overflow: hidden;
    }
    .val-sidebar .sidebar-head {
      padding: 8px 10px;
      border-bottom: 1px solid var(--border-soft);
      display: flex; flex-direction: column; gap: 6px;
      flex-shrink: 0;
    }
    .val-sidebar .sidebar-head .actions { display: flex; gap: 4px; }
    .val-sidebar .sidebar-head .actions button {
      flex: 1;
      background: var(--bg-input); border: 1px solid var(--border);
      color: var(--text); padding: 4px 6px; border-radius: 3px; cursor: pointer;
      font-family: inherit; font-size: 11px;
      display: flex; align-items: center; justify-content: center; gap: 4px;
    }
    .val-sidebar .sidebar-head .actions button.primary {
      background: var(--accent); color: var(--bg); border-color: var(--accent); font-weight: 600;
    }
    .val-sidebar .sidebar-head .actions button:hover { border-color: var(--accent); color: var(--accent); }
    .val-sidebar .sidebar-head .actions button.primary:hover {
      background: var(--accent-hover); color: var(--bg); border-color: var(--accent-hover);
    }
    .val-sidebar input.val-search {
      background: var(--bg-input); border: 1px solid var(--border-soft);
      color: var(--text); padding: 4px 6px; border-radius: 3px;
      font-family: inherit; font-size: 11px; width: 100%;
    }
    .val-sidebar input.val-search:focus { outline: none; border-color: var(--accent); }

    .val-list { flex: 1; overflow-y: auto; padding: 4px 0; }
    .val-list-item {
      padding: 6px 10px;
      cursor: pointer;
      color: var(--text-muted);
      border-left: 3px solid transparent;
    }
    .val-list-item:hover { background: var(--bg-input); color: var(--text); }
    .val-list-item.active {
      background: var(--bg-input); color: var(--text);
      border-left-color: var(--accent);
    }
    .val-list-item .vl-name {
      font-size: 12px; font-weight: 600;
      white-space: nowrap; overflow: hidden; text-overflow: ellipsis;
    }
    .val-list-item .vl-meta {
      font-size: 10px; color: var(--text-dim);
      margin-top: 1px;
      white-space: nowrap; overflow: hidden; text-overflow: ellipsis;
    }
    .val-list-empty {
      padding: 14px 10px; color: var(--text-dim);
      font-style: italic; font-size: 11px;
      text-align: center;
    }

    .val-pane { overflow-y: auto; padding: 14px 22px 32px 22px; }
    .val-pane.empty {
      display: flex; align-items: center; justify-content: center;
      flex-direction: column; gap: 10px;
      color: var(--text-dim); text-align: center;
    }
    .val-pane.empty .big { font-size: 28px; opacity: 0.4; }
    .val-pane.empty p { max-width: 400px; line-height: 1.5; }

    .val-run-head {
      display: flex; align-items: center; gap: 10px;
      margin-bottom: 4px;
    }
    .val-run-name {
      background: transparent; border: none;
      color: var(--text); font-size: 20px; font-weight: 600;
      outline: none; flex: 1; padding: 2px 0;
    }
    .val-run-name:focus { background: var(--bg-input); padding: 2px 8px; border-radius: 4px; }
    .val-run-del {
      background: transparent; border: 1px solid var(--border-soft);
      color: var(--text-dim); padding: 3px 8px; border-radius: 3px;
      cursor: pointer; font-family: inherit; font-size: 11px;
    }
    .val-run-del:hover { color: var(--error-fg); border-color: var(--error-fg); }
    .val-run-meta {
      color: var(--text-dim); font-size: 11px; margin-bottom: 18px;
    }

    .val-section {
      margin-bottom: 18px;
      padding: 6px 0;
      border-top: 1px solid var(--border-soft);
    }
    .val-section-header {
      display: flex; align-items: center; gap: 8px;
      margin-bottom: 8px;
      padding-top: 4px;
    }
    .val-section-header h2 {
      font-size: 11px;
      font-weight: 700; text-transform: uppercase; letter-spacing: 0.6px;
      color: var(--text-muted);
      margin: 0;
    }
    .val-section-header .desc {
      font-size: 11px; color: var(--text-dim);
      font-style: italic;
    }
    .val-section-header .spacer { flex: 1; }
    .val-section-header button.action-btn {
      background: var(--bg-elevated);
      border: 1px solid var(--border);
      color: var(--text-muted);
      padding: 2px 8px;
      border-radius: 3px; cursor: pointer;
      font-size: 10px; font-family: inherit;
      font-weight: 600; letter-spacing: 0.3px;
    }
    .val-section-header button.action-btn:hover { color: var(--accent); border-color: var(--accent); }
    .val-section-header button.snap-btn { padding: 1px 6px; font-size: 12px; }

    .val-table {
      width: 100%;
      border-collapse: collapse;
      font-size: 12px;
    }
    .val-table th, .val-table td {
      border-bottom: 1px solid var(--border-soft);
      padding: 5px 8px;
      text-align: left;
      vertical-align: top;
    }
    .val-table th {
      background: var(--bg-elevated);
      color: var(--text-muted);
      font-weight: 600;
      font-size: 10px;
      text-transform: uppercase;
      letter-spacing: 0.4px;
    }
    .val-table tbody tr:hover td { background: rgba(96, 165, 250, 0.07); }
    html.light .val-table tbody tr:hover td { background: rgba(37, 99, 235, 0.06); }
    .val-table td.editable {
      cursor: text;
      min-height: 18px;
    }
    .val-table td.editable[contenteditable]:focus {
      outline: 1px solid var(--accent);
      background: var(--bg-input);
    }
    .val-table .col-name  { width: 28%; font-weight: 500; }
    .val-table .col-value { width: 22%; font-family: ui-monospace, "Consolas", monospace; }
    .val-table .col-units { width: 12%; color: var(--text-dim); }
    .val-table .col-desc  { color: var(--text-muted); }

    .val-table-empty {
      padding: 14px;
      color: var(--text-dim);
      font-style: italic;
      font-size: 12px;
      text-align: center;
      border: 1px dashed var(--border-soft);
      border-radius: 4px;
    }

    .val-changes-list { display: flex; flex-direction: column; gap: 2px; }
    .val-change {
      display: flex; align-items: flex-start; gap: 6px;
      padding: 3px 4px;
      border-radius: 3px;
    }
    .val-change:hover { background: var(--bg-input); }
    .val-change .bullet { color: var(--text-dim); margin-top: 4px; }
    .val-change textarea.change-text {
      flex: 1; background: transparent; border: none;
      color: var(--text); padding: 2px 0;
      outline: none; font-size: 13px; resize: none;
      font-family: inherit; overflow: hidden;
    }
    .val-change .del {
      background: transparent; border: none; color: var(--text-dim);
      cursor: pointer; padding: 0 4px; font-size: 13px;
      opacity: 0; transition: opacity 0.1s;
    }
    .val-change:hover .del { opacity: 1; }
    .val-change .del:hover { color: var(--error-fg); }

    .val-rich-edit {
      background: transparent;
      border: 1px dashed transparent;
      color: var(--text);
      font-size: 13px; line-height: 1.5;
      padding: 6px 8px;
      border-radius: 4px;
      outline: none;
      min-height: 40px;
    }
    .val-rich-edit:focus { background: var(--bg-input); border-color: var(--border); }
    .val-rich-edit:empty:before {
      content: attr(data-placeholder);
      color: var(--text-dim);
      font-style: italic;
    }

    .val-footer-note {
      margin-top: 28px;
      padding-top: 12px;
      border-top: 1px solid var(--border-soft);
      color: var(--text-dim);
      font-size: 11px;
      font-style: italic;
      line-height: 1.5;
    }

    /* Bumped font sizes for the larger editor-font-size setting */
    body.font-large .val-list-item .vl-name { font-size: 14px; }
    body.font-large .val-list-item .vl-meta { font-size: 11px; }
    body.font-large .val-run-name { font-size: 22px; }
    body.font-large .val-run-meta { font-size: 13px; }
    body.font-large .val-table { font-size: 14px; }
    body.font-large .val-section-header h2 { font-size: 13px; }
    body.font-large .val-section-header .desc { font-size: 13px; }
    body.font-large .val-rich-edit { font-size: 15px; }
  &lt;/style&gt;
&lt;/head&gt;
&lt;body class="inapp"&gt;
  &lt;nav class="main-tabs" id="main-tabs"&gt;
    &lt;div class="tab-scroll-area" id="tab-scroll-area"&gt;
      &lt;button data-tab="scoping" class="active"&gt;Scoping&lt;/button&gt;
      &lt;button data-tab="notes"&gt;Notes&lt;/button&gt;
      &lt;button data-tab="board"&gt;Board&lt;/button&gt;
      &lt;button data-tab="canvases"&gt;Canvases&lt;/button&gt;
      &lt;button data-tab="validation"&gt;Validation&lt;/button&gt;
    &lt;/div&gt;
    &lt;span id="save-status" class="save-status"&gt;&lt;/span&gt;
    &lt;button id="nav-overflow-btn" class="nav-overflow-btn" title="More options" aria-label="More options" aria-haspopup="true" aria-expanded="false"&gt;
      &lt;svg viewBox="0 0 16 16" width="14" height="14" aria-hidden="true"&gt;
        &lt;circle cx="3.5" cy="8" r="1.4" fill="currentColor"/&gt;
        &lt;circle cx="8"   cy="8" r="1.4" fill="currentColor"/&gt;
        &lt;circle cx="12.5" cy="8" r="1.4" fill="currentColor"/&gt;
      &lt;/svg&gt;
    &lt;/button&gt;
  &lt;/nav&gt;
  &lt;div id="nav-overflow-menu" class="nav-overflow-menu" role="menu" aria-hidden="true"&gt;&lt;/div&gt;

  &lt;section id="tab-scoping" class="tab-pane active"&gt;&lt;/section&gt;
  &lt;section id="tab-notes" class="tab-pane"&gt;&lt;/section&gt;
  &lt;section id="tab-board" class="tab-pane"&gt;&lt;/section&gt;
  &lt;section id="tab-canvases" class="tab-pane"&gt;&lt;/section&gt;
  &lt;section id="tab-validation" class="tab-pane"&gt;&lt;/section&gt;

  &lt;div id="confirm-root"&gt;&lt;/div&gt;
  &lt;div id="settings-root"&gt;&lt;/div&gt;
  &lt;div id="about-root"&gt;&lt;/div&gt;

  &lt;script&gt;
    // --- bridge ---
    // When running outside FlexSim, no fireFlexsimEvent global exists.
    // We install a console-logging shim and set inBrowser=true so the
    // persistence layer falls back to localStorage.
    var inBrowser = false;
    if (typeof fireFlexsimEvent === 'undefined') {
      inBrowser = true;
      window.fireFlexsimEvent = function () {
        var args = Array.prototype.slice.call(arguments);
        var cb = (typeof args[args.length - 1] === 'function') ? args.pop() : null;
        console.warn('[mock] fireFlexsimEvent', args);
        if (cb) setTimeout(function () { cb(''); }, 0);
      };
    }

    // Inline prompt — replaces window.prompt(), which CEF renders as a
    // text-only dialog with no input field in our embedding. Shows a
    // small popover positioned near `anchorRect` (a DOMRect) with an
    // input + OK/Cancel. Returns a Promise resolving to the entered
    // value, or null if cancelled.
    function inlinePrompt(message, defaultValue, anchorRect) {
      return new Promise(function (resolve) {
        var existing = document.querySelector('.inline-prompt');
        if (existing &amp;&amp; existing.parentNode) existing.parentNode.removeChild(existing);

        var pop = document.createElement('div');
        pop.className = 'inline-prompt';
        pop.innerHTML =
          '&lt;div class="ip-label"&gt;' + escapeHtml(message) + '&lt;/div&gt;' +
          '&lt;input type="text" class="ip-input" value="' + escapeHtml(defaultValue == null ? '' : String(defaultValue)) + '" /&gt;' +
          '&lt;div class="ip-actions"&gt;' +
            '&lt;button class="ip-cancel"&gt;Cancel&lt;/button&gt;' +
            '&lt;button class="ip-ok"&gt;OK&lt;/button&gt;' +
          '&lt;/div&gt;';

        // Position near the anchor. If no rect given, center on screen.
        if (anchorRect) {
          pop.style.left = Math.min(window.innerWidth - 240, Math.max(8, anchorRect.left)) + 'px';
          pop.style.top  = Math.min(window.innerHeight - 100, anchorRect.bottom + 4) + 'px';
        } else {
          pop.style.left = '50%';
          pop.style.top  = '40%';
          pop.style.transform = 'translate(-50%, -50%)';
        }
        document.body.appendChild(pop);

        var input  = pop.querySelector('.ip-input');
        var okBtn  = pop.querySelector('.ip-ok');
        var cnBtn  = pop.querySelector('.ip-cancel');

        input.focus();
        input.select();

        function close(val) {
          if (pop.parentNode) pop.parentNode.removeChild(pop);
          document.removeEventListener('keydown', keyHandler, true);
          document.removeEventListener('mousedown', outsideHandler, true);
          resolve(val);
        }
        function keyHandler(e) {
          if (e.key === 'Enter')  { e.preventDefault(); close(input.value); }
          if (e.key === 'Escape') { e.preventDefault(); close(null); }
        }
        function outsideHandler(e) {
          if (!pop.contains(e.target)) close(null);
        }
        okBtn.addEventListener('click', function () { close(input.value); });
        cnBtn.addEventListener('click', function () { close(null); });
        document.addEventListener('keydown', keyHandler, true);
        // Allow next tick so the opening click doesn't immediately close
        setTimeout(function () {
          document.addEventListener('mousedown', outsideHandler, true);
        }, 0);
      });
    }

    // --- confirm dialog ---
    function confirmDialog(msg) {
      return new Promise(function (resolve) {
        var root = document.getElementById('confirm-root');
        root.innerHTML =
          '&lt;div class="confirm-backdrop"&gt;' +
            '&lt;div class="confirm-box"&gt;' +
              '&lt;div class="confirm-msg"&gt;' + escapeHtml(msg) + '&lt;/div&gt;' +
              '&lt;div class="confirm-actions"&gt;' +
                '&lt;button id="confirm-yes"&gt;Yes&lt;/button&gt;' +
                '&lt;button id="confirm-no" class="primary"&gt;No&lt;/button&gt;' +
              '&lt;/div&gt;' +
            '&lt;/div&gt;' +
          '&lt;/div&gt;';

        function cleanup() { root.innerHTML = ''; }
        function answer(v) { cleanup(); resolve(v); }

        document.getElementById('confirm-yes').addEventListener('click', function () { answer(true); });
        document.getElementById('confirm-no').addEventListener('click', function () { answer(false); });
        document.getElementById('confirm-no').focus();

        function keyHandler(e) {
          if (e.key === 'Escape') { document.removeEventListener('keydown', keyHandler); answer(false); }
          if (e.key === 'Enter')  { document.removeEventListener('keydown', keyHandler); answer(false); } // No is default
        }
        document.addEventListener('keydown', keyHandler);
      });
    }

    // --- helpers ---
    function escapeHtml(s) {
      if (s == null) return '';
      return String(s)
        .replace(/&amp;/g, '&amp;amp;')
        .replace(/&lt;/g, '&amp;lt;')
        .replace(/&gt;/g, '&amp;gt;')
        .replace(/"/g, '&amp;quot;')
        .replace(/'/g, '&amp;#39;');
    }

    // --- image helpers ---
    // Strip data: URLs from &lt;img&gt; src attributes. We keep data-img-id so we
    // know which image each &lt;img&gt; references, but we don't persist the
    // base64 bytes inside the main blob — those live in their own tree
    // nodes (see saveImage / loadImages).
    function stripDataUrls(html) {
      if (!html) return html;
      return html.replace(/(&lt;img\b[^&gt;]*?)\s+src="data:[^"]*"([^&gt;]*&gt;)/g, '$1$2');
    }

    // Sanitize HTML coming from an Import — a notebook JSON could have been
    // hand-crafted by someone other than the current user. Strip script
    // execution vectors: &lt;script&gt;/&lt;iframe&gt;/&lt;object&gt;/&lt;embed&gt; tags, on*
    // event-handler attributes, and javascript: URLs. Not a full sanitizer
    // (HTML is impossible to fully sanitize via regex) but closes the obvious
    // payloads for a single-user-trust threat model.
    function sanitizeImportedHtml(html) {
      if (!html || typeof html !== 'string') return html;
      return html
        .replace(/&lt;(script|iframe|object|embed)\b[^&gt;]*&gt;[\s\S]*?&lt;\/\1&gt;/gi, '')
        .replace(/&lt;(script|iframe|object|embed)\b[^&gt;]*\/?&gt;/gi, '')
        .replace(/\s*on[a-z]+\s*=\s*"[^"]*"/gi, '')
        .replace(/\s*on[a-z]+\s*=\s*'[^']*'/gi, '')
        .replace(/\s*on[a-z]+\s*=\s*[^\s&gt;]+/gi, '')
        .replace(/(href|src|formaction|action)\s*=\s*(["'])\s*javascript:[^"']*\2/gi, '$1=$2#$2');
    }

    // Sweep every place that stores user-authored HTML in the loaded state
    // and run it through sanitizeImportedHtml. Called once after an Import.
    function sanitizeAllStateHtml(s) {
      if (!s) return;
      if (s.notes &amp;&amp; s.notes.items) {
        s.notes.items.forEach(function (n) { n.body = sanitizeImportedHtml(n.body); });
      }
      if (s.board &amp;&amp; s.board.cards) {
        s.board.cards.forEach(function (c) { c.body = sanitizeImportedHtml(c.body); });
      }
      if (s.scoping &amp;&amp; s.scoping.docs) {
        s.scoping.docs.forEach(function (d) {
          d.background           = sanitizeImportedHtml(d.background);
          d.modelBoundary        = sanitizeImportedHtml(d.modelBoundary);
          d.fidelity             = sanitizeImportedHtml(d.fidelity);
          d.notes                = sanitizeImportedHtml(d.notes);
          d.acceptance           = sanitizeImportedHtml(d.acceptance);
          d.validationAcceptance = sanitizeImportedHtml(d.validationAcceptance);
          if (d.training) d.training.postSupport = sanitizeImportedHtml(d.training.postSupport);
        });
      }
      if (s.canvases &amp;&amp; s.canvases.items) {
        s.canvases.items.forEach(function (cv) {
          if (cv.shapes) cv.shapes.forEach(function (sh) {
            if (sh.text) sh.text = sanitizeImportedHtml(sh.text);
          });
        });
      }
      if (s.validation &amp;&amp; s.validation.runs) {
        s.validation.runs.forEach(function (r) {
          r.observations = sanitizeImportedHtml(r.observations);
          r.analysis     = sanitizeImportedHtml(r.analysis);
          r.nextSteps    = sanitizeImportedHtml(r.nextSteps);
        });
      }
    }

    // Walk a body HTML string and fill in src="..." for every &lt;img data-img-id="X"&gt;
    // by looking up X in imageCache. Used right before innerHTML is set
    // so the user actually sees the image.
    function rehydrateBody(html) {
      if (!html) return '';
      return html.replace(/&lt;img\b([^&gt;]*?)\bdata-img-id="([^"]+)"([^&gt;]*)&gt;/g, function (match, before, id, after) {
        var dataUrl = imageCache[id];
        if (!dataUrl) {
          // Image not in cache — leave the placeholder as-is so the
          // data-img-id stays and GC won't kill the node.
          return match;
        }
        var combined = before + after;
        // Remove any existing src= so we can replace cleanly.
        combined = combined.replace(/\s+src="[^"]*"/g, '');
        return '&lt;img' + combined + ' data-img-id="' + id + '" src="' + dataUrl + '"&gt;';
      });
    }

    // Scan the serialized state for every image-id reference. The
    // resulting list is what GC keeps alive on the FlexSim side.
    // Two reference forms exist:
    //   1. data-img-id="X" inside note/card body HTML (which is a JSON
    //      string value, so the quotes are escaped in the serialized
    //      blob — match \"...\").
    //   2. "imgId":"X" on canvas image shapes (which are JSON objects,
    //      so the quotes are unescaped at the structural level).
    // Missing the second form caused canvas images to be GC'd on save
    // and disappear after reload — the bug fixed here.
    function collectAliveImageIds(serialized) {
      var ids = {};
      var re1 = /data-img-id=\\"([^\\"]+)\\"/g;
      var m;
      while ((m = re1.exec(serialized))) ids[m[1]] = true;
      var re2 = /"imgId":"([^"]+)"/g;
      while ((m = re2.exec(serialized))) ids[m[1]] = true;
      return Object.keys(ids);
    }

    // Format alive IDs as ",id1,id2,id3," so FlexScript can do a simple
    // substring check during GC without parsing JSON.
    function formatAliveStr(ids) {
      return ',' + ids.join(',') + ',';
    }

    // Shared paste handler. Called from the Notes body and Card body
    // editors. If the clipboard has an image, uploads it, caches it,
    // and inserts &lt;img data-img-id=...&gt; at the cursor. Otherwise pastes
    // plain text (we deliberately strip clipboard HTML formatting).
    function handlePaste(e, editor, afterCallback) {
      var items = (e.clipboardData &amp;&amp; e.clipboardData.items) || [];
      for (var i = 0; i &lt; items.length; i++) {
        var item = items[i];
        if (item.kind === 'file' &amp;&amp; item.type &amp;&amp; item.type.indexOf('image/') === 0) {
          e.preventDefault();
          var file = item.getAsFile();
          if (!file) continue;
          var reader = new FileReader();
          reader.onload = function () {
            var dataUrl = String(reader.result);
            var id = newId('img-');
            imageCache[id] = dataUrl;
            // Upload to FlexSim. Any non-"ok" result is a real error and we bail.
            saveImageToHost(id, dataUrl, function (result) {
              if (result !== 'ok') {
                delete imageCache[id];
                console.error('[paste] saveImage failed: ' + result);
                return;
              }
              editor.focus();
              document.execCommand('insertHTML', false,
                '&lt;img data-img-id="' + id + '" src="' + dataUrl + '" alt=""&gt;');
              if (afterCallback) afterCallback();
            });
          };
          reader.readAsDataURL(file);
          return;
        }
      }
      // No image in clipboard — fall back to plain text paste.
      e.preventDefault();
      var text = (e.clipboardData &amp;&amp; e.clipboardData.getData('text/plain')) || '';
      document.execCommand('insertText', false, text);
    }

    // --- theme ---
    // mode is a string: 'light' or 'dark'. Theme persists via the
    // settings tab (state.settings.mode), not its own node.
    function applyTheme(mode) {
      // Tolerate the legacy numeric format (0/1) just in case an old
      // export gets imported.
      if (mode === 1 || mode === '1') mode = 'light';
      if (mode === 0 || mode === '0') mode = 'dark';
      themeMode = mode;
      if (mode === 'light') document.documentElement.classList.add('light');
      else document.documentElement.classList.remove('light');
      var btn = document.getElementById('theme-toggle');
      if (btn) btn.textContent = mode === 'light' ? '☾ Theme' : '☀ Theme';
      // Auto-flip the canvas default stroke until the user picks a
      // colour. White on dark, black on light — keeps the pen visible
      // against the canvas background out of the box. Once the user
      // taps any stroke swatch, canvasStrokeIsDefault flips and theme
      // toggles stop overriding their choice.
      if (typeof canvasStrokeIsDefault !== 'undefined' &amp;&amp; canvasStrokeIsDefault) {
        canvasStroke = (mode === 'light') ? '#000000' : '#ffffff';
        if (state &amp;&amp; state.settings &amp;&amp; state.settings.activeTab === 'canvases' &amp;&amp; typeof renderCanvasesTab === 'function') {
          renderCanvasesTab();
        }
      }
    }

    function toggleTheme() {
      var newMode = themeMode === 'light' ? 'dark' : 'light';
      applyTheme(newMode);
      if (state &amp;&amp; state.settings) {
        state.settings.mode = newMode;
        saveDebounced('settings');
      }
    }

    // --- formatting toolbar ---
    // Builds the toolbar HTML. Every contenteditable body in the app
    // is required to render this above it (project rule).
    function renderToolbar(editorId) {
      return '&lt;div class="format-toolbar" data-editor="' + editorId + '"&gt;' +
        '&lt;button data-cmd="bold"          title="Bold (Ctrl+B)"&gt;&lt;b&gt;B&lt;/b&gt;&lt;/button&gt;' +
        '&lt;button data-cmd="italic"        title="Italic (Ctrl+I)"&gt;&lt;i&gt;I&lt;/i&gt;&lt;/button&gt;' +
        '&lt;button data-cmd="underline"     title="Underline (Ctrl+U)"&gt;&lt;u&gt;U&lt;/u&gt;&lt;/button&gt;' +
        '&lt;button data-cmd="strikeThrough" title="Strikethrough"&gt;&lt;s&gt;S&lt;/s&gt;&lt;/button&gt;' +
        '&lt;span class="sep"&gt;&lt;/span&gt;' +
        '&lt;button data-cmd="color"     title="Text color"&gt;&lt;span class="color-indicator"&gt;A&lt;/span&gt;&lt;/button&gt;' +
        '&lt;button data-cmd="highlight" title="Highlight"&gt;&lt;span class="hi-indicator"&gt;A&lt;/span&gt;&lt;/button&gt;' +
        '&lt;span class="sep"&gt;&lt;/span&gt;' +
        '&lt;button data-cmd="insertUnorderedList" title="Bullet list"&gt;&amp;bull;&lt;/button&gt;' +
        '&lt;button data-cmd="insertOrderedList"   title="Numbered list"&gt;1.&lt;/button&gt;' +
        '&lt;span class="sep"&gt;&lt;/span&gt;' +
        '&lt;button data-cmd="justifyLeft"   title="Align left"&gt;' +
          '&lt;svg viewBox="0 0 16 16" width="13" height="13" fill="none" stroke="currentColor" stroke-width="1.6" stroke-linecap="round"&gt;&lt;path d="M2 4h12M2 8h8M2 12h12M2 16h8"/&gt;&lt;/svg&gt;' +
        '&lt;/button&gt;' +
        '&lt;button data-cmd="justifyCenter" title="Align center"&gt;' +
          '&lt;svg viewBox="0 0 16 16" width="13" height="13" fill="none" stroke="currentColor" stroke-width="1.6" stroke-linecap="round"&gt;&lt;path d="M2 4h12M4 8h8M2 12h12M4 16h8"/&gt;&lt;/svg&gt;' +
        '&lt;/button&gt;' +
        '&lt;button data-cmd="justifyRight"  title="Align right"&gt;' +
          '&lt;svg viewBox="0 0 16 16" width="13" height="13" fill="none" stroke="currentColor" stroke-width="1.6" stroke-linecap="round"&gt;&lt;path d="M2 4h12M6 8h8M2 12h12M6 16h8"/&gt;&lt;/svg&gt;' +
        '&lt;/button&gt;' +
        '&lt;span class="sep"&gt;&lt;/span&gt;' +
        '&lt;button data-cmd="h1" title="Heading 1"&gt;H1&lt;/button&gt;' +
        '&lt;button data-cmd="h2" title="Heading 2"&gt;H2&lt;/button&gt;' +
        '&lt;button data-cmd="h3" title="Heading 3"&gt;H3&lt;/button&gt;' +
        '&lt;span class="sep"&gt;&lt;/span&gt;' +
        '&lt;button data-cmd="link"  title="Insert link (Ctrl+click a link to open it)"&gt;Link&lt;/button&gt;' +
        '&lt;button data-cmd="code"  title="Inline code" style="font-family:Consolas,monospace"&gt;&amp;lt;/&amp;gt;&lt;/button&gt;' +
        '&lt;button data-cmd="image" title="Insert image"&gt;Image&lt;/button&gt;' +
      '&lt;/div&gt;';
    }

    // Wires the toolbar buttons to operate on a specific editor element.
    // mousedown preventDefault stops the button click from stealing focus
    // from the editor; the actual command runs on click, by which point
    // the selection is still intact.
    function wireToolbar(toolbarEl, editorEl) {
      toolbarEl.addEventListener('mousedown', function (e) {
        if (e.target.closest &amp;&amp; e.target.closest('button[data-cmd]')) {
          e.preventDefault();
        }
      });
      toolbarEl.addEventListener('click', function (e) {
        var btn = e.target.closest ? e.target.closest('button[data-cmd]') : null;
        if (!btn) return;
        var cmd = btn.getAttribute('data-cmd');
        if (cmd === 'color' || cmd === 'highlight') {
          openColorPopover(btn, editorEl, cmd === 'highlight');
          return;
        }
        runFormatCommand(cmd, editorEl, btn);
      });
    }

    // --- color / highlight popover ---
    var TEXT_COLORS = [
      { name: 'Default',  value: '' },
      { name: 'Red',      value: '#dc2626' },
      { name: 'Orange',   value: '#ea580c' },
      { name: 'Yellow',   value: '#ca8a04' },
      { name: 'Green',    value: '#16a34a' },
      { name: 'Teal',     value: '#0d9488' },
      { name: 'Blue',     value: '#2563eb' },
      { name: 'Purple',   value: '#9333ea' },
      { name: 'Pink',     value: '#db2777' }
    ];
    var HIGHLIGHT_COLORS = [
      { name: 'None',     value: 'transparent' },
      { name: 'Yellow',   value: '#fef3c7' },
      { name: 'Red',      value: '#fecaca' },
      { name: 'Orange',   value: '#fed7aa' },
      { name: 'Green',    value: '#bbf7d0' },
      { name: 'Blue',     value: '#bfdbfe' },
      { name: 'Purple',   value: '#e9d5ff' },
      { name: 'Pink',     value: '#fbcfe8' }
    ];

    function closeColorPopover() {
      var existing = document.querySelector('.color-popover');
      if (existing &amp;&amp; existing.parentNode) existing.parentNode.removeChild(existing);
    }

    function openColorPopover(button, editor, isHighlight) {
      closeColorPopover();
      var palette = isHighlight ? HIGHLIGHT_COLORS : TEXT_COLORS;
      var pop = document.createElement('div');
      pop.className = 'color-popover';

      palette.forEach(function (c) {
        var sw = document.createElement('button');
        sw.className = 'color-swatch';
        sw.type = 'button';
        sw.title = c.name;
        if (c.value &amp;&amp; c.value !== 'transparent') {
          sw.style.background = c.value;
        } else {
          sw.classList.add('reset');
        }
        sw.addEventListener('mousedown', function (ev) { ev.preventDefault(); });
        sw.addEventListener('click', function (ev) {
          ev.stopPropagation();
          closeColorPopover();
          applyColor(c.value, isHighlight, editor);
        });
        pop.appendChild(sw);
      });

      var rect = button.getBoundingClientRect();
      pop.style.position = 'fixed';
      pop.style.top = (rect.bottom + 4) + 'px';
      pop.style.left = rect.left + 'px';
      document.body.appendChild(pop);

      // Close on next click anywhere outside the popover
      setTimeout(function () {
        document.addEventListener('mousedown', function outsideHandler(e) {
          if (!pop.contains(e.target)) {
            closeColorPopover();
            document.removeEventListener('mousedown', outsideHandler);
          }
        });
      }, 0);
    }

    function applyColor(color, isHighlight, editor) {
      if (document.activeElement !== editor) editor.focus();
      // styleWithCSS=true makes foreColor / hiliteColor emit &lt;span style&gt;
      // instead of deprecated &lt;font&gt; tags, which CEF treats reliably.
      try { document.execCommand('styleWithCSS', false, true); } catch (e) {}
      if (isHighlight) {
        // hiliteColor uses CSS background-color when styleWithCSS=true.
        document.execCommand('hiliteColor', false, color || 'transparent');
      } else {
        // For "Default" pick the computed body text color so the editor
        // gets a real value to apply (foreColor on an empty string is a no-op).
        var c = color || window.getComputedStyle(editor).color || 'inherit';
        document.execCommand('foreColor', false, c);
      }
      editor.dispatchEvent(new Event('input', { bubbles: true }));
    }

    function runFormatCommand(cmd, editor, anchorBtn) {
      if (cmd === 'h1' || cmd === 'h2' || cmd === 'h3') {
        applyHeading(cmd);
      } else if (cmd === 'link') {
        // Preserve the selection before opening the inline prompt
        // (focus moves to the prompt input).
        var sel = window.getSelection();
        var savedRange = sel.rangeCount ? sel.getRangeAt(0).cloneRange() : null;
        // Anchor the popup near the toolbar button (so it appears right
        // next to the Link icon, not floating somewhere far below the
        // editor).
        var anchorRect = anchorBtn
          ? anchorBtn.getBoundingClientRect()
          : editor.getBoundingClientRect();
        inlinePrompt('Enter URL', 'https://', anchorRect).then(function (url) {
          if (!url) return;
          editor.focus();
          if (savedRange) {
            sel.removeAllRanges();
            sel.addRange(savedRange);
          }
          document.execCommand('createLink', false, url);
          editor.dispatchEvent(new Event('input', { bubbles: true }));
        });
        return; // async branch — bail out of the synchronous tail
      } else if (cmd === 'code') {
        toggleInlineCode();
      } else if (cmd === 'image') {
        pickImageAndInsert(editor);
      } else {
        document.execCommand(cmd);
      }
      // Force the contenteditable to fire input so state syncs and save fires.
      editor.dispatchEvent(new Event('input', { bubbles: true }));
    }

    // Apply a heading. If the cursor is inside a &lt;ul&gt;/&lt;ol&gt;, first toggle the
    // list off so we don't end up with &lt;li&gt;&lt;h1&gt;…&lt;/h1&gt;&lt;/li&gt; (which makes
    // repeated heading clicks stack inside each other — the "font keeps
    // getting bigger" bug).
    function applyHeading(tag) {
      var sel = window.getSelection();
      // If the caret is already inside the SAME heading we're toggling
      // to, flip the block back to a paragraph instead of re-applying.
      // Mirrors execCommand's natural toggle behavior on Bold / Italic.
      var upperTag = tag.toUpperCase();
      if (sel &amp;&amp; sel.rangeCount &gt; 0) {
        var probe = sel.anchorNode;
        if (probe &amp;&amp; probe.nodeType === 3) probe = probe.parentNode;
        while (probe &amp;&amp; probe.nodeType === 1 &amp;&amp; probe !== document.body) {
          if (probe.getAttribute &amp;&amp; probe.getAttribute('contenteditable') === 'true') break;
          if (probe.nodeName === upperTag) {
            document.execCommand('formatBlock', false, '&lt;p&gt;');
            return;
          }
          probe = probe.parentNode;
        }
        var node = sel.anchorNode;
        if (node &amp;&amp; node.nodeType === 3) node = node.parentNode;
        while (node &amp;&amp; node.nodeType === 1 &amp;&amp; node !== document.body) {
          if (node.nodeName === 'UL') { document.execCommand('insertUnorderedList'); break; }
          if (node.nodeName === 'OL') { document.execCommand('insertOrderedList'); break; }
          node = node.parentNode;
        }
      }
      document.execCommand('formatBlock', false, '&lt;' + tag + '&gt;');
    }

    // Toggle inline &lt;code&gt; on the current selection. Wraps in &lt;code&gt; if
    // not already inside one; unwraps if the selection (or its caret)
    // is already inside a &lt;code&gt; ancestor. Mirrors how Bold / Italic /
    // etc. work via execCommand — clicking the button again removes
    // the formatting.
    function findCodeAncestor(node) {
      if (node &amp;&amp; node.nodeType === 3) node = node.parentNode;
      while (node &amp;&amp; node.nodeType === 1) {
        if (node.tagName === 'CODE') return node;
        if (node.getAttribute &amp;&amp; node.getAttribute('contenteditable') === 'true') return null;
        node = node.parentNode;
      }
      return null;
    }
    function toggleInlineCode() {
      try {
        var sel = window.getSelection();
        if (!sel || sel.rangeCount === 0) return;
        var range = sel.getRangeAt(0);
        var codeEl = findCodeAncestor(range.commonAncestorContainer)
                  || findCodeAncestor(range.startContainer)
                  || findCodeAncestor(range.endContainer);
        if (codeEl) {
          // Already inside &lt;code&gt;: unwrap it and restore the selection
          // to span the freed text so the user can keep formatting.
          var parent = codeEl.parentNode;
          if (!parent) return;
          var firstMoved = codeEl.firstChild;
          var lastMoved = codeEl.lastChild;
          while (codeEl.firstChild) parent.insertBefore(codeEl.firstChild, codeEl);
          parent.removeChild(codeEl);
          if (firstMoved &amp;&amp; lastMoved) {
            var newRange = document.createRange();
            newRange.setStartBefore(firstMoved);
            newRange.setEndAfter(lastMoved);
            sel.removeAllRanges();
            sel.addRange(newRange);
          }
          return;
        }
        var text = sel.toString();
        if (!text) return;
        document.execCommand('insertHTML', false, '&lt;code&gt;' + escapeHtml(text) + '&lt;/code&gt;');
      } catch (e) {
        console.warn('[code] toggle failed:', e);
      }
    }

    function pickImageAndInsert(editor) {
      var input = document.createElement('input');
      input.type = 'file';
      input.accept = 'image/*';
      input.addEventListener('change', function (e) {
        var file = e.target.files &amp;&amp; e.target.files[0];
        if (!file) return;
        var reader = new FileReader();
        reader.onload = function () {
          var dataUrl = String(reader.result);
          var id = newId('img-');
          imageCache[id] = dataUrl;
          saveImageToHost(id, dataUrl, function (result) {
            if (result !== 'ok') {
              delete imageCache[id];
              console.error('[image picker] saveImage failed: ' + result);
              return;
            }
            editor.focus();
            document.execCommand('insertHTML', false,
              '&lt;img data-img-id="' + id + '" src="' + dataUrl + '" alt=""&gt;');
            editor.dispatchEvent(new Event('input', { bubbles: true }));
          });
        };
        reader.readAsDataURL(file);
      });
      input.click();
    }

    // --- image selection inside contenteditables ---
    // Click an image to select it (visual ring + DOM Range); Delete or
    // Backspace removes it. Listening at the document level catches all
    // contenteditable bodies, present and future.
    function clearImageSelection() {
      document.querySelectorAll('.img-selected').forEach(function (el) {
        el.classList.remove('img-selected');
      });
    }

    document.addEventListener('click', function (e) {
      var img = e.target;
      if (!img || img.tagName !== 'IMG') { clearImageSelection(); return; }
      var editor = img.closest('[contenteditable="true"]');
      if (!editor) return;
      clearImageSelection();
      img.classList.add('img-selected');
      // Also set the DOM selection to the image so Backspace/Delete works.
      var range = document.createRange();
      range.selectNode(img);
      var sel = window.getSelection();
      sel.removeAllRanges();
      sel.addRange(range);
    });

    document.addEventListener('keydown', function (e) {
      if (e.key !== 'Backspace' &amp;&amp; e.key !== 'Delete') return;
      var img = document.querySelector('.img-selected');
      if (!img) return;
      var editor = img.closest('[contenteditable="true"]');
      if (!editor) return;
      e.preventDefault();
      img.parentNode.removeChild(img);
      // Sync state via the editor's input event
      editor.dispatchEvent(new Event('input', { bubbles: true }));
    });

    // Ctrl/Cmd+click on a link inside any contenteditable navigates to
    // it instead of placing the cursor. Browser default in
    // contenteditable is cursor placement, which makes links unusable
    // while editing — this restores the familiar Ctrl+click behavior
    // from IDEs / Notion / Docs.
    document.addEventListener('click', function (e) {
      if (!(e.ctrlKey || e.metaKey)) return;
      var a = e.target.closest &amp;&amp; e.target.closest('a[href]');
      if (!a) return;
      var ed = a.closest('[contenteditable="true"]');
      if (!ed) return;
      e.preventDefault();
      try { window.open(a.href, '_blank'); } catch (err) {}
    });

    // Hover tooltip for links inside any contenteditable. Surfaces the
    // full URL + the hotkey hint ("Ctrl+Click to open"). Without this
    // the user has no easy way to see where a link points while they're
    // editing — the native browser status bar is hidden inside CEF.
    (function setupLinkHoverTooltip() {
      var tip = null;
      function makeTip() {
        if (tip) return tip;
        tip = document.createElement('div');
        tip.className = 'link-hover-tip';
        document.body.appendChild(tip);
        return tip;
      }
      function hideTip() { if (tip) tip.style.display = 'none'; }
      document.addEventListener('mouseover', function (e) {
        var a = e.target.closest ? e.target.closest('a[href]') : null;
        if (!a) return;
        var ed = a.closest('[contenteditable="true"]');
        if (!ed) return;
        var t = makeTip();
        var hotkey = (navigator.platform.indexOf('Mac') &gt;= 0) ? '⌘+Click' : 'Ctrl+Click';
        t.innerHTML =
          '&lt;div class="link-hover-tip-hint"&gt;' + hotkey + ' to open&lt;/div&gt;' +
          '&lt;div class="link-hover-tip-url"&gt;' + escapeHtml(a.href) + '&lt;/div&gt;';
        var rect = a.getBoundingClientRect();
        // Show below the link by default; flip above if near the bottom
        // of the viewport.
        t.style.display = 'block';
        var tipH = t.offsetHeight || 50;
        var top = rect.bottom + 6;
        if (top + tipH &gt; window.innerHeight - 8) top = rect.top - tipH - 6;
        t.style.top = top + 'px';
        t.style.left = Math.min(rect.left, window.innerWidth - (t.offsetWidth || 300) - 8) + 'px';
      });
      document.addEventListener('mouseout', function (e) {
        var a = e.target.closest ? e.target.closest('a[href]') : null;
        if (!a) return;
        if (e.relatedTarget &amp;&amp; a.contains(e.relatedTarget)) return;
        hideTip();
      });
      // Also hide on scroll inside any editor pane so the tip doesn't
      // stick to a stale position.
      document.addEventListener('scroll', hideTip, true);
    })();

    // Fast custom tooltips for every element with a `title` attribute.
    // The native browser tooltip waits ~500-1000 ms before appearing
    // (and the delay is OS-controlled, not CSS-controllable). This
    // intercepts title-bearing elements, strips the native title on
    // hover (so the slow popup doesn't ALSO fire), and shows a styled
    // tooltip after a short delay. Title is restored on mouseout so
    // screen readers and other AT still see it.
    (function setupFastTooltips() {
      var SHOW_DELAY_MS = 100;
      var tip = null;
      var showTimer = null;
      var currentEl = null;
      function makeTip() {
        if (tip) return tip;
        tip = document.createElement('div');
        tip.className = 'fast-tip';
        document.body.appendChild(tip);
        return tip;
      }
      function positionTip(el) {
        var rect = el.getBoundingClientRect();
        tip.style.display = 'block';
        var tipW = tip.offsetWidth, tipH = tip.offsetHeight;
        var top = rect.bottom + 6;
        if (top + tipH &gt; window.innerHeight - 8) top = rect.top - tipH - 6;
        var left = rect.left + (rect.width / 2) - (tipW / 2);
        left = Math.max(4, Math.min(left, window.innerWidth - tipW - 4));
        tip.style.top = top + 'px';
        tip.style.left = left + 'px';
      }
      function hideTip() {
        if (showTimer) { clearTimeout(showTimer); showTimer = null; }
        if (tip) tip.style.display = 'none';
        if (currentEl) {
          var stash = currentEl.getAttribute('data-tip-stash');
          if (stash !== null) {
            currentEl.setAttribute('title', stash);
            currentEl.removeAttribute('data-tip-stash');
          }
          currentEl = null;
        }
      }
      document.addEventListener('mouseover', function (e) {
        if (!e.target.closest) return;
        var el = e.target.closest('[title]');
        if (!el) return;
        // Defer to the link-hover-tip for links inside contenteditable;
        // it already shows the URL + Ctrl+Click hint and uses a higher
        // z-index.
        if (el.tagName === 'A' &amp;&amp; el.getAttribute('href') &amp;&amp; el.closest('[contenteditable="true"]')) return;
        var text = el.getAttribute('title');
        if (!text) return;
        if (currentEl !== el) {
          hideTip();
          currentEl = el;
          // Stash + strip the title so the slow native tooltip never
          // fires while ours is on screen. Restored in hideTip.
          el.setAttribute('data-tip-stash', text);
          el.removeAttribute('title');
        }
        if (showTimer) clearTimeout(showTimer);
        showTimer = setTimeout(function () {
          makeTip().textContent = text;
          positionTip(el);
        }, SHOW_DELAY_MS);
      });
      document.addEventListener('mouseout', function (e) {
        if (!e.target.closest) return;
        var el = e.target.closest('[title], [data-tip-stash]');
        if (!el) return;
        if (e.relatedTarget &amp;&amp; el.contains(e.relatedTarget)) return;
        hideTip();
      });
      document.addEventListener('mousedown', hideTip);
      document.addEventListener('scroll', hideTip, true);
      document.addEventListener('keydown', function (e) {
        if (e.key === 'Escape') hideTip();
      });
    })();

    // --- export to HTML ---
    // Builds a self-contained HTML mirror of the actual Notebook view:
    //   * Notes laid out vertically with full bodies.
    //   * Board rendered as a real 2D grid (columns × priority rows), so
    //     the exported document looks like the live board.
    //   * Images inlined as data: URLs via rehydrateBody — fully portable.
    // Calls window.showSaveFilePicker() when available so the user gets a
    // native Save As dialog; falls back to a download otherwise.
    function exportToHtml() {
      var html = buildExportHtml();
      var stamp = new Date().toISOString().replace(/[:.]/g, '-').slice(0, 19);
      var defaultName = 'notebook-' + stamp + '.html';

      if (window.showSaveFilePicker) {
        window.showSaveFilePicker({
          suggestedName: defaultName,
          types: [{ description: 'HTML document', accept: { 'text/html': ['.html', '.htm'] } }]
        }).then(function (handle) {
          return handle.createWritable().then(function (writable) {
            return writable.write(html).then(function () { return writable.close(); });
          });
        }).catch(function (err) {
          if (err &amp;&amp; err.name === 'AbortError') return;
          console.warn('[export] save picker failed, falling back to download', err);
          downloadFile(defaultName, html, 'text/html;charset=utf-8');
        });
      } else {
        downloadFile(defaultName, html, 'text/html;charset=utf-8');
      }
    }

    // Export the whole data set — every per-tab node plus all stored images —
    // as a single self-contained JSON file. Restorable via importFromJson.
    function exportToJson() {
      // Flush any pending edits so the export reflects what's actually saved.
      if (saveStatus === 'pending') saveImmediate();

      var payload = {
        format: 'pracsim-notebook',
        formatVersion: 1,
        exportedAt: new Date().toISOString(),
        tabs: {
          scoping:    snapshotTab('scoping'),
          notes:      snapshotTab('notes'),
          board:      snapshotTab('board'),
          canvases:   snapshotTab('canvases'),
          validation: snapshotTab('validation'),
          settings:   snapshotTab('settings')
        },
        images: imageCache || {}
      };
      var json = JSON.stringify(payload, null, 2);
      var stamp = new Date().toISOString().replace(/[:.]/g, '-').slice(0, 19);
      var defaultName = 'notebook-data-' + stamp + '.json';

      if (window.showSaveFilePicker) {
        window.showSaveFilePicker({
          suggestedName: defaultName,
          types: [{ description: 'PracSim Notebook data', accept: { 'application/json': ['.json'] } }]
        }).then(function (handle) {
          return handle.createWritable().then(function (w) {
            return w.write(json).then(function () { return w.close(); });
          });
        }).catch(function (err) {
          if (err &amp;&amp; err.name === 'AbortError') return;
          downloadFile(defaultName, json, 'application/json;charset=utf-8');
        });
      } else {
        downloadFile(defaultName, json, 'application/json;charset=utf-8');
      }
    }

    // Import a previously-exported JSON file. Replaces every tab + image
    // cache in one go and persists immediately. Destructive — confirms first.
    function importFromJson() {
      var input = document.createElement('input');
      input.type = 'file';
      input.accept = 'application/json,.json';
      input.style.display = 'none';
      input.addEventListener('change', function () {
        var file = input.files &amp;&amp; input.files[0];
        if (!file) { input.remove(); return; }
        var reader = new FileReader();
        reader.onload = function () {
          try {
            var payload = JSON.parse(reader.result);
            if (!payload || payload.format !== 'pracsim-notebook' || !payload.tabs) {
              alert('That doesn\'t look like a PracSim Notebook export.');
              return;
            }
            var confirmMsg = "Replace all current Notebook data with the imported JSON? This can't be undone.";
            if (!confirm(confirmMsg)) return;

            // Drop the new state in and persist every tab.
            state = {
              scoping:    payload.tabs.scoping    || defaultScoping(),
              notes:      payload.tabs.notes      || defaultNotes(),
              board:      payload.tabs.board      || defaultBoard(),
              canvases:   payload.tabs.canvases   || defaultCanvasesState(),
              validation: payload.tabs.validation || defaultValidation(),
              settings:   payload.tabs.settings   || defaultSettings()
            };
            // Imported HTML may have been authored by someone other than the
            // current user — sweep all rich-text bodies for script-injection
            // vectors BEFORE anything gets rendered via innerHTML.
            sanitizeAllStateHtml(state);
            getSettings();
            ensureNewTabsState();
            applyTheme(state.settings.mode || 'dark');
            applyFontSizeSetting();

            // Restore image cache + write each image back to its tree node.
            imageCache = payload.images || {};
            Object.keys(imageCache).forEach(function (id) {
              saveImageToHost(id, imageCache[id], function () {});
            });

            // Mark every tab dirty + flush so the host stores the new state.
            TAB_NAMES.forEach(markDirty);
            saveImmediate();

            // Reactivate the saved tab. NOTE: activateTab will call
            // saveImmediate('settings') again, after the batch above has
            // already fired. Benign — settings is small, last-write-wins,
            // and the data is the same — but a future refactor that makes
            // saveTabToHost truly async would need to serialize these calls.
            activateTab(state.settings.activeTab || 'scoping');
          } catch (e) {
            console.error('[import] failed', e);
            alert('Import failed: ' + (e.message || e));
          } finally {
            input.remove();
          }
        };
        reader.readAsText(file);
      });
      document.body.appendChild(input);
      input.click();
    }

    // Build a standalone read-only HTML export that mirrors the live UI:
    // the same tab strip, sidebars, and per-tab layouts — but stripped of
    // every editor, add-button, delete-button, drag handle, undo/redo bar,
    // and inline JS handler. Implementation: render each tab into the
    // live DOM in sequence, clone the resulting pane, run it through
    // stripInteractivity(), then bake into a static document with the
    // live stylesheet plus a tiny tab-switch script.
    function buildExportHtml() {
      var tabs = ['scoping', 'notes', 'board', 'canvases', 'validation'];
      var labels = { scoping: 'Scoping', notes: 'Notes', board: 'Board', canvases: 'Canvases', validation: 'Validation' };

      // Capture each tab. For sidebar-driven tabs (scoping/notes/
      // validation/canvases) we render once per item and capture only
      // the main pane so the export can switch via sidebar clicks. For
      // Board we capture the layout once and embed a per-card detail
      // template that the export's click handler clones into the
      // properties panel. Hide the body during the render-cycle so the
      // user doesn't see the visual flicker as we activate each tab.
      var savedTab = state &amp;&amp; state.settings &amp;&amp; state.settings.activeTab;
      var savedScopeId = state.scoping &amp;&amp; state.scoping.activeDocId;
      var savedNoteId  = state.notes &amp;&amp; state.notes.activeNoteId;
      var savedRunId   = state.validation &amp;&amp; state.validation.activeRunId;
      var savedCanvasId = state.canvases &amp;&amp; state.canvases.activeId;
      var savedSelectedCardId = selectedCardId;
      var tabContents = {};
      document.body.style.visibility = 'hidden';
      try {
        tabContents.scoping = captureNavigableTab(
          'scoping',
          (state.scoping &amp;&amp; state.scoping.docs) || [],
          function (id) { state.scoping.activeDocId = id; },
          '#scope-doc-pane'
        );
        tabContents.notes = captureNavigableTab(
          'notes',
          (state.notes &amp;&amp; state.notes.items) || [],
          function (id) { state.notes.activeNoteId = id; },
          '.notes-editor'
        );
        tabContents.validation = captureNavigableTab(
          'validation',
          (state.validation &amp;&amp; state.validation.runs) || [],
          function (id) { state.validation.activeRunId = id; },
          '.val-pane'
        );
        tabContents.canvases = captureNavigableTab(
          'canvases',
          (state.canvases &amp;&amp; state.canvases.items) || [],
          function (id) { state.canvases.activeId = id; },
          '.cnv-main'
        );
        tabContents.board = captureBoardTab();
      } finally {
        // Always restore the user's tab + active selections, even on error.
        if (savedScopeId !== undefined) state.scoping.activeDocId = savedScopeId;
        if (savedNoteId !== undefined)  state.notes.activeNoteId = savedNoteId;
        if (savedRunId !== undefined)   state.validation.activeRunId = savedRunId;
        if (savedCanvasId !== undefined) state.canvases.activeId = savedCanvasId;
        selectedCardId = savedSelectedCardId;
        if (savedTab &amp;&amp; tabs.indexOf(savedTab) !== -1) activateTab(savedTab);
        document.body.style.visibility = '';
      }

      // Extract the live stylesheet so the export inherits the same look.
      // The Notebook ships its CSS in a single inline &lt;style&gt; at the top
      // of &lt;head&gt;; we grab every &lt;style&gt; just in case future edits add
      // more.
      var liveCSS = '';
      document.head.querySelectorAll('style').forEach(function (s) {
        liveCSS += s.textContent + '\n';
      });

      var lines = [];
      lines.push('&lt;!DOCTYPE html&gt;');
      lines.push('&lt;html' + (document.documentElement.classList.contains('light') ? ' class="light"' : '') + '&gt;&lt;head&gt;&lt;meta charset="utf-8"&gt;');
      lines.push('&lt;title&gt;PracSim Notebook — Exported ' + new Date().toLocaleString() + '&lt;/title&gt;');
      lines.push('&lt;style&gt;' + liveCSS + '&lt;/style&gt;');
      lines.push('&lt;style&gt;' + exportOverrideStyles() + '&lt;/style&gt;');
      lines.push('&lt;/head&gt;&lt;body&gt;');

      // Top nav: tab buttons only — no Export/Import/Settings/About/Logs.
      lines.push('&lt;nav class="main-tabs" id="main-tabs"&gt;');
      tabs.forEach(function (t, i) {
        lines.push('&lt;button class="' + (i === 0 ? 'active' : '') + '" data-tab="' + t + '"&gt;' + labels[t] + '&lt;/button&gt;');
      });
      lines.push('&lt;/nav&gt;');

      // Each tab's static, stripped content.
      tabs.forEach(function (t, i) {
        var cls = 'tab-pane' + (i === 0 ? ' active' : '');
        lines.push('&lt;section id="tab-' + t + '" class="' + cls + '"&gt;' + (tabContents[t] || '') + '&lt;/section&gt;');
      });

      // Tiny tab-switch script — the only behavior in the exported file.
      lines.push('&lt;script&gt;' + exportInteractivityJS() + '&lt;\/script&gt;');
      lines.push('&lt;/body&gt;&lt;/html&gt;');
      return lines.join('\n');
    }

    // For a sidebar-driven tab (scoping / notes / validation / canvases):
    // render once per item, capture each main-pane variant, then assemble
    // a base layout where the main pane is replaced with a container of
    // all variants (only the active one is visible). The export's sidebar
    // click handler swaps which variant is shown.
    //
    //   tabName      — 'scoping' | 'notes' | 'validation' | 'canvases'
    //   items        — array of {id, ...} from state.&lt;tab&gt;.&lt;list&gt;
    //   setActiveId  — function(id) that updates the corresponding active-id
    //                  field on state (e.g. state.scoping.activeDocId = id)
    //   mainSelector — CSS selector for the variant container within the
    //                  rendered tab pane (e.g. '#scope-doc-pane', '.cnv-main')
    function captureNavigableTab(tabName, items, setActiveId, mainSelector) {
      // Empty case: render once, no variants.
      if (!items.length) {
        activateTab(tabName);
        var emptyPane = document.getElementById('tab-' + tabName);
        return emptyPane ? stripInteractivity(emptyPane).innerHTML : '';
      }

      // Render the base layout with the first item active.
      setActiveId(items[0].id);
      activateTab(tabName);
      var basePane = document.getElementById('tab-' + tabName);
      var baseClone = stripInteractivity(basePane);

      // Capture each item's main-pane HTML. The first one we already have
      // in baseClone, but re-grabbing keeps the loop uniform.
      var variants = items.map(function (item) {
        setActiveId(item.id);
        activateTab(tabName);
        var pane = document.getElementById('tab-' + tabName);
        var mainEl = pane.querySelector(mainSelector);
        if (!mainEl) return { id: item.id, html: '' };
        return { id: item.id, html: stripInteractivity(mainEl).innerHTML };
      });

      // Replace the main pane in the base layout with a container of all
      // variants, each in a wrapper with data-variant-id matching the
      // sidebar item's data-id (scope-item / note-item / val-list-item)
      // or data-canvas-id (cnv-list-item).
      var baseMain = baseClone.querySelector(mainSelector);
      if (baseMain) {
        baseMain.innerHTML = variants.map(function (v, i) {
          var style = (i === 0) ? '' : ' style="display:none;"';
          return '&lt;div class="export-variant" data-variant-id="' + escapeHtml(v.id) + '"' + style + '&gt;' + v.html + '&lt;/div&gt;';
        }).join('');
        baseMain.classList.add('export-variant-host');
      }
      return baseClone.innerHTML;
    }

    // Board capture: render once with no card selected to get the empty
    // panel state, then for each card render with that card selected and
    // capture the panel's HTML as a &lt;template data-card-detail&gt; embedded
    // in the card. The export's card-click handler clones the template
    // into the properties panel.
    function captureBoardTab() {
      selectedCardId = null;
      activateTab('board');
      var basePane = document.getElementById('tab-board');
      var baseClone = stripInteractivity(basePane);

      // Make sure the panel container exists in the base — the live UI
      // shows the panel even when empty; we need it for the click handler.
      // renderBoardTab() already includes &lt;div id="properties-panel"&gt;.

      // For each card, capture the panel content as a template inside
      // the card element so the click handler can find it by data-card-id.
      var cards = (state.board &amp;&amp; state.board.cards) || [];
      cards.forEach(function (card) {
        selectedCardId = card.id;
        renderBoardTab();
        var panel = document.getElementById('properties-panel');
        if (!panel) return;
        var panelClone = stripInteractivity(panel);
        // Locate the corresponding card in the base layout clone.
        var cardEl = baseClone.querySelector('.card[data-card-id="' + card.id + '"]');
        if (!cardEl) return;
        var tpl = document.createElement('template');
        tpl.setAttribute('data-card-detail', card.id);
        tpl.innerHTML = panelClone.innerHTML;
        cardEl.appendChild(tpl);
        cardEl.classList.add('export-clickable-card');
      });
      selectedCardId = null;
      return baseClone.innerHTML;
    }

    // Walk a cloned tab pane and prune everything interactive: editor
    // toolbars, add/delete buttons, drag handles, contenteditable attrs,
    // inline event handlers. Inputs/textareas/selects become read-only
    // text spans so the visual layout is preserved without affordance.
    // Mutates the input clone; returns it for chaining.
    function stripInteractivity(originalPane) {
      var clone = originalPane.cloneNode(true);

      // Remove things wholesale (whole element + children). The rule of
      // thumb: anything that mutates state, captures live data, or only
      // exists to invite an edit doesn't belong in a static export.
      var removeSelectors = [
        // Editing chrome
        '.tab-undo-bar',
        '.format-toolbar',
        '.cnv-toolbar',
        // Add buttons (every flavor — by class)
        '.add-btn',
        '.add-card-btn',
        '.add-note-btn',
        '.cnv-add-btn',
        '.action-btn',
        // Add buttons by ID (board + validation use bare IDs without an
        // "add" class, so the class-based selectors miss them)
        '#scope-add-doc-btn',
        '#add-note-btn',
        '#add-card-btn',
        '#add-column-btn',
        '#cnv-add-canvas',
        '#val-add-btn',
        '#val-snapshot-btn',
        // Delete / overflow / kebab affordances
        '.del-btn',
        '.del',
        '.delete-x',
        '.menu-btn',
        // Resize / drag handles
        '.board-divider',
        // Empty-state CTAs that point at buttons we just stripped
        '.scope-doc-empty button',
        '.scope-doc-empty .big',
        '.scope-doc-empty p',
        '.val-pane.empty .big',
        '.val-pane.empty p',
        // Notes empty-state copy is "Click + Add note to create one" — the
        // CTA references a button we just stripped, so kill the whole message.
        '.empty-state',
        // Validation per-table empty message is "Empty — click 📷 above to
        // snapshot from the current model…" — points at the Snapshot button
        // we just stripped. Drop it; the table just renders as nothing.
        '.val-table-empty',
        // Per-run "✕ Delete run" button — mutating action in a read-only export.
        '.val-run-del',
        // Canvas instructional hint ("Click a shape to select it — Shift+click
        // for multi-select — right-click for more actions") that lives above
        // the stage. Read-only export has no selection / context menu.
        '.cnv-hint',
        // Validation search input — filtering across pre-captured variants
        // would require live state, so just drop the search affordance.
        '.val-search',
        // Empty action-bar containers left behind by the above
        '.val-sidebar .sidebar-head .actions',
        '.board-main &gt; .board-controls',
        // Canvas live-edit helpers (selection rectangle, drag handles,
        // dimension hint label) shouldn't show in a static export.
        '.cnv-selection-rect',
        '.cnv-handle',
        '.cnv-dim-label'
      ];
      removeSelectors.forEach(function (sel) {
        clone.querySelectorAll(sel).forEach(function (el) { el.remove(); });
      });

      // Strip interactive attributes.
      clone.querySelectorAll('[contenteditable]').forEach(function (el) { el.removeAttribute('contenteditable'); });
      clone.querySelectorAll('[draggable]').forEach(function (el) { el.removeAttribute('draggable'); });
      // Strip the rich-text "Click and type, or paste from your Statement
      // of Work…" placeholder text that the live CSS pipes in via
      // :empty:before { content: attr(data-placeholder) }. Empty editors
      // in the export show nothing — no instructional filler.
      clone.querySelectorAll('[data-placeholder]').forEach(function (el) { el.removeAttribute('data-placeholder'); });
      ['onclick','onchange','oninput','onkeydown','onkeyup','onmousedown','onmouseup','onmouseover','onmouseout','onblur','onfocus','onpaste','ondragstart','ondragover','ondrop'].forEach(function (attr) {
        clone.querySelectorAll('[' + attr + ']').forEach(function (el) { el.removeAttribute(attr); });
      });

      // Convert form controls to read-only text. Using Array.from so
      // replacement during iteration is safe. Empty fields show "—"
      // (a neutral "no value" indicator) instead of the placeholder text,
      // since placeholders often read as instructions ("Add a name…",
      // "Click to choose…") that no longer apply in a static export.
      Array.from(clone.querySelectorAll('input[type="text"], input:not([type]), input[type="date"], input[type="number"]')).forEach(function (inp) {
        var span = document.createElement('span');
        span.className = 'export-readonly-input';
        if (inp.value) {
          span.textContent = inp.value;
        } else {
          span.classList.add('export-empty');
          span.textContent = '—';
        }
        inp.parentNode.replaceChild(span, inp);
      });
      Array.from(clone.querySelectorAll('textarea')).forEach(function (ta) {
        var div = document.createElement('div');
        div.className = 'export-readonly-textarea';
        if (ta.value) {
          div.textContent = ta.value;
        } else {
          div.classList.add('export-empty');
          div.textContent = '—';
        }
        ta.parentNode.replaceChild(div, ta);
      });
      Array.from(clone.querySelectorAll('select')).forEach(function (sel) {
        var span = document.createElement('span');
        span.className = 'export-readonly-select';
        var opt = sel.options[sel.selectedIndex];
        var txt = opt ? (opt.text || '').trim() : '';
        if (txt) {
          span.textContent = txt;
        } else {
          span.classList.add('export-empty');
          span.textContent = '—';
        }
        // Preserve status-coded color classes (dr-status-*, co-status-*,
        // severity low/med/high) so badges still look right.
        ['status-draft','status-active','status-archived','status-superseded','dr-status-pending','dr-status-received','dr-status-partial','dr-status-waived','co-status-pending','co-status-approved','co-status-rejected','co-status-cancelled','low','med','high'].forEach(function (cls) {
          if (sel.classList.contains(cls)) span.classList.add(cls);
        });
        sel.parentNode.replaceChild(span, sel);
      });
      // Belt-and-suspenders: if any element survived my input/textarea
      // replacement above (radio buttons, checkboxes, hidden inputs, etc.)
      // and still carries a placeholder attribute, strip it — the export
      // should never display placeholder text.
      clone.querySelectorAll('[placeholder]').forEach(function (el) { el.removeAttribute('placeholder'); });
      clone.querySelectorAll('input[type="checkbox"], input[type="radio"]').forEach(function (el) {
        el.disabled = true;
      });

      // Hydrate image references. Note bodies were rehydrated at render
      // time (rehydrateBody writes the src attr in place), so &lt;img&gt; nodes
      // in the clone already have data: URLs. But belt-and-suspenders:
      // hit anything that has data-img-id but no src yet.
      clone.querySelectorAll('img[data-img-id]').forEach(function (img) {
        if (img.getAttribute('src')) return;
        var id = img.getAttribute('data-img-id');
        var url = imageCache[id];
        if (url) img.setAttribute('src', url);
      });
      // Canvas SVG &lt;image&gt; nodes already have href set from imageCache
      // at render time — nothing more to do.

      return clone;
    }

    function exportOverrideStyles() {
      return [
        '/* Export overrides — the live CSS is inherited; these rules lock the UI down. */',
        // Hide things that don't belong in a standalone read-only doc
        '.save-status { display: none !important; }',
        'nav.main-tabs .top-action { display: none !important; }',
        // Belt-and-suspenders: kill every form-control interaction
        'input, textarea, select { pointer-events: none !important; }',
        // Buttons get a not-allowed feel except the tab strip + collapsible toggles
        'button:not([data-tab]):not(.scope-sim-group-header *) { pointer-events: none !important; }',
        // Sidebar items, canvas list items, and board cards stay clickable
        '.scope-item, .note-item, .val-list-item, .cnv-list-item, .export-clickable-card { cursor: pointer !important; pointer-events: auto !important; }',
        // Read-only displays mirror inputs/textareas visually so the layout
        // grid doesn\'t collapse on empty fields.
        '.export-readonly-input { display: inline-block; min-width: 60px; min-height: 1em; padding: 2px 4px; color: var(--text); border-bottom: 1px dotted var(--border-soft); word-break: break-word; }',
        '.export-readonly-textarea { display: block; min-height: 1em; padding: 2px 4px; white-space: pre-wrap; word-break: break-word; color: var(--text); }',
        '.export-readonly-select { display: inline-block; padding: 2px 6px; color: var(--text); font-style: italic; }',
        '.export-readonly-input.export-empty, .export-readonly-textarea.export-empty { color: var(--text-dim); font-style: italic; }',
        // Body in export should fill the viewport like the live UI
        'html, body { margin: 0; height: 100vh; overflow: hidden; }',
        'body { display: flex; flex-direction: column; }',
        // Variant container — the active variant fills the host fully
        '.export-variant-host { display: flex; flex-direction: column; flex: 1; min-height: 0; }',
        '.export-variant-host &gt; .export-variant { flex: 1; min-height: 0; overflow: auto; }',
        // For the canvases tab the variant IS the .cnv-main equivalent, with
        // the SVG inside. Force no overflow so pan/zoom feels right.
        '#tab-canvases .export-variant-host &gt; .export-variant { overflow: hidden; display: flex; flex-direction: column; }',
        // Canvas SVG inside a variant must fill the container so pan/zoom maps
        '#tab-canvases .export-variant svg { flex: 1; min-height: 0; width: 100%; height: 100%; }',
        // Stage wrapper inside variant
        '#tab-canvases .export-variant .cnv-stage-wrap { flex: 1; min-height: 0; display: flex; }',
        // Stop the canvas SVG from showing crosshair cursors etc.
        '.cnv-stage svg { cursor: default !important; }',
        // Canvas pan affordance: when Space is held, SVGs show grab cursor
        // (set by JS) — base style says default.
        '#tab-canvases svg { cursor: default; }',
        // Suppress the live UI\'s hardcoded ":empty::before" placeholders
        // ("Start typing… (paste images with Ctrl+V)" on note bodies,
        // "Add notes, paste images…" on card detail editors). The live
        // CSS uses literal content strings (not attr()), so attribute
        // stripping doesn\'t silence them — we override the content here.
        '.note-body:empty::before,',
        '.panel-body-editor:empty::before,',
        '.scope-section .rich-edit:empty:before,',
        '.val-rich-edit:empty:before { content: none !important; }',
        // ---- Board layout in export -----------------------------------
        // The live UI fixes the properties panel at 320px (var --panel-w).
        // In a standalone export the viewport can be narrow, and a
        // 320px sidecar squeezes the board itself into something too
        // small to read. When the user clicks a card we let the panel
        // overlay the right side instead of stealing grid space.
        '#tab-board .board-layout { overflow: auto; }',
        '#tab-board .board-layout.with-panel { position: relative; grid-template-columns: 1fr !important; }',
        '#tab-board .board-layout.with-panel .board-divider { display: none; }',
        '#tab-board .board-layout.with-panel .board-panel {',
        '  position: absolute; top: 0; right: 0; bottom: 0;',
        '  width: min(380px, 80vw);',
        '  z-index: 12;',
        '  box-shadow: -6px 0 16px rgba(0,0,0,0.35);',
        '  display: block;',
        '}',
        // Ensure the board grid can scroll horizontally when there are
        // many columns — the column min-width keeps each readable.
        '#tab-board .board-scroll { overflow: auto !important; }',
        // Panel close button stays clickable in export
        '#tab-board .panel-close { pointer-events: auto !important; cursor: pointer; }'
      ].join('\n');
    }

    function exportInteractivityJS() {
      return [
        '(function(){',
        // ---------------------------------------------------------------
        // Top-level tab switching
        // ---------------------------------------------------------------
        '  function activateTab(name){',
        '    document.querySelectorAll("nav.main-tabs button[data-tab]").forEach(function(b){',
        '      b.classList.toggle("active", b.getAttribute("data-tab") === name);',
        '    });',
        '    document.querySelectorAll(".tab-pane").forEach(function(p){',
        '      p.classList.toggle("active", p.id === "tab-" + name);',
        '    });',
        '    // Canvas pan/zoom needs its viewport BBox; recompute on tab show.',
        '    if (name === "canvases") setTimeout(syncCanvasPanZoom, 0);',
        '  }',
        '  document.querySelectorAll("nav.main-tabs button[data-tab]").forEach(function(b){',
        '    b.addEventListener("click", function(){ activateTab(b.getAttribute("data-tab")); });',
        '  });',
        // ---------------------------------------------------------------
        // Sidebar item navigation — switch which variant pane is shown.
        // Wired generically for any sidebar item carrying data-id or
        // data-canvas-id. The host pane (.export-variant-host) holds
        // &lt;div class="export-variant" data-variant-id="..."&gt; children;
        // we show the one matching the clicked item and hide the rest.
        // ---------------------------------------------------------------
        '  function showVariant(pane, id){',
        '    if (!pane) return;',
        '    pane.querySelectorAll(".export-variant-host &gt; .export-variant").forEach(function(v){',
        '      v.style.display = (v.getAttribute("data-variant-id") === id) ? "" : "none";',
        '    });',
        '  }',
        '  function wireSidebar(selector, idAttr){',
        '    document.querySelectorAll(selector).forEach(function(item){',
        '      item.addEventListener("click", function(e){',
        '        if (e.target.closest &amp;&amp; e.target.closest("button")) return;',
        '        var id = item.getAttribute(idAttr);',
        '        var pane = item.closest(".tab-pane");',
        '        if (!pane) return;',
        '        pane.querySelectorAll(selector).forEach(function(x){',
        '          x.classList.toggle("active", x.getAttribute(idAttr) === id);',
        '        });',
        '        showVariant(pane, id);',
        '        if (pane.id === "tab-canvases") setTimeout(syncCanvasPanZoom, 0);',
        '      });',
        '    });',
        '  }',
        '  wireSidebar(".scope-item",      "data-id");',
        '  wireSidebar(".note-item",       "data-id");',
        '  wireSidebar(".val-list-item",   "data-id");',
        '  wireSidebar(".cnv-list-item",   "data-canvas-id");',
        // ---------------------------------------------------------------
        // Board cards — click a card to clone its &lt;template
        // data-card-detail&gt; into the properties panel; click the
        // panel close button (or outside) to clear.
        // ---------------------------------------------------------------
        '  function openCard(cardEl){',
        '    var pane = cardEl.closest(".tab-pane");',
        '    var panel = pane &amp;&amp; pane.querySelector("#properties-panel");',
        '    if (!panel) return;',
        '    var tpl = cardEl.querySelector("template[data-card-detail]");',
        '    if (!tpl) return;',
        '    panel.innerHTML = "";',
        '    panel.appendChild(tpl.content.cloneNode(true));',
        '    var layout = pane.querySelector(".board-layout");',
        '    if (layout) layout.classList.add("with-panel");',
        '    pane.querySelectorAll(".card.selected").forEach(function(c){ c.classList.remove("selected"); });',
        '    cardEl.classList.add("selected");',
        '    var close = panel.querySelector("#panel-close, .panel-close");',
        '    if (close) close.addEventListener("click", clearCard.bind(null, pane));',
        '  }',
        '  function clearCard(pane){',
        '    var panel = pane.querySelector("#properties-panel");',
        '    if (panel) panel.innerHTML = "";',
        '    var layout = pane.querySelector(".board-layout");',
        '    if (layout) layout.classList.remove("with-panel");',
        '    pane.querySelectorAll(".card.selected").forEach(function(c){ c.classList.remove("selected"); });',
        '  }',
        '  document.querySelectorAll(".export-clickable-card").forEach(function(card){',
        '    card.addEventListener("click", function(){ openCard(card); });',
        '  });',
        // ---------------------------------------------------------------
        // Canvas pan + zoom. Each .export-variant for a canvas has its
        // own &lt;svg&gt;; we wire pan (middle-mouse, Shift+drag, or
        // Space+drag) and wheel-zoom on each.
        // ---------------------------------------------------------------
        '  var canvasSpace = false;',
        '  document.addEventListener("keydown", function(e){ if (e.code === "Space") canvasSpace = true; });',
        '  document.addEventListener("keyup",   function(e){ if (e.code === "Space") canvasSpace = false; });',
        '  function setupSvgPanZoom(svg){',
        '    if (svg._panZoomWired) return;',
        '    svg._panZoomWired = true;',
        '    function getVB(){ var vb = (svg.getAttribute("viewBox") || "0 0 800 600").split(" ").map(parseFloat); return { x: vb[0], y: vb[1], w: vb[2], h: vb[3] }; }',
        '    function setVB(v){ svg.setAttribute("viewBox", v.x + " " + v.y + " " + v.w + " " + v.h); }',
        '    var drag = null;',
        '    svg.addEventListener("mousedown", function(e){',
        '      if (e.button !== 1 &amp;&amp; !canvasSpace &amp;&amp; !e.shiftKey) return;',
        '      e.preventDefault();',
        '      var v = getVB();',
        '      drag = { sx: e.clientX, sy: e.clientY, vx: v.x, vy: v.y, w: v.w, h: v.h, rect: svg.getBoundingClientRect() };',
        '      svg.style.cursor = "grabbing";',
        '    });',
        '    document.addEventListener("mousemove", function(e){',
        '      if (!drag) return;',
        '      var sx = drag.w / drag.rect.width;',
        '      var sy = drag.h / drag.rect.height;',
        '      setVB({ x: drag.vx - (e.clientX - drag.sx) * sx, y: drag.vy - (e.clientY - drag.sy) * sy, w: drag.w, h: drag.h });',
        '    });',
        '    document.addEventListener("mouseup", function(){ if (drag) { drag = null; svg.style.cursor = ""; } });',
        '    svg.addEventListener("wheel", function(e){',
        '      e.preventDefault();',
        '      var v = getVB();',
        '      var rect = svg.getBoundingClientRect();',
        '      var mx = (e.clientX - rect.left) / rect.width;',
        '      var my = (e.clientY - rect.top)  / rect.height;',
        '      var factor = e.deltaY &gt; 0 ? 1.15 : (1/1.15);',
        '      var nw = v.w * factor, nh = v.h * factor;',
        '      setVB({ x: v.x + (mx * v.w) - (mx * nw), y: v.y + (my * v.h) - (my * nh), w: nw, h: nh });',
        '    }, { passive: false });',
        '  }',
        '  function syncCanvasPanZoom(){',
        '    document.querySelectorAll("#tab-canvases svg").forEach(setupSvgPanZoom);',
        '  }',
        '  syncCanvasPanZoom();',
        '})();'
      ].join('\n');
    }


    function downloadFile(filename, content, mimeType) {
      var blob = new Blob([content], { type: mimeType });
      var url = URL.createObjectURL(blob);
      var a = document.createElement('a');
      a.href = url;
      a.download = filename;
      document.body.appendChild(a);
      a.click();
      document.body.removeChild(a);
      setTimeout(function () { URL.revokeObjectURL(url); }, 500);
    }

    // --- lightbox (double-click any image to enlarge) ---
    function openLightbox(src) {
      var existing = document.querySelector('.lightbox-overlay');
      if (existing) existing.parentNode.removeChild(existing);
      var ov = document.createElement('div');
      ov.className = 'lightbox-overlay';
      var img = document.createElement('img');
      img.src = src;
      ov.appendChild(img);
      function close() {
        if (ov.parentNode) ov.parentNode.removeChild(ov);
        document.removeEventListener('keydown', esc);
      }
      function esc(ev) { if (ev.key === 'Escape') { ev.preventDefault(); close(); } }
      ov.addEventListener('click', close);
      document.addEventListener('keydown', esc);
      document.body.appendChild(ov);
    }
    document.addEventListener('dblclick', function (e) {
      var el = e.target;
      if (el &amp;&amp; el.tagName === 'IMG' &amp;&amp; el.hasAttribute('data-img-id') &amp;&amp; el.src) {
        e.preventDefault();
        openLightbox(el.src);
      }
    });

    // --- state ---
    var state = null;
    var saveStatus = 'clean';      // clean | pending | saving | error
    var saveTimer = null;
    var lastSavedAt = 0;
    var selectedCardId = null;     // UI state — which board card has the properties panel open
    var imageCache = {};           // { imgId: dataUrl } populated on load, kept in sync on paste
    var themeMode = 0;             // 0 = dark, 1 = light. Persisted at &gt;variables/mode in the tree

    // Per-tab defaults. Each tab's data is saved to its own tree node so
    // an edit only rewrites the touched tab. The `settings` "tab" is the
    // home for app-wide preferences (theme mode, active tab, user settings,
    // id counter, createdAt/modifiedAt) so anything UI-global lives in one
    // place.
    function defaultScoping() {
      return { version: 1, docs: [], activeDocId: null };
    }
    function defaultNotes() {
      // Empty by default — auto-injecting starter notes ("Scratch",
      // "Session log", etc.) wrote fake user data to disk on every
      // fresh model and survived export/import. The user creates their
      // own notes with the + Add note button.
      return {
        version: 1,
        activeNoteId: null,
        items: []
      };
    }
    function defaultBoard() {
      return {
        version: 1,
        columns: [
          { id: 'c1', name: 'To Do' },
          { id: 'c2', name: 'In Progress' },
          { id: 'c3', name: 'Review' },
          { id: 'c4', name: 'Closed' }
        ],
        cards: [],
        panelWidth: 320
      };
    }
    function defaultCanvasesState() {
      return {
        version: 1,
        activeId: 'cnv-1',
        settings: defaultCanvasSettings(),
        items: [
          { id: 'cnv-1', name: 'Canvas 1', shapes: [], viewport: { x: 0, y: 0, scale: 1 } }
        ]
      };
    }
    function defaultValidation() {
      return { version: 1, runs: [], activeRunId: null };
    }

    function defaultState() {
      return {
        scoping:    defaultScoping(),
        notes:      defaultNotes(),
        board:      defaultBoard(),
        canvases:   defaultCanvasesState(),
        validation: defaultValidation(),
        settings:   defaultSettings()
      };
    }

    function defaultCanvasSettings() {
      return {
        showGrid: true,
        snapToGrid: false,
        gridSize: 20,
        showDimensions: true,   // tooltip with WxH during resize/create
        smoothFreedraw: false,  // apply Bezier smoothing on stroke commit
        showRulers: false       // px ruler along top/left
      };
    }

    // Forward-compat: ensure every tab slot exists. Called after loading
    // per-tab nodes so a brand-new model (or an upgrade from a partial save)
    // gets fully populated defaults for any missing pieces.
    function ensureNewTabsState() {
      if (!state.scoping)    state.scoping    = defaultScoping();
      if (!state.notes)      state.notes      = defaultNotes();
      if (!state.board)      state.board      = defaultBoard();
      if (!state.canvases)   state.canvases   = defaultCanvasesState();
      if (!state.validation) state.validation = defaultValidation();
      if (!state.settings)   state.settings   = defaultSettings();

      // Back-fill missing keys per tab (forward-compat as fields evolve)
      ['scoping','notes','board','canvases','validation','settings'].forEach(function (t) {
        var d = ({
          scoping: defaultScoping, notes: defaultNotes,
          board: defaultBoard, canvases: defaultCanvasesState,
          validation: defaultValidation,
          settings: defaultSettings
        })[t]();
        Object.keys(d).forEach(function (k) {
          if (typeof state[t][k] === 'undefined') state[t][k] = d[k];
        });
      });

      // Canvas-specific back-fills
      if (!state.canvases.settings) state.canvases.settings = defaultCanvasSettings();
      var ds = defaultCanvasSettings();
      Object.keys(ds).forEach(function (k) {
        if (typeof state.canvases.settings[k] === 'undefined') state.canvases.settings[k] = ds[k];
      });
      state.canvases.items.forEach(function (c) {
        if (!c.viewport) c.viewport = { x: 0, y: 0, scale: 1 };
      });
    }

    function newId(prefix) {
      if (!state.settings) state.settings = defaultSettings();
      state.settings.nextId = (state.settings.nextId || 9) + 1;
      // newId only mutates settings — make sure the change persists
      markDirty('settings');
      return prefix + state.settings.nextId;
    }

    // --- settings ---
    // App-wide preferences live in state.settings (the dedicated settings
    // tab). Includes theme mode, active tab, user settings, ID counter,
    // and meta timestamps. All in one place; saved to its own tree node.
    function defaultSettings() {
      return {
        version: 1,
        mode: 'dark',                  // 'dark' | 'light'
        activeTab: 'scoping',          // 'scoping' | 'notes' | 'board' | 'canvases' | 'validation'
        defaultTab: 'last',            // 'last' | 'scoping' | 'notes' | 'board' | 'canvases' | 'validation'
        defaultCardPriority: 'med',    // 'high' | 'med' | 'low'
        editorFontSize: 'medium',      // 'small' | 'medium' | 'large'
        autoSaveDelay: 1000,           // ms
        nextId: 9,                     // global id counter for newId()
        createdAt: new Date().toISOString(),
        modifiedAt: new Date().toISOString()
      };
    }

    function getSettings() {
      if (!state) return defaultSettings();
      if (!state.settings) state.settings = defaultSettings();
      var d = defaultSettings();
      Object.keys(d).forEach(function (k) {
        if (typeof state.settings[k] === 'undefined') state.settings[k] = d[k];
      });
      return state.settings;
    }

    function applyFontSizeSetting() {
      var s = getSettings();
      document.body.classList.remove('font-small', 'font-medium', 'font-large');
      document.body.classList.add('font-' + s.editorFontSize);
    }

    // --- save lifecycle ---
    // Per-tab data model: every tab's state is serialized to its own tree
    // node (&gt;variables/tabs/&lt;name&gt;) so editing one tab doesn't rewrite the
    // others. The JS state shape is { scoping, notes, board, canvases,
    // settings } — each is loaded/saved independently. The settings tab
    // holds app-wide preferences (theme mode, activeTab, user settings,
    // and meta like nextId/createdAt/modifiedAt).
    var TAB_NAMES = ['scoping', 'notes', 'board', 'canvases', 'validation', 'settings'];

    function loadAllTabsFromHost(cb) {
      if (inBrowser) {
        var result = {};
        TAB_NAMES.forEach(function (t) {
          try {
            var v = localStorage.getItem('notebook.tab.' + t);
            result[t] = v ? JSON.parse(v) : null;
          } catch (e) { result[t] = null; }
        });
        cb(result);
        return;
      }
      fireFlexsimEvent('Notebook_loadAllTabs', function (raw) {
        var parsed = {};
        try { parsed = raw ? JSON.parse(raw) : {}; }
        catch (e) { console.error('[loadAllTabs] parse failed', e); parsed = {}; }
        // Ensure every tab key exists (FlexScript only returns nodes that
        // have been written — first run yields {}).
        TAB_NAMES.forEach(function (t) { if (!(t in parsed)) parsed[t] = null; });
        cb(parsed);
      });
    }

    function loadTabFromHost(tab, cb) {
      if (inBrowser) {
        try {
          var v = localStorage.getItem('notebook.tab.' + tab);
          cb(v ? JSON.parse(v) : null);
        } catch (e) { cb(null); }
        return;
      }
      fireFlexsimEvent('Notebook_loadTab', tab, function (raw) {
        try { cb(raw ? JSON.parse(raw) : null); }
        catch (e) { cb(null); }
      });
    }

    function saveTabToHost(tab, json, aliveStr, cb) {
      if (inBrowser) {
        try {
          localStorage.setItem('notebook.tab.' + tab, json);
          // GC stub: in-browser, drop any localStorage images not in aliveStr
          var images = {};
          try { images = JSON.parse(localStorage.getItem('notebook.images') || '{}'); } catch (e) {}
          Object.keys(images).forEach(function (id) {
            if (aliveStr.indexOf(',' + id + ',') &lt; 0) delete images[id];
          });
          localStorage.setItem('notebook.images', JSON.stringify(images));
          cb('ok');
        } catch (e) { cb('error'); }
        return;
      }
      fireFlexsimEvent('Notebook_saveTab', tab, json, aliveStr, function (result) {
        cb(result || 'error');
      });
    }

    function loadImagesFromHost(cb) {
      if (inBrowser) {
        try {
          var stored = localStorage.getItem('notebook.images');
          cb(stored ? JSON.parse(stored) : {});
        } catch (e) { cb({}); }
        return;
      }
      fireFlexsimEvent('Notebook_loadImages', '', function (result) {
        var parsed;
        try { parsed = result ? JSON.parse(result) : {}; }
        catch (e) { parsed = {}; }
        cb(parsed);
      });
    }

    function saveImageToHost(id, dataUrl, cb) {
      if (inBrowser) {
        try {
          var images = {};
          try { images = JSON.parse(localStorage.getItem('notebook.images') || '{}'); } catch (e) {}
          images[id] = dataUrl;
          localStorage.setItem('notebook.images', JSON.stringify(images));
          cb('ok');
        } catch (e) { cb('error'); }
        return;
      }
      fireFlexsimEvent('Notebook_saveImage', id, dataUrl, function (result) { cb(result || 'error'); });
    }

    // Snapshot bridge — reads Model.parameters + Model.performanceMeasures
    // via the snapshotModelState FlexScript event function. Returns
    // { parameters: [...], performanceMeasures: [...] } to the callback.
    // In-browser fallback returns a small fixture so the prototype runs
    // outside FlexSim.
    function snapshotModelStateFromHost(cb) {
      if (inBrowser) {
        cb({
          parameters: [
            { name: 'ArrivalRate', value: 60, evaluatedValue: 60, units: 'per hour', description: '(browser fixture)', tableName: 'Parameters' },
            { name: 'Operators',   value: 4,  evaluatedValue: 4,  units: '',         description: '(browser fixture)', tableName: 'Parameters' }
          ],
          performanceMeasures: [
            { name: 'AvgCycleTime', value: 22.5, units: 'min', description: '(browser fixture)', tableName: 'PerformanceMeasures' },
            { name: 'Utilization',  value: 0.78, units: '',    description: '(browser fixture)', tableName: 'PerformanceMeasures' }
          ]
        });
        return;
      }
      fireFlexsimEvent('Notebook_snapshotModelState', function (raw) {
        var parsed;
        try { parsed = raw ? JSON.parse(raw) : { parameters: [], performanceMeasures: [] }; }
        catch (e) {
          console.error('[snapshot] failed to parse', e, raw);
          parsed = { parameters: [], performanceMeasures: [] };
        }
        if (!parsed.parameters) parsed.parameters = [];
        if (!parsed.performanceMeasures) parsed.performanceMeasures = [];
        cb(parsed);
      });
    }

    function setSaveStatus(status) {
      saveStatus = status;
      var el = document.getElementById('save-status');
      if (!el) return;
      el.className = 'save-status ' + status;
      if (status === 'clean') {
        var s = Math.max(0, Math.round((Date.now() - lastSavedAt) / 1000));
        el.textContent = lastSavedAt ? ('Saved ' + s + 's ago') : '';
      } else if (status === 'pending') {
        el.textContent = 'Unsaved changes';
      } else if (status === 'saving') {
        el.textContent = 'Saving…';
      } else if (status === 'error') {
        el.innerHTML = 'Save failed — &lt;a href="#" onclick="saveImmediate(); return false;"&gt;Retry&lt;/a&gt;';
      }
    }

    // Per-tab dirty tracking. When an edit happens we mark the originating
    // tab dirty; on flush we save only the dirty tabs. saveDebounced/
    // saveImmediate accept an optional tab name — if omitted they fall back
    // to the currently-active tab, which is correct for ~all edit paths
    // since edits happen in the visible tab's event handlers.
    var dirtyTabs = {};   // tab name → true
    function activeTabName() {
      return (state &amp;&amp; state.settings &amp;&amp; state.settings.activeTab) || 'notes';
    }
    // markDirty(tabName)         — explicit, marks that tab dirty.
    // markDirty()  (no arg)       — DELIBERATE fallback: marks the active
    //                                tab. ~60 legacy edit handlers call
    //                                saveDebounced() / saveImmediate() with
    //                                no arg meaning "save what the user is
    //                                editing right now". Those route through
    //                                here. For cross-tab persistence (undo,
    //                                redo, import), iterate TAB_NAMES and
    //                                mark each explicitly — the active-tab
    //                                fallback would silently drop the others.
    function markDirty(tab) {
      tab = tab || activeTabName();
      if (!tab) return;
      dirtyTabs[tab] = true;
    }
    function clearDirty(tab) { delete dirtyTabs[tab]; }
    function hasDirty() { for (var k in dirtyTabs) return true; return false; }

    // Snapshot one tab's state for serialization — strips data: URLs from
    // any rich-text bodies so heavy bytes stay in the dedicated images store.
    function snapshotTab(tab) {
      if (!state || !state[tab]) return null;
      var snap = JSON.parse(JSON.stringify(state[tab]));
      if (tab === 'notes' &amp;&amp; snap.items) {
        snap.items.forEach(function (n) { n.body = stripDataUrls(n.body); });
      } else if (tab === 'board' &amp;&amp; snap.cards) {
        snap.cards.forEach(function (c) { c.body = stripDataUrls(c.body); });
      } else if (tab === 'canvases' &amp;&amp; snap.items) {
        snap.items.forEach(function (cv) {
          if (cv.shapes) cv.shapes.forEach(function (sh) {
            if (sh.text) sh.text = stripDataUrls(sh.text);
          });
        });
      } else if (tab === 'scoping' &amp;&amp; snap.docs) {
        snap.docs.forEach(function (d) {
          if (d.background) d.background = stripDataUrls(d.background);
          if (d.notes)      d.notes      = stripDataUrls(d.notes);
          if (d.modelBoundary) d.modelBoundary = stripDataUrls(d.modelBoundary);
          if (d.fidelity)   d.fidelity   = stripDataUrls(d.fidelity);
          if (d.acceptance) d.acceptance = stripDataUrls(d.acceptance);
          if (d.validationAcceptance) d.validationAcceptance = stripDataUrls(d.validationAcceptance);
          if (d.training &amp;&amp; d.training.postSupport) d.training.postSupport = stripDataUrls(d.training.postSupport);
        });
      } else if (tab === 'validation' &amp;&amp; snap.runs) {
        snap.runs.forEach(function (r) {
          if (r.observations) r.observations = stripDataUrls(r.observations);
          if (r.analysis)     r.analysis     = stripDataUrls(r.analysis);
          if (r.nextSteps)    r.nextSteps    = stripDataUrls(r.nextSteps);
        });
      }
      return snap;
    }

    function saveImmediate(tab) {
      if (saveTimer) { clearTimeout(saveTimer); saveTimer = null; }
      if (!state) return;
      // markDirty falls back to the currently-active tab when tab is undefined.
      // This is the right default — legacy callsites use saveImmediate() to mean
      // "I just changed something on the visible tab, persist now."
      markDirty(tab);
      if (!hasDirty()) { hideSavingOverlay(); return; }

      if (!state.settings) state.settings = defaultSettings();
      state.settings.modifiedAt = new Date().toISOString();
      // settings.modifiedAt updates always count as a settings edit
      dirtyTabs.settings = true;

      setSaveStatus('saving');

      // Compute alive image IDs across the WHOLE state — orphan-GC needs
      // visibility into all tabs at once. Cheap (it's a regex pass).
      var globalAlive = formatAliveStr(collectAliveImageIds(JSON.stringify(state)));

      var tabs = Object.keys(dirtyTabs);
      dirtyTabs = {};
      var pending = tabs.length;
      var anyError = false;

      tabs.forEach(function (t) {
        var snap = snapshotTab(t);
        if (snap === null) { pending--; return; }
        var json = JSON.stringify(snap);
        saveTabToHost(t, json, globalAlive, function (result) {
          if (result !== 'ok') anyError = true;
          pending--;
          if (pending === 0) {
            if (anyError) setSaveStatus('error');
            else { lastSavedAt = Date.now(); setSaveStatus('clean'); }
            hideSavingOverlay();
          }
        });
      });
      if (pending === 0) {
        // Edge case: all tabs were null. Just clear status.
        setSaveStatus('clean');
        hideSavingOverlay();
      }
    }

    function saveDebounced(tab) {
      markDirty(tab);
      setSaveStatus('pending');
      if (saveTimer) clearTimeout(saveTimer);
      var delay = getSettings().autoSaveDelay || 500;
      saveTimer = setTimeout(function () { saveImmediate(); }, delay);
    }

    // Periodically refresh the "Saved Xs ago" text while clean.
    setInterval(function () {
      if (saveStatus === 'clean' &amp;&amp; lastSavedAt) setSaveStatus('clean');
    }, 5000);

    // Save-on-close: show overlay and flush any pending debounce
    // before the panel tears down. fireFlexsimEvent is synchronous to
    // FlexScript's tree write in CEF, so this should complete before
    // the JS context is destroyed.
    function showSavingOverlay() {
      if (document.getElementById('saving-overlay')) return;
      var div = document.createElement('div');
      div.id = 'saving-overlay';
      div.className = 'saving-overlay';
      div.innerHTML = '&lt;div class="saving-box"&gt;Saving…&lt;/div&gt;';
      document.body.appendChild(div);
    }

    function hideSavingOverlay() {
      var el = document.getElementById('saving-overlay');
      if (el &amp;&amp; el.parentNode) el.parentNode.removeChild(el);
    }

    function flushSaveOnClose() {
      if (!state) return;
      if (saveStatus === 'pending' || saveStatus === 'saving') {
        showSavingOverlay();
        saveImmediate();
      }
    }

    window.addEventListener('beforeunload', flushSaveOnClose);
    window.addEventListener('pagehide', flushSaveOnClose);
    document.addEventListener('visibilitychange', function () {
      if (document.visibilityState === 'hidden') flushSaveOnClose();
    });

    // --- auto-grow textarea helper ---
    // Resizes the element to fit its content (no scrollbar). Call once
    // at bind time to size from the saved value, and on every input
    // event while the user types.
    function autoGrowEl(el) {
      if (!el) return;
      el.style.height = 'auto';
      el.style.height = (el.scrollHeight + 2) + 'px';
    }

    // --- drag-reorder helper ---
    // Wires HTML5 drag-and-drop on every itemSelector inside container
    // and mutates `items` (in-place) when the user drops. After the
    // mutation, onReorder() runs so the caller can save + re-render.
    // Used by both the Scopes sidebar and the Notes sidebar so the two
    // lists stay consistent.
    function wireDragReorder(container, itemSelector, items, onReorder) {
      var draggingId = null;
      function indexOfId(id) {
        for (var i = 0; i &lt; items.length; i++) if (items[i].id === id) return i;
        return -1;
      }
      function clearHints() {
        container.querySelectorAll(itemSelector).forEach(function (n) {
          n.classList.remove('drop-above');
          n.classList.remove('drop-below');
        });
      }
      container.querySelectorAll(itemSelector).forEach(function (el) {
        el.addEventListener('dragstart', function (e) {
          draggingId = el.getAttribute('data-id');
          if (e.dataTransfer) {
            e.dataTransfer.effectAllowed = 'move';
            // Firefox refuses to start a drag without setData; harmless elsewhere.
            try { e.dataTransfer.setData('text/plain', draggingId); } catch (_) {}
          }
          el.classList.add('dragging');
        });
        el.addEventListener('dragend', function () {
          el.classList.remove('dragging');
          clearHints();
          draggingId = null;
        });
        el.addEventListener('dragover', function (e) {
          if (!draggingId) return;
          e.preventDefault();
          if (e.dataTransfer) e.dataTransfer.dropEffect = 'move';
          var tgtId = el.getAttribute('data-id');
          if (tgtId === draggingId) return;
          var rect = el.getBoundingClientRect();
          var dropAfter = e.clientY &gt;= (rect.top + rect.height / 2);
          el.classList.toggle('drop-above', !dropAfter);
          el.classList.toggle('drop-below', dropAfter);
        });
        el.addEventListener('dragleave', function () {
          el.classList.remove('drop-above');
          el.classList.remove('drop-below');
        });
        el.addEventListener('drop', function (e) {
          e.preventDefault();
          var srcId = draggingId;
          var tgtId = el.getAttribute('data-id');
          clearHints();
          if (!srcId || srcId === tgtId) return;
          var fromIdx = indexOfId(srcId);
          var toIdx = indexOfId(tgtId);
          if (fromIdx === -1 || toIdx === -1) return;
          var rect = el.getBoundingClientRect();
          var dropAfter = e.clientY &gt;= (rect.top + rect.height / 2);
          var moved = items.splice(fromIdx, 1)[0];
          // Recompute target index after the splice if we removed from
          // earlier in the array.
          var insertAt;
          if (fromIdx &lt; toIdx) insertAt = dropAfter ? toIdx : toIdx - 1;
          else insertAt = dropAfter ? toIdx + 1 : toIdx;
          items.splice(insertAt, 0, moved);
          onReorder();
        });
      });
    }

    // --- scoping tab ---
    // Project-scope reference (SOW-like). One doc per scope; multi-doc
    // sidebar similar to Notes. Each section has an "Add ___" button at
    // the top (no inline add rows). Persists to state.scoping which lives
    // in its own tree node.
    var SCOPE_ROLES = ['Project Manager', 'Point of Contact', 'Decision Maker', 'Subject Matter Expert', 'Other'];
    var SCOPE_SEVERITY = ['low', 'med', 'high'];
    // 2026-06-01: extra constants for the SOW-inspired sections added after
    // the legal SOW draft audit (see CONTRIBUTING / commit log).
    var SCOPE_STATUS = ['draft', 'active', 'archived', 'superseded'];
    var SCOPE_ENGAGEMENT = [
      { v: 'modelBuilding', label: 'Model Building' },
      { v: 'support',       label: 'Support Hours' },
      { v: 'moduleDev',     label: 'Module Development' },
      { v: 'internal',      label: 'Internal' },
      { v: 'other',         label: 'Other' }
    ];
    var WHATIF_KINDS = [
      { v: 'swap',        label: 'Discrete swap' },
      { v: 'sweep',       label: 'Range sweep' },
      { v: 'qualitative', label: 'Qualitative' }
    ];
    var DATA_REQ_STATUS = ['pending', 'received', 'partial', 'waived'];
    var TRAINING_METHODS = [
      { v: 'doc',     label: 'Documentation only' },
      { v: 'virtual', label: 'Virtual workshop' },
      { v: 'onsite',  label: 'On-site workshop' },
      { v: 'combo',   label: 'Docs + virtual session' },
      { v: 'other',   label: 'Other (specify)' }
    ];
    var CHANGE_ORDER_STATUS = ['pending', 'approved', 'rejected', 'cancelled'];

    function scopeEmptyDoc() {
      // No prefill text. Previous versions seeded a bracketed example
      // Business Question and a "Baseline" scenarios row "to defeat
      // empty-canvas paralysis", but those became user data on first
      // save — surviving exports and re-imports as if the user typed
      // them. Templates are the right answer for blank-page friction
      // (roadmap), not silent injection.
      return {
        id: newId('sc-'),
        title: 'Untitled scope',
        oneLiner: '',
        status: 'draft',
        engagementType: 'modelBuilding',
        background: '',
        businessQuestions: [],
        objectives: [],
        inScope: [],
        outScope: [],
        deliverables: [],
        deliveryCriteria: [],
        businessSuccess: [],
        assumptions: [],
        constraints: { timeline: '', budget: '', data: '' },
        stakeholders: [],
        milestones: [],
        risks: [],
        openQuestions: [],
        acceptance: '',
        modelBoundary: '',
        processDiagrams: [],
        fidelity: '',
        dataDrivenParams: [],
        whatIfParams: [],
        dataRequirements: [],
        dataGaps: [],
        validation: [],
        validationTimeline: { historicalWindow: '', targetDays: '' },
        validationAcceptance: '',
        kpis: [],
        charts: [],
        dataSources: [],
        scenarios: [],
        scenariosTable: [],
        training: { method: 'doc', otherText: '', postSupport: '' },
        trainingContent: [],
        changeOrders: [],
        notes: '',
        simExpanded: true,
        trainingExpanded: false,
        changeLogExpanded: false,
        updated: new Date().toISOString()
      };
    }

    // Idempotent shape repair for legacy docs that pre-date the newer
    // fields. Called from renderScopeDoc so any doc the user opens gets
    // upgraded in place; old fields (dataSources, scenarios bullets) are
    // left alone so we don't lose data — they just become unused.
    function ensureScopeShape(d) {
      if (!d) return;
      if (typeof d.status === 'undefined')          d.status = 'draft';
      if (typeof d.engagementType === 'undefined')  d.engagementType = 'modelBuilding';
      if (!d.businessQuestions)                     d.businessQuestions = [];
      if (!d.deliveryCriteria)                      d.deliveryCriteria = [];
      if (!d.businessSuccess)                       d.businessSuccess = [];
      if (typeof d.acceptance === 'undefined')      d.acceptance = '';
      if (!d.processDiagrams)                       d.processDiagrams = [];
      if (!d.dataDrivenParams)                      d.dataDrivenParams = [];
      if (!d.whatIfParams)                          d.whatIfParams = [];
      if (!d.dataRequirements)                      d.dataRequirements = [];
      if (!d.dataGaps)                              d.dataGaps = [];
      if (!d.validationTimeline)                    d.validationTimeline = { historicalWindow: '', targetDays: '' };
      if (typeof d.validationAcceptance === 'undefined') d.validationAcceptance = '';
      if (!d.charts)                                d.charts = [];
      if (!d.scenariosTable)                        d.scenariosTable = [];
      if (!d.training)                              d.training = { method: 'doc', otherText: '', postSupport: '' };
      if (typeof d.training.postSupport === 'undefined') d.training.postSupport = '';
      // Migrate from earlier nested d.training.content shape if present.
      if (d.training.content &amp;&amp; !d.trainingContent) { d.trainingContent = d.training.content; delete d.training.content; }
      if (!d.trainingContent)                       d.trainingContent = [];
      if (!d.changeOrders)                          d.changeOrders = [];
      if (typeof d.trainingExpanded === 'undefined')   d.trainingExpanded = false;
      if (typeof d.changeLogExpanded === 'undefined')  d.changeLogExpanded = false;
    }

    function scopeActiveDoc() {
      if (!state.scoping || !state.scoping.docs) return null;
      return state.scoping.docs.filter(function (d) { return d.id === state.scoping.activeDocId; })[0] || null;
    }

    function renderScopingTab() {
      var pane = document.getElementById('tab-scoping');
      if (!state.scoping) state.scoping = defaultScoping();
      var docs = state.scoping.docs || [];

      var sidebarHtml = docs.map(function (d) {
        var active = d.id === state.scoping.activeDocId ? ' active' : '';
        var counts = scopeCountSummary(d);
        return '&lt;div class="scope-item' + active + '" data-id="' + d.id + '" draggable="true"&gt;' +
          '&lt;div class="title"&gt;' + escapeHtml(d.title || 'Untitled') + '&lt;/div&gt;' +
          '&lt;div class="meta"&gt;' + escapeHtml(counts) + '&lt;/div&gt;' +
          '&lt;button class="del-btn" data-del="' + d.id + '" title="Delete scope"&gt;×&lt;/button&gt;' +
        '&lt;/div&gt;';
      }).join('');

      pane.innerHTML =
        tabUndoBarHtml('scoping') +
        '&lt;div class="scoping-layout"&gt;' +
          '&lt;aside class="scoping-sidebar"&gt;' +
            '&lt;div class="sidebar-head"&gt;' +
              '&lt;h3&gt;SCOPES&lt;/h3&gt;' +
              '&lt;button class="add-card-btn" id="scope-add-doc-btn" style="padding: 3px 9px; font-size: 11px;"&gt;+ New&lt;/button&gt;' +
            '&lt;/div&gt;' +
            '&lt;div class="scope-list" id="scope-list"&gt;' + sidebarHtml + '&lt;/div&gt;' +
          '&lt;/aside&gt;' +
          '&lt;main class="scope-doc" id="scope-doc-pane"&gt;&lt;/main&gt;' +
        '&lt;/div&gt;';
      updateTabUndoButtons('scoping');

      // Wire sidebar
      pane.querySelectorAll('.scope-item').forEach(function (el) {
        el.addEventListener('click', function (e) {
          if (e.target.classList.contains('del-btn')) return;
          var id = el.getAttribute('data-id');
          if (state.scoping.activeDocId !== id) {
            state.scoping.activeDocId = id;
            saveDebounced('scoping');
            renderScopingTab();
          }
        });
      });
      pane.querySelectorAll('.del-btn[data-del]').forEach(function (btn) {
        btn.addEventListener('click', function (e) {
          e.stopPropagation();
          var id = btn.getAttribute('data-del');
          if (!confirm('Delete this scope document?')) return;
          pushHistory('scoping');
          state.scoping.docs = state.scoping.docs.filter(function (d) { return d.id !== id; });
          if (state.scoping.activeDocId === id) {
            state.scoping.activeDocId = state.scoping.docs[0] ? state.scoping.docs[0].id : null;
          }
          saveDebounced('scoping');
          renderScopingTab();
        });
      });
      document.getElementById('scope-add-doc-btn').addEventListener('click', scopeAddDoc);

      // Drag-reorder the scope sidebar list.
      var scopeListEl = document.getElementById('scope-list');
      if (scopeListEl) {
        wireDragReorder(scopeListEl, '.scope-item', state.scoping.docs, function () {
          saveDebounced('scoping');
          renderScopingTab();
        });
      }

      renderScopeDoc();
    }

    function scopeCountSummary(d) {
      var s = [];
      if (d.businessQuestions &amp;&amp; d.businessQuestions.length) s.push(d.businessQuestions.length + ' Q');
      if (d.objectives &amp;&amp; d.objectives.length)     s.push(d.objectives.length + ' obj');
      if (d.deliverables &amp;&amp; d.deliverables.length) s.push(d.deliverables.length + ' deliv');
      if (d.stakeholders &amp;&amp; d.stakeholders.length) s.push(d.stakeholders.length + ' people');
      if (d.openQuestions &amp;&amp; d.openQuestions.length) s.push(d.openQuestions.length + ' open');
      if (d.changeOrders &amp;&amp; d.changeOrders.length) s.push(d.changeOrders.length + ' CO');
      return s.join(' · ') || 'empty';
    }

    function scopeAddDoc() {
      pushHistory('scoping');
      var d = scopeEmptyDoc();
      if (!state.scoping.docs) state.scoping.docs = [];
      state.scoping.docs.unshift(d);
      state.scoping.activeDocId = d.id;
      saveDebounced('scoping');
      renderScopingTab();
      setTimeout(function () {
        var t = document.querySelector('.doc-title-input');
        if (t) { t.focus(); t.select(); }
      }, 30);
    }

    function renderScopeDoc() {
      var host = document.getElementById('scope-doc-pane');
      var d = scopeActiveDoc();
      if (!d) {
        host.className = 'scope-doc empty';
        host.innerHTML =
          '&lt;div class="scope-doc-empty"&gt;' +
            '&lt;div class="big"&gt;📋&lt;/div&gt;' +
            '&lt;div&gt;No scope selected.&lt;/div&gt;' +
            '&lt;button class="add-card-btn" onclick="scopeAddDoc()"&gt;+ Create one&lt;/button&gt;' +
          '&lt;/div&gt;';
        return;
      }
      ensureScopeShape(d);
      host.className = 'scope-doc';

      function sec(label, desc, body, addBtnLabel, addBtnHandler) {
        // Add button sits IMMEDIATELY after the section title so the action
        // reads as belonging to this section, not as a header for what's below.
        var addBtn = addBtnLabel
          ? '&lt;button class="add-btn" onclick="' + addBtnHandler + '"&gt;+ Add ' + addBtnLabel + '&lt;/button&gt;'
          : '';
        return '&lt;div class="scope-section"&gt;' +
          '&lt;div class="scope-section-header"&gt;' +
            '&lt;h2&gt;' + label + '&lt;/h2&gt;' +
            addBtn +
            '&lt;span class="desc"&gt;' + desc + '&lt;/span&gt;' +
          '&lt;/div&gt;' + body +
        '&lt;/div&gt;';
      }
      function bullet(text, field, idx, bulletChar) {
        bulletChar = bulletChar || '•';
        // Rendered as a textarea (not input) so long bullet text wraps
        // and grows in place via autoGrowEl, instead of horizontal
        // overflow. Enter creates a new bullet; Shift+Enter inserts a
        // newline within the current bullet.
        return '&lt;div class="scope-bullet" data-field="' + field + '" data-idx="' + idx + '"&gt;' +
          '&lt;span class="bullet"&gt;' + bulletChar + '&lt;/span&gt;' +
          '&lt;textarea class="bullet-text" rows="1"&gt;' + escapeHtml(text) + '&lt;/textarea&gt;' +
          '&lt;button class="del" onclick="scopeRemoveBullet(\'' + field + '\', ' + idx + ')"&gt;✕&lt;/button&gt;' +
        '&lt;/div&gt;';
      }

      host.innerHTML =
        '&lt;input class="doc-title-input" id="scope-d-title" value="' + escapeHtml(d.title) + '" placeholder="Project title…" /&gt;' +
        '&lt;input class="doc-oneliner-input" id="scope-d-oneliner" value="' + escapeHtml(d.oneLiner) + '" placeholder="One-line summary…" /&gt;' +

        // Engagement type + status badges (SOW §3 / §0 metadata)
        '&lt;div class="scope-meta-row"&gt;' +
          '&lt;label class="scope-meta-cell"&gt;' +
            '&lt;span class="lbl"&gt;Engagement&lt;/span&gt;' +
            '&lt;select id="scope-d-engagement"&gt;' +
              SCOPE_ENGAGEMENT.map(function (e) {
                return '&lt;option value="' + e.v + '" ' + (d.engagementType === e.v ? 'selected' : '') + '&gt;' + escapeHtml(e.label) + '&lt;/option&gt;';
              }).join('') +
            '&lt;/select&gt;' +
          '&lt;/label&gt;' +
          '&lt;label class="scope-meta-cell"&gt;' +
            '&lt;span class="lbl"&gt;Status&lt;/span&gt;' +
            '&lt;select id="scope-d-status" class="status-' + escapeHtml(d.status) + '"&gt;' +
              SCOPE_STATUS.map(function (s) {
                return '&lt;option value="' + s + '" ' + (d.status === s ? 'selected' : '') + '&gt;' + s.toUpperCase() + '&lt;/option&gt;';
              }).join('') +
            '&lt;/select&gt;' +
          '&lt;/label&gt;' +
        '&lt;/div&gt;' +

        sec('BUSINESS QUESTIONS', 'Specific decisions or questions the model is being built to inform.',
          '&lt;div class="scope-bullet-list" id="scope-d-businessQuestions"&gt;' +
            (d.businessQuestions || []).map(function (o, i) { return bullet(o, 'businessQuestions', i, '?'); }).join('') +
          '&lt;/div&gt;',
          'question', 'scopeAddBullet(\'businessQuestions\')'
        ) +

        sec('BACKGROUND', 'Project background and motivation.',
          renderToolbar('scope-d-background') +
          '&lt;div class="rich-edit" id="scope-d-background" contenteditable="true"&gt;' + (d.background || '') + '&lt;/div&gt;'
        ) +

        sec('OBJECTIVES', 'Measurable outcomes that define success.',
          '&lt;div class="scope-bullet-list" id="scope-d-objectives"&gt;' +
            (d.objectives || []).map(function (o, i) { return bullet(o, 'objectives', i); }).join('') +
          '&lt;/div&gt;',
          'objective', 'scopeAddBullet(\'objectives\')'
        ) +

        sec('SCOPE', 'What is and is not part of this project.',
          '&lt;div class="scope-two-col"&gt;' +
            '&lt;div&gt;' +
              '&lt;div class="col-label in"&gt;IN SCOPE &lt;button class="add-btn" onclick="scopeAddBullet(\'inScope\')"&gt;+ Add&lt;/button&gt;&lt;/div&gt;' +
              '&lt;div class="scope-bullet-list" id="scope-d-inScope"&gt;' +
                (d.inScope || []).map(function (o, i) { return bullet(o, 'inScope', i, '✓'); }).join('') +
              '&lt;/div&gt;' +
            '&lt;/div&gt;' +
            '&lt;div&gt;' +
              '&lt;div class="col-label out"&gt;OUT OF SCOPE &lt;button class="add-btn" onclick="scopeAddBullet(\'outScope\')"&gt;+ Add&lt;/button&gt;&lt;/div&gt;' +
              '&lt;div class="scope-bullet-list" id="scope-d-outScope"&gt;' +
                (d.outScope || []).map(function (o, i) { return bullet(o, 'outScope', i, '✗'); }).join('') +
              '&lt;/div&gt;' +
            '&lt;/div&gt;' +
          '&lt;/div&gt;'
        ) +

        sec('DELIVERABLES', 'What hands over and how it gets accepted.',
          '&lt;div class="scope-deliverable-list" id="scope-d-deliverables"&gt;' +
            (d.deliverables || []).map(function (dv) {
              return '&lt;div class="scope-deliverable" data-id="' + dv.id + '"&gt;' +
                '&lt;button class="delete-x" onclick="scopeRemoveDeliverable(\'' + dv.id + '\')"&gt;✕&lt;/button&gt;' +
                '&lt;div class="scope-deliverable-head"&gt;' +
                  '&lt;input class="d-title" value="' + escapeHtml(dv.title) + '" placeholder="Deliverable…" data-field="title" /&gt;' +
                  '&lt;input class="d-due" type="date" value="' + (dv.due || '') + '" data-field="due" /&gt;' +
                '&lt;/div&gt;' +
                '&lt;span class="d-accept-label" title="How will you and the stakeholder agree this is done?"&gt;Acceptance criteria&lt;/span&gt;' +
                '&lt;textarea class="d-accept" rows="1" data-field="accept" placeholder="What proves this deliverable is complete? e.g. matches Q3 throughput within ±5%"&gt;' + escapeHtml(dv.accept) + '&lt;/textarea&gt;' +
              '&lt;/div&gt;';
            }).join('') +
          '&lt;/div&gt;',
          'deliverable', 'scopeAddDeliverable()'
        ) +

        sec('DELIVERY CRITERIA', 'Technical bar for "the model is delivered." (e.g. runs on Client computer, all scenarios modeled.)',
          '&lt;div class="scope-bullet-list" id="scope-d-deliveryCriteria"&gt;' +
            (d.deliveryCriteria || []).map(function (o, i) { return bullet(o, 'deliveryCriteria', i, '✓'); }).join('') +
          '&lt;/div&gt;',
          'criterion', 'scopeAddBullet(\'deliveryCriteria\')'
        ) +

        sec('BUSINESS SUCCESS', 'What the model lets the business actually decide. (e.g. "answers whether to add a second shift.")',
          '&lt;div class="scope-bullet-list" id="scope-d-businessSuccess"&gt;' +
            (d.businessSuccess || []).map(function (o, i) { return bullet(o, 'businessSuccess', i, '★'); }).join('') +
          '&lt;/div&gt;',
          'goal', 'scopeAddBullet(\'businessSuccess\')'
        ) +

        sec('ASSUMPTIONS', 'What we\'re assuming to be true — fails if these are wrong.',
          '&lt;div class="scope-bullet-list" id="scope-d-assumptions"&gt;' +
            (d.assumptions || []).map(function (o, i) { return bullet(o, 'assumptions', i); }).join('') +
          '&lt;/div&gt;',
          'assumption', 'scopeAddBullet(\'assumptions\')'
        ) +

        sec('CONSTRAINTS', 'Limits we operate within.',
          '&lt;div class="scope-kv-grid"&gt;' +
            '&lt;div class="scope-kv"&gt;&lt;label&gt;Timeline&lt;/label&gt;&lt;input id="scope-c-timeline" type="text" value="' + escapeHtml(d.constraints.timeline) + '" placeholder="e.g. 6 weeks" /&gt;&lt;/div&gt;' +
            '&lt;div class="scope-kv"&gt;&lt;label&gt;Budget&lt;/label&gt;&lt;input id="scope-c-budget" type="text" value="' + escapeHtml(d.constraints.budget) + '" placeholder="e.g. 120 hours" /&gt;&lt;/div&gt;' +
            '&lt;div class="scope-kv"&gt;&lt;label&gt;Data&lt;/label&gt;&lt;input id="scope-c-data" type="text" value="' + escapeHtml(d.constraints.data) + '" placeholder="e.g. last 6 months of production data only" /&gt;&lt;/div&gt;' +
          '&lt;/div&gt;'
        ) +

        sec('STAKEHOLDERS', 'Who\'s involved and how.',
          '&lt;table class="scope-stakeholder-table"&gt;' +
            '&lt;thead&gt;&lt;tr&gt;&lt;th&gt;Name&lt;/th&gt;&lt;th&gt;Role&lt;/th&gt;&lt;th&gt;Contact&lt;/th&gt;&lt;th&gt;&lt;/th&gt;&lt;/tr&gt;&lt;/thead&gt;' +
            '&lt;tbody id="scope-d-stakeholders"&gt;' +
              (d.stakeholders || []).map(function (s) {
                return '&lt;tr data-id="' + s.id + '"&gt;' +
                  '&lt;td&gt;&lt;input value="' + escapeHtml(s.name) + '" data-field="name" placeholder="Name" /&gt;&lt;/td&gt;' +
                  '&lt;td&gt;&lt;select data-field="role"&gt;' +
                    // Backward-compat: if the stored role isn't in the
                    // current options list (e.g. legacy "Sponsor" /
                    // "Approver" / "SME" / "Reviewer"), render it as an
                    // extra option so the dropdown still shows the
                    // user's existing value instead of silently falling
                    // back to the first option.
                    (s.role &amp;&amp; SCOPE_ROLES.indexOf(s.role) === -1
                      ? '&lt;option selected&gt;' + escapeHtml(s.role) + '&lt;/option&gt;'
                      : '') +
                    SCOPE_ROLES.map(function (r) { return '&lt;option ' + (s.role === r ? 'selected' : '') + '&gt;' + r + '&lt;/option&gt;'; }).join('') +
                  '&lt;/select&gt;&lt;/td&gt;' +
                  '&lt;td&gt;&lt;input value="' + escapeHtml(s.contact) + '" data-field="contact" placeholder="email / phone / notes" /&gt;&lt;/td&gt;' +
                  '&lt;td class="del-cell"&gt;&lt;button onclick="scopeRemoveStakeholder(\'' + s.id + '\')"&gt;✕&lt;/button&gt;&lt;/td&gt;' +
                '&lt;/tr&gt;';
              }).join('') +
            '&lt;/tbody&gt;' +
          '&lt;/table&gt;',
          'stakeholder', 'scopeAddStakeholder()'
        ) +

        sec('MILESTONES', 'Key dates.',
          '&lt;div class="scope-milestone-list" id="scope-d-milestones"&gt;' +
            (d.milestones || []).map(function (m) {
              return '&lt;div class="scope-milestone" data-id="' + m.id + '"&gt;' +
                '&lt;input class="m-date" type="date" value="' + (m.date || '') + '" data-field="date" /&gt;' +
                '&lt;input class="m-label" value="' + escapeHtml(m.label) + '" data-field="label" placeholder="Milestone label…" /&gt;' +
                '&lt;button class="del" onclick="scopeRemoveMilestone(\'' + m.id + '\')"&gt;✕&lt;/button&gt;' +
              '&lt;/div&gt;';
            }).join('') +
          '&lt;/div&gt;',
          'milestone', 'scopeAddMilestone()'
        ) +

        sec('RISKS', 'Known risks. Severity sets the color.',
          '&lt;div class="scope-bullet-list" id="scope-d-risks"&gt;' +
            (d.risks || []).map(function (r) {
              return '&lt;div class="scope-risk" data-id="' + r.id + '"&gt;' +
                '&lt;select class="severity ' + r.severity + '" data-field="severity"&gt;' +
                  SCOPE_SEVERITY.map(function (sv) { return '&lt;option value="' + sv + '" ' + (r.severity === sv ? 'selected' : '') + '&gt;' + sv.toUpperCase() + '&lt;/option&gt;'; }).join('') +
                '&lt;/select&gt;' +
                '&lt;textarea class="r-text" rows="1" data-field="text" placeholder="Risk description…"&gt;' + escapeHtml(r.text) + '&lt;/textarea&gt;' +
                '&lt;button class="del" onclick="scopeRemoveRisk(\'' + r.id + '\')"&gt;✕&lt;/button&gt;' +
              '&lt;/div&gt;';
            }).join('') +
          '&lt;/div&gt;',
          'risk', 'scopeAddRisk()'
        ) +

        sec('OPEN QUESTIONS', 'Things still unresolved.',
          '&lt;div class="scope-bullet-list" id="scope-d-openQuestions"&gt;' +
            (d.openQuestions || []).map(function (o, i) { return bullet(o, 'openQuestions', i, '?'); }).join('') +
          '&lt;/div&gt;',
          'question', 'scopeAddBullet(\'openQuestions\')'
        ) +

        sec('PROJECT ACCEPTANCE', 'The overall bar for "this is done." Distinct from per-deliverable acceptance.',
          renderToolbar('scope-d-acceptance') +
          '&lt;div class="rich-edit" id="scope-d-acceptance" contenteditable="true" data-placeholder="e.g. Model loads and runs on Client\'s computer; all scenarios in §SCENARIOS produce reported KPIs within ±5% of historical baseline."&gt;' + (d.acceptance || '') + '&lt;/div&gt;'
        ) +

        '&lt;div class="scope-sim-group ' + (d.simExpanded ? '' : 'collapsed') + '" id="scope-sim-group"&gt;' +
          '&lt;div class="scope-sim-group-header" onclick="scopeToggleSim()"&gt;' +
            '&lt;h2&gt;SIMULATION ADD-ONS&lt;/h2&gt;' +
            '&lt;span class="desc"&gt;Model-specific scoping. Optional.&lt;/span&gt;' +
            '&lt;span class="toggle"&gt;▶&lt;/span&gt;' +
          '&lt;/div&gt;' +
          '&lt;div class="scope-sim-content"&gt;' +

            sec('MODEL BOUNDARY', 'What\'s inside the model vs. handled as an outside input.',
              renderToolbar('scope-d-modelBoundary') +
              '&lt;div class="rich-edit" id="scope-d-modelBoundary" contenteditable="true" data-placeholder="e.g. Stations 1-4 modeled; upstream receiving treated as an outside input feed…"&gt;' + (d.modelBoundary || '') + '&lt;/div&gt;'
            ) +

            sec('PROCESS DIAGRAMS', 'Documented process baseline. Links to canvases on the Canvases tab.',
              '&lt;div class="scope-process-list" id="scope-d-processDiagrams"&gt;' +
                (d.processDiagrams || []).map(function (pd) {
                  var cv = (state.canvases &amp;&amp; state.canvases.items || []).filter(function (c) { return c.id === pd.canvasId; })[0];
                  var name = cv ? cv.name : '(canvas missing)';
                  return '&lt;div class="scope-process-row" data-id="' + pd.id + '"&gt;' +
                    '&lt;select class="pd-canvas" data-field="canvasId"&gt;' +
                      '&lt;option value=""&gt;— pick a canvas —&lt;/option&gt;' +
                      (state.canvases &amp;&amp; state.canvases.items || []).map(function (c) {
                        return '&lt;option value="' + c.id + '" ' + (pd.canvasId === c.id ? 'selected' : '') + '&gt;' + escapeHtml(c.name) + '&lt;/option&gt;';
                      }).join('') +
                    '&lt;/select&gt;' +
                    '&lt;input class="pd-label" data-field="label" value="' + escapeHtml(pd.label || '') + '" placeholder="What does this diagram show?" /&gt;' +
                    '&lt;button class="pd-open" onclick="scopeOpenProcessCanvas(\'' + pd.id + '\')" title="Open canvas"&gt;↗&lt;/button&gt;' +
                    '&lt;button class="del" onclick="scopeRemoveProcessDiagram(\'' + pd.id + '\')"&gt;✕&lt;/button&gt;' +
                  '&lt;/div&gt;';
                }).join('') +
              '&lt;/div&gt;',
              'diagram', 'scopeAddProcessDiagram()'
            ) +

            sec('FIDELITY LEVEL', 'Granularity of representation.',
              renderToolbar('scope-d-fidelity') +
              '&lt;div class="rich-edit" id="scope-d-fidelity" contenteditable="true" data-placeholder="e.g. Individual workstations, operators as pool…"&gt;' + (d.fidelity || '') + '&lt;/div&gt;'
            ) +

            sec('DATA-DRIVEN PARAMETERS', 'Numeric inputs that drive model behavior. Adjustable by the user after delivery.',
              '&lt;table class="scope-param-table"&gt;' +
                '&lt;thead&gt;&lt;tr&gt;&lt;th&gt;Name&lt;/th&gt;&lt;th&gt;Current&lt;/th&gt;&lt;th&gt;Range / Distribution&lt;/th&gt;&lt;th&gt;Notes&lt;/th&gt;&lt;th&gt;&lt;/th&gt;&lt;/tr&gt;&lt;/thead&gt;' +
                '&lt;tbody id="scope-d-dataDrivenParams"&gt;' +
                  (d.dataDrivenParams || []).map(function (p) {
                    return '&lt;tr data-id="' + p.id + '"&gt;' +
                      '&lt;td&gt;&lt;input value="' + escapeHtml(p.name) + '" data-field="name" placeholder="e.g. Arrival Rate (orders/hr)" /&gt;&lt;/td&gt;' +
                      '&lt;td&gt;&lt;input value="' + escapeHtml(p.current) + '" data-field="current" placeholder="10" /&gt;&lt;/td&gt;' +
                      '&lt;td&gt;&lt;input value="' + escapeHtml(p.range) + '" data-field="range" placeholder="5-20" /&gt;&lt;/td&gt;' +
                      '&lt;td&gt;&lt;input value="' + escapeHtml(p.notes) + '" data-field="notes" placeholder="optional" /&gt;&lt;/td&gt;' +
                      '&lt;td class="del-cell"&gt;&lt;button onclick="scopeRemoveDataDrivenParam(\'' + p.id + '\')"&gt;✕&lt;/button&gt;&lt;/td&gt;' +
                    '&lt;/tr&gt;';
                  }).join('') +
                '&lt;/tbody&gt;' +
              '&lt;/table&gt;',
              'parameter', 'scopeAddDataDrivenParam()'
            ) +

            sec('WHAT-IF PARAMETERS', 'Scenario knobs: discrete swaps, range sweeps, or qualitative changes.',
              '&lt;table class="scope-param-table"&gt;' +
                '&lt;thead&gt;&lt;tr&gt;&lt;th&gt;Name&lt;/th&gt;&lt;th&gt;Kind&lt;/th&gt;&lt;th&gt;Detail&lt;/th&gt;&lt;th&gt;Notes&lt;/th&gt;&lt;th&gt;&lt;/th&gt;&lt;/tr&gt;&lt;/thead&gt;' +
                '&lt;tbody id="scope-d-whatIfParams"&gt;' +
                  (d.whatIfParams || []).map(function (p) {
                    return '&lt;tr data-id="' + p.id + '"&gt;' +
                      '&lt;td&gt;&lt;input value="' + escapeHtml(p.name) + '" data-field="name" placeholder="e.g. Workers at Station A" /&gt;&lt;/td&gt;' +
                      '&lt;td&gt;&lt;select data-field="kind"&gt;' +
                        WHATIF_KINDS.map(function (k) { return '&lt;option value="' + k.v + '" ' + (p.kind === k.v ? 'selected' : '') + '&gt;' + escapeHtml(k.label) + '&lt;/option&gt;'; }).join('') +
                      '&lt;/select&gt;&lt;/td&gt;' +
                      '&lt;td&gt;&lt;input value="' + escapeHtml(p.detail) + '" data-field="detail" placeholder="1, 2, or 3 workers" /&gt;&lt;/td&gt;' +
                      '&lt;td&gt;&lt;input value="' + escapeHtml(p.notes) + '" data-field="notes" placeholder="optional" /&gt;&lt;/td&gt;' +
                      '&lt;td class="del-cell"&gt;&lt;button onclick="scopeRemoveWhatIfParam(\'' + p.id + '\')"&gt;✕&lt;/button&gt;&lt;/td&gt;' +
                    '&lt;/tr&gt;';
                  }).join('') +
              '&lt;/tbody&gt;' +
              '&lt;/table&gt;',
              'what-if', 'scopeAddWhatIfParam()'
            ) +

            sec('VALIDATION CRITERIA', 'Specific checks that prove the model reflects reality.',
              '&lt;div class="scope-bullet-list" id="scope-d-validation"&gt;' +
                (d.validation || []).map(function (o, i) { return bullet(o, 'validation', i); }).join('') +
              '&lt;/div&gt;',
              'criterion', 'scopeAddBullet(\'validation\')'
            ) +

            sec('VALIDATION TIMELINE', 'How much history we compare against and how long the comparison takes.',
              '&lt;div class="scope-kv-grid"&gt;' +
                '&lt;div class="scope-kv"&gt;&lt;label&gt;Historical data window&lt;/label&gt;&lt;input id="scope-vt-window" type="text" value="' + escapeHtml(d.validationTimeline.historicalWindow) + '" placeholder="e.g. last 6 months" /&gt;&lt;/div&gt;' +
                '&lt;div class="scope-kv"&gt;&lt;label&gt;Target validation time&lt;/label&gt;&lt;input id="scope-vt-days" type="text" value="' + escapeHtml(d.validationTimeline.targetDays) + '" placeholder="e.g. 10 business days from data receipt" /&gt;&lt;/div&gt;' +
              '&lt;/div&gt;'
            ) +

            sec('VALIDATION ACCEPTANCE', 'What "validated" actually means — the threshold for declaring it done.',
              renderToolbar('scope-d-validationAcceptance') +
              '&lt;div class="rich-edit" id="scope-d-validationAcceptance" contenteditable="true" data-placeholder="e.g. Model output is within ±5% of historical baseline for every reported KPI, OR documented divergence is explainable by known assumption."&gt;' + (d.validationAcceptance || '') + '&lt;/div&gt;'
            ) +

            sec('DATA SOURCES', 'Where inputs come from (quick list — pair with the structured table below).',
              '&lt;div class="scope-bullet-list" id="scope-d-dataSources"&gt;' +
                (d.dataSources || []).map(function (o, i) { return bullet(o, 'dataSources', i); }).join('') +
              '&lt;/div&gt;',
              'source', 'scopeAddBullet(\'dataSources\')'
            ) +

            sec('DATA REQUIREMENTS', 'Structured list of what Client must provide before modeling can proceed.',
              '&lt;table class="scope-datareq-table"&gt;' +
                '&lt;thead&gt;&lt;tr&gt;&lt;th&gt;Type&lt;/th&gt;&lt;th&gt;Format&lt;/th&gt;&lt;th&gt;Due&lt;/th&gt;&lt;th&gt;Purpose&lt;/th&gt;&lt;th&gt;Status&lt;/th&gt;&lt;th&gt;&lt;/th&gt;&lt;/tr&gt;&lt;/thead&gt;' +
                '&lt;tbody id="scope-d-dataRequirements"&gt;' +
                  (d.dataRequirements || []).map(function (r) {
                    return '&lt;tr data-id="' + r.id + '"&gt;' +
                      '&lt;td&gt;&lt;input value="' + escapeHtml(r.type) + '" data-field="type" placeholder="e.g. CAD layout" /&gt;&lt;/td&gt;' +
                      '&lt;td&gt;&lt;input value="' + escapeHtml(r.format) + '" data-field="format" placeholder="DWG or PDF" /&gt;&lt;/td&gt;' +
                      '&lt;td&gt;&lt;input type="date" value="' + (r.due || '') + '" data-field="due" /&gt;&lt;/td&gt;' +
                      '&lt;td&gt;&lt;input value="' + escapeHtml(r.purpose) + '" data-field="purpose" placeholder="why we need it" /&gt;&lt;/td&gt;' +
                      '&lt;td&gt;&lt;select data-field="status" class="dr-status dr-status-' + escapeHtml(r.status || 'pending') + '"&gt;' +
                        DATA_REQ_STATUS.map(function (s) { return '&lt;option value="' + s + '" ' + ((r.status || 'pending') === s ? 'selected' : '') + '&gt;' + s.toUpperCase() + '&lt;/option&gt;'; }).join('') +
                      '&lt;/select&gt;&lt;/td&gt;' +
                      '&lt;td class="del-cell"&gt;&lt;button onclick="scopeRemoveDataRequirement(\'' + r.id + '\')"&gt;✕&lt;/button&gt;&lt;/td&gt;' +
                    '&lt;/tr&gt;';
                  }).join('') +
                '&lt;/tbody&gt;' +
              '&lt;/table&gt;',
              'requirement', 'scopeAddDataRequirement()'
            ) +

            sec('DATA GAPS', 'What we asked for and didn\'t get. Drives risk and assumption capture.',
              '&lt;div class="scope-bullet-list" id="scope-d-dataGaps"&gt;' +
                (d.dataGaps || []).map(function (o, i) { return bullet(o, 'dataGaps', i, '⚠'); }).join('') +
              '&lt;/div&gt;',
              'gap', 'scopeAddBullet(\'dataGaps\')'
            ) +

            sec('METRICS REPORTED', 'Output measurements the model produces (also called Key Performance Indicators).',
              '&lt;div class="scope-bullet-list" id="scope-d-kpis"&gt;' +
                (d.kpis || []).map(function (o, i) { return bullet(o, 'kpis', i); }).join('') +
              '&lt;/div&gt;',
              'metric', 'scopeAddBullet(\'kpis\')'
            ) +

            sec('CHARTS &amp; DASHBOARDS', 'Visual reports built on the KPIs above (charts, heatmaps, dashboards).',
              '&lt;div class="scope-bullet-list" id="scope-d-charts"&gt;' +
                (d.charts || []).map(function (o, i) { return bullet(o, 'charts', i, '📊'); }).join('') +
              '&lt;/div&gt;',
              'chart', 'scopeAddBullet(\'charts\')'
            ) +

            // Legacy bullet list: only rendered when this doc carries
            // bullet data AND the table is still empty — that's a doc
            // pre-dating the table that we don't want to silently strand.
            // The table is the canonical surface for new and migrated docs.
            ((d.scenarios &amp;&amp; d.scenarios.length &amp;&amp; !(d.scenariosTable &amp;&amp; d.scenariosTable.length))
              ? sec('SCENARIOS (legacy bullets)', 'Migrate these into the table below at your convenience.',
                  '&lt;div class="scope-bullet-list" id="scope-d-scenarios"&gt;' +
                    (d.scenarios || []).map(function (o, i) { return bullet(o, 'scenarios', i); }).join('') +
                  '&lt;/div&gt;',
                  'scenario', 'scopeAddBullet(\'scenarios\')'
                )
              : ''
            ) +

            sec('SCENARIOS', 'One row per scenario, with baseline anchor.',
              '&lt;table class="scope-scenario-table"&gt;' +
                '&lt;thead&gt;&lt;tr&gt;&lt;th style="width:24px;"&gt;Base&lt;/th&gt;&lt;th&gt;Name&lt;/th&gt;&lt;th&gt;Description&lt;/th&gt;&lt;th&gt;Key changes from baseline&lt;/th&gt;&lt;th&gt;&lt;/th&gt;&lt;/tr&gt;&lt;/thead&gt;' +
                '&lt;tbody id="scope-d-scenariosTable"&gt;' +
                  (d.scenariosTable || []).map(function (s) {
                    return '&lt;tr data-id="' + s.id + '"&gt;' +
                      '&lt;td class="base-cell"&gt;&lt;input type="radio" name="scope-baseline" ' + (s.isBaseline ? 'checked' : '') + ' data-field="isBaseline" title="Mark as baseline" /&gt;&lt;/td&gt;' +
                      '&lt;td&gt;&lt;input value="' + escapeHtml(s.name) + '" data-field="name" placeholder="Scenario name" /&gt;&lt;/td&gt;' +
                      '&lt;td&gt;&lt;input value="' + escapeHtml(s.description) + '" data-field="description" placeholder="What this scenario explores" /&gt;&lt;/td&gt;' +
                      '&lt;td&gt;&lt;input value="' + escapeHtml(s.keyChanges) + '" data-field="keyChanges" placeholder="Key changes from baseline" /&gt;&lt;/td&gt;' +
                      '&lt;td class="del-cell"&gt;&lt;button onclick="scopeRemoveScenarioRow(\'' + s.id + '\')"&gt;✕&lt;/button&gt;&lt;/td&gt;' +
                    '&lt;/tr&gt;';
                  }).join('') +
                '&lt;/tbody&gt;' +
              '&lt;/table&gt;',
              'scenario', 'scopeAddScenarioRow()'
            ) +

          '&lt;/div&gt;' +
        '&lt;/div&gt;' +

        '&lt;div class="scope-sim-group ' + (d.trainingExpanded ? '' : 'collapsed') + '" id="scope-training-group"&gt;' +
          '&lt;div class="scope-sim-group-header" onclick="scopeToggleTraining()"&gt;' +
            '&lt;h2&gt;TRAINING &amp;amp; KNOWLEDGE TRANSFER&lt;/h2&gt;' +
            '&lt;span class="desc"&gt;How the Client learns to use what we built.&lt;/span&gt;' +
            '&lt;span class="toggle"&gt;▶&lt;/span&gt;' +
          '&lt;/div&gt;' +
          '&lt;div class="scope-sim-content"&gt;' +

            sec('TRAINING METHOD', 'How knowledge transfer happens.',
              '&lt;div class="scope-training-method" id="scope-d-trainingMethod"&gt;' +
                TRAINING_METHODS.map(function (m) {
                  return '&lt;label class="tm-radio"&gt;' +
                    '&lt;input type="radio" name="scope-trainingMethod" value="' + m.v + '" ' + (d.training.method === m.v ? 'checked' : '') + ' /&gt;' +
                    '&lt;span&gt;' + escapeHtml(m.label) + '&lt;/span&gt;' +
                  '&lt;/label&gt;';
                }).join('') +
                '&lt;input class="tm-other" id="scope-d-trainingOther" value="' + escapeHtml(d.training.otherText || '') + '" placeholder="If \'Other\', describe…" ' + (d.training.method === 'other' ? '' : 'style="display:none;"') + ' /&gt;' +
              '&lt;/div&gt;'
            ) +

            sec('TRAINING CONTENT', 'What gets covered.',
              '&lt;div class="scope-bullet-list" id="scope-d-trainingContent"&gt;' +
                (d.trainingContent || []).map(function (o, i) { return bullet(o, 'trainingContent', i); }).join('') +
              '&lt;/div&gt;',
              'topic', 'scopeAddBullet(\'trainingContent\')'
            ) +

            sec('POST-DELIVERY SUPPORT', 'What happens after handoff.',
              renderToolbar('scope-d-trainingPostSupport') +
              '&lt;div class="rich-edit" id="scope-d-trainingPostSupport" contenteditable="true" data-placeholder="e.g. None. Client is on their own. Or: PracSim available for 5 hrs of support per separate SOW."&gt;' + (d.training.postSupport || '') + '&lt;/div&gt;'
            ) +

          '&lt;/div&gt;' +
        '&lt;/div&gt;' +

        '&lt;div class="scope-sim-group ' + (d.changeLogExpanded ? '' : 'collapsed') + '" id="scope-change-group"&gt;' +
          '&lt;div class="scope-sim-group-header" onclick="scopeToggleChangeLog()"&gt;' +
            '&lt;h2&gt;CHANGE ORDER LOG&lt;/h2&gt;' +
            '&lt;span class="desc"&gt;Running list of scope changes during execution.&lt;/span&gt;' +
            '&lt;span class="toggle"&gt;▶&lt;/span&gt;' +
          '&lt;/div&gt;' +
          '&lt;div class="scope-sim-content"&gt;' +

            sec('CHANGE ORDERS', 'One row per change request.',
              '&lt;table class="scope-co-table"&gt;' +
                '&lt;thead&gt;&lt;tr&gt;&lt;th&gt;Date&lt;/th&gt;&lt;th&gt;Description&lt;/th&gt;&lt;th&gt;Hours impact&lt;/th&gt;&lt;th&gt;Status&lt;/th&gt;&lt;th&gt;&lt;/th&gt;&lt;/tr&gt;&lt;/thead&gt;' +
                '&lt;tbody id="scope-d-changeOrders"&gt;' +
                  (d.changeOrders || []).map(function (co) {
                    return '&lt;tr data-id="' + co.id + '"&gt;' +
                      '&lt;td&gt;&lt;input type="date" value="' + (co.date || '') + '" data-field="date" /&gt;&lt;/td&gt;' +
                      '&lt;td&gt;&lt;input value="' + escapeHtml(co.description) + '" data-field="description" placeholder="What changed and why" /&gt;&lt;/td&gt;' +
                      '&lt;td&gt;&lt;input value="' + escapeHtml(co.hoursImpact) + '" data-field="hoursImpact" placeholder="+8 / -2 / TBD" /&gt;&lt;/td&gt;' +
                      '&lt;td&gt;&lt;select data-field="status" class="co-status co-status-' + escapeHtml(co.status || 'pending') + '"&gt;' +
                        CHANGE_ORDER_STATUS.map(function (s) { return '&lt;option value="' + s + '" ' + ((co.status || 'pending') === s ? 'selected' : '') + '&gt;' + s.toUpperCase() + '&lt;/option&gt;'; }).join('') +
                      '&lt;/select&gt;&lt;/td&gt;' +
                      '&lt;td class="del-cell"&gt;&lt;button onclick="scopeRemoveChangeOrder(\'' + co.id + '\')"&gt;✕&lt;/button&gt;&lt;/td&gt;' +
                    '&lt;/tr&gt;';
                  }).join('') +
                '&lt;/tbody&gt;' +
              '&lt;/table&gt;',
              'change order', 'scopeAddChangeOrder()'
            ) +

          '&lt;/div&gt;' +
        '&lt;/div&gt;' +

        sec('NOTES', 'Free-form notes that don\'t fit anywhere above.',
          renderToolbar('scope-d-notes') +
          '&lt;div class="rich-edit" id="scope-d-notes" contenteditable="true" data-placeholder="Anything else…"&gt;' + (d.notes || '') + '&lt;/div&gt;'
        );

      wireScopeDoc(d);
    }

    function wireScopeDoc(d) {
      function onTitleInput() { d.title = document.getElementById('scope-d-title').value; saveDebounced('scoping'); scopeRefreshSidebar(); }
      var titleEl = document.getElementById('scope-d-title');
      var onelineEl = document.getElementById('scope-d-oneliner');
      if (titleEl) titleEl.addEventListener('input', onTitleInput);
      if (onelineEl) onelineEl.addEventListener('input', function () { d.oneLiner = onelineEl.value; saveDebounced('scoping'); });

      // Per CLAUDE.md rule + memory/feedback_text_windows_require_toolbar.md:
      // every contenteditable in the panel must have the shared formatting
      // toolbar wired up, AND a paste handler so dropped images get routed
      // through saveImage (otherwise the data: URL is stripped on save and
      // the image is silently lost).
      ['background','modelBoundary','fidelity','acceptance','validationAcceptance','notes'].forEach(function (field) {
        var el = document.getElementById('scope-d-' + field);
        if (!el) return;
        var toolbarEl = document.querySelector('.format-toolbar[data-editor="scope-d-' + field + '"]');
        if (toolbarEl) wireToolbar(toolbarEl, el);
        el.addEventListener('input', function () {
          d[field] = el.innerHTML;
          saveDebounced('scoping');
        });
        el.addEventListener('paste', function (e) {
          handlePaste(e, el, function () {
            d[field] = el.innerHTML;
            saveImmediate('scoping');
          });
        });
      });

      // training.postSupport is nested under d.training, so it needs its
      // own writer rather than going through the top-level list above.
      (function () {
        var el = document.getElementById('scope-d-trainingPostSupport');
        if (!el) return;
        var toolbarEl = document.querySelector('.format-toolbar[data-editor="scope-d-trainingPostSupport"]');
        if (toolbarEl) wireToolbar(toolbarEl, el);
        el.addEventListener('input', function () {
          d.training.postSupport = el.innerHTML;
          saveDebounced('scoping');
        });
        el.addEventListener('paste', function (e) {
          handlePaste(e, el, function () {
            d.training.postSupport = el.innerHTML;
            saveImmediate('scoping');
          });
        });
      })();

      document.querySelectorAll('#tab-scoping .scope-bullet').forEach(function (el) {
        var field = el.getAttribute('data-field');
        var idx = parseInt(el.getAttribute('data-idx'), 10);
        var inp = el.querySelector('.bullet-text');
        if (!inp) return;
        autoGrowEl(inp);
        inp.addEventListener('input', function () {
          d[field][idx] = inp.value;
          autoGrowEl(inp);
          saveDebounced('scoping');
          scopeRefreshSidebar();
        });
        inp.addEventListener('keydown', function (e) {
          // Plain Enter creates a new bullet (preserves the old UX);
          // Shift+Enter falls through to default textarea behavior so
          // the user can write multi-line content in a single bullet.
          if (e.key === 'Enter' &amp;&amp; !e.shiftKey) {
            e.preventDefault();
            pushHistory('scoping');
            d[field].splice(idx + 1, 0, '');
            saveDebounced('scoping');
            renderScopeDoc();
            setTimeout(function () {
              var bullets = document.querySelectorAll('#scope-d-' + field + ' .scope-bullet');
              var next = bullets[idx + 1];
              if (next) next.querySelector('.bullet-text').focus();
            }, 0);
          }
          if (e.key === 'Backspace' &amp;&amp; !inp.value &amp;&amp; d[field].length &gt; 0) {
            e.preventDefault();
            pushHistory('scoping');
            d[field].splice(idx, 1);
            saveDebounced('scoping');
            renderScopeDoc();
            setTimeout(function () {
              var bullets = document.querySelectorAll('#scope-d-' + field + ' .scope-bullet');
              var prev = bullets[Math.max(0, idx - 1)];
              if (prev) prev.querySelector('.bullet-text').focus();
            }, 0);
          }
        });
      });

      document.querySelectorAll('#scope-d-deliverables .scope-deliverable').forEach(function (el) {
        var id = el.getAttribute('data-id');
        var dv = d.deliverables.filter(function (x) { return x.id === id; })[0];
        if (!dv) return;
        el.querySelectorAll('[data-field]').forEach(function (inp) {
          var field = inp.getAttribute('data-field');
          var isTextarea = inp.tagName === 'TEXTAREA';
          if (isTextarea) autoGrowEl(inp);
          inp.addEventListener('input', function () {
            dv[field] = inp.value;
            if (isTextarea) autoGrowEl(inp);
            saveDebounced('scoping');
          });
        });
      });

      ['timeline','budget','data'].forEach(function (k) {
        var el = document.getElementById('scope-c-' + k);
        if (el) el.addEventListener('input', function () { d.constraints[k] = el.value; saveDebounced('scoping'); });
      });

      document.querySelectorAll('#scope-d-stakeholders tr').forEach(function (tr) {
        var id = tr.getAttribute('data-id');
        var sh = d.stakeholders.filter(function (x) { return x.id === id; })[0];
        if (!sh) return;
        tr.querySelectorAll('[data-field]').forEach(function (inp) {
          var field = inp.getAttribute('data-field');
          inp.addEventListener('input', function () { sh[field] = inp.value; saveDebounced('scoping'); scopeRefreshSidebar(); });
          inp.addEventListener('change', function () { sh[field] = inp.value; saveDebounced('scoping'); });
        });
      });

      document.querySelectorAll('#scope-d-milestones .scope-milestone').forEach(function (el) {
        var id = el.getAttribute('data-id');
        var m = d.milestones.filter(function (x) { return x.id === id; })[0];
        if (!m) return;
        el.querySelectorAll('[data-field]').forEach(function (inp) {
          var field = inp.getAttribute('data-field');
          inp.addEventListener('input', function () { m[field] = inp.value; saveDebounced('scoping'); });
          inp.addEventListener('change', function () { m[field] = inp.value; saveDebounced('scoping'); });
        });
      });

      document.querySelectorAll('#scope-d-risks .scope-risk').forEach(function (el) {
        var id = el.getAttribute('data-id');
        var r = d.risks.filter(function (x) { return x.id === id; })[0];
        if (!r) return;
        var sev = el.querySelector('select.severity');
        var text = el.querySelector('.r-text');
        if (sev) sev.addEventListener('change', function () {
          r.severity = sev.value;
          sev.classList.remove('low','med','high');
          sev.classList.add(sev.value);
          saveDebounced('scoping');
        });
        if (text) {
          autoGrowEl(text);
          text.addEventListener('input', function () {
            r.text = text.value;
            autoGrowEl(text);
            saveDebounced('scoping');
          });
        }
      });

      // --- new sections (engagement, status, parameters, data req, scenarios table, change orders, training) ---
      (function wireEngagementAndStatus() {
        var eng = document.getElementById('scope-d-engagement');
        if (eng) eng.addEventListener('change', function () {
          d.engagementType = eng.value;
          saveImmediate('scoping');
        });
        var st = document.getElementById('scope-d-status');
        if (st) st.addEventListener('change', function () {
          d.status = st.value;
          st.className = 'status-' + st.value;
          saveImmediate('scoping');
        });
      })();

      // Process diagrams (canvas links)
      document.querySelectorAll('#scope-d-processDiagrams .scope-process-row').forEach(function (el) {
        var id = el.getAttribute('data-id');
        var pd = d.processDiagrams.filter(function (x) { return x.id === id; })[0];
        if (!pd) return;
        el.querySelectorAll('[data-field]').forEach(function (inp) {
          var field = inp.getAttribute('data-field');
          inp.addEventListener('input', function () { pd[field] = inp.value; saveDebounced('scoping'); });
          inp.addEventListener('change', function () { pd[field] = inp.value; saveImmediate('scoping'); });
        });
      });

      // Data-driven parameters
      document.querySelectorAll('#scope-d-dataDrivenParams tr').forEach(function (tr) {
        var id = tr.getAttribute('data-id');
        var p = d.dataDrivenParams.filter(function (x) { return x.id === id; })[0];
        if (!p) return;
        tr.querySelectorAll('[data-field]').forEach(function (inp) {
          var field = inp.getAttribute('data-field');
          inp.addEventListener('input', function () { p[field] = inp.value; saveDebounced('scoping'); });
        });
      });

      // What-if parameters
      document.querySelectorAll('#scope-d-whatIfParams tr').forEach(function (tr) {
        var id = tr.getAttribute('data-id');
        var p = d.whatIfParams.filter(function (x) { return x.id === id; })[0];
        if (!p) return;
        tr.querySelectorAll('[data-field]').forEach(function (inp) {
          var field = inp.getAttribute('data-field');
          inp.addEventListener('input', function () { p[field] = inp.value; saveDebounced('scoping'); });
          inp.addEventListener('change', function () { p[field] = inp.value; saveImmediate('scoping'); });
        });
      });

      // Data requirements table
      document.querySelectorAll('#scope-d-dataRequirements tr').forEach(function (tr) {
        var id = tr.getAttribute('data-id');
        var r = d.dataRequirements.filter(function (x) { return x.id === id; })[0];
        if (!r) return;
        tr.querySelectorAll('[data-field]').forEach(function (inp) {
          var field = inp.getAttribute('data-field');
          inp.addEventListener('input', function () { r[field] = inp.value; saveDebounced('scoping'); });
          inp.addEventListener('change', function () {
            r[field] = inp.value;
            if (field === 'status') {
              inp.className = 'dr-status dr-status-' + inp.value;
            }
            saveImmediate('scoping');
          });
        });
      });

      // Validation timeline kv inputs
      (function () {
        var w = document.getElementById('scope-vt-window');
        if (w) w.addEventListener('input', function () { d.validationTimeline.historicalWindow = w.value; saveDebounced('scoping'); });
        var t = document.getElementById('scope-vt-days');
        if (t) t.addEventListener('input', function () { d.validationTimeline.targetDays = t.value; saveDebounced('scoping'); });
      })();

      // Scenarios table (baseline radio is exclusive across rows)
      document.querySelectorAll('#scope-d-scenariosTable tr').forEach(function (tr) {
        var id = tr.getAttribute('data-id');
        var s = d.scenariosTable.filter(function (x) { return x.id === id; })[0];
        if (!s) return;
        tr.querySelectorAll('[data-field]').forEach(function (inp) {
          var field = inp.getAttribute('data-field');
          if (field === 'isBaseline') {
            inp.addEventListener('change', function () {
              d.scenariosTable.forEach(function (x) { x.isBaseline = false; });
              s.isBaseline = inp.checked;
              saveImmediate('scoping');
            });
          } else {
            inp.addEventListener('input', function () { s[field] = inp.value; saveDebounced('scoping'); });
          }
        });
      });

      // Training method radios + "other" text
      document.querySelectorAll('#scope-d-trainingMethod input[name="scope-trainingMethod"]').forEach(function (inp) {
        inp.addEventListener('change', function () {
          d.training.method = inp.value;
          var other = document.getElementById('scope-d-trainingOther');
          if (other) other.style.display = (inp.value === 'other') ? '' : 'none';
          saveImmediate('scoping');
        });
      });
      (function () {
        var other = document.getElementById('scope-d-trainingOther');
        if (other) other.addEventListener('input', function () { d.training.otherText = other.value; saveDebounced('scoping'); });
      })();

      // Change orders table
      document.querySelectorAll('#scope-d-changeOrders tr').forEach(function (tr) {
        var id = tr.getAttribute('data-id');
        var co = d.changeOrders.filter(function (x) { return x.id === id; })[0];
        if (!co) return;
        tr.querySelectorAll('[data-field]').forEach(function (inp) {
          var field = inp.getAttribute('data-field');
          inp.addEventListener('input', function () { co[field] = inp.value; saveDebounced('scoping'); scopeRefreshSidebar(); });
          inp.addEventListener('change', function () {
            co[field] = inp.value;
            if (field === 'status') {
              inp.className = 'co-status co-status-' + inp.value;
            }
            saveImmediate('scoping');
          });
        });
      });
    }

    function scopeRefreshSidebar() {
      // Update only the sidebar's per-item meta (counts) and titles without
      // re-rendering the doc pane — preserves focus while typing.
      var docs = state.scoping.docs || [];
      var sidebar = document.getElementById('scope-list');
      if (!sidebar) return;
      docs.forEach(function (d) {
        var el = sidebar.querySelector('.scope-item[data-id="' + d.id + '"]');
        if (!el) return;
        var t = el.querySelector('.title');
        var m = el.querySelector('.meta');
        if (t) t.textContent = d.title || 'Untitled';
        if (m) m.textContent = scopeCountSummary(d);
      });
    }

    // Section add/remove handlers (exposed on window so inline onclicks work)
    function scopeAddBullet(field) {
      var d = scopeActiveDoc(); if (!d) return;
      pushHistory('scoping');
      if (!d[field]) d[field] = [];
      d[field].push('');
      saveDebounced('scoping');
      renderScopeDoc();
      setTimeout(function () {
        var bullets = document.querySelectorAll('#scope-d-' + field + ' .scope-bullet');
        var last = bullets[bullets.length - 1];
        if (last) last.querySelector('.bullet-text').focus();
      }, 0);
    }
    function scopeRemoveBullet(field, idx) {
      var d = scopeActiveDoc(); if (!d) return;
      pushHistory('scoping');
      d[field].splice(idx, 1);
      saveDebounced('scoping');
      renderScopeDoc();
    }
    function scopeAddDeliverable() {
      var d = scopeActiveDoc(); if (!d) return;
      pushHistory('scoping');
      d.deliverables = d.deliverables || [];
      d.deliverables.push({ id: newId('dv-'), title: '', due: '', accept: '' });
      saveDebounced('scoping');
      renderScopeDoc();
      setTimeout(function () {
        var items = document.querySelectorAll('#scope-d-deliverables .scope-deliverable .d-title');
        var last = items[items.length - 1];
        if (last) last.focus();
      }, 0);
    }
    function scopeRemoveDeliverable(id) {
      var d = scopeActiveDoc(); if (!d) return;
      pushHistory('scoping');
      d.deliverables = d.deliverables.filter(function (x) { return x.id !== id; });
      saveDebounced('scoping');
      renderScopeDoc();
    }
    function scopeAddStakeholder() {
      var d = scopeActiveDoc(); if (!d) return;
      pushHistory('scoping');
      d.stakeholders = d.stakeholders || [];
      d.stakeholders.push({ id: newId('sh-'), name: '', role: 'Reviewer', contact: '' });
      saveDebounced('scoping');
      renderScopeDoc();
      setTimeout(function () {
        var items = document.querySelectorAll('#scope-d-stakeholders input[data-field="name"]');
        var last = items[items.length - 1];
        if (last) last.focus();
      }, 0);
    }
    function scopeRemoveStakeholder(id) {
      var d = scopeActiveDoc(); if (!d) return;
      pushHistory('scoping');
      d.stakeholders = d.stakeholders.filter(function (x) { return x.id !== id; });
      saveDebounced('scoping');
      renderScopeDoc();
    }
    function scopeAddMilestone() {
      var d = scopeActiveDoc(); if (!d) return;
      pushHistory('scoping');
      d.milestones = d.milestones || [];
      d.milestones.push({ id: newId('ms-'), date: '', label: '' });
      saveDebounced('scoping');
      renderScopeDoc();
      setTimeout(function () {
        var items = document.querySelectorAll('#scope-d-milestones .m-label');
        var last = items[items.length - 1];
        if (last) last.focus();
      }, 0);
    }
    function scopeRemoveMilestone(id) {
      var d = scopeActiveDoc(); if (!d) return;
      pushHistory('scoping');
      d.milestones = d.milestones.filter(function (x) { return x.id !== id; });
      saveDebounced('scoping');
      renderScopeDoc();
    }
    function scopeAddRisk() {
      var d = scopeActiveDoc(); if (!d) return;
      pushHistory('scoping');
      d.risks = d.risks || [];
      d.risks.push({ id: newId('rk-'), text: '', severity: 'med' });
      saveDebounced('scoping');
      renderScopeDoc();
      setTimeout(function () {
        var items = document.querySelectorAll('#scope-d-risks .r-text');
        var last = items[items.length - 1];
        if (last) last.focus();
      }, 0);
    }
    function scopeRemoveRisk(id) {
      var d = scopeActiveDoc(); if (!d) return;
      pushHistory('scoping');
      d.risks = d.risks.filter(function (x) { return x.id !== id; });
      saveDebounced('scoping');
      renderScopeDoc();
    }
    function scopeToggleSim() {
      var d = scopeActiveDoc(); if (!d) return;
      d.simExpanded = !d.simExpanded;
      saveDebounced('scoping');
      var g = document.getElementById('scope-sim-group');
      if (g) g.classList.toggle('collapsed', !d.simExpanded);
    }
    function scopeToggleTraining() {
      var d = scopeActiveDoc(); if (!d) return;
      d.trainingExpanded = !d.trainingExpanded;
      saveDebounced('scoping');
      var g = document.getElementById('scope-training-group');
      if (g) g.classList.toggle('collapsed', !d.trainingExpanded);
    }
    function scopeToggleChangeLog() {
      var d = scopeActiveDoc(); if (!d) return;
      d.changeLogExpanded = !d.changeLogExpanded;
      saveDebounced('scoping');
      var g = document.getElementById('scope-change-group');
      if (g) g.classList.toggle('collapsed', !d.changeLogExpanded);
    }

    // Process diagrams
    function scopeAddProcessDiagram() {
      var d = scopeActiveDoc(); if (!d) return;
      pushHistory('scoping');
      d.processDiagrams = d.processDiagrams || [];
      d.processDiagrams.push({ id: newId('pd-'), canvasId: '', label: '' });
      saveDebounced('scoping');
      renderScopeDoc();
    }
    function scopeRemoveProcessDiagram(id) {
      var d = scopeActiveDoc(); if (!d) return;
      pushHistory('scoping');
      d.processDiagrams = d.processDiagrams.filter(function (x) { return x.id !== id; });
      saveDebounced('scoping');
      renderScopeDoc();
    }
    function scopeOpenProcessCanvas(id) {
      var d = scopeActiveDoc(); if (!d) return;
      var pd = d.processDiagrams.filter(function (x) { return x.id === id; })[0];
      if (!pd || !pd.canvasId) { alert('Pick a canvas first.'); return; }
      var cv = (state.canvases &amp;&amp; state.canvases.items || []).filter(function (c) { return c.id === pd.canvasId; })[0];
      if (!cv) { alert('That canvas no longer exists.'); return; }
      state.canvases.activeId = pd.canvasId;
      saveImmediate('canvases');
      activateTab('canvases');
    }

    // Data-driven parameters
    function scopeAddDataDrivenParam() {
      var d = scopeActiveDoc(); if (!d) return;
      pushHistory('scoping');
      d.dataDrivenParams = d.dataDrivenParams || [];
      d.dataDrivenParams.push({ id: newId('dp-'), name: '', current: '', range: '', notes: '' });
      saveDebounced('scoping');
      renderScopeDoc();
      setTimeout(function () {
        var rows = document.querySelectorAll('#scope-d-dataDrivenParams tr input[data-field="name"]');
        var last = rows[rows.length - 1];
        if (last) last.focus();
      }, 0);
    }
    function scopeRemoveDataDrivenParam(id) {
      var d = scopeActiveDoc(); if (!d) return;
      pushHistory('scoping');
      d.dataDrivenParams = d.dataDrivenParams.filter(function (x) { return x.id !== id; });
      saveDebounced('scoping');
      renderScopeDoc();
    }

    // What-if parameters
    function scopeAddWhatIfParam() {
      var d = scopeActiveDoc(); if (!d) return;
      pushHistory('scoping');
      d.whatIfParams = d.whatIfParams || [];
      d.whatIfParams.push({ id: newId('wp-'), name: '', kind: 'swap', detail: '', notes: '' });
      saveDebounced('scoping');
      renderScopeDoc();
      setTimeout(function () {
        var rows = document.querySelectorAll('#scope-d-whatIfParams tr input[data-field="name"]');
        var last = rows[rows.length - 1];
        if (last) last.focus();
      }, 0);
    }
    function scopeRemoveWhatIfParam(id) {
      var d = scopeActiveDoc(); if (!d) return;
      pushHistory('scoping');
      d.whatIfParams = d.whatIfParams.filter(function (x) { return x.id !== id; });
      saveDebounced('scoping');
      renderScopeDoc();
    }

    // Data requirements table
    function scopeAddDataRequirement() {
      var d = scopeActiveDoc(); if (!d) return;
      pushHistory('scoping');
      d.dataRequirements = d.dataRequirements || [];
      d.dataRequirements.push({ id: newId('dr-'), type: '', format: '', due: '', purpose: '', status: 'pending' });
      saveDebounced('scoping');
      renderScopeDoc();
      setTimeout(function () {
        var rows = document.querySelectorAll('#scope-d-dataRequirements tr input[data-field="type"]');
        var last = rows[rows.length - 1];
        if (last) last.focus();
      }, 0);
    }
    function scopeRemoveDataRequirement(id) {
      var d = scopeActiveDoc(); if (!d) return;
      pushHistory('scoping');
      d.dataRequirements = d.dataRequirements.filter(function (x) { return x.id !== id; });
      saveDebounced('scoping');
      renderScopeDoc();
    }

    // Scenarios table
    function scopeAddScenarioRow() {
      var d = scopeActiveDoc(); if (!d) return;
      pushHistory('scoping');
      d.scenariosTable = d.scenariosTable || [];
      d.scenariosTable.push({ id: newId('sn-'), name: '', description: '', keyChanges: '', isBaseline: false });
      saveDebounced('scoping');
      renderScopeDoc();
      setTimeout(function () {
        var rows = document.querySelectorAll('#scope-d-scenariosTable tr input[data-field="name"]');
        var last = rows[rows.length - 1];
        if (last) last.focus();
      }, 0);
    }
    function scopeRemoveScenarioRow(id) {
      var d = scopeActiveDoc(); if (!d) return;
      pushHistory('scoping');
      d.scenariosTable = d.scenariosTable.filter(function (x) { return x.id !== id; });
      saveDebounced('scoping');
      renderScopeDoc();
    }

    // Change orders
    function scopeAddChangeOrder() {
      var d = scopeActiveDoc(); if (!d) return;
      pushHistory('scoping');
      d.changeOrders = d.changeOrders || [];
      var today = (new Date()).toISOString().slice(0, 10);
      d.changeOrders.push({ id: newId('co-'), date: today, description: '', hoursImpact: '', status: 'pending' });
      saveDebounced('scoping');
      renderScopeDoc();
      setTimeout(function () {
        var rows = document.querySelectorAll('#scope-d-changeOrders tr input[data-field="description"]');
        var last = rows[rows.length - 1];
        if (last) last.focus();
      }, 0);
    }
    function scopeRemoveChangeOrder(id) {
      var d = scopeActiveDoc(); if (!d) return;
      pushHistory('scoping');
      d.changeOrders = d.changeOrders.filter(function (x) { return x.id !== id; });
      saveDebounced('scoping');
      renderScopeDoc();
    }

    // Expose the inline-onclick handlers on window
    window.scopeAddDoc          = scopeAddDoc;
    window.scopeAddBullet       = scopeAddBullet;
    window.scopeRemoveBullet    = scopeRemoveBullet;
    window.scopeAddDeliverable  = scopeAddDeliverable;
    window.scopeRemoveDeliverable = scopeRemoveDeliverable;
    window.scopeAddStakeholder  = scopeAddStakeholder;
    window.scopeRemoveStakeholder = scopeRemoveStakeholder;
    window.scopeAddMilestone    = scopeAddMilestone;
    window.scopeRemoveMilestone = scopeRemoveMilestone;
    window.scopeAddRisk         = scopeAddRisk;
    window.scopeRemoveRisk      = scopeRemoveRisk;
    window.scopeToggleSim       = scopeToggleSim;
    window.scopeToggleTraining  = scopeToggleTraining;
    window.scopeToggleChangeLog = scopeToggleChangeLog;
    window.scopeAddProcessDiagram    = scopeAddProcessDiagram;
    window.scopeRemoveProcessDiagram = scopeRemoveProcessDiagram;
    window.scopeOpenProcessCanvas    = scopeOpenProcessCanvas;
    window.scopeAddDataDrivenParam    = scopeAddDataDrivenParam;
    window.scopeRemoveDataDrivenParam = scopeRemoveDataDrivenParam;
    window.scopeAddWhatIfParam        = scopeAddWhatIfParam;
    window.scopeRemoveWhatIfParam     = scopeRemoveWhatIfParam;
    window.scopeAddDataRequirement    = scopeAddDataRequirement;
    window.scopeRemoveDataRequirement = scopeRemoveDataRequirement;
    window.scopeAddScenarioRow        = scopeAddScenarioRow;
    window.scopeRemoveScenarioRow     = scopeRemoveScenarioRow;
    window.scopeAddChangeOrder        = scopeAddChangeOrder;
    window.scopeRemoveChangeOrder     = scopeRemoveChangeOrder;

    // --- validation tab ---
    // Per-run capture of model inputs (Model.parameters), outputs
    // (Model.performanceMeasures), manual change notes, and three
    // rich-text sections (Observations / Analysis / Next Steps).
    // For interactive single runs only — FlexSim's Experimenter
    // handles multi-replication batches.

    var valFilter = '';   // search filter on run names

    function valGetRuns() {
      if (!state.validation) state.validation = defaultValidation();
      return state.validation.runs;
    }
    function valActiveRun() {
      var v = state.validation || defaultValidation();
      if (!v.runs.length) return null;
      var r = v.runs.filter(function (x) { return x.id === v.activeRunId; })[0];
      return r || v.runs[0];
    }
    function valFilteredRuns() {
      var runs = valGetRuns();
      if (!valFilter) return runs;
      var q = valFilter.toLowerCase();
      return runs.filter(function (r) { return (r.name || '').toLowerCase().indexOf(q) !== -1; });
    }
    function valFmtDate(iso) {
      if (!iso) return '—';
      try {
        var d = new Date(iso);
        return d.toLocaleDateString(undefined, { month: 'short', day: 'numeric' }) +
               ' ' + d.toLocaleTimeString(undefined, { hour: '2-digit', minute: '2-digit' });
      } catch (e) { return iso; }
    }

    function renderValidationTab() {
      var pane = document.getElementById('tab-validation');
      if (!pane) return;
      var run = valActiveRun();

      var sidebarHtml =
        '&lt;aside class="val-sidebar"&gt;' +
          '&lt;div class="sidebar-head"&gt;' +
            '&lt;div class="actions"&gt;' +
              '&lt;button id="val-add-btn" title="Add an empty run (fill in values by hand)"&gt;+ Add empty run&lt;/button&gt;' +
              '&lt;button id="val-snapshot-btn" class="primary" title="Capture current model parameters and performance measures into a new run"&gt;📷 Snapshot&lt;/button&gt;' +
            '&lt;/div&gt;' +
            '&lt;input class="val-search" id="val-search" placeholder="Search runs…" value="' + escapeHtml(valFilter) + '" /&gt;' +
          '&lt;/div&gt;' +
          '&lt;div class="val-list" id="val-list"&gt;' + renderValSidebarList() + '&lt;/div&gt;' +
        '&lt;/aside&gt;';

      var paneHtml = run
        ? renderValRunPane(run)
        : '&lt;main class="val-pane empty"&gt;' +
            '&lt;div class="big"&gt;📋&lt;/div&gt;' +
            '&lt;div&gt;&lt;strong&gt;No runs captured yet.&lt;/strong&gt;&lt;/div&gt;' +
            '&lt;p&gt;Click &lt;strong&gt;📷 Snapshot&lt;/strong&gt; to capture this model\'s current parameter values and performance measures into a new run, or &lt;strong&gt;+ Add empty run&lt;/strong&gt; to type values manually.&lt;/p&gt;' +
          '&lt;/main&gt;';

      pane.innerHTML = tabUndoBarHtml('validation') + '&lt;div class="val-layout"&gt;' + sidebarHtml + paneHtml + '&lt;/div&gt;';
      updateTabUndoButtons('validation');

      wireValidationTab();
    }

    function renderValSidebarList() {
      var runs = valFilteredRuns();
      if (!runs.length) {
        return '&lt;div class="val-list-empty"&gt;' +
          (valFilter ? 'No runs match the search.' : 'No runs yet.') +
        '&lt;/div&gt;';
      }
      var activeId = (state.validation || defaultValidation()).activeRunId;
      return runs.map(function (r) {
        var active = (r.id === activeId) ? ' active' : '';
        var meta = valFmtDate(r.createdAt) +
                   (r.parameters &amp;&amp; r.parameters.length ? ' · ' + r.parameters.length + ' params' : ' · empty');
        return '&lt;div class="val-list-item' + active + '" data-id="' + escapeHtml(r.id) + '"&gt;' +
                 '&lt;div class="vl-name"&gt;' + escapeHtml(r.name || 'Untitled run') + '&lt;/div&gt;' +
                 '&lt;div class="vl-meta"&gt;' + escapeHtml(meta) + '&lt;/div&gt;' +
               '&lt;/div&gt;';
      }).join('');
    }

    function renderValRunPane(run) {
      function sec(label, desc, body, actionBtnHtml) {
        return '&lt;section class="val-section"&gt;' +
          '&lt;div class="val-section-header"&gt;' +
            '&lt;h2&gt;' + label + '&lt;/h2&gt;' +
            (actionBtnHtml || '') +
            (desc ? '&lt;span class="desc"&gt;' + escapeHtml(desc) + '&lt;/span&gt;' : '') +
          '&lt;/div&gt;' + body +
        '&lt;/section&gt;';
      }

      function tableHtml(rows, which) {
        if (!rows || !rows.length) {
          return '&lt;div class="val-table-empty"&gt;Empty — click 📷 above to snapshot from the current model, or add rows manually (no UI yet for that — use Snapshot).&lt;/div&gt;';
        }
        var trs = rows.map(function (row, i) {
          return '&lt;tr&gt;' +
            '&lt;td class="col-name editable" contenteditable="true" data-vfield="name" data-vtable="' + which + '" data-vidx="' + i + '"&gt;' + escapeHtml(String(row.name || '')) + '&lt;/td&gt;' +
            '&lt;td class="col-value editable" contenteditable="true" data-vfield="value" data-vtable="' + which + '" data-vidx="' + i + '"&gt;' + escapeHtml(valDisplayValue(row.value)) + '&lt;/td&gt;' +
            '&lt;td class="col-units editable" contenteditable="true" data-vfield="units" data-vtable="' + which + '" data-vidx="' + i + '"&gt;' + escapeHtml(String(row.units || '')) + '&lt;/td&gt;' +
            '&lt;td class="col-desc editable" contenteditable="true" data-vfield="description" data-vtable="' + which + '" data-vidx="' + i + '"&gt;' + escapeHtml(String(row.description || '')) + '&lt;/td&gt;' +
          '&lt;/tr&gt;';
        }).join('');
        return '&lt;table class="val-table"&gt;' +
          '&lt;thead&gt;&lt;tr&gt;' +
            '&lt;th&gt;Name&lt;/th&gt;&lt;th&gt;Value&lt;/th&gt;&lt;th&gt;Units&lt;/th&gt;&lt;th&gt;Description&lt;/th&gt;' +
          '&lt;/tr&gt;&lt;/thead&gt;' +
          '&lt;tbody&gt;' + trs + '&lt;/tbody&gt;' +
        '&lt;/table&gt;';
      }

      function changesHtml(changes) {
        var rows = (changes || []).map(function (c, i) {
          return '&lt;div class="val-change" data-vcidx="' + i + '"&gt;' +
            '&lt;span class="bullet"&gt;•&lt;/span&gt;' +
            '&lt;textarea class="change-text" rows="1"&gt;' + escapeHtml(c) + '&lt;/textarea&gt;' +
            '&lt;button class="del" onclick="valRemoveChange(' + i + ')" title="remove"&gt;✕&lt;/button&gt;' +
          '&lt;/div&gt;';
        }).join('');
        return '&lt;div class="val-changes-list" id="val-changes"&gt;' + rows + '&lt;/div&gt;';
      }

      var paramSnap = '&lt;button class="action-btn snap-btn" onclick="valSnapshotTable(\'parameters\')" title="Re-snapshot just this table from the current model"&gt;📷&lt;/button&gt;';
      var pmSnap    = '&lt;button class="action-btn snap-btn" onclick="valSnapshotTable(\'performanceMeasures\')" title="Re-snapshot just this table from the current model"&gt;📷&lt;/button&gt;';
      var changeAdd = '&lt;button class="action-btn" onclick="valAddChange()"&gt;+ Add change&lt;/button&gt;';

      return '&lt;main class="val-pane"&gt;' +
        '&lt;div class="val-run-head"&gt;' +
          '&lt;input class="val-run-name" id="val-run-name" value="' + escapeHtml(run.name || '') + '" placeholder="Run name…" /&gt;' +
          '&lt;button class="val-run-del" id="val-run-del"&gt;✕ Delete run&lt;/button&gt;' +
        '&lt;/div&gt;' +
        '&lt;div class="val-run-meta"&gt;' +
          'Created ' + escapeHtml(valFmtDate(run.createdAt)) +
          ' · Snapshot ' + escapeHtml(valFmtDate(run.snapshotAt)) +
          (run.modifiedAt &amp;&amp; run.modifiedAt !== run.createdAt ? ' · Modified ' + escapeHtml(valFmtDate(run.modifiedAt)) : '') +
        '&lt;/div&gt;' +

        sec('INPUTS — Model parameters', 'Captured from Model.parameters at snapshot time.', tableHtml(run.parameters, 'parameters'), paramSnap) +
        sec('OUTPUTS — Performance measures', 'Captured from Model.performanceMeasures at snapshot time.', tableHtml(run.performanceMeasures, 'performanceMeasures'), pmSnap) +

        sec('MANUAL CHANGES', 'Non-parameter modifications (e.g. "moved machines to a different location").', changesHtml(run.changes), changeAdd) +

        sec('OBSERVATIONS', 'What you saw.',
          renderToolbar('val-r-observations') +
          '&lt;div class="val-rich-edit" id="val-r-observations" contenteditable="true" data-placeholder="What did you observe in this run?"&gt;' + (run.observations || '') + '&lt;/div&gt;'
        ) +
        sec('ANALYSIS', 'Why you think it happened.',
          renderToolbar('val-r-analysis') +
          '&lt;div class="val-rich-edit" id="val-r-analysis" contenteditable="true" data-placeholder="What\'s your interpretation?"&gt;' + (run.analysis || '') + '&lt;/div&gt;'
        ) +
        sec('NEXT STEPS', 'Follow-on actions.',
          renderToolbar('val-r-nextSteps') +
          '&lt;div class="val-rich-edit" id="val-r-nextSteps" contenteditable="true" data-placeholder="What will you try next?"&gt;' + (run.nextSteps || '') + '&lt;/div&gt;'
        ) +

        '&lt;div class="val-footer-note"&gt;' +
          'For interactive single runs only. Use FlexSim\'s ' +
          '&lt;a href="#" onclick="return false;" style="color:var(--accent);text-decoration:none;cursor:default;"&gt;Experimenter&lt;/a&gt;' +
          ' for multi-replication batch experiments.' +
        '&lt;/div&gt;' +
      '&lt;/main&gt;';
    }

    // Numbers display as their JS representation; other Variants are
    // JSON-stringified so the user sees something parseable. Editing a
    // cell stores the result as a string (round-trip via JSON.parse if
    // it parses cleanly, otherwise stored as string).
    function valDisplayValue(v) {
      if (v === null || v === undefined) return '';
      if (typeof v === 'number' || typeof v === 'boolean') return String(v);
      if (typeof v === 'string') return v;
      try { return JSON.stringify(v); } catch (e) { return String(v); }
    }
    function valParseCellValue(s) {
      if (s === null || s === undefined) return '';
      var t = String(s).trim();
      if (t === '') return '';
      // Try numeric
      if (/^-?\d+(\.\d+)?$/.test(t)) return Number(t);
      if (t === 'true')  return true;
      if (t === 'false') return false;
      // Try JSON for arrays/objects/quoted strings
      if (t[0] === '{' || t[0] === '[' || t[0] === '"') {
        try { return JSON.parse(t); } catch (e) { /* fall through */ }
      }
      return t;
    }

    function wireValidationTab() {
      var run = valActiveRun();

      // Sidebar header — Add + Snapshot
      var addBtn  = document.getElementById('val-add-btn');
      var snapBtn = document.getElementById('val-snapshot-btn');
      if (addBtn)  addBtn.addEventListener('click', valAddEmpty);
      if (snapBtn) snapBtn.addEventListener('click', valSnapshot);

      // Search box
      var searchEl = document.getElementById('val-search');
      if (searchEl) {
        searchEl.addEventListener('input', function () {
          valFilter = searchEl.value;
          var listEl = document.getElementById('val-list');
          if (listEl) listEl.innerHTML = renderValSidebarList();
          attachValSidebarHandlers();
        });
      }
      attachValSidebarHandlers();

      if (!run) return;

      // Run-name input
      var nameEl = document.getElementById('val-run-name');
      if (nameEl) {
        nameEl.addEventListener('input', function () {
          run.name = nameEl.value;
          run.modifiedAt = new Date().toISOString();
          saveDebounced('validation');
          // Refresh sidebar name without a full re-render
          var item = document.querySelector('.val-list-item[data-id="' + run.id + '"] .vl-name');
          if (item) item.textContent = run.name || 'Untitled run';
        });
        nameEl.addEventListener('keydown', function (e) {
          if (e.key === 'Enter') { e.preventDefault(); nameEl.blur(); }
        });
      }

      // Delete-run button
      var delEl = document.getElementById('val-run-del');
      if (delEl) delEl.addEventListener('click', function () {
        if (!confirm('Delete run "' + (run.name || 'Untitled') + '"? This can\'t be undone via the Trash, but Ctrl+Z will bring it back.')) return;
        pushHistory();
        state.validation.runs = state.validation.runs.filter(function (x) { return x.id !== run.id; });
        if (state.validation.activeRunId === run.id) {
          state.validation.activeRunId = state.validation.runs.length ? state.validation.runs[0].id : null;
        }
        saveImmediate('validation');
        renderValidationTab();
      });

      // Table-cell edits
      document.querySelectorAll('#tab-validation .val-table td.editable').forEach(function (td) {
        td.addEventListener('blur', function () {
          var which = td.dataset.vtable;
          var idx   = +td.dataset.vidx;
          var field = td.dataset.vfield;
          var rows  = (which === 'parameters') ? run.parameters : run.performanceMeasures;
          if (!rows[idx]) return;
          if (field === 'value') {
            var parsed = valParseCellValue(td.textContent);
            if (rows[idx].value === parsed) return;
            rows[idx].value = parsed;
          } else {
            var newVal = td.textContent.trim();
            if (rows[idx][field] === newVal) return;
            rows[idx][field] = newVal;
          }
          run.modifiedAt = new Date().toISOString();
          saveImmediate('validation');
        });
        td.addEventListener('keydown', function (e) {
          if (e.key === 'Enter') { e.preventDefault(); td.blur(); }
        });
      });

      // Manual-change bullets
      document.querySelectorAll('#tab-validation .val-change').forEach(function (el) {
        var ta = el.querySelector('textarea.change-text');
        if (!ta) return;
        var idx = +el.dataset.vcidx;
        autoGrowEl(ta);
        ta.addEventListener('input', function () {
          run.changes[idx] = ta.value;
          run.modifiedAt = new Date().toISOString();
          autoGrowEl(ta);
          saveDebounced('validation');
        });
        ta.addEventListener('keydown', function (e) {
          if (e.key === 'Enter' &amp;&amp; !e.shiftKey) {
            e.preventDefault();
            pushHistory();
            run.changes.splice(idx + 1, 0, '');
            run.modifiedAt = new Date().toISOString();
            saveImmediate('validation');
            renderValidationTab();
            // Focus the newly-inserted bullet
            var next = document.querySelector('#tab-validation .val-change[data-vcidx="' + (idx + 1) + '"] textarea.change-text');
            if (next) next.focus();
          }
          if (e.key === 'Backspace' &amp;&amp; !ta.value &amp;&amp; run.changes.length &gt; 0) {
            e.preventDefault();
            pushHistory();
            run.changes.splice(idx, 1);
            saveImmediate('validation');
            renderValidationTab();
            var prev = document.querySelector('#tab-validation .val-change[data-vcidx="' + Math.max(0, idx - 1) + '"] textarea.change-text');
            if (prev) prev.focus();
          }
        });
      });

      // Rich-text sections — same C1 pattern as Scoping: toolbar + paste handler
      ['observations', 'analysis', 'nextSteps'].forEach(function (field) {
        var el = document.getElementById('val-r-' + field);
        if (!el) return;
        var toolbarEl = document.querySelector('.format-toolbar[data-editor="val-r-' + field + '"]');
        if (toolbarEl) wireToolbar(toolbarEl, el);
        el.addEventListener('input', function () {
          run[field] = el.innerHTML;
          run.modifiedAt = new Date().toISOString();
          saveDebounced('validation');
        });
        el.addEventListener('paste', function (e) {
          handlePaste(e, el, function () {
            run[field] = el.innerHTML;
            saveImmediate('validation');
          });
        });
      });
    }

    function attachValSidebarHandlers() {
      document.querySelectorAll('#tab-validation .val-list-item').forEach(function (el) {
        el.addEventListener('click', function () {
          var id = el.dataset.id;
          valSwitch(id);
        });
      });
    }

    function valSwitch(runId) {
      // Flush any pending edits on the current run before swapping
      if (saveStatus === 'pending') saveImmediate('validation');
      if (!state.validation) state.validation = defaultValidation();
      state.validation.activeRunId = runId;
      saveImmediate('validation');
      renderValidationTab();
    }

    function valAddEmpty() {
      pushHistory();
      if (!state.validation) state.validation = defaultValidation();
      var run = {
        id: newId('v'),
        name: 'Run ' + (state.validation.runs.length + 1),
        createdAt: new Date().toISOString(),
        modifiedAt: new Date().toISOString(),
        snapshotAt: null,
        pinned: false,
        parameters: [],
        performanceMeasures: [],
        changes: [],
        observations: '',
        analysis: '',
        nextSteps: ''
      };
      state.validation.runs.unshift(run);
      state.validation.activeRunId = run.id;
      saveImmediate('validation');
      activateTab('validation');
      // Focus name input for immediate rename
      setTimeout(function () {
        var n = document.getElementById('val-run-name');
        if (n) { n.focus(); n.select(); }
      }, 50);
    }

    function valSnapshot() {
      var btn = document.getElementById('val-snapshot-btn');
      if (btn) { btn.disabled = true; btn.textContent = '📷 Snapshotting…'; }
      snapshotModelStateFromHost(function (data) {
        if (btn) { btn.disabled = false; btn.textContent = '📷 Snapshot'; }
        if (!data.parameters.length &amp;&amp; !data.performanceMeasures.length) {
          alert('This model has no parameter tables or performance measures defined yet.\n\nOpen Toolbox → Add → Model Parameter Table (and Performance Measure Table) to create them, then try Snapshot again.');
          return;
        }
        pushHistory();
        if (!state.validation) state.validation = defaultValidation();
        var now = new Date().toISOString();
        var run = {
          id: newId('v'),
          name: 'Run ' + (state.validation.runs.length + 1),
          createdAt: now,
          modifiedAt: now,
          snapshotAt: now,
          pinned: false,
          parameters: data.parameters,
          performanceMeasures: data.performanceMeasures,
          changes: [],
          observations: '',
          analysis: '',
          nextSteps: ''
        };
        state.validation.runs.unshift(run);
        state.validation.activeRunId = run.id;
        saveImmediate('validation');
        activateTab('validation');
        setTimeout(function () {
          var n = document.getElementById('val-run-name');
          if (n) { n.focus(); n.select(); }
        }, 50);
      });
    }

    function valSnapshotTable(which) {
      var run = valActiveRun();
      if (!run) return;
      var currentRows = (which === 'parameters') ? run.parameters : run.performanceMeasures;
      if (currentRows.length &gt; 0) {
        var label = (which === 'parameters') ? 'Inputs' : 'Outputs';
        if (!confirm('Replace the current ' + label + ' table with the model\'s current values? Other parts of the run are unchanged.')) return;
      }
      snapshotModelStateFromHost(function (data) {
        pushHistory();
        if (which === 'parameters') run.parameters = data.parameters;
        else                        run.performanceMeasures = data.performanceMeasures;
        run.snapshotAt = new Date().toISOString();
        run.modifiedAt = run.snapshotAt;
        saveImmediate('validation');
        renderValidationTab();
      });
    }

    function valAddChange() {
      var run = valActiveRun();
      if (!run) return;
      pushHistory();
      run.changes.push('');
      run.modifiedAt = new Date().toISOString();
      saveImmediate('validation');
      renderValidationTab();
      // Focus the newly-added bullet
      setTimeout(function () {
        var last = document.querySelectorAll('#tab-validation .val-change textarea.change-text');
        if (last.length) last[last.length - 1].focus();
      }, 50);
    }
    function valRemoveChange(idx) {
      var run = valActiveRun();
      if (!run) return;
      pushHistory();
      run.changes.splice(idx, 1);
      run.modifiedAt = new Date().toISOString();
      saveImmediate('validation');
      renderValidationTab();
    }

    window.valSnapshotTable = valSnapshotTable;
    window.valAddChange     = valAddChange;
    window.valRemoveChange  = valRemoveChange;

    // --- notes tab ---
    function renderNotesTab() {
      var pane = document.getElementById('tab-notes');
      var items = state.notes.items;
      var activeId = state.notes.activeNoteId;
      var active = items.filter(function (n) { return n.id === activeId; })[0];

      var sidebarHtml = items.map(function (n) {
        var cls = 'note-item' + (n.id === activeId ? ' active' : '');
        return '&lt;div class="' + cls + '" data-id="' + n.id + '" draggable="true"&gt;' +
          '&lt;span class="name"&gt;' + escapeHtml(n.name) + '&lt;/span&gt;' +
          '&lt;button class="menu-btn" data-action="delete" data-id="' + n.id + '" title="Delete"&gt;×&lt;/button&gt;' +
          '&lt;/div&gt;';
      }).join('');

      var editorHtml = active
        ? '&lt;div class="note-header"&gt;' +
            '&lt;input class="note-name-input" id="note-name" value="' + escapeHtml(active.name) + '" /&gt;' +
          '&lt;/div&gt;' +
          renderToolbar('note-body') +
          '&lt;div class="note-body" id="note-body" contenteditable="true"&gt;' + rehydrateBody(active.body) + '&lt;/div&gt;'
        : '&lt;div class="empty-state"&gt;No notes yet. Click &lt;strong&gt;+ Add note&lt;/strong&gt; to create one.&lt;/div&gt;';

      pane.innerHTML =
        tabUndoBarHtml('notes') +
        '&lt;div class="notes-layout"&gt;' +
          '&lt;div class="notes-sidebar"&gt;' +
            '&lt;button class="add-note-btn" id="add-note-btn"&gt;+ Add note&lt;/button&gt;' +
            sidebarHtml +
          '&lt;/div&gt;' +
          '&lt;div class="notes-editor"&gt;' + editorHtml + '&lt;/div&gt;' +
        '&lt;/div&gt;';
      updateTabUndoButtons('notes');

      // Wire up sidebar clicks (switch note)
      pane.querySelectorAll('.note-item').forEach(function (el) {
        el.addEventListener('click', function (e) {
          if (e.target.classList.contains('menu-btn')) return;
          switchActiveNote(el.getAttribute('data-id'));
        });
      });

      // Wire up delete buttons
      pane.querySelectorAll('.menu-btn[data-action="delete"]').forEach(function (btn) {
        btn.addEventListener('click', function (e) {
          e.stopPropagation();
          deleteNote(btn.getAttribute('data-id'));
        });
      });

      // Add-note button
      var addBtn = document.getElementById('add-note-btn');
      if (addBtn) addBtn.addEventListener('click', addNote);

      // Drag-reorder the notes sidebar list.
      var notesSidebar = pane.querySelector('.notes-sidebar');
      if (notesSidebar) {
        wireDragReorder(notesSidebar, '.note-item', state.notes.items, function () {
          saveDebounced('notes');
          renderNotesTab();
        });
      }

      // Wire up name input (blur = save, Enter = blur)
      var nameInput = document.getElementById('note-name');
      if (nameInput) {
        nameInput.addEventListener('blur', function () {
          renameActiveNote(nameInput.value);
        });
        nameInput.addEventListener('keydown', function (e) {
          if (e.key === 'Enter') { e.preventDefault(); nameInput.blur(); }
        });
      }

      // Wire the formatting toolbar above the body editor.
      var noteToolbar = pane.querySelector('.format-toolbar[data-editor="note-body"]');

      // Wire up body (contenteditable). Debounced save while typing,
      // immediate on blur, paste handler intercepts images.
      var bodyDiv = document.getElementById('note-body');
      if (noteToolbar &amp;&amp; bodyDiv) wireToolbar(noteToolbar, bodyDiv);
      if (bodyDiv) {
        bodyDiv.addEventListener('input', function () {
          if (!active) return;
          active.body = stripDataUrls(bodyDiv.innerHTML);
          saveDebounced();
        });
        bodyDiv.addEventListener('blur', function () {
          if (saveStatus === 'pending') saveImmediate();
        });
        bodyDiv.addEventListener('paste', function (e) {
          handlePaste(e, bodyDiv, function () {
            if (!active) return;
            active.body = stripDataUrls(bodyDiv.innerHTML);
            // Use immediate save so the new image reference is persisted
            // promptly and GC won't kill its node on the next save.
            saveImmediate();
          });
        });
        // Note: do NOT override Enter. Native contenteditable Enter
        // creates real block elements (&lt;div&gt;/&lt;p&gt;) which is what
        // execCommand list / heading formatting needs to work.
      }
    }

    function switchActiveNote(id) {
      if (saveStatus === 'pending') saveImmediate();
      state.notes.activeNoteId = id;
      saveImmediate();
      renderNotesTab();
    }

    function addNote() {
      pushHistory();
      var id = newId('n');
      state.notes.items.push({ id: id, name: 'Untitled', body: '' });
      state.notes.activeNoteId = id;
      saveImmediate();
      renderNotesTab();
      var nameInput = document.getElementById('note-name');
      if (nameInput) { nameInput.focus(); nameInput.select(); }
    }

    function renameActiveNote(newName) {
      var id = state.notes.activeNoteId;
      var note = state.notes.items.filter(function (n) { return n.id === id; })[0];
      if (!note) return;
      var trimmed = (newName || '').trim();
      if (!trimmed) trimmed = 'Untitled';
      if (note.name === trimmed) return;
      pushHistory();
      note.name = trimmed;
      saveImmediate();
      renderNotesTab();
    }

    function deleteNote(id) {
      var note = state.notes.items.filter(function (n) { return n.id === id; })[0];
      if (!note) return;
      confirmDialog('Delete note "' + note.name + '"?').then(function (ok) {
        if (!ok) return;
        pushHistory();
        state.notes.items = state.notes.items.filter(function (n) { return n.id !== id; });
        if (state.notes.activeNoteId === id) {
          state.notes.activeNoteId = state.notes.items.length ? state.notes.items[0].id : null;
        }
        saveImmediate();
        renderNotesTab();
      });
    }

    // --- board tab ---
    var PRIORITIES = ['high', 'med', 'low'];
    var PRIORITY_LABELS = { high: 'High', med: 'Med', low: 'Low' };

    function cardsIn(columnId, priority) {
      return state.board.cards
        .filter(function (c) { return c.columnId === columnId &amp;&amp; c.priority === priority; })
        .sort(function (a, b) { return a.rank - b.rank; });
    }

    function findCard(id) {
      return state.board.cards.filter(function (c) { return c.id === id; })[0];
    }

    function renderBoardTab() {
      var pane = document.getElementById('tab-board');
      var cols = state.board.columns;
      var panelOpen = !!findCard(selectedCardId);
      var panelW = (state.board.panelWidth || 320) + 'px';

      var html = '&lt;div class="board-layout' + (panelOpen ? ' with-panel' : '') +
                 '" style="--panel-w: ' + panelW + '"&gt;';
      html += '&lt;div class="board-main"&gt;';

      html += '&lt;div class="board-controls"&gt;';
      html +=   '&lt;button id="add-card-btn"&gt;+ Add card&lt;/button&gt;';
      html +=   '&lt;button id="add-column-btn"&gt;+ Add column&lt;/button&gt;';
      html += '&lt;/div&gt;';

      // .board-scroll is the actual scroll container. Sticky col-heads /
      // row-heads pin to its padding-box edge, so it has no padding-left
      // or padding-top — the grid below absorbs that spacing instead.
      html += '&lt;div class="board-scroll"&gt;';
      html += '&lt;div class="board-grid" style="--col-count: ' + cols.length + '"&gt;';
      // Header row: corner cell (sticky top+left) + column heads (sticky top)
      html += '&lt;div class="corner"&gt;&lt;/div&gt;';
      cols.forEach(function (col) {
        html += '&lt;div class="col-head"&gt;' +
                  '&lt;input class="name-input" data-column-id="' + col.id + '" value="' + escapeHtml(col.name) + '" /&gt;' +
                  '&lt;button class="col-menu" data-column-id="' + col.id + '" title="Delete column"&gt;×&lt;/button&gt;' +
                '&lt;/div&gt;';
      });

      PRIORITIES.forEach(function (pri) {
        html += '&lt;div class="row-head ' + pri + '"&gt;' + PRIORITY_LABELS[pri] + '&lt;/div&gt;';
        cols.forEach(function (col) {
          html += '&lt;div class="cell" data-column-id="' + col.id + '" data-priority="' + pri + '"&gt;';
          cardsIn(col.id, pri).forEach(function (card) {
            html += renderCard(card);
          });
          html += '&lt;/div&gt;';
        });
      });

      html += '&lt;/div&gt;'; // board-grid
      html += '&lt;/div&gt;'; // board-scroll
      html += '&lt;/div&gt;'; // board-main

      // Drag-to-resize handle + properties panel (only meaningful when open)
      if (panelOpen) {
        html += '&lt;div class="board-divider" id="board-divider" title="Drag to resize"&gt;&lt;/div&gt;';
      }
      html += '&lt;div class="board-panel" id="properties-panel"&gt;&lt;/div&gt;';

      html += '&lt;/div&gt;'; // board-layout

      pane.innerHTML = tabUndoBarHtml('board') + html;
      updateTabUndoButtons('board');

      wireBoard();
      renderPropertiesPanel();
    }

    // Card on the board: title-only, draggable, click to select.
    // All editing happens in the properties panel.
    function renderCard(card) {
      var sel = (card.id === selectedCardId) ? ' selected' : '';
      return '&lt;div class="card priority-' + card.priority + sel + '" data-card-id="' + card.id + '" draggable="true"&gt;' +
        '&lt;div class="card-title-display"&gt;' + escapeHtml(card.title || 'Untitled') + '&lt;/div&gt;' +
      '&lt;/div&gt;';
    }

    function wireBoard() {
      var pane = document.getElementById('tab-board');

      // Card click selects the card and opens the properties panel.
      // Drag is HTML5-native — if dragstart fires, click won't.
      pane.querySelectorAll('.card').forEach(function (cardEl) {
        cardEl.addEventListener('click', function () {
          var id = cardEl.getAttribute('data-card-id');
          if (selectedCardId === id) return;
          // Flush any pending typing in the currently-open panel before
          // switching to a different card.
          if (saveStatus === 'pending') saveImmediate();
          selectedCardId = id;
          renderBoardTab();
        });
      });

      // Add-card button
      var addBtn = document.getElementById('add-card-btn');
      if (addBtn) addBtn.addEventListener('click', addCardAndSelect);

      // Properties-panel resize handle
      var dividerEl = document.getElementById('board-divider');
      if (dividerEl) {
        dividerEl.addEventListener('mousedown', function (e) {
          e.preventDefault();
          var layoutEl = pane.querySelector('.board-layout');
          if (!layoutEl) return;
          dividerEl.classList.add('dragging');
          var startX = e.clientX;
          var startW = state.board.panelWidth || 320;
          function onMove(ev) {
            // Dragging the divider LEFT grows the panel; RIGHT shrinks it.
            var dx = startX - ev.clientX;
            var newW = Math.max(220, Math.min(800, startW + dx));
            layoutEl.style.setProperty('--panel-w', newW + 'px');
          }
          function onUp() {
            document.removeEventListener('mousemove', onMove);
            document.removeEventListener('mouseup', onUp);
            dividerEl.classList.remove('dragging');
            var pxStr = layoutEl.style.getPropertyValue('--panel-w');
            var finalW = parseInt(pxStr, 10) || (state.board.panelWidth || 320);
            if (finalW !== state.board.panelWidth) {
              state.board.panelWidth = finalW;
              saveImmediate();
            }
          }
          document.addEventListener('mousemove', onMove);
          document.addEventListener('mouseup', onUp);
        });
      }

      // Column rename (blur saves)
      pane.querySelectorAll('.col-head .name-input').forEach(function (input) {
        input.addEventListener('blur', function () {
          var col = state.board.columns.filter(function (c) { return c.id === input.getAttribute('data-column-id'); })[0];
          if (!col) return;
          var trimmed = (input.value || '').trim();
          if (!trimmed) trimmed = 'Untitled column';
          if (col.name === trimmed) return;
          pushHistory();
          col.name = trimmed;
          saveImmediate();
        });
        input.addEventListener('keydown', function (e) {
          if (e.key === 'Enter') { e.preventDefault(); input.blur(); }
        });
      });

      // Column delete
      pane.querySelectorAll('.col-menu').forEach(function (btn) {
        btn.addEventListener('click', function () {
          deleteColumn(btn.getAttribute('data-column-id'));
        });
      });

      // Disable delete when only 2 columns left
      var atMin = state.board.columns.length &lt;= 2;
      pane.querySelectorAll('.col-menu').forEach(function (btn) {
        btn.disabled = atMin;
        btn.style.opacity = atMin ? 0.3 : 1;
        btn.style.cursor = atMin ? 'not-allowed' : 'pointer';
      });

      var addColBtn = document.getElementById('add-column-btn');
      if (addColBtn) addColBtn.addEventListener('click', addColumn);

      // Drag and drop
      var draggingId = null;
      pane.querySelectorAll('.card').forEach(function (cardEl) {
        cardEl.addEventListener('dragstart', function (e) {
          draggingId = cardEl.getAttribute('data-card-id');
          cardEl.classList.add('dragging');
          if (e.dataTransfer) {
            e.dataTransfer.effectAllowed = 'move';
            e.dataTransfer.setData('text/plain', draggingId); // required by Firefox
          }
        });
        cardEl.addEventListener('dragend', function () {
          cardEl.classList.remove('dragging');
          pane.querySelectorAll('.cell.drop-target').forEach(function (c) { c.classList.remove('drop-target'); });
          draggingId = null;
        });
      });

      pane.querySelectorAll('.cell').forEach(function (cellEl) {
        cellEl.addEventListener('dragover', function (e) {
          e.preventDefault();
          if (e.dataTransfer) e.dataTransfer.dropEffect = 'move';
          cellEl.classList.add('drop-target');
        });
        cellEl.addEventListener('dragleave', function () {
          cellEl.classList.remove('drop-target');
        });
        cellEl.addEventListener('drop', function (e) {
          e.preventDefault();
          cellEl.classList.remove('drop-target');
          if (!draggingId) return;
          var card = findCard(draggingId);
          if (!card) return;
          var targetColumnId = cellEl.getAttribute('data-column-id');
          var targetPriority = cellEl.getAttribute('data-priority');

          // Determine drop rank: count existing cards in target cell that
          // appear above the cursor.
          var cardsInTarget = cardsIn(targetColumnId, targetPriority).filter(function (c) { return c.id !== card.id; });
          var newRank = cardsInTarget.length;
          var cardEls = cellEl.querySelectorAll('.card');
          for (var i = 0; i &lt; cardEls.length; i++) {
            if (cardEls[i].getAttribute('data-card-id') === card.id) continue;
            var ceRect = cardEls[i].getBoundingClientRect();
            if (e.clientY &lt; ceRect.top + ceRect.height / 2) {
              newRank = i;
              break;
            }
          }

          moveCard(card.id, targetColumnId, targetPriority, newRank);
        });
      });
    }

    function moveCard(cardId, columnId, priority, rank) {
      var card = findCard(cardId);
      if (!card) return;
      var wasSamePosition = (card.columnId === columnId &amp;&amp; card.priority === priority &amp;&amp; card.rank === rank);
      if (wasSamePosition) return;
      pushHistory();

      // Remove the card from its current cell's rank ordering.
      var siblings = cardsIn(columnId, priority).filter(function (c) { return c.id !== cardId; });
      // Insert at the desired rank.
      siblings.splice(Math.max(0, Math.min(rank, siblings.length)), 0, card);
      // Reassign ranks within the cell.
      siblings.forEach(function (c, i) { c.rank = i; });

      // Update the moved card's cell coordinates.
      card.columnId = columnId;
      card.priority = priority;

      saveImmediate();
      renderBoardTab();
    }

    function addColumn() {
      pushHistory();
      var id = newId('c');
      state.board.columns.push({ id: id, name: 'New column' });
      saveImmediate();
      renderBoardTab();
      // Focus the new column's name input so the user can rename immediately
      var input = document.querySelector('.col-head .name-input[data-column-id="' + id + '"]');
      if (input) { input.focus(); input.select(); }
    }

    function deleteColumn(id) {
      if (state.board.columns.length &lt;= 2) return;
      var col = state.board.columns.filter(function (c) { return c.id === id; })[0];
      if (!col) return;
      var cardsInCol = state.board.cards.filter(function (c) { return c.columnId === id; });
      var proceed;
      if (cardsInCol.length === 0) {
        proceed = Promise.resolve(true);
      } else {
        proceed = confirmDialog('Delete column "' + col.name + '" and its ' + cardsInCol.length + ' card(s)?');
      }
      proceed.then(function (ok) {
        if (!ok) return;
        pushHistory();
        state.board.columns = state.board.columns.filter(function (c) { return c.id !== id; });
        state.board.cards = state.board.cards.filter(function (c) { return c.columnId !== id; });
        saveImmediate();
        renderBoardTab();
      });
    }

    // Create a new card with sensible defaults and immediately open
    // the properties panel on it, focused on the title input.
    function addCardAndSelect() {
      if (!state.board.columns.length) return;
      pushHistory();
      var defaultColumn = state.board.columns[0].id;
      var defaultPriority = getSettings().defaultCardPriority || 'med';
      var maxRank = state.board.cards
        .filter(function (c) { return c.columnId === defaultColumn &amp;&amp; c.priority === defaultPriority; })
        .reduce(function (m, c) { return Math.max(m, c.rank); }, -1);
      var id = newId('card-');
      state.board.cards.push({
        id: id,
        title: 'Untitled',
        body: '',
        columnId: defaultColumn,
        priority: defaultPriority,
        rank: maxRank + 1
      });
      selectedCardId = id;
      saveImmediate();
      renderBoardTab();
      var titleInput = document.getElementById('panel-title');
      if (titleInput) { titleInput.focus(); titleInput.select(); }
    }

    // Render the right-side properties panel for the currently-selected
    // card. No-op (hides the panel) when nothing is selected.
    function renderPropertiesPanel() {
      var host = document.getElementById('properties-panel');
      if (!host) return;
      var card = findCard(selectedCardId);
      if (!card) {
        host.innerHTML = '';
        return;
      }

      var colOptions = state.board.columns.map(function (c) {
        var sel = (c.id === card.columnId) ? ' selected' : '';
        return '&lt;option value="' + c.id + '"' + sel + '&gt;' + escapeHtml(c.name) + '&lt;/option&gt;';
      }).join('');

      var priOptions = '' +
        '&lt;option value="high"' + (card.priority === 'high' ? ' selected' : '') + '&gt;High&lt;/option&gt;' +
        '&lt;option value="med"'  + (card.priority === 'med'  ? ' selected' : '') + '&gt;Med&lt;/option&gt;' +
        '&lt;option value="low"'  + (card.priority === 'low'  ? ' selected' : '') + '&gt;Low&lt;/option&gt;';

      host.innerHTML =
        '&lt;div class="panel-header"&gt;' +
          '&lt;span&gt;Card&lt;/span&gt;' +
          '&lt;button class="panel-close" id="panel-close" title="Close (Esc)"&gt;×&lt;/button&gt;' +
        '&lt;/div&gt;' +
        '&lt;label class="panel-label"&gt;Title&lt;/label&gt;' +
        '&lt;input class="panel-input" id="panel-title" value="' + escapeHtml(card.title) + '" /&gt;' +
        '&lt;div class="panel-row"&gt;' +
          '&lt;div&gt;' +
            '&lt;label class="panel-label"&gt;Column&lt;/label&gt;' +
            '&lt;select id="panel-column"&gt;' + colOptions + '&lt;/select&gt;' +
          '&lt;/div&gt;' +
          '&lt;div&gt;' +
            '&lt;label class="panel-label"&gt;Priority&lt;/label&gt;' +
            '&lt;select id="panel-priority"&gt;' + priOptions + '&lt;/select&gt;' +
          '&lt;/div&gt;' +
        '&lt;/div&gt;' +
        '&lt;label class="panel-label"&gt;Body&lt;/label&gt;' +
        renderToolbar('panel-body') +
        '&lt;div class="panel-body-editor" id="panel-body" contenteditable="true"&gt;' +
          rehydrateBody(card.body) +
        '&lt;/div&gt;' +
        '&lt;button class="panel-delete" id="panel-delete"&gt;Delete card&lt;/button&gt;';

      wirePropertiesPanel(card.id);
    }

    function wirePropertiesPanel(cardId) {
      var closeBtn = document.getElementById('panel-close');
      if (closeBtn) closeBtn.addEventListener('click', closeProperties);

      var titleInput = document.getElementById('panel-title');
      if (titleInput) {
        titleInput.addEventListener('blur', function () {
          var c = findCard(cardId);
          if (!c) return;
          var trimmed = (titleInput.value || '').trim();
          if (!trimmed) trimmed = 'Untitled';
          if (c.title === trimmed) return;
          pushHistory();
          c.title = trimmed;
          saveImmediate();
          // Refresh the card label on the board without a full re-render.
          var label = document.querySelector('.card[data-card-id="' + c.id + '"] .card-title-display');
          if (label) label.textContent = c.title;
        });
        titleInput.addEventListener('keydown', function (e) {
          if (e.key === 'Enter') { e.preventDefault(); titleInput.blur(); }
        });
      }

      var colSelect = document.getElementById('panel-column');
      if (colSelect) colSelect.addEventListener('change', function () {
        var c = findCard(cardId);
        if (!c) return;
        pushHistory();
        c.columnId = colSelect.value;
        // Move to the end of the new cell.
        var maxRank = state.board.cards
          .filter(function (x) { return x.id !== c.id &amp;&amp; x.columnId === c.columnId &amp;&amp; x.priority === c.priority; })
          .reduce(function (m, x) { return Math.max(m, x.rank); }, -1);
        c.rank = maxRank + 1;
        saveImmediate();
        renderBoardTab();
      });

      var priSelect = document.getElementById('panel-priority');
      if (priSelect) priSelect.addEventListener('change', function () {
        var c = findCard(cardId);
        if (!c) return;
        pushHistory();
        c.priority = priSelect.value;
        var maxRank = state.board.cards
          .filter(function (x) { return x.id !== c.id &amp;&amp; x.columnId === c.columnId &amp;&amp; x.priority === c.priority; })
          .reduce(function (m, x) { return Math.max(m, x.rank); }, -1);
        c.rank = maxRank + 1;
        saveImmediate();
        renderBoardTab();
      });

      var panelToolbar = document.querySelector('.format-toolbar[data-editor="panel-body"]');
      var bodyDiv = document.getElementById('panel-body');
      if (panelToolbar &amp;&amp; bodyDiv) wireToolbar(panelToolbar, bodyDiv);
      if (bodyDiv) {
        bodyDiv.addEventListener('input', function () {
          var c = findCard(cardId);
          if (!c) return;
          c.body = stripDataUrls(bodyDiv.innerHTML);
          saveDebounced();
        });
        bodyDiv.addEventListener('blur', function () {
          if (saveStatus === 'pending') saveImmediate();
        });
        bodyDiv.addEventListener('paste', function (e) {
          handlePaste(e, bodyDiv, function () {
            var c = findCard(cardId);
            if (!c) return;
            c.body = stripDataUrls(bodyDiv.innerHTML);
            saveImmediate();
          });
        });
        // Note: do NOT override Enter. Native contenteditable Enter
        // creates real block elements (&lt;div&gt;/&lt;p&gt;) which is what
        // execCommand list / heading formatting needs to work.
      }

      var del = document.getElementById('panel-delete');
      if (del) del.addEventListener('click', function () {
        var c = findCard(cardId);
        if (!c) return;
        confirmDialog('Delete card "' + c.title + '"?').then(function (ok) {
          if (!ok) return;
          pushHistory();
          state.board.cards = state.board.cards.filter(function (x) { return x.id !== c.id; });
          selectedCardId = null;
          saveImmediate();
          renderBoardTab();
        });
      });
    }

    function closeProperties() {
      if (saveStatus === 'pending') saveImmediate();
      selectedCardId = null;
      renderBoardTab();
    }


    // ============================================================
    // --- canvases tab ---
    // Multi-canvas drawing surface. Tools: select, 6 shape types
    // (rectangle, rounded rect, ellipse, diamond, triangle, hexagon),
    // line, arrow, free-draw (pen), text, image. Each shape supports
    // stroke color/width and fill color. Double-click a shape to edit
    // the text label centered inside it.
    // ============================================================
    var canvasTool = 'select';
    // Stroke default follows theme until the user explicitly picks a
    // swatch. Cold start in dark mode → white pen, light mode → black.
    // Once canvasStrokeIsDefault flips false (user clicked a swatch),
    // theme toggles stop overriding their choice.
    var canvasStroke = '#ffffff';
    var canvasStrokeIsDefault = true;
    var canvasFill = 'transparent';
    var canvasStrokeWidth = 2;
    var canvasFillOpacity = 1;  // 0..1 — fill opacity for new shapes / selected shape edits
    var canvasSelectedShapeIds = {}; // map of id -&gt; true (multi-select)
    var canvasInteraction = null;    // { mode, ... }
    var canvasSpaceDown = false;     // hold Space + drag to pan
    // Zoom clamp shared by wheel / +/- buttons / fit-to-screen. Lower
    // bound lets Fit to Screen accommodate shapes spread far apart.
    var CNV_ZOOM_MIN = 0.05;
    var CNV_ZOOM_MAX = 8;
    // Global undo/redo. Snapshots the entire `state` object (excluding
    // the imageCache which lives only in JS memory, not in state). One
    // stack covers Notes, Board, and Canvases — every discrete mutation
    // pushes a snapshot via pushHistory() and Ctrl+Z/Y restore them.
    // NB: `history` is reserved on `window` (the browser History API),
    // so we avoid that name — `undoStack` / `redoStack` are unambiguous.
    // 2026-06-02: per-tab history. FlexSim's WebPanel host eats Ctrl+Z
    // before it reaches CEF, so undo/redo is button-driven now; per-tab
    // stacks mean undoing on Scoping can't accidentally revert canvas
    // shape work or vice versa. Each tab snapshots ONLY its own state
    // subtree (state.scoping, state.notes, …) so the JSON payload stays
    // small and tabs are fully isolated.
    var HISTORY = {
      scoping:    { undo: [], redo: [] },
      notes:      { undo: [], redo: [] },
      board:      { undo: [], redo: [] },
      canvases:   { undo: [], redo: [] },
      validation: { undo: [], redo: [] }
    };
    var HISTORY_MAX = 60;
    var canvasSettingsOpen = false;

    var CNV_STROKE_COLORS = ['#000000', '#dc2626', '#ea580c', '#ca8a04', '#16a34a', '#2563eb', '#9333ea', '#ffffff'];
    // Saturated fills that mirror the stroke palette — use the opacity
    // slider to lighten when you want a tint instead of swapping to a
    // pale color permanently.
    var CNV_FILL_COLORS   = ['transparent', '#ffffff', '#dc2626', '#ea580c', '#ca8a04', '#16a34a', '#2563eb', '#9333ea'];

    // Inline SVG icons for the canvas toolbar. 16×16 viewBox, currentColor
    // so they pick up the button's text color (and active highlight).
    var CNV_TOOL_ICONS = {
      select:    '&lt;svg viewBox="0 0 16 16"&gt;&lt;path d="M3 1.5l8.5 8.5-4 0.7L10 14l-1.5 1L6 11l-3 3z" fill="currentColor"/&gt;&lt;/svg&gt;',
      rect:      '&lt;svg viewBox="0 0 16 16"&gt;&lt;rect x="2.5" y="3.5" width="11" height="9" fill="none" stroke="currentColor" stroke-width="1.5"/&gt;&lt;/svg&gt;',
      roundrect: '&lt;svg viewBox="0 0 16 16"&gt;&lt;rect x="2.5" y="3.5" width="11" height="9" rx="2.5" ry="2.5" fill="none" stroke="currentColor" stroke-width="1.5"/&gt;&lt;/svg&gt;',
      ellipse:   '&lt;svg viewBox="0 0 16 16"&gt;&lt;ellipse cx="8" cy="8" rx="6" ry="4.5" fill="none" stroke="currentColor" stroke-width="1.5"/&gt;&lt;/svg&gt;',
      diamond:   '&lt;svg viewBox="0 0 16 16"&gt;&lt;polygon points="8,2 14,8 8,14 2,8" fill="none" stroke="currentColor" stroke-width="1.5" stroke-linejoin="round"/&gt;&lt;/svg&gt;',
      triangle:  '&lt;svg viewBox="0 0 16 16"&gt;&lt;polygon points="8,2.5 14,13 2,13" fill="none" stroke="currentColor" stroke-width="1.5" stroke-linejoin="round"/&gt;&lt;/svg&gt;',
      hexagon:   '&lt;svg viewBox="0 0 16 16"&gt;&lt;polygon points="5,2 11,2 14,8 11,14 5,14 2,8" fill="none" stroke="currentColor" stroke-width="1.5" stroke-linejoin="round"/&gt;&lt;/svg&gt;',
      line:      '&lt;svg viewBox="0 0 16 16"&gt;&lt;line x1="3" y1="13" x2="13" y2="3" stroke="currentColor" stroke-width="1.6" stroke-linecap="round"/&gt;&lt;/svg&gt;',
      arrow:     '&lt;svg viewBox="0 0 16 16"&gt;&lt;line x1="3" y1="13" x2="12" y2="4" stroke="currentColor" stroke-width="1.6" stroke-linecap="round"/&gt;&lt;polyline points="7,3 13,3 13,9" fill="none" stroke="currentColor" stroke-width="1.6" stroke-linecap="round" stroke-linejoin="round"/&gt;&lt;/svg&gt;',
      freedraw:  '&lt;svg viewBox="0 0 16 16"&gt;&lt;path d="M2 12 Q 4 6 7 10 T 14 7" fill="none" stroke="currentColor" stroke-width="1.6" stroke-linecap="round"/&gt;&lt;/svg&gt;',
      text:      '&lt;svg viewBox="0 0 16 16"&gt;&lt;path d="M3 3h10v2H9.5v9h-3V5H3z" fill="currentColor"/&gt;&lt;/svg&gt;',
      image:     '&lt;svg viewBox="0 0 16 16"&gt;&lt;rect x="2" y="3" width="12" height="10" rx="1" fill="none" stroke="currentColor" stroke-width="1.5"/&gt;&lt;circle cx="5.5" cy="6.5" r="1.2" fill="currentColor"/&gt;&lt;path d="M2.5 12.5l3.5-3 3 2.5 2-2 4 4" fill="none" stroke="currentColor" stroke-width="1.5" stroke-linejoin="round"/&gt;&lt;/svg&gt;'
    };

    // Align / distribute icons. Each shows two reference rectangles +
    // an alignment guide so you can read at a glance which edge they're
    // aligning to.
    var CNV_ALIGN_ICONS = {
      alignL: '&lt;svg viewBox="0 0 16 16"&gt;&lt;line x1="2" y1="2" x2="2" y2="14" stroke="currentColor" stroke-width="1.4"/&gt;&lt;rect x="3.5" y="4" width="5" height="3" fill="currentColor"/&gt;&lt;rect x="3.5" y="9" width="9" height="3" fill="currentColor"/&gt;&lt;/svg&gt;',
      alignC: '&lt;svg viewBox="0 0 16 16"&gt;&lt;line x1="8" y1="2" x2="8" y2="14" stroke="currentColor" stroke-width="1.4"/&gt;&lt;rect x="5.5" y="4" width="5" height="3" fill="currentColor"/&gt;&lt;rect x="3.5" y="9" width="9" height="3" fill="currentColor"/&gt;&lt;/svg&gt;',
      alignR: '&lt;svg viewBox="0 0 16 16"&gt;&lt;line x1="14" y1="2" x2="14" y2="14" stroke="currentColor" stroke-width="1.4"/&gt;&lt;rect x="7.5" y="4" width="5" height="3" fill="currentColor"/&gt;&lt;rect x="3.5" y="9" width="9" height="3" fill="currentColor"/&gt;&lt;/svg&gt;',
      alignT: '&lt;svg viewBox="0 0 16 16"&gt;&lt;line x1="2" y1="2" x2="14" y2="2" stroke="currentColor" stroke-width="1.4"/&gt;&lt;rect x="4" y="3.5" width="3" height="5" fill="currentColor"/&gt;&lt;rect x="9" y="3.5" width="3" height="9" fill="currentColor"/&gt;&lt;/svg&gt;',
      alignM: '&lt;svg viewBox="0 0 16 16"&gt;&lt;line x1="2" y1="8" x2="14" y2="8" stroke="currentColor" stroke-width="1.4"/&gt;&lt;rect x="4" y="5.5" width="3" height="5" fill="currentColor"/&gt;&lt;rect x="9" y="3.5" width="3" height="9" fill="currentColor"/&gt;&lt;/svg&gt;',
      alignB: '&lt;svg viewBox="0 0 16 16"&gt;&lt;line x1="2" y1="14" x2="14" y2="14" stroke="currentColor" stroke-width="1.4"/&gt;&lt;rect x="4" y="7.5" width="3" height="5" fill="currentColor"/&gt;&lt;rect x="9" y="3.5" width="3" height="9" fill="currentColor"/&gt;&lt;/svg&gt;',
      distH:  '&lt;svg viewBox="0 0 16 16"&gt;&lt;rect x="2" y="5" width="3" height="6" fill="currentColor"/&gt;&lt;rect x="6.5" y="5" width="3" height="6" fill="currentColor"/&gt;&lt;rect x="11" y="5" width="3" height="6" fill="currentColor"/&gt;&lt;/svg&gt;',
      distV:  '&lt;svg viewBox="0 0 16 16"&gt;&lt;rect x="5" y="2" width="6" height="3" fill="currentColor"/&gt;&lt;rect x="5" y="6.5" width="6" height="3" fill="currentColor"/&gt;&lt;rect x="5" y="11" width="6" height="3" fill="currentColor"/&gt;&lt;/svg&gt;'
    };

    function cnvSettings() {
      if (!state.canvases.settings) state.canvases.settings = defaultCanvasSettings();
      return state.canvases.settings;
    }
    function isShapeSelected(id) { return !!canvasSelectedShapeIds[id]; }
    function selectOnlyShape(id) { canvasSelectedShapeIds = {}; if (id) canvasSelectedShapeIds[id] = true; }
    function selectedShapeIds() { return Object.keys(canvasSelectedShapeIds); }
    function clearShapeSelection() { canvasSelectedShapeIds = {}; }
    function snap(v) {
      var s = cnvSettings();
      if (!s.snapToGrid) return v;
      var g = s.gridSize || 20;
      return Math.round(v / g) * g;
    }

    // Push a snapshot of the current canvases items onto the undo stack.
    // Call BEFORE any mutation that should be undoable. Clears the redo
    // stack (since a new action invalidates the previous redo chain).
    // --- selection-shape helpers (used by copy/align/group/z-order) ---
    // Bounding box for any shape type. Used for align/distribute math.
    function shapeBBox(s) {
      if (s.type === 'line' || s.type === 'arrow') {
        return { x: Math.min(s.x1, s.x2), y: Math.min(s.y1, s.y2),
                 w: Math.abs(s.x2 - s.x1), h: Math.abs(s.y2 - s.y1) };
      }
      if (s.type === 'freedraw') {
        if (!s.points || !s.points.length) return { x: 0, y: 0, w: 0, h: 0 };
        var xs = s.points.map(function (p) { return p[0]; });
        var ys = s.points.map(function (p) { return p[1]; });
        var minx = Math.min.apply(null, xs), maxx = Math.max.apply(null, xs);
        var miny = Math.min.apply(null, ys), maxy = Math.max.apply(null, ys);
        return { x: minx, y: miny, w: maxx - minx, h: maxy - miny };
      }
      if (s.type === 'text') {
        // Rough estimate: width based on text length × font size, height = font size
        var w = (s.text || '').length * (s.fontSize || 16) * 0.55;
        var h = s.fontSize || 16;
        return { x: s.x, y: s.y - h, w: w, h: h };
      }
      return { x: s.x || 0, y: s.y || 0, w: s.w || 0, h: s.h || 0 };
    }

    function moveShape(s, dx, dy) {
      if (s.type === 'line' || s.type === 'arrow') {
        s.x1 += dx; s.y1 += dy; s.x2 += dx; s.y2 += dy;
      } else if (s.type === 'freedraw') {
        s.points = (s.points || []).map(function (p) { return [p[0] + dx, p[1] + dy]; });
      } else if (s.x !== undefined &amp;&amp; s.y !== undefined) {
        s.x += dx; s.y += dy;
      }
    }

    // Clipboard for copy/paste of shapes within the canvases tab.
    var canvasClipboard = [];

    // pushHistory snapshots the full state before a mutation. Call this
    // RIGHT BEFORE you mutate state — never during free-form typing
    // (that's saveDebounced's job and would balloon the stack).
    // HTML snippet for the per-tab Undo/Redo bar. Renders the buttons
    // with data-tab-undo/data-tab-redo attributes so updateTabUndoButtons
    // can enable/disable them based on stack contents, and a delegated
    // click handler (installed once at boot) routes the click to the
    // correct tab. Use the same markup on every tab so the visual
    // affordance is identical across the whole app.
    function tabUndoBarHtml(tab) {
      return '&lt;div class="tab-undo-bar"&gt;' +
        '&lt;button class="tab-undo-btn" data-tab-undo="' + tab + '" title="Undo"&gt;↶ Undo&lt;/button&gt;' +
        '&lt;button class="tab-redo-btn" data-tab-redo="' + tab + '" title="Redo"&gt;↷ Redo&lt;/button&gt;' +
      '&lt;/div&gt;';
    }

    // Resolve which tab a history op should target. Callers may pass
    // the tab explicitly; otherwise we fall back to the active tab.
    function resolveHistoryTab(tab) {
      if (tab &amp;&amp; HISTORY[tab]) return tab;
      var active = state &amp;&amp; state.settings &amp;&amp; state.settings.activeTab;
      return HISTORY[active] ? active : 'scoping';
    }

    function pushHistory(tab) {
      tab = resolveHistoryTab(tab);
      var h = HISTORY[tab];
      h.undo.push(JSON.stringify(state[tab]));
      if (h.undo.length &gt; HISTORY_MAX) h.undo.shift();
      h.redo = [];
      updateTabUndoButtons(tab);
    }

    function undoOp(tab) {
      tab = resolveHistoryTab(tab);
      var h = HISTORY[tab];
      if (!h.undo.length) return;
      h.redo.push(JSON.stringify(state[tab]));
      state[tab] = JSON.parse(h.undo.pop());
      // Selection state lives in JS module-locals (canvasSelectedShapeIds,
      // selectedCardId) — drop it on undo so we don't dangle a reference
      // to a shape/card that the snapshot just replaced.
      if (tab === 'canvases') clearShapeSelection();
      markDirty(tab);
      saveImmediate(tab);
      renderActiveTab();
      updateTabUndoButtons(tab);
    }

    function redoOp(tab) {
      tab = resolveHistoryTab(tab);
      var h = HISTORY[tab];
      if (!h.redo.length) return;
      h.undo.push(JSON.stringify(state[tab]));
      state[tab] = JSON.parse(h.redo.pop());
      if (tab === 'canvases') clearShapeSelection();
      markDirty(tab);
      saveImmediate(tab);
      renderActiveTab();
      updateTabUndoButtons(tab);
    }

    // Refresh enabled/disabled state of the per-tab Undo/Redo buttons
    // after any history change. Each tab toolbar carries
    // `data-tab-undo="&lt;name&gt;"` / `data-tab-redo="&lt;name&gt;"` attributes so
    // we can find them generically.
    function updateTabUndoButtons(tab) {
      var tabs = tab ? [tab] : Object.keys(HISTORY);
      tabs.forEach(function (t) {
        var h = HISTORY[t];
        if (!h) return;
        var u = document.querySelector('[data-tab-undo="' + t + '"]');
        var r = document.querySelector('[data-tab-redo="' + t + '"]');
        if (u) u.disabled = !h.undo.length;
        if (r) r.disabled = !h.redo.length;
      });
    }

    // Delegated click for ANY data-tab-undo / data-tab-redo button so
    // every tab's undo/redo bar works without per-render wiring (the
    // bar is recreated on each render — wiring per-render would be
    // both noisy and a hidden-bug magnet).
    document.addEventListener('click', function (e) {
      var t = e.target.closest &amp;&amp; e.target.closest('[data-tab-undo]');
      if (t) { undoOp(t.getAttribute('data-tab-undo')); return; }
      t = e.target.closest &amp;&amp; e.target.closest('[data-tab-redo]');
      if (t) { redoOp(t.getAttribute('data-tab-redo')); return; }
    });

    // Re-render whichever tab the user is currently looking at. Used by
    // undo/redo since a single restore can affect any tab's data.
    function renderActiveTab() {
      var t = state.settings.activeTab || 'scoping';
      if (t === 'scoping')    renderScopingTab();
      if (t === 'notes')      renderNotesTab();
      if (t === 'board')      renderBoardTab();
      if (t === 'canvases')   renderCanvasesTab();
      if (t === 'validation') renderValidationTab();
    }

    // Thin shim — used by the many canvas mutation sites that already
    // call pushCanvasHistory(). Kept because the call sites are
    // pervasive; routing them all to pushHistory('canvases') is a
    // mechanical rename for a separate commit.
    function pushCanvasHistory() { pushHistory('canvases'); }

    function activeCanvas() {
      var c = state.canvases.items.filter(function (x) { return x.id === state.canvases.activeId; })[0];
      if (!c &amp;&amp; state.canvases.items.length) c = state.canvases.items[0];
      if (!c) {
        c = { id: 'cnv-1', name: 'Canvas 1', shapes: [] };
        state.canvases.items.push(c);
        state.canvases.activeId = c.id;
      }
      return c;
    }

    // Dynamic canvas view size — measure the wrap's actual rect so the
    // SVG viewBox always matches the visible area (truly infinite canvas:
    // pan/zoom only, no scrollbars, no fixed virtual stage size).
    function getCanvasViewSize() {
      var wrap = document.getElementById('cnv-stage-wrap');
      if (wrap) {
        var r = wrap.getBoundingClientRect();
        if (r.width &gt; 0 &amp;&amp; r.height &gt; 0) return { w: r.width, h: r.height };
      }
      return { w: 1000, h: 600 }; // fallback for first-render before layout
    }

    // Refresh the SVG viewBox in place (no full re-render) — used during
    // pan and on window resize so the visible region tracks the wrap.
    function updateCanvasViewBox() {
      var svg = document.getElementById('cnv-stage');
      if (!svg) return;
      var c = activeCanvas();
      var vp = c.viewport || (c.viewport = { x: 0, y: 0, scale: 1 });
      var view = getCanvasViewSize();
      var vw = view.w / vp.scale;
      var vh = view.h / vp.scale;
      svg.setAttribute('viewBox', vp.x + ' ' + vp.y + ' ' + vw + ' ' + vh);
      var gridRect = svg.querySelector('rect[fill="url(#cnv-grid)"]');
      if (gridRect) {
        gridRect.setAttribute('x', vp.x);
        gridRect.setAttribute('y', vp.y);
        gridRect.setAttribute('width', vw);
        gridRect.setAttribute('height', vh);
      }
    }

    function renderCanvasesTab() {
      var pane = document.getElementById('tab-canvases');
      var canvas = activeCanvas();
      var s = cnvSettings();
      if (!canvas.viewport) canvas.viewport = { x: 0, y: 0, scale: 1 };
      var vp = canvas.viewport;
      var view = getCanvasViewSize();
      var viewW = view.w / vp.scale;
      var viewH = view.h / vp.scale;
      var viewBox = vp.x + ' ' + vp.y + ' ' + viewW + ' ' + viewH;

      // Sidebar with list of canvases
      var sideHtml = '';
      state.canvases.items.forEach(function (c) {
        var cls = 'cnv-list-item' + (c.id === state.canvases.activeId ? ' active' : '');
        sideHtml += '&lt;div class="' + cls + '" data-canvas-id="' + c.id + '"&gt;' +
                      '&lt;span class="name"&gt;' + escapeHtml(c.name) + '&lt;/span&gt;' +
                      '&lt;button class="menu-btn" data-action="rename" data-canvas-id="' + c.id + '" title="Rename"&gt;✏&lt;/button&gt;' +
                      '&lt;button class="menu-btn" data-action="delete" data-canvas-id="' + c.id + '" title="Delete"&gt;×&lt;/button&gt;' +
                    '&lt;/div&gt;';
      });

      var toolBtn = function (cmd, title) {
        var cls = 'cnv-tool icon-btn' + (canvasTool === cmd ? ' active' : '');
        return '&lt;button class="' + cls + '" data-tool="' + cmd + '" title="' + title + '"&gt;' + (CNV_TOOL_ICONS[cmd] || cmd) + '&lt;/button&gt;';
      };

      var strokeSwHtml = CNV_STROKE_COLORS.map(function (c) {
        var cls = 'cnv-swatch' + (c === canvasStroke ? ' active' : '');
        return '&lt;button class="' + cls + '" data-stroke="' + c + '" style="background:' + c + '" title="Stroke ' + c + '"&gt;&lt;/button&gt;';
      }).join('');

      var fillSwHtml = CNV_FILL_COLORS.map(function (c) {
        var cls = 'cnv-swatch' + (c === canvasFill ? ' active' : '');
        var style = c === 'transparent'
          ? 'background:repeating-linear-gradient(45deg, #cbd5e1, #cbd5e1 3px, #fff 3px, #fff 6px)'
          : 'background:' + c;
        return '&lt;button class="' + cls + '" data-fill="' + c + '" style="' + style + '" title="Fill ' + c + '"&gt;&lt;/button&gt;';
      }).join('');

      var thickHtml = [1, 2, 4, 7].map(function (w) {
        var cls = 'cnv-thick' + (w === canvasStrokeWidth ? ' active' : '');
        return '&lt;button class="' + cls + '" data-width="' + w + '" title="Stroke ' + w + 'px"&gt;' + w + 'px&lt;/button&gt;';
      }).join('');

      var toolbarHtml =
        '&lt;div class="cnv-toolbar" id="cnv-toolbar"&gt;' +
          // Undo/Redo first — Ctrl+Z is eaten by the FlexSim host, so the
          // buttons need to be the most visible thing in the toolbar.
          '&lt;button class="cnv-tool cnv-undo-btn" id="cnv-undo-btn" data-tab-undo="canvases" title="Undo"&gt;↶&lt;/button&gt;' +
          '&lt;button class="cnv-tool cnv-redo-btn" id="cnv-redo-btn" data-tab-redo="canvases" title="Redo"&gt;↷&lt;/button&gt;' +
          '&lt;span class="cnv-sep"&gt;&lt;/span&gt;' +
          toolBtn('select',    'Select (V) — click shapes to move; Shift+click multi-select; Space+drag pans; wheel zooms; Esc returns here') +
          '&lt;span class="cnv-sep"&gt;&lt;/span&gt;' +
          toolBtn('rect',      'Rectangle') +
          toolBtn('roundrect', 'Rounded rectangle') +
          toolBtn('ellipse',   'Ellipse / circle') +
          toolBtn('diamond',   'Diamond') +
          toolBtn('triangle',  'Triangle') +
          toolBtn('hexagon',   'Hexagon') +
          '&lt;span class="cnv-sep"&gt;&lt;/span&gt;' +
          toolBtn('line',      'Line') +
          toolBtn('arrow',     'Arrow') +
          toolBtn('freedraw',  'Free draw / pen') +
          toolBtn('text',      'Text') +
          toolBtn('image',     'Insert image') +
          '&lt;span class="cnv-sep"&gt;&lt;/span&gt;' +
          '&lt;span class="cnv-label"&gt;Stroke&lt;/span&gt;' + strokeSwHtml +
          '&lt;span class="cnv-sep"&gt;&lt;/span&gt;' +
          '&lt;span class="cnv-label"&gt;Fill&lt;/span&gt;' + fillSwHtml +
          '&lt;span class="cnv-mini-sep"&gt;&lt;/span&gt;' +
          '&lt;span class="cnv-label"&gt;Opacity&lt;/span&gt;' +
          '&lt;input type="range" class="cnv-opacity" id="cnv-fill-opacity" ' +
                 'min="0" max="100" step="5" value="' + Math.round(canvasFillOpacity * 100) + '" ' +
                 'title="Fill opacity (' + Math.round(canvasFillOpacity * 100) + '%)" /&gt;' +
          '&lt;span class="cnv-opacity-val" id="cnv-fill-opacity-val"&gt;' + Math.round(canvasFillOpacity * 100) + '%&lt;/span&gt;' +
          '&lt;span class="cnv-sep"&gt;&lt;/span&gt;' +
          '&lt;span class="cnv-label"&gt;Width&lt;/span&gt;' + thickHtml +
          '&lt;span class="cnv-sep"&gt;&lt;/span&gt;' +
          '&lt;button class="cnv-tool" id="cnv-zoom-out"   title="Zoom out (−)"&gt;−&lt;/button&gt;' +
          '&lt;button class="cnv-tool" id="cnv-zoom-reset" title="Reset zoom (100%)"&gt;' + Math.round(vp.scale * 100) + '%&lt;/button&gt;' +
          '&lt;button class="cnv-tool" id="cnv-zoom-in"    title="Zoom in (+)"&gt;+&lt;/button&gt;' +
          '&lt;button class="cnv-tool" id="cnv-settings-btn" title="Canvas settings"&gt;⚙&lt;/button&gt;' +
        '&lt;/div&gt;';

      // Per-color arrow markers — generate one for every unique stroke color
      // used by arrows, so arrowheads inherit the line color.
      var arrowColors = {};
      canvas.shapes.forEach(function (sh) {
        if (sh.type === 'arrow') arrowColors[sh.stroke || '#000000'] = true;
      });
      arrowColors['#000000'] = true; // always have a black marker available
      var markersHtml = Object.keys(arrowColors).map(function (col) {
        return '&lt;marker id="cnv-arrow-' + colorToId(col) + '" viewBox="0 0 10 10" refX="8" refY="5" markerWidth="7" markerHeight="7" orient="auto-start-reverse"&gt;' +
                 '&lt;path d="M 0 0 L 10 5 L 0 10 z" fill="' + col + '" /&gt;' +
               '&lt;/marker&gt;';
      }).join('');

      var gridHtml = '';
      if (s.showGrid) {
        var g = s.gridSize || 20;
        gridHtml = '&lt;rect x="' + vp.x + '" y="' + vp.y + '" width="' + viewW + '" height="' + viewH + '" fill="url(#cnv-grid)" pointer-events="none" /&gt;';
      }

      // Resize handles for the single selected shape with x/y/w/h
      var handlesHtml = '';
      var selIds = selectedShapeIds();
      if (selIds.length === 1) {
        var only = findShape(selIds[0]);
        if (only &amp;&amp; ['rect','roundrect','ellipse','diamond','triangle','hexagon','image','text'].indexOf(only.type) &gt;= 0) {
          handlesHtml = renderResizeHandles(only);
        }
      }

      // Contextual selection toolbar — ALWAYS rendered so the canvas
      // doesn't shift when shapes are selected/deselected. Content is
      // contextual.
      var selIdsAll = selectedShapeIds();
      var selToolbarHtml;
      if (selIdsAll.length &gt;= 1) {
        var multi = selIdsAll.length &gt;= 2;
        var tri   = selIdsAll.length &gt;= 3;
        var anyGrouped = selIdsAll.some(function (sid) {
          var sh = findShape(sid);
          return sh &amp;&amp; sh.groupId;
        });
        selToolbarHtml =
          '&lt;div class="cnv-sel-toolbar"&gt;' +
            '&lt;span class="cnv-sel-count"&gt;' + selIdsAll.length + ' selected&lt;/span&gt;' +
            '&lt;span class="cnv-sep"&gt;&lt;/span&gt;' +
            '&lt;button class="cnv-tool wide" data-sel="dup" title="Duplicate (Ctrl+D)"&gt;Duplicate&lt;/button&gt;' +
            '&lt;span class="cnv-sep"&gt;&lt;/span&gt;' +
            '&lt;span class="cnv-label"&gt;Order&lt;/span&gt;' +
            '&lt;button class="cnv-tool wide" data-sel="front" title="Bring to Front (Ctrl+Shift+])"&gt;Front&lt;/button&gt;' +
            '&lt;button class="cnv-tool wide" data-sel="fwd"   title="Bring Forward (Ctrl+])"&gt;Forward&lt;/button&gt;' +
            '&lt;button class="cnv-tool wide" data-sel="bwd"   title="Send Backward (Ctrl+[)"&gt;Backward&lt;/button&gt;' +
            '&lt;button class="cnv-tool wide" data-sel="back"  title="Send to Back (Ctrl+Shift+[)"&gt;Back&lt;/button&gt;' +
            (multi ? '&lt;span class="cnv-sep"&gt;&lt;/span&gt;' : '') +
            (multi ? '&lt;span class="cnv-label"&gt;Align horizontal&lt;/span&gt;' : '') +
            (multi ? '&lt;button class="cnv-tool" data-sel="alignL" title="Align Left edges"&gt;L&lt;/button&gt;' : '') +
            (multi ? '&lt;button class="cnv-tool" data-sel="alignC" title="Align Centers horizontally"&gt;C&lt;/button&gt;' : '') +
            (multi ? '&lt;button class="cnv-tool" data-sel="alignR" title="Align Right edges"&gt;R&lt;/button&gt;' : '') +
            (multi ? '&lt;span class="cnv-mini-sep"&gt;&lt;/span&gt;' : '') +
            (multi ? '&lt;span class="cnv-label"&gt;Align vertical&lt;/span&gt;' : '') +
            (multi ? '&lt;button class="cnv-tool" data-sel="alignT" title="Align Top edges"&gt;T&lt;/button&gt;' : '') +
            (multi ? '&lt;button class="cnv-tool" data-sel="alignM" title="Align Middles vertically"&gt;M&lt;/button&gt;' : '') +
            (multi ? '&lt;button class="cnv-tool" data-sel="alignB" title="Align Bottom edges"&gt;B&lt;/button&gt;' : '') +
            (tri   ? '&lt;span class="cnv-sep"&gt;&lt;/span&gt;' : '') +
            (tri   ? '&lt;span class="cnv-label"&gt;Distribute&lt;/span&gt;' : '') +
            (tri   ? '&lt;button class="cnv-tool wide" data-sel="distH" title="Distribute horizontally"&gt;H&lt;/button&gt;' : '') +
            (tri   ? '&lt;button class="cnv-tool wide" data-sel="distV" title="Distribute vertically"&gt;V&lt;/button&gt;' : '') +
            // Show the group separator only if there's actually a group
            // / ungroup button to follow it, otherwise we'd emit two
            // stacked separators with nothing between them.
            ((multi || anyGrouped) ? '&lt;span class="cnv-sep"&gt;&lt;/span&gt;' : '') +
            (multi ? '&lt;button class="cnv-tool wide" data-sel="group" title="Group (Ctrl+G)"&gt;Group&lt;/button&gt;' : '') +
            (anyGrouped ? '&lt;button class="cnv-tool wide" data-sel="ungroup" title="Ungroup (Ctrl+Shift+G)"&gt;Ungroup&lt;/button&gt;' : '') +
            '&lt;span class="cnv-hint"&gt;Right-click for more&lt;/span&gt;' +
          '&lt;/div&gt;';
      } else {
        // Empty placeholder — same height, gives a hint about how to start.
        selToolbarHtml =
          '&lt;div class="cnv-sel-toolbar empty"&gt;' +
            '&lt;span class="cnv-hint"&gt;Click a shape to select it &amp;mdash; Shift+click for multi-select &amp;mdash; right-click for more actions&lt;/span&gt;' +
          '&lt;/div&gt;';
      }

      var shapesSvg = canvas.shapes.map(shapeToSVG).join('');
      var stageHtml =
        selToolbarHtml +
        '&lt;div class="cnv-stage-wrap' + (canvasSpaceDown ? ' panning' : '') + '" id="cnv-stage-wrap"&gt;' +
          '&lt;svg class="cnv-stage tool-' + canvasTool + '" id="cnv-stage" xmlns="http://www.w3.org/2000/svg" viewBox="' + viewBox + '" preserveAspectRatio="xMidYMid meet"&gt;' +
            '&lt;defs&gt;' +
              '&lt;pattern id="cnv-grid" width="' + (s.gridSize || 20) + '" height="' + (s.gridSize || 20) + '" patternUnits="userSpaceOnUse"&gt;' +
                '&lt;circle cx="0" cy="0" r="1" fill="currentColor" /&gt;' +
              '&lt;/pattern&gt;' +
              markersHtml +
            '&lt;/defs&gt;' +
            gridHtml +
            shapesSvg +
            handlesHtml +
          '&lt;/svg&gt;' +
          (canvasInteraction &amp;&amp; canvasInteraction.dimensionsLabel ? '&lt;div class="cnv-dim-label"&gt;' + canvasInteraction.dimensionsLabel + '&lt;/div&gt;' : '') +
        '&lt;/div&gt;';

      pane.innerHTML =
        '&lt;div class="cnv-layout"&gt;' +
          '&lt;div class="cnv-sidebar"&gt;' +
            '&lt;button class="cnv-add-btn" id="cnv-add-canvas"&gt;+ Add canvas&lt;/button&gt;' +
            sideHtml +
          '&lt;/div&gt;' +
          '&lt;div class="cnv-main"&gt;' +
            toolbarHtml +
            stageHtml +
          '&lt;/div&gt;' +
        '&lt;/div&gt;';

      // Before any new toolbar items get re-added to the popover, kill
      // any leftover body-attached overflow menu from a prior render.
      // (innerHTML above destroyed the old toolbar, but the menu was
      // appended to &lt;body&gt; so it survives — and its stale items would
      // get merged into the fresh toolbar by applyToolbarOverflow,
      // causing visible duplicates.)
      var staleMenu = document.getElementById('cnv-overflow-menu');
      if (staleMenu) staleMenu.remove();

      if (canvasSettingsOpen) renderCanvasSettingsDropdown();
      wireCanvasesTab();
      // Defer overflow-menu fit by one frame so the browser has laid
      // out the toolbar at its final width before we measure it.
      requestAnimationFrame(applyToolbarOverflow);
      // The viewBox above used a fallback size on first render (wrap
      // hadn't been created yet). Now that the wrap exists, measure it
      // and patch the viewBox to match the actual visible region.
      requestAnimationFrame(updateCanvasViewBox);
    }

    // Google-Slides-style toolbar overflow:
    // If the main canvas toolbar is wider than its container, move the
    // trailing items into a "More" popover behind a … button. Items
    // keep their event listeners because we MOVE them, not clone them.
    function applyToolbarOverflow() {
      var toolbar = document.getElementById('cnv-toolbar');
      if (!toolbar) return;

      // Clean up any previous overflow state (so each render starts fresh).
      // Use querySelectorAll in case multiple stale menus / morebuttons
      // exist (can happen if rapid resize events or rerenders raced).
      var prevMore = document.getElementById('cnv-more-btn');
      var prevMenus = document.querySelectorAll('#cnv-overflow-menu, .cnv-overflow-menu');
      prevMenus.forEach(function (m) {
        // Move the menu's children back into the toolbar IFF they belong
        // to the current toolbar's set (we can't tell for sure, but the
        // toolbar's existing items + menu's items together represent the
        // full toolbar that overflowed). Just append — duplicates are
        // avoided because renderCanvasesTab() above already removed any
        // stale body-attached menus.
        while (m.firstChild) toolbar.appendChild(m.firstChild);
        m.remove();
      });
      if (prevMore) prevMore.remove();

      // Anything still fitting? Nothing to do.
      if (toolbar.scrollWidth &lt;= toolbar.clientWidth) return;

      // Build the … button
      var moreBtn = document.createElement('button');
      moreBtn.className = 'cnv-tool icon-btn';
      moreBtn.id = 'cnv-more-btn';
      moreBtn.title = 'More tools';
      moreBtn.innerHTML =
        '&lt;svg viewBox="0 0 16 16"&gt;' +
          '&lt;circle cx="3.5" cy="8" r="1.3" fill="currentColor"/&gt;' +
          '&lt;circle cx="8"   cy="8" r="1.3" fill="currentColor"/&gt;' +
          '&lt;circle cx="12.5" cy="8" r="1.3" fill="currentColor"/&gt;' +
        '&lt;/svg&gt;';
      toolbar.appendChild(moreBtn);

      // Build the overflow menu (appended to body so it isn't clipped)
      var menu = document.createElement('div');
      menu.id = 'cnv-overflow-menu';
      menu.className = 'cnv-overflow-menu';
      menu.style.display = 'none';
      document.body.appendChild(menu);

      // Move trailing items into the menu one at a time until the toolbar fits
      var iter = 0;
      while (toolbar.scrollWidth &gt; toolbar.clientWidth &amp;&amp; iter++ &lt; 200) {
        var children = toolbar.children;
        if (children.length &lt; 2) break;
        // Index right before moreBtn (always the last child)
        var idx = children.length - 2;
        var item = children[idx];
        if (!item || item === moreBtn) break;
        menu.insertBefore(item, menu.firstChild);
      }

      moreBtn.addEventListener('click', function (e) {
        e.stopPropagation();
        if (menu.style.display === 'flex') { menu.style.display = 'none'; return; }
        var rect = moreBtn.getBoundingClientRect();
        menu.style.display = 'flex';
        menu.style.top   = (rect.bottom + 4) + 'px';
        menu.style.right = Math.max(8, window.innerWidth - rect.right) + 'px';
        setTimeout(function () {
          document.addEventListener('mousedown', function outside(ev) {
            if (!menu.contains(ev.target) &amp;&amp; ev.target !== moreBtn) {
              menu.style.display = 'none';
              document.removeEventListener('mousedown', outside);
            }
          });
        }, 0);
      });

      // Any button click inside the menu also closes it (so picking a
      // tool from the overflow dismisses the popover).
      menu.addEventListener('click', function (e) {
        if (e.target.closest('button')) menu.style.display = 'none';
      });
    }

    // Re-fit the toolbar when the window changes width, and refresh the
    // canvas viewBox so the visible region tracks the wrap's new size.
    window.addEventListener('resize', function () {
      var active = document.querySelector('.tab-pane.active');
      if (active &amp;&amp; active.id === 'tab-canvases') {
        applyToolbarOverflow();
        updateCanvasViewBox();
      }
    });

    function renderResizeHandles(s) {
      var sw   = 8;
      var half = sw / 2;
      var cx   = s.x + s.w / 2;
      var cy   = s.y + s.h / 2;
      var rot  = s.rotation || 0;
      var rotArm = 22;                              // px above the top edge
      var handles = [
        { id: 'nw', x: s.x - half,           y: s.y - half },
        { id: 'ne', x: s.x + s.w - half,     y: s.y - half },
        { id: 'sw', x: s.x - half,           y: s.y + s.h - half },
        { id: 'se', x: s.x + s.w - half,     y: s.y + s.h - half }
      ];
      var corners = handles.map(function (h) {
        return '&lt;rect class="cnv-handle" data-handle="' + h.id + '" data-shape-id="' + s.id + '" x="' + h.x + '" y="' + h.y + '" width="' + sw + '" height="' + sw + '" fill="#fff" stroke="#2563eb" stroke-width="1.5" /&gt;';
      }).join('');
      // Rotation handle floats above the top-center, connected by a short
      // line. Whole group rotates with the shape so handles stay glued
      // to the rotated corners.
      var rotHandle =
        '&lt;line x1="' + cx + '" y1="' + s.y + '" x2="' + cx + '" y2="' + (s.y - rotArm) + '" stroke="#2563eb" stroke-width="1.25" /&gt;' +
        '&lt;circle class="cnv-handle cnv-rot-handle" data-handle="rotate" data-shape-id="' + s.id + '" cx="' + cx + '" cy="' + (s.y - rotArm) + '" r="6" fill="#fff" stroke="#2563eb" stroke-width="1.5" /&gt;';
      var wrapOpen  = rot
        ? '&lt;g class="cnv-handles" transform="rotate(' + rot + ' ' + cx + ' ' + cy + ')"&gt;'
        : '&lt;g class="cnv-handles"&gt;';
      return wrapOpen + corners + rotHandle + '&lt;/g&gt;';
    }

    // Refresh the corner / rotation handle group in place during a drag.
    // The shape body re-renders via updateShapeElement (cheap), but the
    // handles live in a separate &lt;g&gt; that's only emitted on a full canvas
    // render — so a multi-drag needs us to reposition the group ourselves
    // or the handles get left behind.
    function updateSelectionHandlesInPlace() {
      var selIds = selectedShapeIds();
      if (selIds.length !== 1) return;
      var only = findShape(selIds[0]);
      if (!only) return;
      if (['rect','roundrect','ellipse','diamond','triangle','hexagon','image','text'].indexOf(only.type) &lt; 0) return;
      var svg = document.getElementById('cnv-stage');
      if (!svg) return;
      var oldGroup = svg.querySelector('.cnv-handles');
      if (!oldGroup) return;
      var wrap = document.createElementNS('http://www.w3.org/2000/svg', 'g');
      wrap.innerHTML = renderResizeHandles(only);
      var fresh = wrap.firstChild;
      oldGroup.parentNode.replaceChild(fresh, oldGroup);
    }

    function renderCanvasSettingsDropdown() {
      var existing = document.getElementById('cnv-settings-root');
      if (existing) existing.parentNode.removeChild(existing);
      var anchor = document.getElementById('cnv-settings-btn');
      if (!anchor) return;
      var s = cnvSettings();
      var root = document.createElement('div');
      root.id = 'cnv-settings-root';
      root.className = 'settings-dropdown';

      function toggle(label, key) {
        var on = !!s[key];
        return '&lt;div class="settings-row"&gt;&lt;h4&gt;' + label + '&lt;/h4&gt;&lt;div class="options"&gt;' +
          '&lt;button class="opt' + (!on ? ' active' : '') + '" data-skey="' + key + '" data-sval="false"&gt;Off&lt;/button&gt;' +
          '&lt;button class="opt' + ( on ? ' active' : '') + '" data-skey="' + key + '" data-sval="true"&gt;On&lt;/button&gt;' +
        '&lt;/div&gt;&lt;/div&gt;';
      }
      function radio(label, key, choices) {
        var cur = s[key];
        var opts = choices.map(function (c) {
          var cls = 'opt' + (c.value === cur ? ' active' : '');
          return '&lt;button class="' + cls + '" data-skey="' + key + '" data-sval="' + c.value + '"&gt;' + escapeHtml(c.label) + '&lt;/button&gt;';
        }).join('');
        return '&lt;div class="settings-row"&gt;&lt;h4&gt;' + label + '&lt;/h4&gt;&lt;div class="options"&gt;' + opts + '&lt;/div&gt;&lt;/div&gt;';
      }

      // Don't wrap in another &lt;div class="settings-dropdown"&gt; — `root`
      // already carries that class. The previous double-wrap stacked
      // two position:fixed boxes with each their own 14px padding,
      // pushing the visible panel down and to the right of the gear.
      var html = '';
      html += toggle('Show grid', 'showGrid');
      html += toggle('Snap to grid', 'snapToGrid');
      html += radio('Grid size', 'gridSize', [
        { value: '10', label: '10px' }, { value: '20', label: '20px' }, { value: '40', label: '40px' }
      ]);
      html += toggle('Show dimensions while drawing', 'showDimensions');
      html += toggle('Smooth free-draw on commit', 'smoothFreedraw');
      html += toggle('Show rulers', 'showRulers');
      root.innerHTML = html;

      // Anchor the panel to the BOTTOM of the canvas toolbar (so it
      // sits flush below the toolbar row, not below the gear's own
      // edge) and to the RIGHT of the canvas stage (so the popup hugs
      // the canvas area rather than the gear's individual right edge).
      var toolbar = document.getElementById('cnv-toolbar');
      var stage = document.getElementById('cnv-stage-wrap');
      var topRect = toolbar ? toolbar.getBoundingClientRect() : anchor.getBoundingClientRect();
      var rightRect = stage ? stage.getBoundingClientRect() : anchor.getBoundingClientRect();
      root.style.position = 'fixed';
      root.style.top = (topRect.bottom + 4) + 'px';
      root.style.right = Math.max(8, window.innerWidth - rightRect.right) + 'px';
      document.body.appendChild(root);

      root.querySelectorAll('.opt').forEach(function (btn) {
        btn.addEventListener('click', function () {
          var key = btn.getAttribute('data-skey');
          var raw = btn.getAttribute('data-sval');
          var val;
          if (raw === 'true') val = true;
          else if (raw === 'false') val = false;
          else if (!isNaN(parseInt(raw, 10))) val = parseInt(raw, 10);
          else val = raw;
          s[key] = val;
          saveImmediate();
          renderCanvasesTab();
          renderCanvasSettingsDropdown();
        });
      });

      // Close on outside click
      setTimeout(function () {
        document.addEventListener('mousedown', function outside(e) {
          if (!root.contains(e.target) &amp;&amp; e.target !== anchor) {
            canvasSettingsOpen = false;
            if (root.parentNode) root.parentNode.removeChild(root);
            document.removeEventListener('mousedown', outside);
          }
        });
      }, 0);
    }

    // Convert a color hex to a safe id fragment for marker ids
    function colorToId(color) { return (color || '#000000').replace('#', '').toLowerCase(); }

    // Render a single shape as SVG markup. Text labels render centered
    // inside shapes that support them.
    // Build the rotate(...) transform attribute for a shape, or empty if
    // unrotated. Pivot is the shape's center (or midpoint for lines /
    // freedraw). Applied on the shape's wrapping &lt;g&gt; so all visuals,
    // text overlays, and image content rotate together.
    function shapeRotateAttr(s) {
      var rot = s.rotation || 0;
      if (!rot) return '';
      var cx, cy;
      if (s.type === 'line' || s.type === 'arrow') {
        cx = (s.x1 + s.x2) / 2; cy = (s.y1 + s.y2) / 2;
      } else if (s.type === 'freedraw') {
        var pts = s.points || [];
        if (!pts.length) return '';
        var minX = Infinity, minY = Infinity, maxX = -Infinity, maxY = -Infinity;
        pts.forEach(function (p) {
          if (p[0] &lt; minX) minX = p[0]; if (p[0] &gt; maxX) maxX = p[0];
          if (p[1] &lt; minY) minY = p[1]; if (p[1] &gt; maxY) maxY = p[1];
        });
        cx = (minX + maxX) / 2; cy = (minY + maxY) / 2;
      } else {
        cx = s.x + (s.w || 0) / 2; cy = s.y + (s.h || 0) / 2;
      }
      return ' transform="rotate(' + rot + ' ' + cx + ' ' + cy + ')"';
    }

    function shapeToSVG(s) {
      var stroke = s.stroke || '#000000';
      var fill = s.fill || 'transparent';
      var sw = s.strokeWidth || 2;
      // Fill opacity is opt-in — only emit the attribute if the shape
      // has a stored value (so unset shapes keep the SVG default of 1).
      var fillOp = (typeof s.fillOpacity === 'number') ? s.fillOpacity : null;
      var foAttr = (fillOp !== null) ? ' fill-opacity="' + fillOp + '"' : '';
      var attrs = ' data-shape-id="' + s.id + '"' + shapeRotateAttr(s);
      var cls = ' class="shape' + (isShapeSelected(s.id) ? ' selected' : '') + '"';
      // For shaped containers with text, embed HTML via &lt;foreignObject&gt;
      // so the user gets the same rich-text capabilities as note/card
      // bodies (bold/italic/lists/headings/colors/links). The shape's
      // `text` field holds an HTML string; double-click to edit toggles
      // contenteditable on the inner div directly.
      var textEl = '';
      if (s.text &amp;&amp; ['rect', 'roundrect', 'ellipse', 'diamond', 'triangle', 'hexagon'].indexOf(s.type) &gt;= 0) {
        var pad  = 8;
        var ta   = s.textAlign  || 'center';
        var tva  = s.textVAlign || 'middle';
        var jc   = tva === 'top' ? 'flex-start' : (tva === 'bottom' ? 'flex-end' : 'center');
        textEl = '&lt;foreignObject x="' + (s.x + pad) + '" y="' + (s.y + pad) +
                 '" width="' + Math.max(0, s.w - pad * 2) + '" height="' + Math.max(0, s.h - pad * 2) + '"&gt;' +
                   '&lt;div xmlns="http://www.w3.org/1999/xhtml" class="cnv-shape-text" ' +
                        'data-shape-text-for="' + s.id + '" ' +
                        'style="justify-content:' + jc + ';text-align:' + ta + ';"&gt;' +
                     rehydrateBody(s.text) +
                   '&lt;/div&gt;' +
                 '&lt;/foreignObject&gt;';
      }
      switch (s.type) {
        case 'rect':
          return '&lt;g' + cls + attrs + '&gt;&lt;rect x="' + s.x + '" y="' + s.y + '" width="' + s.w + '" height="' + s.h + '" stroke="' + stroke + '" stroke-width="' + sw + '" fill="' + fill + '"' + foAttr + ' /&gt;' + textEl + '&lt;/g&gt;';
        case 'roundrect':
          return '&lt;g' + cls + attrs + '&gt;&lt;rect rx="10" ry="10" x="' + s.x + '" y="' + s.y + '" width="' + s.w + '" height="' + s.h + '" stroke="' + stroke + '" stroke-width="' + sw + '" fill="' + fill + '"' + foAttr + ' /&gt;' + textEl + '&lt;/g&gt;';
        case 'ellipse':
          return '&lt;g' + cls + attrs + '&gt;&lt;ellipse cx="' + (s.x + s.w / 2) + '" cy="' + (s.y + s.h / 2) + '" rx="' + (s.w / 2) + '" ry="' + (s.h / 2) + '" stroke="' + stroke + '" stroke-width="' + sw + '" fill="' + fill + '"' + foAttr + ' /&gt;' + textEl + '&lt;/g&gt;';
        case 'diamond':
          return '&lt;g' + cls + attrs + '&gt;&lt;polygon points="' + [
            (s.x + s.w / 2) + ',' + s.y,
            (s.x + s.w)     + ',' + (s.y + s.h / 2),
            (s.x + s.w / 2) + ',' + (s.y + s.h),
            s.x             + ',' + (s.y + s.h / 2)
          ].join(' ') + '" stroke="' + stroke + '" stroke-width="' + sw + '" fill="' + fill + '"' + foAttr + ' /&gt;' + textEl + '&lt;/g&gt;';
        case 'triangle':
          return '&lt;g' + cls + attrs + '&gt;&lt;polygon points="' + [
            (s.x + s.w / 2) + ',' + s.y,
            (s.x + s.w)     + ',' + (s.y + s.h),
            s.x             + ',' + (s.y + s.h)
          ].join(' ') + '" stroke="' + stroke + '" stroke-width="' + sw + '" fill="' + fill + '"' + foAttr + ' /&gt;' + textEl + '&lt;/g&gt;';
        case 'hexagon':
          var hx = s.w / 4;
          return '&lt;g' + cls + attrs + '&gt;&lt;polygon points="' + [
            (s.x + hx)         + ',' + s.y,
            (s.x + s.w - hx)   + ',' + s.y,
            (s.x + s.w)        + ',' + (s.y + s.h / 2),
            (s.x + s.w - hx)   + ',' + (s.y + s.h),
            (s.x + hx)         + ',' + (s.y + s.h),
            s.x                + ',' + (s.y + s.h / 2)
          ].join(' ') + '" stroke="' + stroke + '" stroke-width="' + sw + '" fill="' + fill + '"' + foAttr + ' /&gt;' + textEl + '&lt;/g&gt;';
        case 'line':
          return '&lt;line' + cls + attrs + ' x1="' + s.x1 + '" y1="' + s.y1 + '" x2="' + s.x2 + '" y2="' + s.y2 + '" stroke="' + stroke + '" stroke-width="' + sw + '" stroke-linecap="round" /&gt;';
        case 'arrow':
          return '&lt;line' + cls + attrs + ' x1="' + s.x1 + '" y1="' + s.y1 + '" x2="' + s.x2 + '" y2="' + s.y2 + '" stroke="' + stroke + '" stroke-width="' + sw + '" stroke-linecap="round" marker-end="url(#cnv-arrow-' + colorToId(stroke) + ')" /&gt;';
        case 'freedraw':
          var pts = (s.points || []).map(function (p) { return p[0] + ',' + p[1]; }).join(' ');
          return '&lt;polyline' + cls + attrs + ' points="' + pts + '" stroke="' + stroke + '" stroke-width="' + sw + '" fill="none" stroke-linecap="round" stroke-linejoin="round" /&gt;';
        case 'text':
          // Free-floating text box. Stored as HTML (same as note/card
          // bodies) and rendered via &lt;foreignObject&gt;. The shape has its
          // own w/h so it can hold multi-line / formatted content.
          // s.y is the top of the bounding box (same as other shapes),
          // not a font-baseline — keeps resize handles aligned.
          var fs    = s.fontSize || 16;
          var tW    = s.w || 200;
          var tH    = s.h || (fs * 2);
          var tTa   = s.textAlign  || 'left';
          return '&lt;g' + cls + attrs + '&gt;' +
                   '&lt;rect x="' + s.x + '" y="' + s.y + '" width="' + tW + '" height="' + tH + '" fill="transparent" stroke="none" /&gt;' +
                   '&lt;foreignObject x="' + s.x + '" y="' + s.y + '" width="' + tW + '" height="' + tH + '"&gt;' +
                     '&lt;div xmlns="http://www.w3.org/1999/xhtml" class="cnv-text-shape" ' +
                          'data-shape-text-for="' + s.id + '" ' +
                          'style="font-size:' + fs + 'px;color:' + (s.color || stroke) + ';text-align:' + tTa + ';"&gt;' +
                       rehydrateBody(s.text || '') +
                     '&lt;/div&gt;' +
                   '&lt;/foreignObject&gt;' +
                 '&lt;/g&gt;';
        case 'image':
          var src = imageCache[s.imgId] || '';
          return '&lt;image' + cls + attrs + ' x="' + s.x + '" y="' + s.y + '" width="' + s.w + '" height="' + s.h + '" href="' + src + '" preserveAspectRatio="xMidYMid meet" /&gt;';
      }
      return '';
    }

    // Convert client (mouse) coords to SVG-internal coords. Uses
    // getScreenCTM().inverse() so the conversion respects the SVG's
    // viewBox (which we use for pan/zoom).
    function clientToCnv(e, svg) {
      var pt = svg.createSVGPoint();
      pt.x = e.clientX;
      pt.y = e.clientY;
      var ctm = svg.getScreenCTM();
      if (!ctm) return { x: 0, y: 0 };
      var p = pt.matrixTransform(ctm.inverse());
      return { x: p.x, y: p.y };
    }

    function wireCanvasesTab() {
      var pane = document.getElementById('tab-canvases');
      var svg = document.getElementById('cnv-stage');

      // Sidebar: switch canvases
      pane.querySelectorAll('.cnv-list-item').forEach(function (el) {
        el.addEventListener('click', function (e) {
          if (e.target.classList &amp;&amp; e.target.classList.contains('menu-btn')) return;
          if (saveStatus === 'pending') saveImmediate();
          state.canvases.activeId = el.getAttribute('data-canvas-id');
          clearShapeSelection();
          saveImmediate();
          renderCanvasesTab();
        });
      });
      pane.querySelectorAll('.cnv-list-item .menu-btn[data-action="rename"]').forEach(function (btn) {
        btn.addEventListener('click', function (e) {
          e.stopPropagation();
          var id = btn.getAttribute('data-canvas-id');
          var c = state.canvases.items.filter(function (x) { return x.id === id; })[0];
          if (!c) return;
          var anchorRect = btn.getBoundingClientRect();
          inlinePrompt('Canvas name', c.name, anchorRect).then(function (newName) {
            if (newName == null) return;
            newName = newName.trim();
            if (!newName) return;
            pushCanvasHistory();
            c.name = newName;
            saveImmediate();
            renderCanvasesTab();
          });
        });
      });
      pane.querySelectorAll('.cnv-list-item .menu-btn[data-action="delete"]').forEach(function (btn) {
        btn.addEventListener('click', function (e) {
          e.stopPropagation();
          var id = btn.getAttribute('data-canvas-id');
          var c = state.canvases.items.filter(function (x) { return x.id === id; })[0];
          if (!c) return;
          if (state.canvases.items.length &lt;= 1) return; // keep at least one
          confirmDialog('Delete canvas "' + c.name + '" and everything on it?').then(function (ok) {
            if (!ok) return;
            pushCanvasHistory();
            state.canvases.items = state.canvases.items.filter(function (x) { return x.id !== id; });
            if (state.canvases.activeId === id) {
              state.canvases.activeId = state.canvases.items[0].id;
            }
            clearShapeSelection();
            saveImmediate();
            renderCanvasesTab();
          });
        });
      });

      var addBtn = document.getElementById('cnv-add-canvas');
      if (addBtn) addBtn.addEventListener('click', function () {
        pushCanvasHistory();
        var id = newId('cnv-');
        state.canvases.items.push({ id: id, name: 'Canvas ' + (state.canvases.items.length + 1), shapes: [], viewport: { x: 0, y: 0, scale: 1 } });
        state.canvases.activeId = id;
        clearShapeSelection();
        saveImmediate();
        renderCanvasesTab();
      });

      // Tool buttons
      pane.querySelectorAll('.cnv-tool[data-tool]').forEach(function (btn) {
        btn.addEventListener('click', function () {
          canvasTool = btn.getAttribute('data-tool');
          if (canvasTool === 'image') {
            pickImageForCanvas();
            canvasTool = 'select';
          }
          renderCanvasesTab();
        });
      });

      // Color/width swatches — apply to all currently-selected shapes
      pane.querySelectorAll('.cnv-swatch[data-stroke]').forEach(function (btn) {
        btn.addEventListener('click', function () {
          canvasStroke = btn.getAttribute('data-stroke');
          canvasStrokeIsDefault = false;
          var sel = selectedShapeIds();
          if (sel.length) {
            pushCanvasHistory();
            sel.forEach(function (id) { var s = findShape(id); if (s) s.stroke = canvasStroke; });
            saveImmediate();
          }
          renderCanvasesTab();
        });
      });
      pane.querySelectorAll('.cnv-swatch[data-fill]').forEach(function (btn) {
        btn.addEventListener('click', function () {
          canvasFill = btn.getAttribute('data-fill');
          var sel = selectedShapeIds();
          if (sel.length) {
            pushCanvasHistory();
            sel.forEach(function (id) { var s = findShape(id); if (s) s.fill = canvasFill; });
            saveImmediate();
          }
          renderCanvasesTab();
        });
      });
      pane.querySelectorAll('.cnv-thick[data-width]').forEach(function (btn) {
        btn.addEventListener('click', function () {
          canvasStrokeWidth = parseInt(btn.getAttribute('data-width'), 10);
          var sel = selectedShapeIds();
          if (sel.length) {
            pushCanvasHistory();
            sel.forEach(function (id) { var s = findShape(id); if (s) s.strokeWidth = canvasStrokeWidth; });
            saveImmediate();
          }
          renderCanvasesTab();
        });
      });
      var opacityInput = document.getElementById('cnv-fill-opacity');
      var opacityVal   = document.getElementById('cnv-fill-opacity-val');
      if (opacityInput) {
        var applyOpacity = function (commit) {
          var pct = parseInt(opacityInput.value, 10);
          if (isNaN(pct)) pct = 100;
          canvasFillOpacity = Math.max(0, Math.min(100, pct)) / 100;
          if (opacityVal) opacityVal.textContent = Math.round(canvasFillOpacity * 100) + '%';
          opacityInput.title = 'Fill opacity (' + Math.round(canvasFillOpacity * 100) + '%)';
          var sel = selectedShapeIds();
          if (sel.length) {
            // Update live for visual feedback; only push history on commit.
            sel.forEach(function (id) {
              var s = findShape(id);
              if (!s) return;
              s.fillOpacity = canvasFillOpacity;
              updateShapeElement(s);
            });
            if (commit) {
              pushCanvasHistory();
              saveImmediate();
            }
          }
        };
        opacityInput.addEventListener('input', function () { applyOpacity(false); });
        opacityInput.addEventListener('change', function () { applyOpacity(true); });
      }

      // Canvas Undo/Redo buttons are picked up by the global delegated
      // click handler (data-tab-undo/data-tab-redo attributes); no
      // per-render wiring required.

      var zoomIn = document.getElementById('cnv-zoom-in');
      if (zoomIn) zoomIn.addEventListener('click', function () { zoomCanvasBy(1.25); });
      var zoomOut = document.getElementById('cnv-zoom-out');
      if (zoomOut) zoomOut.addEventListener('click', function () { zoomCanvasBy(0.8); });
      var zoomReset = document.getElementById('cnv-zoom-reset');
      if (zoomReset) zoomReset.addEventListener('click', function () {
        var c = activeCanvas();
        c.viewport = { x: 0, y: 0, scale: 1 };
        saveImmediate();
        renderCanvasesTab();
      });

      var settingsBtn = document.getElementById('cnv-settings-btn');
      if (settingsBtn) settingsBtn.addEventListener('click', function () {
        canvasSettingsOpen = !canvasSettingsOpen;
        if (canvasSettingsOpen) renderCanvasSettingsDropdown();
        else {
          var existing = document.getElementById('cnv-settings-root');
          if (existing) existing.parentNode.removeChild(existing);
        }
      });

      // Contextual selection toolbar (align / order / group / etc.)
      pane.querySelectorAll('.cnv-sel-toolbar .cnv-tool[data-sel]').forEach(function (btn) {
        btn.addEventListener('click', function () {
          var act = btn.getAttribute('data-sel');
          switch (act) {
            case 'dup':     duplicateSelection(); break;
            case 'front':   reorderSelection('front'); break;
            case 'fwd':     reorderSelection('forward'); break;
            case 'bwd':     reorderSelection('backward'); break;
            case 'back':    reorderSelection('back'); break;
            case 'alignL':  alignSelection('left'); break;
            case 'alignC':  alignSelection('center'); break;
            case 'alignR':  alignSelection('right'); break;
            case 'alignT':  alignSelection('top'); break;
            case 'alignM':  alignSelection('middle'); break;
            case 'alignB':  alignSelection('bottom'); break;
            case 'distH':   distributeSelection('h'); break;
            case 'distV':   distributeSelection('v'); break;
            case 'group':   groupSelection(); break;
            case 'ungroup': ungroupSelection(); break;
          }
        });
      });

      // Stage interactions
      if (svg) {
        svg.addEventListener('mousedown', onCnvMouseDown);
        svg.addEventListener('dblclick', onCnvDoubleClick);
        svg.addEventListener('wheel', onCnvWheel, { passive: false });
        svg.addEventListener('contextmenu', onCnvContextMenu);
      }
    }

    // --- right-click context menu ---
    // Standard PowerPoint / Figma / draw.io pattern: right-click a shape
    // (or the canvas with shapes selected) to access z-order, group, and
    // duplicate/delete without hunting for cryptic toolbar icons.
    function closeContextMenu() {
      var existing = document.getElementById('cnv-context-menu');
      if (existing &amp;&amp; existing.parentNode) existing.parentNode.removeChild(existing);
    }

    function onCnvContextMenu(e) {
      e.preventDefault();
      closeContextMenu();

      // If a drawing/creation tool is active, right-click is treated
      // purely as an "escape to Select" gesture — no context menu. The
      // user is signalling "I'm done drawing." This avoids the surprise
      // of getting a context menu when you meant to cancel the tool.
      if (canvasTool !== 'select') {
        canvasTool = 'select';
        renderCanvasesTab();
        return;
      }

      var hit = e.target.closest &amp;&amp; e.target.closest('[data-shape-id]');
      var onEmptySpace = !(hit &amp;&amp; !hit.classList.contains('cnv-handle'));

      if (!onEmptySpace) {
        // Right-click on a shape: select it (expanding to its group) if
        // it isn't already, so the menu's actions apply to what was
        // clicked — same as PowerPoint / Figma / draw.io.
        var id = hit.getAttribute('data-shape-id');
        if (!isShapeSelected(id)) {
          var s = findShape(id);
          clearShapeSelection();
          if (s &amp;&amp; s.groupId) {
            activeCanvas().shapes.forEach(function (x) {
              if (x.groupId === s.groupId) canvasSelectedShapeIds[x.id] = true;
            });
          } else if (s) {
            canvasSelectedShapeIds[id] = true;
          }
          renderCanvasesTab();
        }
      }

      var sel = selectedShapeIds();

      // Detect if anything in the selection is grouped (enables Ungroup)
      var anyGrouped = sel.some(function (sid) {
        var s = findShape(sid);
        return s &amp;&amp; s.groupId;
      });

      var menu = document.createElement('div');
      menu.className = 'cnv-context-menu';
      menu.id = 'cnv-context-menu';

      function item(act, label, shortcut, disabled) {
        return '&lt;button data-act="' + act + '"' + (disabled ? ' disabled' : '') + '&gt;' +
                 '&lt;span class="label"&gt;' + label + '&lt;/span&gt;' +
                 (shortcut ? '&lt;span class="shortcut"&gt;' + shortcut + '&lt;/span&gt;' : '') +
               '&lt;/button&gt;';
      }

      var hasShapes = activeCanvas().shapes.length &gt; 0;
      var html;
      if (onEmptySpace) {
        // Empty-space right-click → view menu. The canvas is infinite
        // (no scrollbars), so Fit to Screen / Reset Zoom are the two
        // navigation aids users need.
        html = [
          item('fit',     'Fit to Screen',    'Ctrl+Shift+F', !hasShapes),
          item('reset',   'Reset Zoom (100%)')
        ].join('');
      } else {
        html = [
          item('dup',     'Duplicate',          'Ctrl+D'),
          item('delete',  'Delete',             'Del'),
          '&lt;hr&gt;',
          item('front',   'Bring to Front',     'Ctrl+Shift+]'),
          item('fwd',     'Bring Forward',      'Ctrl+]'),
          item('bwd',     'Send Backward',      'Ctrl+['),
          item('back',    'Send to Back',       'Ctrl+Shift+['),
          '&lt;hr&gt;',
          item('group',   'Group',              'Ctrl+G',         sel.length &lt; 2),
          item('ungroup', 'Ungroup',            'Ctrl+Shift+G',   !anyGrouped),
          (sel.length &gt;= 2 ? '&lt;hr&gt;' : ''),
          (sel.length &gt;= 2 ? item('alignL', 'Align Left')        : ''),
          (sel.length &gt;= 2 ? item('alignC', 'Align Center')      : ''),
          (sel.length &gt;= 2 ? item('alignR', 'Align Right')       : ''),
          (sel.length &gt;= 2 ? item('alignT', 'Align Top')         : ''),
          (sel.length &gt;= 2 ? item('alignM', 'Align Middle')      : ''),
          (sel.length &gt;= 2 ? item('alignB', 'Align Bottom')      : ''),
          (sel.length &gt;= 3 ? item('distH',  'Distribute Horizontally') : ''),
          (sel.length &gt;= 3 ? item('distV',  'Distribute Vertically')   : '')
        ].join('');
      }
      menu.innerHTML = html;

      // Position the menu near the cursor, but clamp inside the viewport
      menu.style.left = e.clientX + 'px';
      menu.style.top  = e.clientY + 'px';
      document.body.appendChild(menu);
      var menuRect = menu.getBoundingClientRect();
      if (menuRect.right &gt; window.innerWidth) {
        menu.style.left = (window.innerWidth - menuRect.width - 8) + 'px';
      }
      if (menuRect.bottom &gt; window.innerHeight) {
        menu.style.top = (window.innerHeight - menuRect.height - 8) + 'px';
      }

      menu.querySelectorAll('button[data-act]').forEach(function (btn) {
        btn.addEventListener('click', function () {
          if (btn.hasAttribute('disabled')) return;
          var act = btn.getAttribute('data-act');
          closeContextMenu();
          performShapeAction(act);
        });
      });

      // Close on any subsequent click outside, or on Escape
      setTimeout(function () {
        document.addEventListener('mousedown', function outside(ev) {
          if (!menu.contains(ev.target)) {
            closeContextMenu();
            document.removeEventListener('mousedown', outside);
          }
        });
      }, 0);
    }

    function performShapeAction(act) {
      switch (act) {
        case 'dup':     duplicateSelection(); break;
        case 'delete':
          var sel = selectedShapeIds();
          if (!sel.length) return;
          pushCanvasHistory();
          var c = activeCanvas();
          c.shapes = c.shapes.filter(function (s) { return !isShapeSelected(s.id); });
          clearShapeSelection();
          saveImmediate();
          renderCanvasesTab();
          break;
        case 'front':   reorderSelection('front');    break;
        case 'fwd':     reorderSelection('forward');  break;
        case 'bwd':     reorderSelection('backward'); break;
        case 'back':    reorderSelection('back');     break;
        case 'group':   groupSelection();             break;
        case 'ungroup': ungroupSelection();           break;
        case 'alignL':  alignSelection('left');       break;
        case 'alignC':  alignSelection('center');     break;
        case 'alignR':  alignSelection('right');      break;
        case 'alignT':  alignSelection('top');        break;
        case 'alignM':  alignSelection('middle');     break;
        case 'alignB':  alignSelection('bottom');     break;
        case 'distH':   distributeSelection('h');     break;
        case 'distV':   distributeSelection('v');     break;
        case 'fit':     zoomToFit();                  break;
        case 'reset':
          var rc = activeCanvas();
          rc.viewport = { x: 0, y: 0, scale: 1 };
          saveImmediate();
          renderCanvasesTab();
          break;
      }
    }

    function zoomCanvasBy(factor) {
      var c = activeCanvas();
      var vp = c.viewport || (c.viewport = { x: 0, y: 0, scale: 1 });
      var newScale = Math.max(CNV_ZOOM_MIN, Math.min(CNV_ZOOM_MAX, vp.scale * factor));
      // Keep center of view stationary
      var view = getCanvasViewSize();
      var centerX = vp.x + (view.w / vp.scale) / 2;
      var centerY = vp.y + (view.h / vp.scale) / 2;
      vp.scale = newScale;
      vp.x = centerX - (view.w / vp.scale) / 2;
      vp.y = centerY - (view.h / vp.scale) / 2;
      saveImmediate();
      renderCanvasesTab();
    }

    function onCnvWheel(e) {
      // Only zoom when the canvases tab is active; otherwise let the
      // page scroll naturally.
      e.preventDefault();
      var svg = e.currentTarget;
      var p = clientToCnv(e, svg);   // model-space mouse coords BEFORE zoom
      var c = activeCanvas();
      var vp = c.viewport || (c.viewport = { x: 0, y: 0, scale: 1 });
      var oldScale = vp.scale;
      var factor = e.deltaY &lt; 0 ? 1.1 : 1 / 1.1;
      var newScale = Math.max(CNV_ZOOM_MIN, Math.min(CNV_ZOOM_MAX, oldScale * factor));
      if (newScale === oldScale) return;
      vp.scale = newScale;
      // Adjust viewport.x/y so the mouse-pointed model coord stays put
      var rect = svg.getBoundingClientRect();
      var mx = (e.clientX - rect.left) / rect.width;   // 0..1 across viewport
      var my = (e.clientY - rect.top)  / rect.height;
      var view = getCanvasViewSize();
      vp.x = p.x - mx * (view.w / newScale);
      vp.y = p.y - my * (view.h / newScale);
      renderCanvasesTab();
      // No history push for zoom — view-only state. But still save.
      saveDebounced();
    }

    function findShape(id) {
      return activeCanvas().shapes.filter(function (s) { return s.id === id; })[0];
    }

    // --- clipboard ops ---
    function copySelection() {
      var sel = selectedShapeIds();
      if (!sel.length) return;
      // Deep clone so further edits don't mutate the clipboard
      canvasClipboard = sel.map(function (id) {
        var s = findShape(id);
        return s ? JSON.parse(JSON.stringify(s)) : null;
      }).filter(Boolean);
    }
    function pasteClipboard() {
      if (!canvasClipboard.length) return;
      pushCanvasHistory();
      var c = activeCanvas();
      var newSel = {};
      // Re-map groupIds so pasted group stays grouped together but is distinct from original
      var groupRemap = {};
      canvasClipboard.forEach(function (src) {
        var copy = JSON.parse(JSON.stringify(src));
        copy.id = newId('shape-');
        // Offset 20px so the paste is visible distinct from the original
        moveShape(copy, 20, 20);
        // Re-key the groupId so pasted copies aren't accidentally joined
        // to the original group
        if (copy.groupId) {
          if (!groupRemap[copy.groupId]) groupRemap[copy.groupId] = newId('grp-');
          copy.groupId = groupRemap[copy.groupId];
        }
        c.shapes.push(copy);
        newSel[copy.id] = true;
      });
      canvasSelectedShapeIds = newSel;
      saveImmediate();
      renderCanvasesTab();
    }
    function duplicateSelection() {
      copySelection();
      pasteClipboard();
    }

    // --- z-order ---
    function reorderSelection(action) {
      var sel = selectedShapeIds();
      if (!sel.length) return;
      pushCanvasHistory();
      var c = activeCanvas();
      var selSet = {};
      sel.forEach(function (id) { selSet[id] = true; });
      var others = c.shapes.filter(function (s) { return !selSet[s.id]; });
      var theSelected = c.shapes.filter(function (s) { return selSet[s.id]; });
      if (action === 'front') {
        c.shapes = others.concat(theSelected);
      } else if (action === 'back') {
        c.shapes = theSelected.concat(others);
      } else if (action === 'forward') {
        // Move each selected one position later in the array (skip if at end or
        // immediately followed by another selected shape, to avoid hopping).
        for (var i = c.shapes.length - 2; i &gt;= 0; i--) {
          if (selSet[c.shapes[i].id] &amp;&amp; !selSet[c.shapes[i + 1].id]) {
            var tmp = c.shapes[i]; c.shapes[i] = c.shapes[i + 1]; c.shapes[i + 1] = tmp;
          }
        }
      } else if (action === 'backward') {
        for (var i2 = 1; i2 &lt; c.shapes.length; i2++) {
          if (selSet[c.shapes[i2].id] &amp;&amp; !selSet[c.shapes[i2 - 1].id]) {
            var tmp2 = c.shapes[i2]; c.shapes[i2] = c.shapes[i2 - 1]; c.shapes[i2 - 1] = tmp2;
          }
        }
      }
      saveImmediate();
      renderCanvasesTab();
    }

    // --- group / ungroup ---
    function groupSelection() {
      var sel = selectedShapeIds();
      if (sel.length &lt; 2) return;
      pushCanvasHistory();
      var gid = newId('grp-');
      sel.forEach(function (id) {
        var s = findShape(id);
        if (s) s.groupId = gid;
      });
      saveImmediate();
      renderCanvasesTab();
    }
    function ungroupSelection() {
      var sel = selectedShapeIds();
      if (!sel.length) return;
      pushCanvasHistory();
      sel.forEach(function (id) {
        var s = findShape(id);
        if (s) delete s.groupId;
      });
      saveImmediate();
      renderCanvasesTab();
    }

    // --- align / distribute ---
    function alignSelection(mode) {
      var sel = selectedShapeIds();
      if (sel.length &lt; 2) return;
      pushCanvasHistory();
      var boxes = sel.map(function (id) {
        var s = findShape(id);
        return s ? { shape: s, bbox: shapeBBox(s) } : null;
      }).filter(Boolean);

      var minX  = Math.min.apply(null, boxes.map(function (b) { return b.bbox.x; }));
      var maxX  = Math.max.apply(null, boxes.map(function (b) { return b.bbox.x + b.bbox.w; }));
      var minY  = Math.min.apply(null, boxes.map(function (b) { return b.bbox.y; }));
      var maxY  = Math.max.apply(null, boxes.map(function (b) { return b.bbox.y + b.bbox.h; }));
      var midX  = (minX + maxX) / 2;
      var midY  = (minY + maxY) / 2;

      boxes.forEach(function (b) {
        var bb = b.bbox;
        switch (mode) {
          case 'left':   moveShape(b.shape, minX - bb.x, 0); break;
          case 'center': moveShape(b.shape, midX - (bb.x + bb.w / 2), 0); break;
          case 'right':  moveShape(b.shape, maxX - (bb.x + bb.w), 0); break;
          case 'top':    moveShape(b.shape, 0, minY - bb.y); break;
          case 'middle': moveShape(b.shape, 0, midY - (bb.y + bb.h / 2)); break;
          case 'bottom': moveShape(b.shape, 0, maxY - (bb.y + bb.h)); break;
        }
      });
      saveImmediate();
      renderCanvasesTab();
    }

    function distributeSelection(axis) {
      var sel = selectedShapeIds();
      if (sel.length &lt; 3) return; // distribute requires 3+ items to be meaningful
      pushCanvasHistory();
      var boxes = sel.map(function (id) {
        var s = findShape(id);
        return s ? { shape: s, bbox: shapeBBox(s) } : null;
      }).filter(Boolean);

      boxes.sort(function (a, b) {
        return axis === 'h'
          ? (a.bbox.x + a.bbox.w / 2) - (b.bbox.x + b.bbox.w / 2)
          : (a.bbox.y + a.bbox.h / 2) - (b.bbox.y + b.bbox.h / 2);
      });

      var firstCenter = axis === 'h'
        ? boxes[0].bbox.x + boxes[0].bbox.w / 2
        : boxes[0].bbox.y + boxes[0].bbox.h / 2;
      var lastCenter = axis === 'h'
        ? boxes[boxes.length - 1].bbox.x + boxes[boxes.length - 1].bbox.w / 2
        : boxes[boxes.length - 1].bbox.y + boxes[boxes.length - 1].bbox.h / 2;
      var step = (lastCenter - firstCenter) / (boxes.length - 1);

      boxes.forEach(function (b, i) {
        if (i === 0 || i === boxes.length - 1) return;
        var bb = b.bbox;
        var target = firstCenter + step * i;
        var current = axis === 'h' ? bb.x + bb.w / 2 : bb.y + bb.h / 2;
        var delta = target - current;
        if (axis === 'h') moveShape(b.shape, delta, 0);
        else moveShape(b.shape, 0, delta);
      });
      saveImmediate();
      renderCanvasesTab();
    }

    function selectAllShapes() {
      var c = activeCanvas();
      c.shapes.forEach(function (s) { canvasSelectedShapeIds[s.id] = true; });
      renderCanvasesTab();
    }

    function zoomToFit() {
      var c = activeCanvas();
      if (!c.shapes.length) return;
      var minX = Infinity, minY = Infinity, maxX = -Infinity, maxY = -Infinity;
      c.shapes.forEach(function (s) {
        var bb = shapeBBox(s);
        if (bb.x &lt; minX) minX = bb.x;
        if (bb.y &lt; minY) minY = bb.y;
        if (bb.x + bb.w &gt; maxX) maxX = bb.x + bb.w;
        if (bb.y + bb.h &gt; maxY) maxY = bb.y + bb.h;
      });
      var pad = 40;
      var bw = (maxX - minX) + pad * 2;
      var bh = (maxY - minY) + pad * 2;
      var view = getCanvasViewSize();
      var sx = view.w / bw;
      var sy = view.h / bh;
      var scale = Math.min(sx, sy, CNV_ZOOM_MAX);
      scale = Math.max(CNV_ZOOM_MIN, scale);
      c.viewport = {
        x: (minX - pad) - ((view.w / scale) - bw) / 2,
        y: (minY - pad) - ((view.h / scale) - bh) / 2,
        scale: scale
      };
      saveImmediate();
      renderCanvasesTab();
    }

    // Shared insert helper: drops an image at the visible viewport
    // center and creates the shape. Used by pickImageForCanvas (file
    // picker) and the canvas paste handler.
    function insertImageOnCanvas(dataUrl, savedResult) {
      pushCanvasHistory();
      var c = activeCanvas();
      var vp = c.viewport || { x: 0, y: 0, scale: 1 };
      var view = getCanvasViewSize();
      var cx = vp.x + (view.w / vp.scale) / 2 - 120;
      var cy = vp.y + (view.h / vp.scale) / 2 - 90;
      var imgId = newId('img-');
      imageCache[imgId] = dataUrl;
      saveImageToHost(imgId, dataUrl, function (result) {
        if (result !== 'ok') {
          delete imageCache[imgId];
          console.error('[canvas paste] saveImage failed: ' + result);
          return;
        }
        c.shapes.push({
          id: newId('shape-'), type: 'image',
          x: snap(cx), y: snap(cy), w: 240, h: 180, imgId: imgId
        });
        saveImmediate();
        renderCanvasesTab();
      });
    }

    // Insert a text shape filled with pasted plain text. Each newline
    // becomes a &lt;p&gt;, matching the canvas text editor's contenteditable
    // semantics (text shape.text holds HTML).
    function insertTextOnCanvas(text) {
      pushCanvasHistory();
      var c = activeCanvas();
      var vp = c.viewport || { x: 0, y: 0, scale: 1 };
      var view = getCanvasViewSize();
      var fs = 16;
      // Reasonable default width; height grows on first render via the
      // text editor's autosize path. Drop near the viewport center.
      var w = 320;
      var cx = vp.x + (view.w / vp.scale) / 2 - w / 2;
      var cy = vp.y + (view.h / vp.scale) / 2 - fs;
      var html = String(text || '').split(/\r?\n/).map(function (line) {
        return '&lt;p&gt;' + (line ? escapeHtml(line) : '&lt;br&gt;') + '&lt;/p&gt;';
      }).join('');
      var tx = {
        id: newId('shape-'), type: 'text',
        x: snap(cx), y: snap(cy),
        w: w, h: fs * 2,
        text: html,
        color: canvasStroke,
        fontSize: fs,
        textAlign: 'left'
      };
      c.shapes.push(tx);
      selectOnlyShape(tx.id);
      saveImmediate();
      renderCanvasesTab();
    }

    // Document-level paste handler. Routes Ctrl+V (and right-click &gt;
    // Paste) onto the active canvas as either a text shape or an image
    // shape, but ONLY when the user isn't typing in a form input or
    // contenteditable elsewhere on the page.
    document.addEventListener('paste', function (e) {
      var activeTab = state &amp;&amp; state.settings &amp;&amp; state.settings.activeTab;
      if (activeTab !== 'canvases') return;
      var active = document.activeElement;
      // If the user is editing a canvas text shape (contenteditable=true)
      // or any input/textarea, let that editor handle the paste itself.
      if (active &amp;&amp; (active.tagName === 'INPUT' || active.tagName === 'TEXTAREA' || active.isContentEditable)) return;
      var cd = e.clipboardData;
      if (!cd) return;
      // 1) Image takes priority — many apps put both image and text on
      //    the clipboard; user wants the image.
      var items = cd.items || [];
      for (var i = 0; i &lt; items.length; i++) {
        var it = items[i];
        if (it.kind === 'file' &amp;&amp; it.type &amp;&amp; it.type.indexOf('image/') === 0) {
          var file = it.getAsFile();
          if (!file) continue;
          e.preventDefault();
          var reader = new FileReader();
          reader.onload = function () {
            insertImageOnCanvas(String(reader.result));
          };
          reader.readAsDataURL(file);
          return;
        }
      }
      // 2) Plain text → text shape
      var text = cd.getData('text/plain') || '';
      if (text) {
        e.preventDefault();
        insertTextOnCanvas(text);
      }
    });

    function pickImageForCanvas() {
      var input = document.createElement('input');
      input.type = 'file';
      input.accept = 'image/*';
      input.addEventListener('change', function (e) {
        var file = e.target.files &amp;&amp; e.target.files[0];
        if (!file) return;
        var reader = new FileReader();
        reader.onload = function () {
          insertImageOnCanvas(String(reader.result));
        };
        reader.readAsDataURL(file);
      });
      input.click();
    }

    function onCnvMouseDown(e) {
      // Right-click is handled by the contextmenu event — bail out here
      // so the active tool (e.g. Rectangle) doesn't start drawing a
      // shape underneath the menu.
      if (e.button === 2) return;
      // If a shape is currently in text-edit mode and the click is
      // inside that editor, do nothing (the editor handles its own
      // events — we shouldn't start a drag).
      if (canvasEditingShapeId) {
        var inEditor = e.target.closest &amp;&amp; e.target.closest('[data-shape-text-for="' + canvasEditingShapeId + '"]');
        if (inEditor) return;
      }

      var svg = e.currentTarget;
      var p = clientToCnv(e, svg);

      // 1. Pan mode: Space held OR middle mouse button → drag-pan
      //    regardless of tool. Middle button is treated as "I want to pan
      //    through a dense canvas" — common in PowerPoint, Miro,
      //    draw.io, etc.
      if (canvasSpaceDown || e.button === 1) {
        e.preventDefault();
        canvasInteraction = {
          mode: 'pan',
          startClientX: e.clientX,
          startClientY: e.clientY,
          origVpX: activeCanvas().viewport.x,
          origVpY: activeCanvas().viewport.y
        };
        var wrap = document.getElementById('cnv-stage-wrap');
        if (wrap) wrap.classList.add('panning');
        return;
      }

      // 2. Hit-test for a resize / rotate handle (priority over shape hit)
      var handleEl = e.target.closest &amp;&amp; e.target.closest('.cnv-handle');
      if (handleEl &amp;&amp; canvasTool === 'select') {
        var hShapeId = handleEl.getAttribute('data-shape-id');
        var hCorner  = handleEl.getAttribute('data-handle');
        var hShape   = findShape(hShapeId);
        if (hShape) {
          pushCanvasHistory();
          if (hCorner === 'rotate') {
            var rcx = hShape.x + (hShape.w || 0) / 2;
            var rcy = hShape.y + (hShape.h || 0) / 2;
            canvasInteraction = {
              mode: 'rotate', id: hShapeId,
              cx: rcx, cy: rcy,
              origRotation: hShape.rotation || 0,
              startAngle: Math.atan2(p.y - rcy, p.x - rcx)
            };
          } else {
            canvasInteraction = {
              mode: 'resize', id: hShapeId, corner: hCorner,
              origX: hShape.x, origY: hShape.y, origW: hShape.w, origH: hShape.h,
              origRot: hShape.rotation || 0,
              startX: p.x, startY: p.y
            };
          }
        }
        return;
      }

      // 3. Hit-test for a shape
      var hit = e.target.closest &amp;&amp; e.target.closest('[data-shape-id]');

      if (canvasTool === 'select') {
        if (hit) {
          var id = hit.getAttribute('data-shape-id');
          var s = findShape(id);
          if (!s) return;

          // Shift+click: toggle membership in selection. If the shape has
          // a groupId, the whole group toggles together.
          if (e.shiftKey) {
            var gmates = s.groupId
              ? activeCanvas().shapes.filter(function (x) { return x.groupId === s.groupId; }).map(function (x) { return x.id; })
              : [id];
            var addingIn = !isShapeSelected(id);
            gmates.forEach(function (mid) {
              if (addingIn) canvasSelectedShapeIds[mid] = true;
              else delete canvasSelectedShapeIds[mid];
            });
            renderCanvasesTab();
            return;
          }

          // Plain click — if the shape has a groupId, select the whole
          // group; otherwise just this shape. Preserve current selection
          // only if the shape was already selected.
          var selectionChanged = false;
          if (!isShapeSelected(id)) {
            clearShapeSelection();
            if (s.groupId) {
              activeCanvas().shapes.forEach(function (x) {
                if (x.groupId === s.groupId) canvasSelectedShapeIds[x.id] = true;
              });
            } else {
              canvasSelectedShapeIds[id] = true;
            }
            selectionChanged = true;
          }

          // Begin a drag that moves all selected shapes together
          var selIds = selectedShapeIds();
          var origs = {};
          selIds.forEach(function (sid) {
            var ss = findShape(sid);
            if (!ss) return;
            if (ss.type === 'line' || ss.type === 'arrow') {
              origs[sid] = { type: 'line', x1: ss.x1, y1: ss.y1, x2: ss.x2, y2: ss.y2 };
            } else if (ss.type === 'freedraw') {
              origs[sid] = { type: 'freedraw', points: ss.points.map(function (pt) { return [pt[0], pt[1]]; }) };
            } else {
              origs[sid] = { type: 'box', x: ss.x, y: ss.y };
            }
          });
          canvasInteraction = {
            mode: 'dragMulti',
            startX: p.x, startY: p.y,
            origs: origs,
            moved: false   // mousemove sets true; mouseup checks before saving
          };
          // Only re-render when selection actually changed. Re-rendering
          // here on every mousedown destroys the SVG element, which
          // prevents the browser from dispatching dblclick across both
          // clicks of a double-click (it tracks "same element").
          if (selectionChanged) renderCanvasesTab();
        } else {
          // Clicked empty space — clear selection
          if (Object.keys(canvasSelectedShapeIds).length) {
            clearShapeSelection();
            renderCanvasesTab();
          }
        }
        return;
      }

      // Shape creation tools
      var shapeTools = ['rect','roundrect','ellipse','diamond','triangle','hexagon'];
      if (shapeTools.indexOf(canvasTool) &gt;= 0) {
        pushCanvasHistory();
        var nid = newId('shape-');
        var sp = { x: snap(p.x), y: snap(p.y) };
        var shape = {
          id: nid, type: canvasTool,
          x: sp.x, y: sp.y, w: 1, h: 1,
          stroke: canvasStroke, fill: canvasFill, strokeWidth: canvasStrokeWidth,
          fillOpacity: canvasFillOpacity,
          text: ''
        };
        activeCanvas().shapes.push(shape);
        canvasInteraction = { mode: 'create-shape', id: nid, startX: sp.x, startY: sp.y };
        renderCanvasesTab();
        return;
      }

      if (canvasTool === 'line' || canvasTool === 'arrow') {
        pushCanvasHistory();
        var lid = newId('shape-');
        var lsp = { x: snap(p.x), y: snap(p.y) };
        var lineShape = {
          id: lid, type: canvasTool,
          x1: lsp.x, y1: lsp.y, x2: lsp.x, y2: lsp.y,
          stroke: canvasStroke, strokeWidth: canvasStrokeWidth
        };
        activeCanvas().shapes.push(lineShape);
        canvasInteraction = { mode: 'create-line', id: lid };
        renderCanvasesTab();
        return;
      }

      if (canvasTool === 'freedraw') {
        pushCanvasHistory();
        var fid = newId('shape-');
        var fd = {
          id: fid, type: 'freedraw',
          points: [[p.x, p.y]],
          stroke: canvasStroke, strokeWidth: canvasStrokeWidth
        };
        activeCanvas().shapes.push(fd);
        canvasInteraction = { mode: 'create-freedraw', id: fid };
        renderCanvasesTab();
        return;
      }

      if (canvasTool === 'text') {
        pushHistory();
        var tid = newId('shape-');
        var tFs = 16;
        var tx = {
          id: tid, type: 'text',
          x: snap(p.x), y: snap(p.y),    // top-left of the text box
          w: 220, h: tFs * 2,
          text: '&lt;p&gt;&lt;br&gt;&lt;/p&gt;',           // empty paragraph so contenteditable has a baseline
          color: canvasStroke,
          fontSize: tFs,
          textAlign: 'left'
        };
        activeCanvas().shapes.push(tx);
        selectOnlyShape(tid);
        canvasTool = 'select';
        saveImmediate();
        renderCanvasesTab();
        setTimeout(function () { openShapeTextEditor(tid); }, 0);
      }
    }

    document.addEventListener('mousemove', function (e) {
      if (!canvasInteraction) return;
      var svg = document.getElementById('cnv-stage');
      if (!svg) return;
      var mode = canvasInteraction.mode;

      // PAN — Space + drag. Operates in client coords (px) translated to
      // viewport units via scale.
      if (mode === 'pan') {
        var c = activeCanvas();
        var rect = svg.getBoundingClientRect();
        var dxc = e.clientX - canvasInteraction.startClientX;
        var dyc = e.clientY - canvasInteraction.startClientY;
        // Translate client-px delta to model-units. 1 client px = (view.w/scale)/rect.width model units.
        var view = getCanvasViewSize();
        var unitsPerPxX = (view.w / c.viewport.scale) / rect.width;
        var unitsPerPxY = (view.h / c.viewport.scale) / rect.height;
        c.viewport.x = canvasInteraction.origVpX - dxc * unitsPerPxX;
        c.viewport.y = canvasInteraction.origVpY - dyc * unitsPerPxY;
        svg.setAttribute('viewBox', c.viewport.x + ' ' + c.viewport.y + ' ' +
                                    (view.w / c.viewport.scale) + ' ' +
                                    (view.h / c.viewport.scale));
        return;
      }

      var p = clientToCnv(e, svg);

      if (mode === 'dragMulti') {
        var dx = snap(p.x - canvasInteraction.startX);
        var dy = snap(p.y - canvasInteraction.startY);
        if (!dx &amp;&amp; !dy) return;
        if (!canvasInteraction.moved) {
          // First measurable movement — capture history once, then
          // start mutating positions. This way a pure click (no drag)
          // doesn't pollute the undo stack with a no-op snapshot.
          pushHistory();
          canvasInteraction.moved = true;
        }
        Object.keys(canvasInteraction.origs).forEach(function (sid) {
          var s = findShape(sid);
          var orig = canvasInteraction.origs[sid];
          if (!s || !orig) return;
          if (orig.type === 'line') {
            s.x1 = orig.x1 + dx; s.y1 = orig.y1 + dy;
            s.x2 = orig.x2 + dx; s.y2 = orig.y2 + dy;
          } else if (orig.type === 'freedraw') {
            s.points = orig.points.map(function (pt) { return [pt[0] + dx, pt[1] + dy]; });
          } else {
            s.x = orig.x + dx; s.y = orig.y + dy;
          }
          updateShapeElement(s);
        });
        // Move the resize/rotation handles along with the shape — without
        // this, the handles get left behind at the original position until
        // the drag ends and the canvas re-renders.
        updateSelectionHandlesInPlace();
        showDimLabel(null);
        return;
      }

      if (mode === 'rotate') {
        var rs = findShape(canvasInteraction.id);
        if (!rs) return;
        canvasInteraction.moved = true;
        var dx = p.x - canvasInteraction.cx;
        var dy = p.y - canvasInteraction.cy;
        var currentAngle = Math.atan2(dy, dx);
        var deltaDeg = (currentAngle - canvasInteraction.startAngle) * 180 / Math.PI;
        var newRot = canvasInteraction.origRotation + deltaDeg;
        // Hold Shift to snap to 15° increments
        if (e.shiftKey) newRot = Math.round(newRot / 15) * 15;
        // Normalize to (-180, 180]
        while (newRot &gt; 180)  newRot -= 360;
        while (newRot &lt;= -180) newRot += 360;
        rs.rotation = Math.round(newRot);
        showDimLabel(rs.rotation + '°');
        renderCanvasesTab();   // also refreshes handle positions
        return;
      }

      if (mode === 'resize') {
        var s = findShape(canvasInteraction.id);
        if (!s) return;
        // For rotated shapes, rotate the world-delta by -origRot so the
        // existing axis-aligned resize math operates in the shape's
        // local (unrotated) frame.
        var dxw = p.x - canvasInteraction.startX;
        var dyw = p.y - canvasInteraction.startY;
        var dx2, dy2;
        if (canvasInteraction.origRot) {
          var rad = -canvasInteraction.origRot * Math.PI / 180;
          dx2 = dxw * Math.cos(rad) - dyw * Math.sin(rad);
          dy2 = dxw * Math.sin(rad) + dyw * Math.cos(rad);
        } else {
          dx2 = dxw; dy2 = dyw;
        }
        var nx = canvasInteraction.origX, ny = canvasInteraction.origY;
        var nw = canvasInteraction.origW, nh = canvasInteraction.origH;
        switch (canvasInteraction.corner) {
          case 'nw': nx = canvasInteraction.origX + dx2; ny = canvasInteraction.origY + dy2;
                     nw = canvasInteraction.origW - dx2; nh = canvasInteraction.origH - dy2; break;
          case 'ne': ny = canvasInteraction.origY + dy2;
                     nw = canvasInteraction.origW + dx2; nh = canvasInteraction.origH - dy2; break;
          case 'sw': nx = canvasInteraction.origX + dx2;
                     nw = canvasInteraction.origW - dx2; nh = canvasInteraction.origH + dy2; break;
          case 'se': nw = canvasInteraction.origW + dx2; nh = canvasInteraction.origH + dy2; break;
        }
        // Hold Shift to constrain aspect ratio
        if (e.shiftKey &amp;&amp; canvasInteraction.origW &gt; 0 &amp;&amp; canvasInteraction.origH &gt; 0) {
          var aspect = canvasInteraction.origW / canvasInteraction.origH;
          if (Math.abs(nw) / Math.abs(nh) &gt; aspect) nw = Math.sign(nw) * Math.abs(nh) * aspect;
          else nh = Math.sign(nh) * Math.abs(nw) / aspect;
        }
        // Don't allow negative w/h — clamp to 4px min
        if (nw &lt; 4)  { nx += nw - 4;  nw = 4; }
        if (nh &lt; 4)  { ny += nh - 4;  nh = 4; }
        s.x = snap(nx); s.y = snap(ny);
        s.w = Math.max(4, snap(nw));
        s.h = Math.max(4, snap(nh));
        showDimLabel(Math.round(s.w) + ' × ' + Math.round(s.h));
        // Re-render the whole stage to also update the handle positions
        renderCanvasesTab();
        return;
      }

      var s = findShape(canvasInteraction.id);
      if (!s) return;

      if (mode === 'create-shape') {
        s.x = snap(Math.min(canvasInteraction.startX, p.x));
        s.y = snap(Math.min(canvasInteraction.startY, p.y));
        s.w = Math.max(2, Math.abs(snap(p.x) - canvasInteraction.startX));
        s.h = Math.max(2, Math.abs(snap(p.y) - canvasInteraction.startY));
        showDimLabel(Math.round(s.w) + ' × ' + Math.round(s.h));
        updateShapeElement(s);
        return;
      }
      if (mode === 'create-line') {
        s.x2 = snap(p.x); s.y2 = snap(p.y);
        updateShapeElement(s);
        return;
      }
      if (mode === 'create-freedraw') {
        s.points.push([p.x, p.y]);
        updateShapeElement(s);
        return;
      }
    });

    document.addEventListener('mouseup', function () {
      if (!canvasInteraction) return;
      var mode = canvasInteraction.mode;
      // For create-shape: if user just clicked without dragging, bump
      // the shape to a usable size.
      if (mode === 'create-shape') {
        var s = findShape(canvasInteraction.id);
        if (s &amp;&amp; s.w &lt; 20 &amp;&amp; s.h &lt; 20) { s.w = 120; s.h = 80; }
      }
      // Smooth free-draw on commit if the setting is on
      if (mode === 'create-freedraw' &amp;&amp; cnvSettings().smoothFreedraw) {
        var fs = findShape(canvasInteraction.id);
        if (fs) fs.points = smoothPolyline(fs.points);
      }
      var wasPan  = (mode === 'pan');
      // dragMulti: only treat as a real action if the user actually moved.
      // A pure click on an already-selected shape would otherwise save
      // and re-render — which destroys the SVG element between clicks
      // and prevents the browser from firing dblclick.
      var isClickOnly = (mode === 'dragMulti' &amp;&amp; !canvasInteraction.moved);
      canvasInteraction = null;
      showDimLabel(null);
      // Clean up panning cursor if it was added by middle-mouse pan
      // (Space-driven pan still needs the class while Space is held).
      if (wasPan &amp;&amp; !canvasSpaceDown) {
        var wrap = document.getElementById('cnv-stage-wrap');
        if (wrap) wrap.classList.remove('panning');
      }
      if (isClickOnly) return;          // no state mutation → no save / render
      if (!wasPan) saveImmediate();
      else saveDebounced();
      renderCanvasesTab();
    });

    // Suppress the browser's default middle-button autoscroll on the
    // canvas stage so our pan handler can take over cleanly.
    document.addEventListener('auxclick', function (e) {
      if (e.button !== 1) return;
      var target = e.target.closest &amp;&amp; e.target.closest('#cnv-stage, #cnv-stage-wrap');
      if (target) e.preventDefault();
    });

    // Lightweight polyline smoothing — averages adjacent points so
    // free-draw strokes look less jittery.
    function smoothPolyline(pts) {
      if (!pts || pts.length &lt; 3) return pts;
      var out = [pts[0]];
      for (var i = 1; i &lt; pts.length - 1; i++) {
        out.push([
          (pts[i - 1][0] + pts[i][0] + pts[i + 1][0]) / 3,
          (pts[i - 1][1] + pts[i][1] + pts[i + 1][1]) / 3
        ]);
      }
      out.push(pts[pts.length - 1]);
      return out;
    }

    function showDimLabel(text) {
      var existing = document.querySelector('.cnv-dim-label');
      if (existing) existing.parentNode.removeChild(existing);
      if (!text || !cnvSettings().showDimensions) return;
      var wrap = document.getElementById('cnv-stage-wrap');
      if (!wrap) return;
      var div = document.createElement('div');
      div.className = 'cnv-dim-label';
      div.textContent = text;
      wrap.appendChild(div);
    }

    // Patch a single shape's SVG element in place without re-rendering
    // the whole stage. Used during drag/create for fluid feedback.
    function updateShapeElement(s) {
      var svg = document.getElementById('cnv-stage');
      if (!svg) return;
      var existing = svg.querySelector('[data-shape-id="' + s.id + '"]');
      if (!existing) return;
      var wrapper = document.createElementNS('http://www.w3.org/2000/svg', 'g');
      wrapper.innerHTML = shapeToSVG(s);
      var fresh = wrapper.firstChild;
      existing.parentNode.replaceChild(fresh, existing);
    }

    function onCnvDoubleClick(e) {
      var hit = e.target.closest &amp;&amp; e.target.closest('[data-shape-id]');
      if (!hit) return;
      var id = hit.getAttribute('data-shape-id');
      var s = findShape(id);
      if (!s) return;
      if (['rect','roundrect','ellipse','diamond','triangle','hexagon','text'].indexOf(s.type) &lt; 0) return;
      e.preventDefault();
      // Defer one tick past the current event loop so that the mouseup
      // handler's renderCanvasesTab() (from the just-finished
      // dragMulti interaction) is done re-creating the SVG. Otherwise
      // we'd add the input to a soon-to-be-discarded wrap.
      setTimeout(function () { openShapeTextEditor(id); }, 0);
    }

    // Track the shape currently in text-edit mode so the canvas
    // mousedown handler can defer to the editor (no drag while typing).
    var canvasEditingShapeId = null;

    function openShapeTextEditor(shapeId) {
      var s = findShape(shapeId);
      if (!s) return;
      var svg = document.getElementById('cnv-stage');
      if (!svg) return;

      // Close any other text editor first
      closeShapeTextEditor();

      // Find the inner editable div (it's rendered inside foreignObject)
      var div = svg.querySelector('[data-shape-text-for="' + shapeId + '"]');
      if (!div) {
        // For shapes that don't have any text yet, the textEl wasn't
        // rendered (we only emit it when s.text is truthy). Seed empty
        // HTML and re-render so the foreignObject exists.
        if (s.text === undefined || s.text === '' || s.text === null) {
          s.text = '&lt;p&gt;&lt;br&gt;&lt;/p&gt;';
          renderCanvasesTab();
          div = svg.querySelector('[data-shape-text-for="' + shapeId + '"]');
        }
        if (!div) return;
      }

      div.setAttribute('contenteditable', 'true');
      canvasEditingShapeId = shapeId;

      // Position-and-focus on next frame so the layout settles first
      // (otherwise focus inside a freshly-flipped foreignObject can
      // misbehave in CEF).
      requestAnimationFrame(function () {
        div.focus();
        // Place cursor at end so user can immediately start typing
        var range = document.createRange();
        range.selectNodeContents(div);
        range.collapse(false);
        var sel = window.getSelection();
        sel.removeAllRanges();
        sel.addRange(range);
        positionCanvasTextToolbar(div);
      });

      // Stop drag-on-shape while editing — clicks inside the editor go
      // to the editor, not to the SVG mousedown handler.
      div.addEventListener('mousedown', stopProp);
      div.addEventListener('dblclick',  stopProp);

      // Mount the format toolbar
      showCanvasTextToolbar(div, s);

      // Auto-grow text-shape height to fit content while typing
      var isText = (s.type === 'text');

      function commit() {
        if (canvasEditingShapeId !== shapeId) return; // already closed
        var newHtml = div.innerHTML;
        // Strip embedded data: URLs the same way note/card bodies do
        newHtml = stripDataUrls(newHtml);
        if (newHtml !== s.text) {
          pushHistory();
          s.text = newHtml;
          if (isText) {
            // Grow-only: if the content overflows the current height,
            // expand the shape to fit. Never shrink — that would undo
            // a height the user explicitly set by dragging a handle.
            var requiredH = div.scrollHeight + 4;
            if (requiredH &gt; s.h) s.h = Math.round(requiredH);
          }
          saveImmediate();
        }
        div.removeEventListener('mousedown', stopProp);
        div.removeEventListener('dblclick',  stopProp);
        canvasEditingShapeId = null;
        hideCanvasTextToolbar();
        renderCanvasesTab();
      }

      div.addEventListener('blur', function () {
        // Defer so a click on the toolbar or an editor-spawned popover
        // (color picker, link prompt, image picker) doesn't trigger
        // commit. Those are transient UIs the editor relies on.
        setTimeout(function () {
          var actEl = document.activeElement;
          if (!actEl) return;
          if (div.contains(actEl)) return;
          var tb = document.getElementById('cnv-text-toolbar-wrap');
          if (tb &amp;&amp; tb.contains(actEl)) return;
          if (actEl.closest &amp;&amp; actEl.closest('.color-popover, .inline-prompt')) return;
          commit();
        }, 0);
      });
      div.addEventListener('keydown', function (e) {
        if (e.key === 'Escape') { e.preventDefault(); commit(); }
      });
      div.addEventListener('input', function () {
        if (isText) {
          // Grow-only during typing too; preserves any manual resize.
          var requiredH = div.scrollHeight + 4;
          if (requiredH &gt; s.h) s.h = Math.round(requiredH);
        }
        positionCanvasTextToolbar(div);
      });
      div.addEventListener('paste', function (e) {
        handlePaste(e, div, function () {
          // image paste already wrote the &lt;img data-img-id=...&gt; into
          // the editor; nothing more to do — commit on blur picks it up
        });
      });
    }

    function stopProp(e) { e.stopPropagation(); }

    function closeShapeTextEditor() {
      if (!canvasEditingShapeId) return;
      var prev = document.querySelector('[data-shape-text-for="' + canvasEditingShapeId + '"]');
      if (prev) prev.removeAttribute('contenteditable');
      canvasEditingShapeId = null;
      hideCanvasTextToolbar();
    }

    function showCanvasTextToolbar(editor, shape) {
      hideCanvasTextToolbar();
      var wrap = document.createElement('div');
      wrap.id = 'cnv-text-toolbar-wrap';
      wrap.innerHTML = renderToolbar('cnv-shape-editor');
      document.body.appendChild(wrap);
      var tb = wrap.firstChild;
      wireToolbar(tb, editor);
      positionCanvasTextToolbar(editor);
    }

    function hideCanvasTextToolbar() {
      var t = document.getElementById('cnv-text-toolbar-wrap');
      if (t &amp;&amp; t.parentNode) t.parentNode.removeChild(t);
    }

    function positionCanvasTextToolbar(editor) {
      var wrap = document.getElementById('cnv-text-toolbar-wrap');
      if (!wrap) return;
      var er = editor.getBoundingClientRect();
      var tw = wrap.offsetWidth || 300;
      var th = wrap.offsetHeight || 36;
      var left = er.left;
      var top  = er.top - th - 6;
      if (top &lt; 6) top = er.bottom + 6;     // not enough room above, drop below
      if (left + tw &gt; window.innerWidth - 6) left = window.innerWidth - tw - 6;
      if (left &lt; 6) left = 6;
      wrap.style.left = left + 'px';
      wrap.style.top  = top + 'px';
    }

    // Global keyboard handler. Ctrl+Z / Ctrl+Y work on every tab — they
    // undo/redo the entire state. Tab-specific shortcuts (canvas
    // copy/paste/group/etc.) only fire when that tab is active.
    document.addEventListener('keydown', function (e) {
      var tab = document.querySelector('.tab-pane.active');
      var onCnv = tab &amp;&amp; tab.id === 'tab-canvases';
      var active = document.activeElement;
      var typing = active &amp;&amp; (active.tagName === 'INPUT' || active.tagName === 'TEXTAREA' || active.isContentEditable);
      // For global undo/redo we only defer to native handling inside a
      // contenteditable (note/card body) where char-by-char native undo
      // matters. In single-line inputs (titles, column names, settings
      // fields) we'd rather let global undo work even with focus
      // there — the input's tiny char-undo isn't valuable enough to
      // strand the user's discrete-action undo.
      var inEditable = active &amp;&amp; active.isContentEditable;

      // Global undo/redo — any tab, except inside a contenteditable
      // (where we defer to the browser's native per-char undo). Note:
      // FlexSim's WebPanel host eats bare Ctrl+Z before CEF sees it,
      // so these bindings only fire reliably for Ctrl+Shift+Z (redo).
      // The user-facing path is the per-tab Undo/Redo buttons.
      if ((e.ctrlKey || e.metaKey) &amp;&amp; !inEditable) {
        if ((e.key === 'z' || e.key === 'Z') &amp;&amp; !e.shiftKey) { e.preventDefault(); undoOp(); return; }
        if ((e.key === 'z' || e.key === 'Z') &amp;&amp;  e.shiftKey) { e.preventDefault(); redoOp(); return; }
        if  (e.key === 'y' || e.key === 'Y')                 { e.preventDefault(); redoOp(); return; }
      }

      // Canvas-only Ctrl shortcuts
      if (onCnv &amp;&amp; (e.ctrlKey || e.metaKey)) {
        if (typing) return;
        // Copy / paste / duplicate
        if (e.key === 'c' || e.key === 'C') { e.preventDefault(); copySelection(); return; }
        if (e.key === 'v' || e.key === 'V') { e.preventDefault(); pasteClipboard(); return; }
        if (e.key === 'd' || e.key === 'D') { e.preventDefault(); duplicateSelection(); return; }
        // Select all
        if (e.key === 'a' || e.key === 'A') { e.preventDefault(); selectAllShapes(); return; }
        // Group / ungroup
        if ((e.key === 'g' || e.key === 'G') &amp;&amp; !e.shiftKey) { e.preventDefault(); groupSelection(); return; }
        if ((e.key === 'g' || e.key === 'G') &amp;&amp;  e.shiftKey) { e.preventDefault(); ungroupSelection(); return; }
        // Z-order: ] / [
        if (e.key === ']' &amp;&amp; !e.shiftKey)  { e.preventDefault(); reorderSelection('forward'); return; }
        if (e.key === '[' &amp;&amp; !e.shiftKey)  { e.preventDefault(); reorderSelection('backward'); return; }
        if (e.key === ']' &amp;&amp;  e.shiftKey)  { e.preventDefault(); reorderSelection('front');   return; }
        if (e.key === '[' &amp;&amp;  e.shiftKey)  { e.preventDefault(); reorderSelection('back');    return; }
        // Zoom to fit
        if ((e.key === 'f' || e.key === 'F') &amp;&amp; e.shiftKey) { e.preventDefault(); zoomToFit(); return; }
      }

      // Space → enter pan-mode while held (only on canvases tab, not while typing)
      if (e.code === 'Space' &amp;&amp; onCnv &amp;&amp; !typing) {
        if (!canvasSpaceDown) {
          canvasSpaceDown = true;
          var wrap = document.getElementById('cnv-stage-wrap');
          if (wrap) wrap.classList.add('panning');
        }
        e.preventDefault();
        return;
      }

      // Esc on canvases tab → switch back to Select tool (also closes any
      // open canvas-settings dropdown / context menu).
      if (e.key === 'Escape' &amp;&amp; onCnv &amp;&amp; !typing) {
        if (canvasTool !== 'select') {
          canvasTool = 'select';
          renderCanvasesTab();
          e.preventDefault();
          return;
        }
        // If Select was already active, fall through so the global Esc
        // handler can dismiss any open modal / overlay.
      }

      // Delete / Backspace removes all selected shapes (only when not editing)
      if ((e.key === 'Delete' || e.key === 'Backspace') &amp;&amp; onCnv &amp;&amp; !typing) {
        var sel = selectedShapeIds();
        if (!sel.length) return;
        e.preventDefault();
        pushCanvasHistory();
        var c = activeCanvas();
        c.shapes = c.shapes.filter(function (s) { return !isShapeSelected(s.id); });
        clearShapeSelection();
        saveImmediate();
        renderCanvasesTab();
      }
    });

    document.addEventListener('keyup', function (e) {
      if (e.code === 'Space') {
        canvasSpaceDown = false;
        var wrap = document.getElementById('cnv-stage-wrap');
        if (wrap) wrap.classList.remove('panning');
      }
    });

    // Global keydown — Esc closes the properties panel (but only when no
    // modal is on top, since those have their own Esc handlers).
    document.addEventListener('keydown', function (e) {
      if (e.key !== 'Escape') return;
      if (!selectedCardId) return;
      if (document.querySelector('.confirm-backdrop')) return;
      if (document.querySelector('.lightbox-overlay')) return;
      e.preventDefault();
      closeProperties();
    });

    // --- settings dropdown ---
    function closeSettings() {
      var root = document.getElementById('settings-root');
      if (root) root.innerHTML = '';
    }

    function openSettings(anchorBtn) {
      closeSettings();
      var s = getSettings();
      var root = document.getElementById('settings-root');

      function optGroup(rowLabel, key, current, options) {
        var html = '&lt;div class="settings-row"&gt;&lt;h4&gt;' + rowLabel + '&lt;/h4&gt;&lt;div class="options"&gt;';
        options.forEach(function (o) {
          var cls = 'opt' + (o.value === current ? ' active' : '');
          html += '&lt;button class="' + cls + '" data-key="' + key + '" data-value="' + o.value + '"&gt;' + escapeHtml(o.label) + '&lt;/button&gt;';
        });
        html += '&lt;/div&gt;&lt;/div&gt;';
        return html;
      }

      var curDelay = getSettings().autoSaveDelay || 1000;
      var html = '&lt;div class="settings-dropdown"&gt;';
      // applyTheme normalizes themeMode to the strings 'light' or 'dark'
      // (legacy numeric 0/1 values get coerced on load), so compare to
      // 'light'. The old check used themeMode === 1, which is always
      // false against a string and made the Dark button look selected
      // even when the user was in light mode.
      html += optGroup('Theme', 'mode', themeMode === 'light' ? 'light' : 'dark', [
        { value: 'dark', label: 'Dark' }, { value: 'light', label: 'Light' }
      ]);
      html += '&lt;div class="settings-row"&gt;' +
                '&lt;h4&gt;Autosave delay&lt;/h4&gt;' +
                '&lt;div class="options"&gt;' +
                  '&lt;input type="number" class="settings-num" id="settings-autosave" ' +
                         'min="200" max="10000" step="100" value="' + curDelay + '" /&gt; ' +
                  '&lt;span class="settings-suffix"&gt;ms&lt;/span&gt;' +
                '&lt;/div&gt;' +
                '&lt;div class="settings-hint"&gt;Delay before typing is saved (200–10000 ms).&lt;/div&gt;' +
              '&lt;/div&gt;';
      html += '&lt;/div&gt;';
      root.innerHTML = html;

      // Position the dropdown anchored to the settings button
      var dd = root.querySelector('.settings-dropdown');
      var rect = anchorBtn.getBoundingClientRect();
      dd.style.top = (rect.bottom + 4) + 'px';
      dd.style.right = (window.innerWidth - rect.right) + 'px';

      // Wire up segmented options
      dd.querySelectorAll('.opt').forEach(function (btn) {
        btn.addEventListener('click', function () {
          var key = btn.getAttribute('data-key');
          var value = btn.getAttribute('data-value');
          applySettingChange(key, value);
          // Update visual active state without re-rendering the whole dropdown
          dd.querySelectorAll('.opt[data-key="' + key + '"]').forEach(function (b) { b.classList.remove('active'); });
          btn.classList.add('active');
        });
      });

      // Wire up the autosave-delay number field. Commit on change/blur.
      var autosaveInput = document.getElementById('settings-autosave');
      if (autosaveInput) {
        var commitAutosave = function () {
          var v = parseInt(autosaveInput.value, 10);
          if (isNaN(v)) v = 1000;
          v = Math.max(200, Math.min(10000, v));
          autosaveInput.value = v;
          applySettingChange('autoSaveDelay', v);
        };
        autosaveInput.addEventListener('change', commitAutosave);
        autosaveInput.addEventListener('blur',   commitAutosave);
      }

      // Close on outside click (next tick to avoid catching the opening click)
      setTimeout(function () {
        document.addEventListener('mousedown', function outside(e) {
          if (!dd.contains(e.target) &amp;&amp; e.target !== anchorBtn) {
            closeSettings();
            document.removeEventListener('mousedown', outside);
          }
        });
      }, 0);
    }

    function applySettingChange(key, value) {
      if (key === 'mode') {
        applyTheme(value);
        if (state &amp;&amp; state.settings) {
          state.settings.mode = (value === 'light') ? 'light' : 'dark';
          saveDebounced('settings');
        }
        return;
      }
      var s = getSettings();
      s[key] = value;
      if (key === 'editorFontSize') applyFontSizeSetting();
      saveImmediate('settings');
    }

    // --- about modal ---
    function closeAbout() {
      var root = document.getElementById('about-root');
      if (root) root.innerHTML = '';
    }

    // Practical Simulation Solutions logo, single-shade. Inlined so the
    // module is self-contained and the path renders even before any
    // bitmap loads. Color is overridden via CSS for light theme.
    var PRACSIM_LOGO_SVG = '&lt;svg class="about-logo" viewBox="0 0 84.5 45.5" xmlns="http://www.w3.org/2000/svg"&gt;&lt;g transform="translate(-3.2,25.146522)"&gt;&lt;path d="m 34.603785,-21.076523 c -8.556282,3.259701 -14.59553,12.3025982 -23.556642,14.0138511 -1.8617629,0.3555303 -5.4449971,-0.7983164 -5.6302241,-0.7960164 1.652255,2.6784805 6.2502851,3.8175543 8.8885061,3.3111333 11.422684,-2.1926477 15.591455,-11.803672 24.749576,-14.622797 4.623706,-1.423305 10.071824,-1.763969 14.484107,-0.922373 -2.266487,-2.65454 -8.577489,-3.099641 -14.298917,-2.163576 -1.305816,0.213641 -3.400511,0.708937 -4.636406,1.179778 z m 29.112418,-1.908891 c 0,0 -1.122628,-0.01027 -2.369881,0.869198 -4.127338,2.91027 -13.19489,10.288315 -17.84749,15.5225667 C 35.95036,1.8985082 33.862672,13.996155 25.714388,18.324726 24.543854,18.946543 38.834957,15.068789 46.316748,8.2602244 l 5.325256,8.0630736 6.816639,0.04341 c 0.600095,1.169613 1.807746,1.901559 3.12229,1.892391 1.910708,-0.01702 3.450736,-1.570657 3.450952,-3.481441 l -0.0021,-0.124023 c -0.06796,-1.909853 -1.662531,-3.408019 -3.572909,-3.356901 -1.342053,0.03677 -2.543413,0.841832 -3.087667,2.069124 l -5.106148,-0.03307 -3.530017,-5.3428263 14.483354,0.00672 4.189408,8.0863283 8.357113,-0.02377 3.738273,-4.204395 c 0.309472,0.08547 0.629278,0.127729 0.950329,0.125574 1.911112,-0.01674 3.451534,-1.570773 3.451469,-3.4819581 L 84.90039,8.3749542 C 84.83243,6.465309 83.238177,4.9672243 81.327999,5.0180532 c -1.910138,0.051038 -3.422277,1.6318993 -3.388424,3.5424194 0.01017,0.4579998 0.110619,0.9094911 0.295589,1.3286011 l -2.8236,3.1744833 -5.18573,0.0155 -4.185274,-8.0821942 -16.708541,-0.00723 c 0.569657,-0.7584548 1.084768,-1.5439925 1.516186,-2.36368 0.36531,-0.6093895 0.686607,-1.1642659 1.038697,-1.75751546 L 64.858769,0.73716941 69.310693,4.4914622 c -0.06005,0.2628842 -0.08936,0.531854 -0.08733,0.8015015 0.03397,1.9106953 1.601526,3.436973 3.512447,3.4199463 1.910909,-0.017025 3.451019,-1.5709729 3.450952,-3.481958 l -0.0021,-0.1240235 c -0.06796,-1.9098521 -1.662531,-3.4080188 -3.572908,-3.356901 -0.508116,0.014332 -1.006932,0.139742 -1.46141,0.3674194 l -5.209501,-4.39198 -12.269535,0.1240235 c 1.057745,-1.8100844 2.068118,-3.5575379 3.01842,-5.2188029 l 7.253304,-0.028422 1.580266,-1.480013 7.388179,7.323584 h 4.275708 c 0.59325,1.19019919 1.812624,1.93854722 3.142444,1.92856445 1.910909,-0.0170251 3.45102,-1.57097295 3.450952,-3.48195805 l -0.0021,-0.1240234 c -0.06796,-1.9096456 -1.662214,-3.4077304 -3.572392,-3.356901 -1.327629,0.037144 -2.518498,0.8263133 -3.070096,2.0345011 h -2.989999 l -6.432165,-6.3753216 0.592212,-0.554488 2.122867,-0.02119 c 0.556593,1.278899 1.822642,2.1022579 3.217375,2.0923784 1.910909,-0.017025 3.45102,-1.5709734 3.450952,-3.4819584 l -0.0021,-0.123506 c -0.06796,-1.909852 -1.662531,-3.408019 -3.572908,-3.356901 -1.259727,0.03706 -2.401105,0.751928 -2.984314,1.869136 l -3.429248,0.03566 -4.35529,4.076237 -4.358907,0.01705 c 3.176521,-5.626941 5.324223,-9.606649 5.324223,-9.606649 h 9.854695 l 5.0276,4.138249 c -0.07162,0.287774 -0.106173,0.583518 -0.102836,0.88005 0.03397,1.910492 1.60121,3.436688 3.511931,3.419946 1.911112,-0.01674 3.451534,-1.570773 3.451469,-3.481958 l -0.0026,-0.123507 c -0.06768,-1.90985 -1.662019,-3.408243 -3.572392,-3.357418 -0.482592,0.01383 -0.957035,0.127863 -1.393197,0.334864 L 74.64979,-22.98335 H 63.71672 Z M 10.526685,-1.8332164 c -2.7607214,-0.9715448 -4.5805994,-2.563151 -4.5805994,-2.563151 0,0 7.0510234,10.5831046 12.5921844,10.8920061 8.966024,0.4998265 17.275516,-9.9067802 22.207761,-15.2502486 4.932245,-5.3434691 8.519499,-7.0198771 11.942151,-9.2709121 -8.120604,0.482899 -8.232632,0.384575 -12.142017,1.55321 C 29.87965,-13.283764 23.529833,1.7412127 10.526685,-1.8332164 Z M 5.4169189,-0.12427672 C 17.03958,32.179365 30.737387,12.552566 35.607808,0.39971733 24.612453,10.687389 18.193032,13.576628 5.4169189,-0.12427672 Z"/&gt;&lt;/g&gt;&lt;/svg&gt;';

    function openAbout() {
      var root = document.getElementById('about-root');
      root.innerHTML =
        '&lt;div class="about-backdrop"&gt;' +
          '&lt;div class="about-box"&gt;' +
            PRACSIM_LOGO_SVG +
            '&lt;div class="about-tagline"&gt;Practical Simulation Solutions&lt;/div&gt;' +
            '&lt;div class="about-product"&gt;PracSim Notebook&lt;/div&gt;' +
            '&lt;div class="about-version"&gt;v1.0 &amp;middot; for FlexSim 2026&lt;/div&gt;' +
            '&lt;hr class="about-divider" /&gt;' +
            '&lt;div class="about-field"&gt;' +
              '&lt;span class="about-label"&gt;License:&lt;/span&gt;' +
              '&lt;span class="about-value"&gt;Released under the MIT License&lt;/span&gt;' +
            '&lt;/div&gt;' +
            '&lt;div class="about-field"&gt;' +
              // Plain copyable text instead of a mailto: link — CEF's
              // embedded browser tries to open mailto: in a real shell
              // mail handler and crashes the WebPanel. Users can select
              // and copy the address.
              '&lt;span class="about-label"&gt;Contact:&lt;/span&gt;' +
              '&lt;span class="about-value about-email-addr" title="Click to select" style="user-select:all;cursor:text;"&gt;josh@pracsimsolutions.com&lt;/span&gt;' +
            '&lt;/div&gt;' +
            '&lt;div class="about-field"&gt;' +
              '&lt;span class="about-label"&gt;GitHub:&lt;/span&gt;' +
              '&lt;span class="about-value" style="user-select:all;cursor:text;"&gt;https://github.com/pracsimsolutions/Notebook&lt;/span&gt;' +
            '&lt;/div&gt;' +
            '&lt;hr class="about-divider" /&gt;' +
            '&lt;div class="about-footer"&gt;' +
              '© Practical Simulation Solutions LLC&lt;br&gt;' +
              'No installer, no activation, no telemetry.' +
            '&lt;/div&gt;' +
            '&lt;button class="about-close" id="about-close-btn"&gt;Close&lt;/button&gt;' +
          '&lt;/div&gt;' +
        '&lt;/div&gt;';

      var backdrop = root.querySelector('.about-backdrop');
      backdrop.addEventListener('click', function (e) {
        if (e.target === backdrop) closeAbout();
      });
      document.getElementById('about-close-btn').addEventListener('click', closeAbout);

      function esc(e) {
        if (e.key === 'Escape') { closeAbout(); document.removeEventListener('keydown', esc); }
      }
      document.addEventListener('keydown', esc);
    }

    // --- bootstrap ---
    function activateTab(name) {
      document.querySelectorAll('nav.main-tabs button').forEach(function (b) {
        b.classList.toggle('active', b.getAttribute('data-tab') === name);
      });
      document.querySelectorAll('.tab-pane').forEach(function (p) {
        p.classList.toggle('active', p.id === 'tab-' + name);
      });
      if (state) {
        state.settings.activeTab = name;
        // Switching tabs persists to the settings node only — not the
        // tab content. Pass the tab explicitly so the dirty-set falls back
        // to settings, not to the just-activated tab (which hasn't changed).
        saveImmediate('settings');
      }
      if (name === 'scoping')    renderScopingTab();
      if (name === 'notes')      renderNotesTab();
      if (name === 'board')      renderBoardTab();
      if (name === 'canvases')   renderCanvasesTab();
      if (name === 'validation') renderValidationTab();
    }

    document.querySelectorAll('nav.main-tabs button[data-tab]').forEach(function (b) {
      b.addEventListener('click', function () {
        activateTab(b.getAttribute('data-tab'));
      });
    });

    // ============================================================
    // Top-right "⋯" overflow menu. Replaces the row of top-action
    // buttons (Export / Import / Settings / About / Logs). Always a
    // single button so it fits any panel width — keeps the live UI
    // tight on narrow screens and consolidates infrequent actions in
    // one place.
    // ============================================================
    (function setupNavOverflow() {
      var btn = document.getElementById('nav-overflow-btn');
      var menu = document.getElementById('nav-overflow-menu');
      if (!btn || !menu) return;

      function icon(svgInner) {
        return '&lt;svg viewBox="0 0 16 16" width="13" height="13" fill="none" stroke="currentColor" stroke-width="1.5" stroke-linecap="round" stroke-linejoin="round"&gt;' + svgInner + '&lt;/svg&gt;';
      }
      var ICONS = {
        exportHtml: icon('&lt;path d="M8 2 v8 m -3 -3 l3 3 3 -3 M2 13 h12"/&gt;'),
        exportJson: icon('&lt;path d="M8 2 v8 m -3 -3 l3 3 3 -3 M2 13 h12"/&gt;'),
        import:     icon('&lt;path d="M8 13 V5 m -3 3 l3 -3 3 3 M2 2 h12"/&gt;'),
        settings:   icon('&lt;circle cx="8" cy="8" r="2"/&gt;&lt;path d="M8 1 v2 M8 13 v2 M1 8 h2 M13 8 h2 M3 3 l1.4 1.4 M11.6 11.6 l1.4 1.4 M3 13 l1.4 -1.4 M11.6 4.4 l1.4 -1.4"/&gt;'),
        about:      icon('&lt;circle cx="8" cy="8" r="6.5"/&gt;&lt;path d="M8 7 v4"/&gt;&lt;circle cx="8" cy="5" r="0.5" fill="currentColor"/&gt;')
      };

      // Menu items are defined once; populate on every open so labels
      // (e.g. the Logs item showing current state) stay fresh.
      function populate() {
        menu.innerHTML = '';
        function item(iconHtml, label, onClick) {
          var b = document.createElement('button');
          b.className = 'menu-item';
          b.innerHTML = iconHtml + '&lt;span&gt;' + label + '&lt;/span&gt;';
          b.addEventListener('click', function () {
            close();
            onClick();
          });
          menu.appendChild(b);
        }
        function sep() {
          var s = document.createElement('div');
          s.className = 'menu-sep';
          menu.appendChild(s);
        }
        item(ICONS.exportHtml, 'Export as HTML',     exportToHtml);
        item(ICONS.exportJson, 'Export data (JSON)', exportToJson);
        item(ICONS.import,     'Import data (JSON)', importFromJson);
        sep();
        item(ICONS.settings,   'Settings',           function () { openSettings(btn); });
        item(ICONS.about,      'About',              openAbout);
      }

      function open() {
        populate();
        menu.classList.add('open');
        btn.setAttribute('aria-expanded', 'true');
        menu.setAttribute('aria-hidden', 'false');
        // Anchor menu to the button (top-right aligned)
        var rect = btn.getBoundingClientRect();
        menu.style.top = (rect.bottom + 4) + 'px';
        menu.style.right = Math.max(8, window.innerWidth - rect.right) + 'px';
        // Close on outside click — install on next tick so the opening
        // click doesn't immediately re-close.
        setTimeout(function () {
          document.addEventListener('mousedown', outsideHandler);
        }, 0);
      }
      function close() {
        menu.classList.remove('open');
        btn.setAttribute('aria-expanded', 'false');
        menu.setAttribute('aria-hidden', 'true');
        document.removeEventListener('mousedown', outsideHandler);
      }
      function outsideHandler(e) {
        if (!menu.contains(e.target) &amp;&amp; e.target !== btn &amp;&amp; !btn.contains(e.target)) close();
      }
      function toggle() {
        if (menu.classList.contains('open')) close();
        else open();
      }
      btn.addEventListener('click', toggle);
      // Esc closes
      document.addEventListener('keydown', function (e) {
        if (e.key === 'Escape' &amp;&amp; menu.classList.contains('open')) close();
      });
      // Reposition on resize while open
      window.addEventListener('resize', function () {
        if (!menu.classList.contains('open')) return;
        var rect = btn.getBoundingClientRect();
        menu.style.top = (rect.bottom + 4) + 'px';
        menu.style.right = Math.max(8, window.innerWidth - rect.right) + 'px';
      });
    })();

    // Enable CSS-style mode so foreColor / hiliteColor produce &lt;span style&gt;
    // instead of deprecated &lt;font&gt; tags.
    try { document.execCommand('styleWithCSS', false, true); } catch (e) {}

    // Boot: one batch read of every per-tab node, then default-fill
    // anything missing, then load images, then activate the start tab.
    loadAllTabsFromHost(function (tabs) {
      state = {
        scoping:    tabs.scoping    || defaultScoping(),
        notes:      tabs.notes      || defaultNotes(),
        board:      tabs.board      || defaultBoard(),
        canvases:   tabs.canvases   || defaultCanvasesState(),
        validation: tabs.validation || defaultValidation(),
        settings:   tabs.settings   || defaultSettings()
      };
      getSettings();           // backfill missing settings keys
      ensureNewTabsState();    // backfill any missing per-tab fields
      applyTheme(state.settings.mode || 'dark');
      applyFontSizeSetting();
      loadImagesFromHost(function (images) {
        imageCache = images || {};
        lastSavedAt = Date.now();
        setSaveStatus('clean');
        // Resolve start tab from defaultTab setting (with 'last' = use saved activeTab)
        var s = getSettings();
        var validStartTabs = ['scoping','notes','board','canvases','validation'];
        var startTab;
        if (validStartTabs.indexOf(s.defaultTab) !== -1) {
          startTab = s.defaultTab;
        } else {
          startTab = state.settings.activeTab || 'scoping';
        }
        if (validStartTabs.indexOf(startTab) === -1) startTab = 'scoping';
        activateTab(startTab);
      });
    });
  &lt;/script&gt;
&lt;/body&gt;
&lt;/html&gt;
</data></node>
        </node>
        <node f="42"><name>eventfunctions</name>
         <node f="40"><name></name></node>
         <node f="442" dt="2"><name>Notebook_loadTab</name><data>string name = param(1);
return applicationcommand("Notebook_loadTab", name);</data></node>
         <node f="442" dt="2"><name>Notebook_loadAllTabs</name><data>return applicationcommand("Notebook_loadAllTabs");</data></node>
         <node f="442" dt="2"><name>Notebook_saveTab</name><data>string name = param(1);
string json = param(2);
string aliveCsv = param(3);
return applicationcommand("Notebook_saveTab", name, json, aliveCsv);</data></node>
         <node f="442" dt="2"><name>Notebook_saveImage</name><data>string id = param(1);
string dataUrl = param(2);
return applicationcommand("Notebook_saveImage", id, dataUrl);</data></node>
         <node f="442" dt="2"><name>Notebook_loadImages</name><data>string idsCsv = param(1);
return applicationcommand("Notebook_loadImages", idsCsv);</data></node>
         <node f="442" dt="2"><name>Notebook_snapshotModelState</name><data>return applicationcommand("Notebook_snapshotModelState");</data></node>
        </node>
       </data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
   </node>
  </node>
  <node f="42" dt="2"><name>add_nodefunctions</name><data>VIEW:/nodefunctions</data>
   <node f="40"><name></name></node>
   <node f="42" dt="3"><name>Notebook</name><data><coupling>null</coupling></data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>rank</name><data>0000000000000000</data></node>
    <node f="42" dt="2"><name>after</name><data>Submodels</data></node>
    <node f="42" dt="1"><name>into object</name><data>0000000000000000</data></node>
    <node f="42"><name>data</name>
     <node f="40"><name></name></node>
     <node f="42"><name>Notebook</name>
      <node f="40"><name></name></node>
      <node f="1000042" dt="2"><name>Notebook_loadTab</name><data>dll:"module:Notebook" func:"Notebook_loadTab"</data></node>
      <node f="1000042" dt="2"><name>Notebook_loadAllTabs</name><data>dll:"module:Notebook" func:"Notebook_loadAllTabs"</data></node>
      <node f="1000042" dt="2"><name>Notebook_saveTab</name><data>dll:"module:Notebook" func:"Notebook_saveTab"</data></node>
      <node f="1000042" dt="2"><name>Notebook_saveImage</name><data>dll:"module:Notebook" func:"Notebook_saveImage"</data></node>
      <node f="1000042" dt="2"><name>Notebook_loadImages</name><data>dll:"module:Notebook" func:"Notebook_loadImages"</data></node>
      <node f="1000042" dt="2"><name>Notebook_snapshotModelState</name><data>dll:"module:Notebook" func:"Notebook_snapshotModelState"</data></node>
      <node f="442" dt="2"><name>addnotebook</name><data>treenode activeViewNode = views().find("active&gt;Documents/Notebook");
if (activeViewNode.first){
	treenode existingView = ownerobject(tonode(get(rank(activeViewNode, 1))));
	applicationcommand("activatedockedview", existingView);
	return existingView;
}
string viewPath = "VIEW:/modules/Notebook/Notebook";

treenode notebookTools = Model.find("Tools").subnodes.assert("Notebook");
treenode notebook;
if (!notebookTools.first)
	notebook = createcopy(library().find("Notebook/Notebook"), notebookTools,1);
else
	notebook = notebookTools.first;
int skipRefresh = 0;
treenode theView = applicationcommand("createdockedview", viewPath, DOCK_TYPE_DOCUMENT, nodetopath(notebook), nodetopath(notebook), skipRefresh, [
		[DOCK_PANE_MAIN, "/$findmatchintree(i, get(tabwindow(a)) == DOCK_TYPE_DOCUMENT)$"]
	]);
return theView;</data></node>
     </node>
    </node>
   </node>
  </node>
  <node f="42" dt="2"><name>add_tools</name><data>VIEW:/standardviews/modelingutilities/Toolbox&gt;variables/tools</data>
   <node f="40"><name></name></node>
   <node f="42" dt="3"><name>Notebook</name><data><coupling>null</coupling></data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>rank</name><data>0000000000000000</data></node>
    <node f="42" dt="2"><name>after</name><data>Workspaces</data></node>
    <node f="42" dt="1"><name>into object</name><data>0000000000000000</data></node>
    <node f="42"><name>data</name>
     <node f="40"><name></name></node>
     <node f="42" dt="4"><name>Notebook</name><data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>objectfocus</name><data>MODEL:/Tools/Notebook</data></node>
      <node f="42" dt="2"><name>bitmap</name><data>modules\Notebook\Notebook.png</data></node>
      <node f="42"><name>variables</name>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>menuBitmap</name><data>modules\Notebook\Notebook.png</data></node>
       <node f="42" dt="2"><name>toolType</name><data>Singleton</data></node>
       <node f="42"><name>addMenu</name>
        <node f="40"><name></name></node>
        <node f="2000000042" dt="2"><name>Notebook</name><data>applicationcommand("addnotebook")</data></node>
       </node>
      </node>
      <node f="42"><name>eventfunctions</name>
       <node f="40"><name></name></node>
       <node f="442" dt="2"><name>onDoubleClick</name><data>applicationcommand("addnotebook")</data></node>
       <node f="442" dt="2"><name>onDelete</name><data>return 1;</data></node>
      </node>
      <node f="4000000042" dt="2"><name>windowtitle</name><data>Notebook</data></node>
     </data></node>
    </node>
   </node>
  </node>
  <node f="42" dt="2"><name>add_library</name><data>MAIN:/project/library</data>
   <node f="40"><name></name></node>
   <node f="42" dt="3"><name>Notebook</name><data><coupling>null</coupling></data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>rank</name><data>0000000000000000</data></node>
    <node f="42" dt="2"><name>after</name><data>fluid</data></node>
    <node f="42" dt="1"><name>into object</name><data>0000000000000000</data></node>
    <node f="42"><name>data</name>
     <node f="40"><name></name></node>
     <node f="42"><name>Notebook</name>
      <node f="40"><name></name></node>
      <node f="10000042" dt="4"><name>Notebook</name><data>
       <node f="40"><name></name></node>
       <node f="42"><name>variables</name>
        <node f="40"><name></name></node>
        <node f="42"><name>data</name></node>
        <node f="42" dt="1"><name>mode</name><data>000000003ff00000</data></node>
       </node>
       <node f="42"><name>classes</name>
        <node f="40"><name></name></node>
        <node f="42" dt="3"><name>Notebook::Notebook</name><data><coupling>/installdata/add_library/Notebook/data/Notebook/Notebook</coupling></data></node>
       </node>
      </data></node>
     </node>
    </node>
   </node>
  </node>
  <node f="42" dt="2"><name>add_Documents</name><data>VIEW:/active&gt;Documents</data>
   <node f="40"><name></name></node>
   <node f="42" dt="3"><name>Notebook</name><data><coupling>null</coupling></data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>rank</name><data>0000000000000000</data></node>
    <node f="42" dt="2"><name>after</name><data>Html</data></node>
    <node f="42" dt="1"><name>into object</name><data>0000000000000000</data></node>
    <node f="42"><name>data</name>
     <node f="40"><name></name></node>
     <node f="42"><name>Notebook</name>
      <node f="40"><name></name></node></node>
    </node>
   </node>
  </node>
  <node f="42" dt="2"><name>add_Tools</name><data>MAIN:/project/exec/globals/Tools</data>
   <node f="40"><name></name></node>
   <node f="42" dt="3"><name>Notebook</name><data><coupling>null</coupling></data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>rank</name><data>0000000000000000</data></node>
    <node f="42" dt="2"><name>after</name><data>SubmodelImport</data></node>
    <node f="42" dt="1"><name>into object</name><data>0000000000000000</data></node>
    <node f="42"><name>data</name>
     <node f="40"><name></name></node>
     <node f="42"><name>Notebook</name>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>LibraryPath</name><data>Notebook</data></node>
      <node f="42" dt="2"><name>FolderName</name><data>Notebook</data></node>
     </node>
    </node>
   </node>
  </node>
 </node>
 <node f="42" dt="2"><name>release</name><data>26.0</data></node>
 <node f="42" dt="2"><name>revision</name><data>.0</data></node>
 <node f="42" dt="2"><name>flexsim release</name><data>26.0</data></node>
</node></flexsim-tree>
