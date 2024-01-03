using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;

namespace Highlighter
{
    internal static class Definitions
    {
        [Export(typeof(ClassificationTypeDefinition))]
        [Name(Consts._classificationTypeNameToDo)]
        private static readonly ClassificationTypeDefinition Definition_Comment_Todo;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name(Consts._classificationTypeNameBug)]
        private static readonly ClassificationTypeDefinition Definition_Comment_Bug;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name(Consts._classificationTypeNameFix)]
        private static readonly ClassificationTypeDefinition Definition_Comment_Fix;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name(Consts._classificationTypeNameNote)]
        private static readonly ClassificationTypeDefinition Definition_Comment_Note;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name(Consts._classificationTypeNameOptimize)]
        private static readonly ClassificationTypeDefinition Definition_Comment_Optimize;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name(Consts._classificationTypeNameIdea)]
        private static readonly ClassificationTypeDefinition Definition_Comment_Idea;
    }
}