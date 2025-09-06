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
        private readonly IClassifier classifier;
        private readonly string pattern = @"(?<Star>\*)?" + @"(?<Slashes>(?<!/)(/{2,}))[ \t\v\f]*" + @"(?<Comment>[^\n]*)";
        private bool isClassificationRunning;
        private readonly Dictionary<string, IClassificationType> classificationMap;

        internal Classifier(IClassificationTypeRegistryService registry, IClassifier classifier)
        {
            this.isClassificationRunning = false;
            this.classificationMap = new Dictionary<string, IClassificationType>(StringComparer.OrdinalIgnoreCase);
            this.classifier = classifier;

            foreach (var item in KeywordService.KeywordToClassification) {
                if (registry.GetClassificationType(item.Value) != null) {
                    classificationMap[item.Key] = registry.GetClassificationType(item.Value);
                }
            }
        }

        public event EventHandler<ClassificationChangedEventArgs> ClassificationChanged;

        public IList<ClassificationSpan> GetClassificationSpans(SnapshotSpan span)
        {
            if (isClassificationRunning)
                return new List<ClassificationSpan>();

            try
            {
                isClassificationRunning = true;
                return Classify(span);
            }
            finally
            {
                isClassificationRunning = false;
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
            foreach (Match match in new Regex(pattern).Matches(text))
            {
                var starOffset = 0;

                if (match.Groups["Star"].Length > 0)
                    goto SkipComment;

                var matchedSpan = new SnapshotSpan(span.Snapshot, new Span(span.Start + offset + starOffset + match.Index, match.Length - starOffset));
                var intersections = classifier.GetClassificationSpans(matchedSpan);

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
                        spans.Add(new ClassificationSpan(new SnapshotSpan(span.Snapshot, new Span(slashesStart + slashesLength, prefix.Length + 1)), GetClassifier(prefix)));
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

        private IClassificationType GetClassifier(string prefix) => 
            classificationMap.TryGetValue(prefix, out var type) ? type : null;
    }
}
