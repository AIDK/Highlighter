using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Tagging;
using Microsoft.VisualStudio.Utilities;

namespace Highlighter {

    [Export(typeof(ITaggerProvider))]
    [ContentType("code")]
    [TagType(typeof(ITextMarkerTag))]
    internal sealed class KeywordMarkerProvider : ITaggerProvider {

        public ITagger<T> CreateTagger<T>(ITextBuffer buffer) where T : ITag => 
            new KeywordMarkerTagger(buffer) as ITagger<T>;
    }

    internal sealed class KeywordMarkerTagger : ITagger<ITextMarkerTag> {

        private readonly ITextBuffer buffer;
        public event EventHandler<SnapshotSpanEventArgs> TagsChanged { add { } remove { } }

        public KeywordMarkerTagger(ITextBuffer buffer) => this.buffer = buffer;

        public IEnumerable<ITagSpan<ITextMarkerTag>> GetTags(NormalizedSnapshotSpanCollection spans) {
            foreach (var span in spans) {
                var text = span.GetText();
                foreach (var keyword in KeywordService.GetAllPrefixes()) {

                    var index = text.IndexOf(keyword, StringComparison.OrdinalIgnoreCase);
                    while (index >= 0) {
                        var markerName = KeywordService.GetMarker(keyword);
                        if (markerName != null) {
                            var keywordSpan = new SnapshotSpan(span.Snapshot, new Span(span.Start + index, keyword.Length));
                            //yield return new TagSpan<ITextMarkerTag>(keywordSpan, new TextMarkerTag(markerName));
                            yield return null;
                        }

                        index = text.IndexOf(keyword, index + keyword.Length);
                    }
                }
            }
        }
    }
}
