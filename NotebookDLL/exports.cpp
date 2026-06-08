// All FlexScript-callable entry points for PracSim Notebook.
// Each Notebook_* function is registered via Notebook.fsx >
// add_nodefunctions, making it callable from FlexScript via
// applicationcommand("Notebook_<name>") and from the WebPanel JS via
// fireFlexsimEvent("Notebook_<name>", ...).
//
// Pattern matches RouteGraph's module.cpp exactly: functions live
// inside `namespace Notebook { ... }`, declared with
// `__declspec(dllexport)` WITHOUT `extern "C"`. FlexSim's bridge looks
// up the C++ name-mangled symbol; an `extern "C"` decoration causes
// the bridge to find an undecorated symbol that triggers an exception
// during call (wrong calling convention / stack layout).

#include "FlexsimDefs.h"
#include "allobjects.h"
#include "tab_storage.h"
#include "image_storage.h"
#include "snapshot.h"

namespace Notebook {

// ---- Tab storage exports (Task 8 + 9) ----

__declspec(dllexport) Variant Notebook_loadTab(FLEXSIMINTERFACE)
{
    // Variant→std::string is via implicit conversion (RouteGraph
    // pattern). An explicit (const char*) cast does NOT compile.
    std::string name = param(1);
    return nb::loadTab(name);
}

__declspec(dllexport) Variant Notebook_loadAllTabs(FLEXSIMINTERFACE)
{
    return nb::loadAllTabs();
}

__declspec(dllexport) Variant Notebook_saveTab(FLEXSIMINTERFACE)
{
    std::string name      = param(1);
    std::string json      = param(2);
    std::string aliveCsv  = param(3);
    return nb::saveTab(name, json, aliveCsv);
}

// ---- Image storage exports (Task 10) ----

__declspec(dllexport) Variant Notebook_saveImage(FLEXSIMINTERFACE)
{
    std::string id      = param(1);
    std::string dataUrl = param(2);
    return nb::saveImage(id, dataUrl);
}

__declspec(dllexport) Variant Notebook_loadImages(FLEXSIMINTERFACE)
{
    std::string idsCsv = param(1);
    return nb::loadImages(idsCsv);
}

// ---- Validation snapshot export (Task 11) ----

__declspec(dllexport) Variant Notebook_snapshotModelState(FLEXSIMINTERFACE)
{
    return nb::snapshotModelState();
}

}  // namespace Notebook
