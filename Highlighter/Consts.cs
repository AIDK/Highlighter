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

        internal const string _classificationTypeNameDiscuss = "Comment.Discuss";
        internal const string _classificationTypeNameStep = "Comment.Step";
        internal const string _classificationTypeNameImportant = "Comment.Important";

        internal const string _classificationTypeNameIdea = "Comment.Idea";

        internal const string _classificationTypeNameDelete = "Comment.Delete";

        internal static class Colors
        {
            internal static readonly Color _todo = Color.FromRgb(r: 39, g: 174, b: 96); // Deeper, grounded green
            internal static readonly Color _bug = Color.FromRgb(r: 231, g: 76, b: 60); // Keep vibrant red
            internal static readonly Color _fix = Color.FromRgb(r: 184, g: 77, b: 40); // Richer, warm reddish-brown
            internal static readonly Color _note = Color.FromRgb(r: 68, g: 158, b: 235); // Slightly brighter informational blue
            internal static readonly Color _optimize = Color.FromRgb(r: 32, g: 196, b: 180); // Slightly more vibrant teal
            internal static readonly Color _system = Color.FromRgb(r: 10, g: 10, b: 10); // Very, very dark grey (reads as full black)

            internal static readonly Color _discuss = Color.FromRgb(r: 241, g: 196, b: 15); // Keep golden yellow
            internal static readonly Color _step = Color.FromRgb(r: 243, g: 156, b: 18); // Clear, distinct orange
            internal static readonly Color _important = Color.FromRgb(r: 211, g: 84, b: 0); // Strong, deep amber/orange-gold

            internal static readonly Color _idea = Color.FromRgb(r: 177, g: 95, b: 219); // Slightly brighter, imaginative purple

            internal static readonly Color _delete = Color.FromRgb(r: 178, g: 34, b: 34); // Deep, slightly lighter red for destructive actions
        }
    }
}
