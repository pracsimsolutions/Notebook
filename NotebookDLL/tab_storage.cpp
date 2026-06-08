#include "tab_storage.h"
#include "tree_io.h"

namespace nb {

// Helper — pick the right parent node for this tab.
// "settings" lives directly under >variables; every other tab lives
// under >variables/tabs/. If `create` is true and `tabs` doesn't
// exist yet, it's asserted into being. If false, returns nullptr
// when tabs/ doesn't exist (caller treats as "no data yet").
static treenode parentForTab(const std::string& name, bool create) {
    treenode vars = getVariablesNode();
    if (!vars) return nullptr;
    if (name == "settings") return vars;
    if (create) return vars->subnodes._assert("tabs");
    return vars->find("tabs");
}

std::string loadTab(const std::string& name) {
    treenode parent = parentForTab(name, /*create=*/false);
    if (!parent) return "";
    return readNodeString(parent, name);
}

std::string loadAllTabs() {
    treenode vars = getVariablesNode();
    if (!vars) return "{}";

    std::string out = "{";
    bool first = true;

    // settings — directly under variables
    treenode settingsNode = vars->find("settings");
    if (settingsNode) {
        std::string v(getnodestr(settingsNode));
        out += "\"settings\":";
        out += (v.empty() ? "null" : v);
        first = false;
    }

    // other tabs — under variables/tabs/
    treenode tabsContainer = vars->find("tabs");
    if (tabsContainer) {
        int n = tabsContainer->subnodes.length;
        for (int i = 1; i <= n; i++) {
            treenode tabNode = tabsContainer->subnodes[i];
            if (!first) out += ",";
            first = false;
            std::string v(getnodestr(tabNode));
            out += "\"";
            out += getnodename(tabNode);
            out += "\":";
            out += (v.empty() ? "null" : v);
        }
    }

    out += "}";
    return out;
}

// Walk >variables/images/ and destroy every node whose ID isn't in
// the comma-delimited alive list. aliveCsv is ",id1,id2,id3,"
// (leading + trailing commas so the substring search ",ID," is
// unambiguous). Empty aliveCsv → no-op for safety.
static void garbageCollectOrphanImages(treenode vars, const std::string& aliveCsv) {
    if (aliveCsv.empty()) return;
    treenode imagesContainer = vars->find("images");
    if (!imagesContainer) return;

    // Walk backwards so destroy() doesn't invalidate our index.
    for (int i = imagesContainer->subnodes.length; i >= 1; i--) {
        treenode img = imagesContainer->subnodes[i];
        std::string needle = ",";
        needle += getnodename(img);
        needle += ",";
        if (aliveCsv.find(needle) == std::string::npos) {
            img->destroy();
        }
    }
}

std::string saveTab(const std::string& name,
                    const std::string& json,
                    const std::string& aliveImageIdsCsv) {
    treenode vars = getVariablesNode();
    if (!vars) return "no-tool";

    treenode parent = parentForTab(name, /*create=*/true);
    if (!parent) return "no-variables";

    treenode n = parent->subnodes._assert(name.c_str());
    nodeadddata(n, DATATYPE_STRING);
    setnodestr(n, json.c_str());

    // Legacy node cleanup — destroys old single-blob `data` node and
    // standalone `mode` node if present. No-op once gone.
    destroyChild(vars, "data");
    destroyChild(vars, "mode");

    garbageCollectOrphanImages(vars, aliveImageIdsCsv);

    return "ok";
}

}  // namespace nb
