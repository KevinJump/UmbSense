using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbTabsNav : BaseCompletion
    {
        internal const string TagName = "umb-tabs-nav";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "tabs", "A collection of tabs." },
            { "on-tab-change", "Callback when a tab is called. It Returns the selected tab." }
        };
    }
}
