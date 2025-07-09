using Color = System.Windows.Media.Color;

namespace Highlighter
{
    internal static class Consts
    {
        internal const string classificationTypeNameToDo = "Comment.Todo";
        internal const string classificationTypeNameBug = "Comment.Bug";
        internal const string classificationTypeNameFix = "Comment.FixMe";
        internal const string classificationTypeNameNote = "Comment.Note";
        internal const string classificationTypeNameOptimize = "Comment.Optimize";
        internal const string classificationTypeNameDiscuss = "Comment.Discuss";
        internal const string classificationTypeNameStep = "Comment.Step";
        internal const string classificationTypeNameImportant = "Comment.Important";
        internal const string classificationTypeNameIdea = "Comment.Idea";

        internal static class Colors
        {
            // deep green
            internal static readonly Color todo = Color.FromRgb(39, 174, 96);
            // vibrant red
            internal static readonly Color bug = Color.FromRgb(231, 76, 60);
            // reddish-brown
            internal static readonly Color fix = Color.FromRgb(184, 77, 40);
            // bright blue
            internal static readonly Color note = Color.FromRgb(68, 158, 235);
            // teal 
            internal static readonly Color optimize = Color.FromRgb(32, 196, 156);
            // black
            internal static readonly Color system = Color.FromRgb(10, 10, 10);
            // golden yellow
            internal static readonly Color discuss = Color.FromRgb(241, 196, 15);
            // distinct orange
            internal static readonly Color step = Color.FromRgb(243, 156, 18);
            // amber/orange-gold
            internal static readonly Color important = Color.FromRgb(211, 84, 0);
            // purple
            internal static readonly Color idea = Color.FromRgb(177, 95, 219);
        }
    }
}
