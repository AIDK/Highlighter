using Microsoft.VisualStudio.Language.StandardClassification;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;

namespace Highlighter
{
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts._classificationTypeNameToDo)]
    [Name(Consts._classificationTypeNameToDo)]
    [BaseDefinition(PredefinedClassificationTypeNames.Comment)]
    [UserVisible(true)]
    [Order(After = PredefinedClassificationTypeNames.Comment)]
    [Order(After = "Xml Doc Comment")]
    [Order(After = Priority.Default)]
    internal sealed class FormatCommentTodo : ClassificationFormatDefinition
    {
        public FormatCommentTodo()
        {
            DisplayName = "Highlighter - TODO";

            BackgroundCustomizable = false;
            ForegroundColor = Consts.ColorKeyword.SYSTEM.ToColor();
            BackgroundColor = Consts.ColorKeyword.TODO.ToColor();
            BackgroundCustomizable = true;
            IsBold = false;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts._classificationTypeNameBug)]
    [Name(Consts._classificationTypeNameBug)]
    [BaseDefinition(PredefinedClassificationTypeNames.Comment)]
    [UserVisible(true)]
    [Order(After = PredefinedClassificationTypeNames.Comment)]
    [Order(After = "Xml Doc Comment")]
    [Order(After = Priority.Default)]

    internal sealed class FormatCommentBug : ClassificationFormatDefinition
    {
        public FormatCommentBug()
        {
            DisplayName = "Highlighter - BUG";

            BackgroundCustomizable = false;
            ForegroundColor = Consts.ColorKeyword.SYSTEM.ToColor();
            BackgroundColor = Consts.ColorKeyword.BUG.ToColor();
            BackgroundCustomizable = true;
            IsBold = false;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts._classificationTypeNameFix)]
    [Name(Consts._classificationTypeNameFix)]
    [BaseDefinition(PredefinedClassificationTypeNames.Comment)]
    [UserVisible(true)]
    [Order(After = PredefinedClassificationTypeNames.Comment)]
    [Order(After = "Xml Doc Comment")]
    [Order(After = Priority.Default)]
    internal sealed class FormatCommentFix : ClassificationFormatDefinition
    {
        public FormatCommentFix()
        {
            DisplayName = "Highlighter - FIXME";

            BackgroundCustomizable = false;
            ForegroundColor = Consts.ColorKeyword.SYSTEM.ToColor();
            BackgroundColor = Consts.ColorKeyword.FIXME.ToColor();
            BackgroundCustomizable = true;
            IsBold = false;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts._classificationTypeNameNote)]
    [Name(Consts._classificationTypeNameNote)]
    [BaseDefinition(PredefinedClassificationTypeNames.Comment)]
    [UserVisible(true)]
    [Order(After = PredefinedClassificationTypeNames.Comment)]
    [Order(After = "Xml Doc Comment")]
    [Order(After = Priority.Default)]
    internal sealed class FormatCommentNote : ClassificationFormatDefinition
    {
        public FormatCommentNote()
        {
            DisplayName = "Highlighter - NOTE";

            BackgroundCustomizable = false;
            ForegroundColor = Consts.ColorKeyword.SYSTEM.ToColor();
            BackgroundColor = Consts.ColorKeyword.NOTE.ToColor();
            BackgroundCustomizable = true;
            IsBold = false;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts._classificationTypeNameDiscuss)]
    [Name(Consts._classificationTypeNameDiscuss)]
    [BaseDefinition(PredefinedClassificationTypeNames.Comment)]
    [UserVisible(true)]
    [Order(After = PredefinedClassificationTypeNames.Comment)]
    [Order(After = "Xml Doc Comment")]
    [Order(After = Priority.Default)]
    internal sealed class FormatCommentDiscuss : ClassificationFormatDefinition
    {
        public FormatCommentDiscuss()
        {
            DisplayName = "Highlighter - DISCUSS";

            BackgroundCustomizable = false;
            ForegroundColor = Consts.ColorKeyword.SYSTEM.ToColor();
            BackgroundColor = Consts.ColorKeyword.DISCUSS.ToColor();
            BackgroundCustomizable = true;
            IsBold = false;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts._classificationTypeNameIdea)]
    [Name(Consts._classificationTypeNameIdea)]
    [BaseDefinition(PredefinedClassificationTypeNames.Comment)]
    [UserVisible(true)]
    [Order(After = PredefinedClassificationTypeNames.Comment)]
    [Order(After = "Xml Doc Comment")]
    [Order(After = Priority.Default)]
    internal sealed class FormatCommentIdea : ClassificationFormatDefinition
    {
        public FormatCommentIdea()
        {
            DisplayName = "Highlighter - IDEA";

            BackgroundCustomizable = false;
            ForegroundColor = Consts.ColorKeyword.SYSTEM.ToColor();
            BackgroundColor = Consts.ColorKeyword.IDEA.ToColor();
            BackgroundCustomizable = true;
            IsBold = false;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts._classificationTypeNameOptimize)]
    [Name(Consts._classificationTypeNameOptimize)]
    [BaseDefinition(PredefinedClassificationTypeNames.Comment)]
    [UserVisible(true)]
    [Order(After = PredefinedClassificationTypeNames.Comment)]
    [Order(After = "Xml Doc Comment")]
    [Order(After = Priority.Default)]
    internal sealed class FormatCommentOptimize : ClassificationFormatDefinition
    {
        public FormatCommentOptimize()
        {
            DisplayName = "Highlighter - OPTIMIZE";

            BackgroundCustomizable = false;
            ForegroundColor = Consts.ColorKeyword.SYSTEM.ToColor();
            BackgroundColor = Consts.ColorKeyword.OPTIMIZE.ToColor();
            BackgroundCustomizable = true;
            IsBold = false;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts._classificationTypeNameStep)]
    [Name(Consts._classificationTypeNameStep)]
    [BaseDefinition(PredefinedClassificationTypeNames.Comment)]
    [UserVisible(true)]
    [Order(After = PredefinedClassificationTypeNames.Comment)]
    [Order(After = "Xml Doc Comment")]
    [Order(After = Priority.Default)]
    internal sealed class FormatCommentStep : ClassificationFormatDefinition
    {
        public FormatCommentStep ()
        {
            DisplayName = "Highlighter - STEP";

            BackgroundCustomizable = false;
            ForegroundColor = Consts.ColorKeyword.SYSTEM.ToColor();
            BackgroundColor = Consts.ColorKeyword.STEP.ToColor();
            BackgroundCustomizable = true;
            IsBold = false;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts._classificationTypeNameImportant)]
    [Name(Consts._classificationTypeNameImportant)]
    [BaseDefinition(PredefinedClassificationTypeNames.Comment)]
    [UserVisible(true)]
    [Order(After = PredefinedClassificationTypeNames.Comment)]
    [Order(After = "Xml Doc Comment")]
    [Order(After = Priority.Default)]
    internal sealed class FormatCommentImportant : ClassificationFormatDefinition
    {
        public FormatCommentImportant()
        {
            DisplayName = "Highlighter - IMPORTANT";

            BackgroundCustomizable = false;
            ForegroundColor = Consts.ColorKeyword.SYSTEM.ToColor();
            BackgroundColor = Consts.ColorKeyword.IMPORTANT.ToColor();
            BackgroundCustomizable = true;
            IsBold = false;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts._classificationTypeNameDelete)]
    [Name(Consts._classificationTypeNameDelete)]
    [BaseDefinition(PredefinedClassificationTypeNames.Comment)]
    [UserVisible(true)]
    [Order(After = PredefinedClassificationTypeNames.Comment)]
    [Order(After = "Xml Doc Comment")]
    [Order(After = Priority.Default)]
    internal sealed class FormatCommentDelete : ClassificationFormatDefinition
    {
        public FormatCommentDelete()
        {
            DisplayName = "Highlighter - DELETE";

            BackgroundCustomizable = false;
            ForegroundColor = Consts.ColorKeyword.SYSTEM.ToColor();
            BackgroundColor = Consts.ColorKeyword.DELETE.ToColor();
            BackgroundCustomizable = true;
            IsBold = false;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts._classificationTypeNameWip)]
    [Name(Consts._classificationTypeNameWip)]
    [BaseDefinition(PredefinedClassificationTypeNames.Comment)]
    [UserVisible(true)]
    [Order(After = PredefinedClassificationTypeNames.Comment)]
    [Order(After = "Xml Doc Comment")]
    [Order(After = Priority.Default)]
    internal sealed class FormatCommentWip : ClassificationFormatDefinition
    {
        public FormatCommentWip()
        {
            DisplayName = "Highlighter - WIP";

            BackgroundCustomizable = false;
            ForegroundColor = Consts.ColorKeyword.SYSTEM.ToColor();
            BackgroundColor = Consts.ColorKeyword.WIP.ToColor();
            BackgroundCustomizable = true;
            IsBold = false;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts._classificationTypeNameWorkaround)]
    [Name(Consts._classificationTypeNameWorkaround)]
    [BaseDefinition(PredefinedClassificationTypeNames.Comment)]
    [UserVisible(true)]
    [Order(After = PredefinedClassificationTypeNames.Comment)]
    [Order(After = "Xml Doc Comment")]
    [Order(After = Priority.Default)]
    internal sealed class FormatCommentWorkaround : ClassificationFormatDefinition
    {
        public FormatCommentWorkaround()
        {
            DisplayName = "Highlighter - WORKAROUND";

            BackgroundCustomizable = false;
            ForegroundColor = Consts.ColorKeyword.SYSTEM.ToColor();
            BackgroundColor = Consts.ColorKeyword.WORKAROUND.ToColor();
            BackgroundCustomizable = true;
            IsBold = false;
        }
    }
}
