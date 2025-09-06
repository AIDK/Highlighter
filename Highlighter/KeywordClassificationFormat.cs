using System.Windows.Media;

using Microsoft.VisualStudio.Text.Classification;

namespace Highlighter {

    internal abstract class KeywordClassificationFormat : ClassificationFormatDefinition {

        protected KeywordClassificationFormat(string displayName, Color background, bool isBold = false) {

            DisplayName = $"Highlighter - {displayName}";
            ForegroundColor = Consts.ColorKeyword.SYSTEM.ToColor();
            BackgroundColor = background;
            IsBold = isBold;
        }
    }

    internal abstract class KeywordMarkerFormat : MarkerFormatDefinition {

        protected KeywordMarkerFormat(string displayName, Color background) {

            DisplayName = $"Highlighter Marker - {displayName}";
            ForegroundColor = Consts.ColorKeyword.SYSTEM.ToColor();
            BackgroundColor = background;
            ZOrder = 5;
        }
    }
}
