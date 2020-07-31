using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbColorSwatches : BaseCompletion
    {
        internal const string TagName = "umb-color-swatches";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "colors", "The array of colors" },
            { "selected-color", "The selected color" },
            { "size", "The size (s, m)" },
            { "use-label", "Specify if labels should be used" },
            { "use-color-class", "Specify if color values are CSS classes" },
            { "color-class-name-prefix", "Specify the prefix used for the class for each color." },
            { "on-select", "Callback function when the item is selected" },
        };
    }

    [HtmlCompletionProvider(CompletionTypes.Values, UmbColorSwatches.TagName, "*")]
    [ContentType("htmlx")]
    class UmbColorSwatchesValues : BaseValueCompletion
    {
        protected override Dictionary<string, List<string>> attribValues => new Dictionary<string, List<string>>()
        {
            { "size", new List<string> { "s", "m" } }
        };
    }
}
