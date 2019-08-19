using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "umb-table")]
    [ContentType("htmlx")]
    class UmbTable : BaseCompletion
    {
        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "items", "" },
            { "item-properties", "" },
            { "allow-select-all", "Show/Hide the \"Select All\" option." },
            { "on-select", "Callback function when the row is selected." },
            { "on-click", "Callback function when the \"Name\" column link is clicked." },
            { "on-select-all", "Callback function when selecting all items." },
            { "on-selected-all", "Callback function when all items are selected." },
            { "on-sorting-direction", "Callback function when sorting direction is changed." },
            { "on-sort", "Callback function when sorting items." },
        };
    }

    [HtmlCompletionProvider(CompletionTypes.Values, "umb-table")]
    [ContentType("htmlx")]
    class UmbTableValues : BaseValueCompletion
    {
        protected override Dictionary<string, List<string>> attribValues => new Dictionary<string, List<string>>()
        {
            { "allow-select-all", new List<string> { "true", "false" } },
        };
    }
}
