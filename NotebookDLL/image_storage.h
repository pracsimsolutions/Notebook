#pragma once
#include <string>

namespace nb {

// Write one pasted image's base64 data URL to >variables/images/<id>.
// Returns:
//   "ok"            — write performed
//   "no-tool"       — Tools/Notebook/Notebook node not found
//   "no-variables"  — couldn't reach >variables
std::string saveImage(const std::string& id, const std::string& dataUrl);

// Returns a JSON object {id: base64DataUrl, ...} for every image
// currently stored. The idsCsv parameter is accepted for bridge-call
// compatibility with the legacy FlexScript event function but is
// ignored — we always return all images.
std::string loadImages(const std::string& idsCsv);

}  // namespace nb
