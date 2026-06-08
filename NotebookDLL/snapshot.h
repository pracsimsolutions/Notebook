#pragma once
#include <string>

namespace nb {

// Read every Model.parameters and Model.performanceMeasures table,
// return JSON {"parameters":[...], "performanceMeasures":[...]}.
std::string snapshotModelState();

}  // namespace nb
