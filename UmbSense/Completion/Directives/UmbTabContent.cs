using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbTabContent : BaseCompletion
    {
        internal const string TagName = "umb-tab-content";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "tab", "The tab." }
        };
    }
}
