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
        internal const string _classificationTypeNameWip = "Comment.Wip";
        internal const string _classificationTypeNameWorkaround = "Comment.Workaround";

        internal static class Colors
        {
            internal static readonly Color _system = Color.FromRgb(r: 10, g: 10, b: 10);

            //TODO:
            internal static readonly Color _todo = Color.FromRgb(r: 39, g: 174, b: 96);
            //BUG:
            internal static readonly Color _bug = Color.FromRgb(r: 231, g: 76, b: 60);
            //FIXME:
            internal static readonly Color _fixme = Color.FromRgb(r: 184, g: 77, b: 40);
            //NOTE:
            internal static readonly Color _note = Color.FromRgb(r: 68, g: 158, b: 235);
            //OPTIMIZE:
            internal static readonly Color _optimize = Color.FromRgb(r: 32, g: 196, b: 180);
            //DISCUSS:
            internal static readonly Color _discuss = Color.FromRgb(r: 241, g: 196, b: 15);
            //STEP:
            internal static readonly Color _step = Color.FromRgb(r: 243, g: 156, b: 18);
            //IMPORTANT:
            internal static readonly Color _important = Color.FromRgb(r: 211, g: 84, b: 0);
            //IDEA:
            internal static readonly Color _idea = Color.FromRgb(r: 177, g: 95, b: 219);
            //DELETE:
            internal static readonly Color _delete = Color.FromRgb(r: 178, g: 34, b: 34);
            //WIP:
            internal static readonly Color _wip = Color.FromRgb(r: 255, g: 214, b: 179);
            //WORKAROUND:
            internal static readonly Color _workaround = Color.FromRgb(r: 179, g: 217, b: 255);
        }
    }
}
