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
            ForegroundColor = Consts.Colors._system;
            BackgroundColor = Consts.Colors._todo;
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
            ForegroundColor = Consts.Colors._system;
            BackgroundColor = Consts.Colors._bug;
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
            ForegroundColor = Consts.Colors._system;
            BackgroundColor = Consts.Colors._fix;
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
            ForegroundColor = Consts.Colors._system;
            BackgroundColor = Consts.Colors._note;
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
    internal sealed class FormatCommentIdea : ClassificationFormatDefinition
    {
        public FormatCommentIdea()
        {
            DisplayName = "Highlighter - DISCUSS";

            BackgroundCustomizable = false;
            ForegroundColor = Consts.Colors._system;
            BackgroundColor = Consts.Colors._discuss;
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
            ForegroundColor = Consts.Colors._system;
            BackgroundColor = Consts.Colors._optimize;
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
            ForegroundColor = Consts.Colors._system;
            BackgroundColor = Consts.Colors._step;
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
            ForegroundColor = Consts.Colors._system;
            BackgroundColor = Consts.Colors._important;
            BackgroundCustomizable = true;
            IsBold = false;
        }
    }
}
