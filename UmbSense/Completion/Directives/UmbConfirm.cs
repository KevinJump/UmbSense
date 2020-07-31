using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbConfirm : BaseCompletion
    {
        internal const string TagName = "umb-confirm";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "caption", "The caption shown above the buttons" },
            { "on-confirm", "The call back when the \"OK\" button is clicked" },
            { "on-cancel", "The call back when the \"Cancel\" button is clicked" }
        };
    }
}
