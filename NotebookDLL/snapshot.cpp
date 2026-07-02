#include "snapshot.h"
#include "FlexsimDefs.h"
#include "allobjects.h"
#include "ParameterTable.h"
#include "PerformanceMeasureTable.h"
#include <string>
#include <sstream>

namespace nb {

// Serialize a Variant to its JSON representation using the SDK helper.
static std::string variantToJson(const Variant& v) {
    const char* s = JSON::stringify(v);
    return s ? std::string(s) : "null";
}

// Serialize a treenode's string value as a JSON string literal.
// Returns "\"\"" if the node is null or has no string data.
static std::string nodeStringJson(treenode n) {
    if (!n) return "\"\"";
    Variant v = n->value;
    const char* s = JSON::stringify(v);
    return s ? std::string(s) : "\"\"";
}

std::string snapshotModelState() {
    std::ostringstream out;
    out << "{\"parameters\":[";

    Parameters params = Model::getParameters();
    Array paramTables = params.tableNames;
    bool firstParam = true;

    for (int t = 1; t <= paramTables.length; t++) {
        std::string tableName = std::string(paramTables[t]);
        Array paramNames = params.names(tableName.c_str());

        for (int i = 1; i <= paramNames.length; i++) {
            std::string pname = std::string(paramNames[i]);

            // findParameter returns the row node; rank 2 is the CV node.
            treenode rowNode = ParameterTable::findParameter(pname.c_str());

            // The CV node's own scalar value is NOT the parameter's value —
            // ConstrainedVariable is an engine-internal type, and reading
            // cvNode->value / cvNode->evaluate() returns a constant type code
            // (2) for every parameter. Read the value the way FlexScript users
            // do, bridging through the engine like the PM path below:
            //   Model.parameters["Name"].value
            Variant rawValue;
            if (rowNode) {
                std::string expr = "return Model.parameters[\"";
                for (char c : pname) {
                    if (c == '\\' || c == '"') expr += '\\';
                    expr += c;
                }
                expr += "\"].value;";
                rawValue = executestring(expr.c_str());
            }
            // Plain numeric/string parameters resolve to the same evaluated
            // value; expose both fields for the webview's snapshot schema.
            Variant evalValue = rawValue;

            // Units and description are accessed by subnode name, matching
            // the FlexScript pattern: row.subnodes["Display Units"].value
            treenode unitsNode = rowNode ? rowNode->subnodes["Display Units"] : nullptr;
            treenode descNode  = rowNode ? rowNode->subnodes["Description"]   : nullptr;

            if (!firstParam) out << ",";
            firstParam = false;
            out << "{\"name\":"           << variantToJson(Variant(pname.c_str()))
                << ",\"value\":"          << variantToJson(rawValue)
                << ",\"evaluatedValue\":" << variantToJson(evalValue)
                << ",\"units\":"          << nodeStringJson(unitsNode)
                << ",\"description\":"    << nodeStringJson(descNode)
                << ",\"tableName\":"      << variantToJson(Variant(tableName.c_str()))
                << "}";
        }
    }

    out << "],\"performanceMeasures\":[";

    PerformanceMeasures pms = Model::getPerformanceMeasures();
    Array pmTables = pms.tableNames;
    bool firstPm = true;

    for (int t = 1; t <= pmTables.length; t++) {
        std::string tableName = std::string(pmTables[t]);
        Array pmNames = pms.names(tableName.c_str());

        for (int i = 1; i <= pmNames.length; i++) {
            std::string pmName = std::string(pmNames[i]);

            // findPerformanceMeasure returns the row node; rank 2 is the SV node.
            treenode rowNode = PerformanceMeasureTable::findPerformanceMeasure(pmName.c_str());
            treenode svNode  = rowNode ? rowNode->subnodes[2] : nullptr;

            // PM value: svNode->evaluate() from C++ returns the formula's
            // source text rather than running it. Bridge through FlexScript:
            //   Model.performanceMeasures["Name"].evaluate()
            // This is the same call FlexScript users write to get a PM's
            // current computed value.
            Variant pmValue;
            if (svNode) {
                std::string expr = "return Model.performanceMeasures[\"";
                for (char c : pmName) {
                    if (c == '\\' || c == '"') expr += '\\';
                    expr += c;
                }
                expr += "\"].evaluate();";
                pmValue = executestring(expr.c_str());
            }

            treenode unitsNode = rowNode ? rowNode->subnodes["Display Units"] : nullptr;
            treenode descNode  = rowNode ? rowNode->subnodes["Description"]   : nullptr;

            if (!firstPm) out << ",";
            firstPm = false;
            out << "{\"name\":"        << variantToJson(Variant(pmName.c_str()))
                << ",\"value\":"       << variantToJson(pmValue)
                << ",\"units\":"       << nodeStringJson(unitsNode)
                << ",\"description\":" << nodeStringJson(descNode)
                << ",\"tableName\":"   << variantToJson(Variant(tableName.c_str()))
                << "}";
        }
    }

    out << "]}";
    return out.str();
}

}  // namespace nb
