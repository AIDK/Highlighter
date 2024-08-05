using Color = System.Windows.Media.Color;

namespace Highlighter
{
    internal static class Consts
    {
        internal const string _classificationTypeNameToDo = "Comment.Todo";
        internal const string _classificationTypeNameBug = "Comment.Bug";
        internal const string _classificationTypeNameFix = "Comment.FixMe";
        internal const string _classificationTypeNameNote = "Comment.Note";
        internal const string _classificationTypeNameOptimize = "Comment.Optimize";

        // 2024-08-05 (#1)
        internal const string _classificationTypeNameDiscuss = "Comment.Discuss";
        internal const string _classificationTypeNameStep = "Comment.Step";
        internal const string _classificationTypeNameImportant = "Comment.Important";

        internal static class Colors
        {
            internal static readonly Color _todo = Color.FromRgb(46, 204, 113);
            internal static readonly Color _bug = Color.FromRgb(231, 76, 60);
            internal static readonly Color _fix = Color.FromRgb(230, 126, 34);
            internal static readonly Color _note = Color.FromRgb(52, 152, 219);
            internal static readonly Color _optimize = Color.FromRgb(26, 188, 156);
            internal static readonly Color _system = Color.FromRgb(51, 51, 3);

            // 2024-08-05 (#1)
            internal static readonly Color _discuss = Color.FromRgb(241, 196, 15);
            internal static readonly Color _step = Color.FromRgb(241, 126, 23);
            internal static readonly Color _important = Color.FromRgb(235, 217, 180);
        }
    }
}