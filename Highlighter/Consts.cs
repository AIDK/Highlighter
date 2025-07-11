using System;
using System.Collections.Generic;

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

        private static readonly Dictionary<ColorKeyword, Color> keywordColors = new Dictionary<ColorKeyword, Color>() {
            //SYSTEM:
            [ColorKeyword.SYSTEM] = Color.FromRgb(10, 10, 10),
            //TODO:
            [ColorKeyword.TODO] = Color.FromRgb(39, 174, 96),
            //BUG:
            [ColorKeyword.BUG] = Color.FromRgb(231, 76, 60),
            //FIXME:
            [ColorKeyword.FIXME] = Color.FromRgb(184, 77, 40),
            //NOTE:
            [ColorKeyword.NOTE] = Color.FromRgb(68, 158, 235),
            //OPTIMIZE:
            [ColorKeyword.OPTIMIZE] = Color.FromRgb(32, 196, 180),
            //DISCUSS:
            [ColorKeyword.DISCUSS] = Color.FromRgb(241, 196, 15),
            //STEP:
            [ColorKeyword.STEP] = Color.FromRgb(243, 156, 18),
            //IMPORTANT:
            [ColorKeyword.IMPORTANT] = Color.FromRgb(211, 84, 0),
            //IDEA:
            [ColorKeyword.IDEA] = Color.FromRgb(177, 95, 219),
            //DELETE:
            [ColorKeyword.DELETE] = Color.FromRgb(178, 34, 34),
            //WIP:
            [ColorKeyword.WIP] = Color.FromRgb(255, 214, 179),
            //WORKAROUND:
            [ColorKeyword.WORKAROUND] = Color.FromRgb(179, 217, 255)
        };

        public static Color ToColor(this ColorKeyword keyword) {
            if (keywordColors.TryGetValue(keyword, out Color color))
                return color;

            throw new ArgumentOutOfRangeException(nameof(keyword), $"No color defined for keyword: {keyword}");
        }
    }
}
