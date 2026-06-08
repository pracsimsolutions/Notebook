#include "image_storage.h"
#include "tree_io.h"

namespace nb {

std::string saveImage(const std::string& id, const std::string& dataUrl) {
    treenode vars = getVariablesNode();
    if (!vars) return "no-tool";

    treenode imagesContainer = vars->subnodes._assert("images");
    treenode img = imagesContainer->subnodes._assert(id.c_str());
    nodeadddata(img, DATATYPE_STRING);
    setnodestr(img, dataUrl.c_str());
    return "ok";
}

std::string loadImages(const std::string& /*idsCsv ignored — legacy compat*/) {
    treenode vars = getVariablesNode();
    if (!vars) return "{}";

    treenode imagesContainer = vars->find("images");
    if (!imagesContainer) return "{}";

    std::string out = "{";
    int n = imagesContainer->subnodes.length;
    for (int i = 1; i <= n; i++) {
        treenode img = imagesContainer->subnodes[i];
        if (i > 1) out += ",";
        out += "\"";
        out += getnodename(img);
        out += "\":\"";
        out += std::string(getnodestr(img));
        out += "\"";
    }
    out += "}";
    return out;
}

}  // namespace nb
