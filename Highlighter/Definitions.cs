using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;

namespace Highlighter
{
    internal static class Definitions
    {
        [Export(typeof(ClassificationTypeDefinition))]
        [Name(Consts.classificationTypeNameToDo)]
        private static readonly ClassificationTypeDefinition Definition_Comment_Todo;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name(Consts.classificationTypeNameBug)]
        private static readonly ClassificationTypeDefinition Definition_Comment_Bug;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name(Consts.classificationTypeNameFix)]
        private static readonly ClassificationTypeDefinition Definition_Comment_FixMe;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name(Consts.classificationTypeNameNote)]
        private static readonly ClassificationTypeDefinition Definition_Comment_Note;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name(Consts.classificationTypeNameOptimize)]
        private static readonly ClassificationTypeDefinition Definition_Comment_Optimize;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name(Consts.classificationTypeNameDiscuss)]
        private static readonly ClassificationTypeDefinition Definition_Comment_Discuss;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name(Consts.classificationTypeNameStep)]
        private static readonly ClassificationTypeDefinition Definition_Comment_Step;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name(Consts.classificationTypeNameImportant)]
        private static readonly ClassificationTypeDefinition Definition_Comment_Important;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name(Consts.classificationTypeNameIdea)]
        private static readonly ClassificationTypeDefinition Definition_Comment_Idea;
    }
}
