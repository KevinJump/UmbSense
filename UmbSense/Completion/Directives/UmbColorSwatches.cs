using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "umb-color-swatches")]
    [ContentType("htmlx")]
    class UmbColorSwatches : BaseCompletion
    {
        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "colors", "The array of colors" },
            { "selected-color", "The selected color" },
            { "size", "The size (s, m)" },
            { "use-label", "Specify if labels should be used" },
            { "use-color-class", "Specify if color values are css classes" },
            { "on-select", "Callback function when the item is selected" },
        };
    }
}
