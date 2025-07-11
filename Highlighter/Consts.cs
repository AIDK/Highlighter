using System;

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

        internal enum ColorKeyword {
            SYSTEM,
            TODO,
            BUG,
            FIXME,
            NOTE,
            OPTIMIZE,
            DISCUSS,
            STEP,
            IMPORTANT,
            IDEA,
            DELETE,
            WIP,
            WORKAROUND
        }

        internal static Color ToColor(ColorKeyword color) {
            (byte r, byte g, byte b) = GetRGB(color);
            return Color.FromRgb(r, g, b);
        }

        private static (byte r, byte g, byte b) GetRGB(ColorKeyword keyword) {
            switch (keyword) {
                //SYSTEM:
                case ColorKeyword.SYSTEM:
                    return (r: 10, g: 10, b: 10);
                //TODO:
                case ColorKeyword.TODO:
                    return (r: 39, g: 174, b: 96);
                //BUG:
                case ColorKeyword.BUG:
                    return (r: 231, g: 76, b: 60);
                //FIXME:
                case ColorKeyword.FIXME:
                    return (r: 184, g: 77, b: 40);
                //NOTE:
                case ColorKeyword.NOTE:
                    return (r: 68, g: 158, b: 235);
                //OPTIMIZE:
                case ColorKeyword.OPTIMIZE:
                    return (r: 32, g: 196, b: 180);
                //DISCUSS:
                case ColorKeyword.DISCUSS:
                    return (r: 241, g: 196, b: 15);
                //STEP:
                case ColorKeyword.STEP:
                    return (r: 243, g: 156, b: 18);
                //IMPORTANT:
                case ColorKeyword.IMPORTANT:
                    return (r: 211, g: 84, b: 0);
                //IDEA:
                case ColorKeyword.IDEA:
                    return (r: 177, g: 95, b: 219);
                //DELETE:
                case ColorKeyword.DELETE:
                    return (r: 178, g: 34, b: 34);
                //WIP:
                case ColorKeyword.WIP:
                    return (r: 255, g: 214, b: 179);
                //WORKAROUND:
                case ColorKeyword.WORKAROUND:
                    return (r: 179, g: 217, b: 255);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
