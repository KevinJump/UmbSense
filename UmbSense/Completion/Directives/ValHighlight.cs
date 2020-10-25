using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "*")]
    [ContentType("htmlx")]
    class ValHighlight : BaseCompletion
    {
        internal const string TagName = "val-highlight";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { TagName, "Used on input fields when you want to signal that they are in error, this will highlight the item for 1 second" }
        };
    }
}