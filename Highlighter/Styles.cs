using Microsoft.VisualStudio.Language.StandardClassification;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

using System.ComponentModel.Composition;

namespace Highlighter {
    #region TODO
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts._classificationTypeNameToDo)]
    [Name(Consts._classificationTypeNameToDo)]
    [BaseDefinition(PredefinedClassificationTypeNames.Comment)]
    [UserVisible(true)]
    internal sealed class FormatCommentTodo : KeywordClassificationFormat {
        public FormatCommentTodo() : base("TODO", Consts.ColorKeyword.TODO.ToColor()) { }
    }

    [Export(typeof(EditorFormatDefinition))]
    [Name("Comment.TodoMarker")]
    [UserVisible(true)]
    [Order(After = Priority.Default)]
    internal sealed class MarkerFormatTodo : KeywordMarkerFormat {
        public MarkerFormatTodo() : base("TODO", Consts.ColorKeyword.TODO.ToColor()) { }
    }
    #endregion

    #region BUG
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts._classificationTypeNameBug)]
    [Name(Consts._classificationTypeNameBug)]
    [BaseDefinition(PredefinedClassificationTypeNames.Comment)]
    [UserVisible(true)]

    internal sealed class FormatCommentBug : KeywordClassificationFormat {
        public FormatCommentBug() : base("BUG", Consts.ColorKeyword.BUG.ToColor()) { }
    }

    [Export(typeof(EditorFormatDefinition))]
    [Name(Consts._classificationTypeNameBug + "Marker")]
    [UserVisible(true)]
    internal sealed class MarkerFormatBug : KeywordMarkerFormat {
        public MarkerFormatBug() : base("BUG", Consts.ColorKeyword.BUG.ToColor()) { }
    }
    #endregion

    #region FIXME
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts._classificationTypeNameFix)]
    [Name(Consts._classificationTypeNameFix)]
    [BaseDefinition(PredefinedClassificationTypeNames.Comment)]
    [UserVisible(true)]
    internal sealed class FormatCommentFix : KeywordClassificationFormat {
        public FormatCommentFix() : base("FIXME", Consts.ColorKeyword.FIXME.ToColor()) { }
    }

    [Export(typeof(EditorFormatDefinition))]
    [Name(Consts._classificationTypeNameFix + "Marker")]
    [UserVisible(true)]
    internal sealed class MarkerFormatFix : KeywordMarkerFormat {
        public MarkerFormatFix() : base("FIXME", Consts.ColorKeyword.FIXME.ToColor()) { }
    }
    #endregion

    #region NOTE
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts._classificationTypeNameNote)]
    [Name(Consts._classificationTypeNameNote)]
    [BaseDefinition(PredefinedClassificationTypeNames.Comment)]
    [UserVisible(true)]
    internal sealed class FormatCommentNote : KeywordClassificationFormat {
        public FormatCommentNote() : base("NOTE", Consts.ColorKeyword.NOTE.ToColor()) { }
    }

    [Export(typeof(EditorFormatDefinition))]
    [Name(Consts._classificationTypeNameNote + "Marker")]
    [UserVisible(true)]
    internal sealed class MarkerFormatNote : KeywordMarkerFormat {
        public MarkerFormatNote() : base("NOTE", Consts.ColorKeyword.NOTE.ToColor()) { }
    }
    #endregion

    #region DISCUSS
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts._classificationTypeNameDiscuss)]
    [Name(Consts._classificationTypeNameDiscuss)]
    [BaseDefinition(PredefinedClassificationTypeNames.Comment)]
    [UserVisible(true)]
    internal sealed class FormatCommentDiscuss : KeywordClassificationFormat {
        public FormatCommentDiscuss() : base("DISCUSS", Consts.ColorKeyword.DISCUSS.ToColor()) { }
    }

    [Export(typeof(EditorFormatDefinition))]
    [Name(Consts._classificationTypeNameDiscuss + "Marker")]
    [UserVisible(true)]
    internal sealed class MarkerFormatDiscuss : KeywordMarkerFormat {
        public MarkerFormatDiscuss() : base("DISCUSS", Consts.ColorKeyword.DISCUSS.ToColor()) { }
    }
    #endregion

    #region IDEA

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts._classificationTypeNameIdea)]
    [Name(Consts._classificationTypeNameIdea)]
    [BaseDefinition(PredefinedClassificationTypeNames.Comment)]
    [UserVisible(true)]
    internal sealed class FormatCommentIdea : KeywordClassificationFormat {
        public FormatCommentIdea() : base("IDEA", Consts.ColorKeyword.IDEA.ToColor()) { }
    }

    [Export(typeof(EditorFormatDefinition))]
    [Name(Consts._classificationTypeNameIdea + "Marker")]
    [UserVisible(true)]
    internal sealed class MarkerFormatIdea : KeywordMarkerFormat {
        public MarkerFormatIdea() : base("IDEA", Consts.ColorKeyword.IDEA.ToColor()) { }
    }
    #endregion

    #region OPTIMIZE

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts._classificationTypeNameOptimize)]
    [Name(Consts._classificationTypeNameOptimize)]
    [BaseDefinition(PredefinedClassificationTypeNames.Comment)]
    [UserVisible(true)]
    internal sealed class FormatCommentOptimize : KeywordClassificationFormat {
        public FormatCommentOptimize() : base("OPTIMIZE", Consts.ColorKeyword.OPTIMIZE.ToColor()) { }
    }

    [Export(typeof(EditorFormatDefinition))]
    [Name(Consts._classificationTypeNameOptimize + "Marker")]
    [UserVisible(true)]
    internal sealed class MarkerFormatOptimize : KeywordMarkerFormat {
        public MarkerFormatOptimize() : base("OPTIMIZE", Consts.ColorKeyword.OPTIMIZE.ToColor()) { }
    }
    #endregion

    #region STEP


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts._classificationTypeNameStep)]
    [Name(Consts._classificationTypeNameStep)]
    [BaseDefinition(PredefinedClassificationTypeNames.Comment)]
    [UserVisible(true)]
    internal sealed class FormatCommentStep : KeywordClassificationFormat {
        public FormatCommentStep() : base("STEP", Consts.ColorKeyword.STEP.ToColor()) { }
    }

    [Export(typeof(EditorFormatDefinition))]
    [Name(Consts._classificationTypeNameStep + "Marker")]
    [UserVisible(true)]
    internal sealed class MarkerFormatStep : KeywordMarkerFormat {
        public MarkerFormatStep() : base("STEP", Consts.ColorKeyword.STEP.ToColor()) { }
    }
    #endregion

    #region IMPORTANT

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts._classificationTypeNameImportant)]
    [Name(Consts._classificationTypeNameImportant)]
    [BaseDefinition(PredefinedClassificationTypeNames.Comment)]
    [UserVisible(true)]
    internal sealed class FormatCommentImportant : KeywordClassificationFormat {
        public FormatCommentImportant() : base("IMPORTANT", Consts.ColorKeyword.IMPORTANT.ToColor()) { }
    }

    [Export(typeof(EditorFormatDefinition))]
    [Name(Consts._classificationTypeNameImportant + "Marker")]
    [UserVisible(true)]
    internal sealed class MarkerFormatImportant : KeywordMarkerFormat {
        public MarkerFormatImportant() : base("IMPORTANT", Consts.ColorKeyword.IMPORTANT.ToColor()) { }
    }

    #endregion

    #region DELETE

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts._classificationTypeNameDelete)]
    [Name(Consts._classificationTypeNameDelete)]
    [BaseDefinition(PredefinedClassificationTypeNames.Comment)]
    [UserVisible(true)]
    internal sealed class FormatCommentDelete : KeywordClassificationFormat {
        public FormatCommentDelete() : base("DELETE", Consts.ColorKeyword.DELETE.ToColor()) { }
    }

    [Export(typeof(EditorFormatDefinition))]
    [Name(Consts._classificationTypeNameDelete + "Marker")]
    [UserVisible(true)]
    internal sealed class MarkerFormatDelete : KeywordMarkerFormat {
        public MarkerFormatDelete() : base("DELETE", Consts.ColorKeyword.DELETE.ToColor()) { }
    }
    #endregion

    #region WIP
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts._classificationTypeNameWip)]
    [Name(Consts._classificationTypeNameWip)]
    [BaseDefinition(PredefinedClassificationTypeNames.Comment)]
    [UserVisible(true)]
    internal sealed class FormatCommentWip : KeywordClassificationFormat {
        public FormatCommentWip() : base("WIP", Consts.ColorKeyword.WIP.ToColor()) { }
    }

    [Export(typeof(EditorFormatDefinition))]
    [Name(Consts._classificationTypeNameWip + "Marker")]
    [UserVisible(true)]
    internal sealed class MarkerFormatWip : KeywordMarkerFormat {
        public MarkerFormatWip() : base("WIP", Consts.ColorKeyword.WIP.ToColor()) { }
    }
    #endregion

    #region WORKAROUND

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts._classificationTypeNameWorkaround)]
    [Name(Consts._classificationTypeNameWorkaround)]
    [BaseDefinition(PredefinedClassificationTypeNames.Comment)]
    [UserVisible(true)]
    internal sealed class FormatCommentWorkaround : KeywordClassificationFormat {
        public FormatCommentWorkaround() : base("WORKAROUND", Consts.ColorKeyword.WORKAROUND.ToColor()) { }
    }

    [Export(typeof(EditorFormatDefinition))]
    [Name(Consts._classificationTypeNameWorkaround + "Marker")]
    [UserVisible(true)]
    internal sealed class MarkerFormatWorkaround : KeywordMarkerFormat {
        public MarkerFormatWorkaround() : base("WORKAROUND", Consts.ColorKeyword.WORKAROUND.ToColor()) { }
    }
    #endregion
}
