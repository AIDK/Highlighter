using Microsoft.VisualStudio.Language.StandardClassification;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;
using System.Windows.Media;

namespace Highlighter
{
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Consts._classificationTypeNameToDo)]
    [Name(Consts._classificationTypeNameToDo)]
    [BaseDefinition(PredefinedClassificationTypeNames.Comment)]
    [UserVisible(true)]
    [Order(After = PredefinedClassificationTypeNames.Comment)]
    [Order(After = "Xml Doc Comment")]
    internal sealed class FormatCommentTodo : ClassificationFormatDefinition
    {
        public FormatCommentTodo()
        {
            DisplayName = "Todo Comment";

            BackgroundCustomizable = false;
            ForegroundColor = Consts.Colors._system;
            BackgroundBrush = new SolidColorBrush(Consts.Colors._todo);
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
    internal sealed class FormatCommentBug : ClassificationFormatDefinition
    {
        public FormatCommentBug()
        {
            DisplayName = "Bug Comment";

            BackgroundCustomizable = false;
            ForegroundColor = Consts.Colors._system;
            BackgroundBrush = new SolidColorBrush(Consts.Colors._bug);
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
    internal sealed class FormatCommentFix : ClassificationFormatDefinition
    {
        public FormatCommentFix()
        {
            DisplayName = "Fix Comment";

            BackgroundCustomizable = false;
            ForegroundColor = Consts.Colors._system;
            BackgroundBrush = new SolidColorBrush(Consts.Colors._fix);
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
    internal sealed class FormatCommentNote : ClassificationFormatDefinition
    {
        public FormatCommentNote()
        {
            DisplayName = "Note Comment";

            BackgroundCustomizable = false;
            ForegroundColor = Consts.Colors._system;
            BackgroundBrush = new SolidColorBrush(Consts.Colors._note);
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
    internal sealed class FormatCommentIdea : ClassificationFormatDefinition
    {
        public FormatCommentIdea()
        {
            DisplayName = "Idea Comment";

            BackgroundCustomizable = false;
            ForegroundColor = Consts.Colors._system;
            BackgroundBrush = new SolidColorBrush(Consts.Colors._idea);
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
    internal sealed class FormatCommentOptimize : ClassificationFormatDefinition
    {
        public FormatCommentOptimize()
        {
            DisplayName = "Optimize Comment";

            BackgroundCustomizable = false;
            ForegroundColor = Consts.Colors._system;
            BackgroundBrush = new SolidColorBrush(Consts.Colors._optimize);
            IsBold = false;
        }
    }
}