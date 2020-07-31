using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbContentGrid : BaseCompletion
    {
        internal const string TagName = "umb-content-grid";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "content", "Array of content items" },
            { "content-properties", "Array of content item properties to include in the item" },
            { "on-click", "Callback method to handle click events on the content item" },
            { "on-click-name", "Callback method to handle click events on the checkmark icon" }
        };
    }
}
