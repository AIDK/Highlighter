using Microsoft.VisualStudio.Language.StandardClassification;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Highlighter
{
    internal class Classifier : IClassifier
    {
        private readonly IClassifier _classifier;
        private readonly IClassificationType _comment_Bug;
        private readonly IClassificationType _comment_Fix;
        private readonly IClassificationType _comment_Discuss;
        private readonly IClassificationType _comment_Note;
        private readonly IClassificationType _comment_Optimize;
        private readonly IClassificationType _comment_Todo;
        private readonly IClassificationType _comment_Step;
        private readonly IClassificationType _comment_Important;
        private readonly string _pattern = @"(?<Star>\*)?" + @"(?<Slashes>(?<!/)(/{2,}))[ \t\v\f]*" + @"(?<Comment>[^\n]*)";
        private bool _isClassificationRunning;

        internal Classifier(IClassificationTypeRegistryService registry, IClassifier classifier)
        {
            _isClassificationRunning = false;
            _classifier = classifier;

            _comment_Todo = registry.GetClassificationType(Consts._classificationTypeNameToDo);
            _comment_Bug = registry.GetClassificationType(Consts._classificationTypeNameBug);
            _comment_Fix = registry.GetClassificationType(Consts._classificationTypeNameFix);
            _comment_Note = registry.GetClassificationType(Consts._classificationTypeNameNote);
            _comment_Optimize = registry.GetClassificationType(Consts._classificationTypeNameOptimize);
            _comment_Discuss = registry.GetClassificationType(Consts._classificationTypeNameDiscuss);
            _comment_Step = registry.GetClassificationType(Consts._classificationTypeNameStep);
            _comment_Important = registry.GetClassificationType(Consts._classificationTypeNameImportant);
        }

        public event EventHandler<ClassificationChangedEventArgs> ClassificationChanged;

        public IList<ClassificationSpan> GetClassificationSpans(SnapshotSpan span)
        {
            if (_isClassificationRunning)
                return new List<ClassificationSpan>();

            try
            {
                _isClassificationRunning = true;
                return Classify(span);
            }
            finally
            {
                _isClassificationRunning = false;
            }
        }

        private IList<ClassificationSpan> Classify(SnapshotSpan span)
        {
            var spans = new List<ClassificationSpan>();
            if (span.IsEmpty)
                return spans;

            var text = span.GetText();
            var offset = 0;
            int currentOffset;

        NextComment:
            foreach (Match match in new Regex(_pattern).Matches(text))
            {
                var starOffset = 0;

                if (match.Groups["Star"].Length > 0)
                    goto SkipComment;

                var matchedSpan = new SnapshotSpan(span.Snapshot, new Span(span.Start + offset + starOffset + match.Index, match.Length - starOffset));
                var intersections = _classifier.GetClassificationSpans(matchedSpan);

                foreach (var intersection in intersections)
                {
                    var classifications = intersection.ClassificationType.Classification.Split(new[] { " - " }, StringSplitOptions.None);

                    if (!Utils.IsClassifiedAs(classifications, new[] { PredefinedClassificationTypeNames.Comment, "XML Doc Comment" }))
                        goto SkipComment;

                    if (Utils.IsClassifiedAs(classifications, new[] { "Comment.Default" }))
                        goto SkipComment;
                }

                // start offset of slashes
                var slashesStart = Convert.ToInt32(span.Start + offset + match.Groups["Slashes"].Index);
                if (starOffset == 2)
                    slashesStart += 1;

                var slashesLength = match.Groups["Slashes"].Length;
                if (starOffset == 2)
                    slashesLength -= 1;

                var isTripleSlash = slashesLength == 3;
                if (isTripleSlash)
                    goto SkipComment;

                var commentText = match.Groups["Comment"].Value;
                var skipInlineMatching = false;

                for (int i = 0; i < PrefixManager.Count; i++)
                {
                    var prefix = PrefixManager.GetPrefix(i);
                    if (commentText.ToLower().Trim().StartsWith(prefix.ToLower() + ":"))
                    {
                        // uncomment below code if you want to highlight the entire commented line
                        //spans.Add(new ClassificationSpan(new SnapshotSpan(span.Snapshot, new Span(slashesStart, commentText.Length + slashesLength)), GetClassifier(prefix.ToLower())));

                        // the below code highlights only the prefix i.e. BUG, TODO, etc.
                        spans.Add(new ClassificationSpan(new SnapshotSpan(span.Snapshot, new Span(slashesStart + slashesLength, prefix.Length + 1)), GetClassifier(prefix.ToLower())));
                        skipInlineMatching = true;
                    }
                }

                if (skipInlineMatching)
                    goto FinishClassification;

            FinishClassification:
                currentOffset = match.Index + match.Length;
                text = text.Substring(currentOffset);
                offset += currentOffset;
                goto NextComment;

            SkipComment:
                currentOffset = match.Groups["Slashes"].Index + match.Groups["Slashes"].Length;

                text = text.Substring(currentOffset);
                offset += currentOffset;
                goto NextComment;
            }

            return spans;
        }

        private IClassificationType GetClassifier(string prefix)
        {
            switch (prefix)
            {
                case "todo":
                    return _comment_Todo;

                case "bug":
                    return _comment_Bug;

                case "fixme":
                    return _comment_Fix;

                case "note":
                    return _comment_Note;

                case "optimize":
                    return _comment_Optimize;

                case "discuss":
                    return _comment_Discuss;

                case "step":
                    return _comment_Step;

                case "important":
                    return _comment_Important;

                default:
                    return _comment_Todo;
            }
        }
    }
}