#include "tree_io.h"

// FlexSim's C++ SDK uses different syntax than FlexScript:
//   FlexScript                       C++ SDK
//   ------------------------         --------------------------
//   Model.find("x")                  model()->find("x")
//   treenode n; n.find("x")          treenode n; n->find("x")
//   parent.subnodes.assert(name)     parent->subnodes._assert(name)
//   destroyobject(n)                 n->destroy()
//   treenode is a value              treenode is pointer-like → use ->

namespace nb {

treenode getVariablesNode() {
    treenode tool = model()->find("Tools/Notebook/Notebook");
    if (!tool) return nullptr;
    return tool->find(">variables");
}

std::string readNodeString(treenode parent, const std::string& name) {
    if (!parent) return "";
    treenode n = parent->find(name.c_str());
    if (!n) return "";
    return std::string(getnodestr(n));
}

void writeNodeString(treenode parent, const std::string& name, const std::string& value) {
    if (!parent) return;
    treenode n = parent->subnodes._assert(name.c_str());
    nodeadddata(n, DATATYPE_STRING);
    setnodestr(n, value.c_str());
}

treenode assertStringChild(treenode parent, const std::string& name) {
    if (!parent) return nullptr;
    treenode n = parent->subnodes._assert(name.c_str());
    nodeadddata(n, DATATYPE_STRING);
    return n;
}

void destroyChild(treenode parent, const std::string& name) {
    if (!parent) return;
    treenode n = parent->find(name.c_str());
    if (n) n->destroy();
}

}  // namespace nb
