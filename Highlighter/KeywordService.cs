using System.Collections.Generic;

namespace Highlighter {
    internal static class KeywordService {
        public static readonly Dictionary<string, string> KeywordToClassification = new Dictionary<string, string>() {
            {"TODO",Consts._classificationTypeNameToDo},
            {"BUG",Consts._classificationTypeNameBug},
            {"FIXME",Consts._classificationTypeNameFix},
            {"NOTE",Consts._classificationTypeNameNote},
            {"OPTIMIZE",Consts._classificationTypeNameOptimize},
            {"DISCUSS",Consts._classificationTypeNameDiscuss},
            {"STEP",Consts._classificationTypeNameStep},
            {"IMPORTANT",Consts._classificationTypeNameImportant},
            {"IDEA",Consts._classificationTypeNameIdea},
            {"DELETE",Consts._classificationTypeNameDelete},
            {"WIP",Consts._classificationTypeNameWip},
            {"WORKAROUND",Consts._classificationTypeNameWorkaround},
        };

        public static string GetClassification(string keyword) =>
            KeywordToClassification.TryGetValue(keyword, out var classification) ? classification : null;

        public static string GetMarker(string keyword) {
            var classification = GetClassification(keyword);
            return classification != null ? classification + "Marker" : null;
        }

        public static IEnumerable<string> GetAllPrefixes() => KeywordToClassification.Keys;
    }
}
