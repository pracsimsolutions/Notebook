#pragma once
#include "FlexsimDefs.h"
#include "allobjects.h"
#include <string>

namespace nb {

// Returns the Notebook tool's >variables node, or nullptr if the
// tool isn't found in the model tree. Equivalent to the FlexScript
// pattern:
//   treenode tool = Model.find("Tools/Notebook/Notebook");
//   return tool ? tool.find(">variables") : nullptr;
treenode getVariablesNode();

// Read a node's string value (DATATYPE_STRING). Returns "" if the
// node doesn't exist or isn't a string node.
std::string readNodeString(treenode parent, const std::string& name);

// Write a string value to parent/name (asserting the node exists with
// DATATYPE_STRING). No-op if parent is null.
void writeNodeString(treenode parent, const std::string& name, const std::string& value);

// Get-or-create a child node by name with DATATYPE_STRING. Returns
// nullptr if parent is null.
treenode assertStringChild(treenode parent, const std::string& name);

// Destroy a child node if it exists. Safe to call on missing children.
void destroyChild(treenode parent, const std::string& name);

}  // namespace nb
