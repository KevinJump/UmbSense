using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "*")]
    [ContentType("htmlx")]
    class ValTab : BaseCompletion
    {
        internal const string TagName = "val-tab";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { TagName, "Used to show validation warnings for a tab to indicate that the tab content has validations errors in its data. In order for this directive to work, the valFormManager directive must be placed on the containing form." }
        };
    }
}