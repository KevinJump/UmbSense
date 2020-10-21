using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbPagination : BaseCompletion
    {
        internal const string TagName = "umb-pagination";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "page-number", "Current page number." },
            { "total-pages", "The total number of pages." },
            { "on-next", "Callback method to go to the next page." },
            { "on-prev", "Callback method to go to the previous page." },
            { "on-go-to-page", "Callback method to go to a specific page." }
        };
    }
}
