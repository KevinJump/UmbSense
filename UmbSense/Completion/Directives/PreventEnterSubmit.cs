using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "*")]
    [ContentType("htmlx")]
    class PreventEnterSubmit : BaseCompletion
    {
        internal const string TagName = "prevent-enter-submit";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { TagName, "prevents a form from submitting when the enter key is pressed on an input field" }
        };
    }
}