using Microsoft.VisualStudio.Language.StandardClassification;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;

namespace Highlighter
{
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts.classificationTypeNameToDo)]
    [Name(Consts.classificationTypeNameToDo)]
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
            ForegroundColor = Consts.Colors.system;
            BackgroundColor = Consts.Colors.todo;
            BackgroundCustomizable = true;
            IsBold = false;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts.classificationTypeNameBug)]
    [Name(Consts.classificationTypeNameBug)]
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
            ForegroundColor = Consts.Colors.system;
            BackgroundColor = Consts.Colors.bug;
            BackgroundCustomizable = true;
            IsBold = false;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts.classificationTypeNameFix)]
    [Name(Consts.classificationTypeNameFix)]
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
            ForegroundColor = Consts.Colors.system;
            BackgroundColor = Consts.Colors.fix;
            BackgroundCustomizable = true;
            IsBold = false;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts.classificationTypeNameNote)]
    [Name(Consts.classificationTypeNameNote)]
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
            ForegroundColor = Consts.Colors.system;
            BackgroundColor = Consts.Colors.note;
            BackgroundCustomizable = true;
            IsBold = false;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts.classificationTypeNameDiscuss)]
    [Name(Consts.classificationTypeNameDiscuss)]
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
            ForegroundColor = Consts.Colors.system;
            BackgroundColor = Consts.Colors.discuss;
            BackgroundCustomizable = true;
            IsBold = false;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts.classificationTypeNameIdea)]
    [Name(Consts.classificationTypeNameIdea)]
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
            ForegroundColor = Consts.Colors.system;
            BackgroundColor = Consts.Colors.idea;
            BackgroundCustomizable = true;
            IsBold = false;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts.classificationTypeNameOptimize)]
    [Name(Consts.classificationTypeNameOptimize)]
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
            ForegroundColor = Consts.Colors.system;
            BackgroundColor = Consts.Colors.optimize;
            BackgroundCustomizable = true;
            IsBold = false;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts.classificationTypeNameStep)]
    [Name(Consts.classificationTypeNameStep)]
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
            ForegroundColor = Consts.Colors.system;
            BackgroundColor = Consts.Colors.step;
            BackgroundCustomizable = true;
            IsBold = false;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts.classificationTypeNameImportant)]
    [Name(Consts.classificationTypeNameImportant)]
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
            ForegroundColor = Consts.Colors.system;
            BackgroundColor = Consts.Colors.important;
            BackgroundCustomizable = true;
            IsBold = false;
        }
    }
}
