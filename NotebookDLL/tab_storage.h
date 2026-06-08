#pragma once
#include <string>

namespace nb {

// Read one tab's serialized JSON.
// "settings" lives at >variables/settings (sibling of tabs/); every
// other tab lives at >variables/tabs/<name>. Returns "" if not yet
// written.
std::string loadTab(const std::string& name);

// Batch-read every tab + settings as a JSON object:
//   {"settings": <json or null>, "scoping": <...>, "notes": <...>, ...}
// Empty / unwritten tabs serialize as null in the result.
std::string loadAllTabs();

// Write a tab's JSON to its node + GC orphan image nodes.
// Returns:
//   "ok"            — write performed, GC ran
//   "no-tool"       — Tools/Notebook/Notebook node not found
//   "no-variables"  — couldn't reach >variables (should not happen
//                     under normal FlexSim operation)
//
// aliveImageIdsCsv format: ",id1,id2,id3,"  — matches the existing
// FlexScript event-function contract. Empty string = skip GC for
// safety (caller didn't provide an alive list).
std::string saveTab(const std::string& name,
                    const std::string& json,
                    const std::string& aliveImageIdsCsv);

}  // namespace nb
