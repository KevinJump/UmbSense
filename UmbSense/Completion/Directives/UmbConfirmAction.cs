using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

using System.Collections.Generic;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "umb-confirm-action")]
    [ContentType("htmlx")]
    class UmbConfirmAction : BaseCompletion
    {
        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "direction", "The direction the prompt options" },
            { "on-confirm", "The call back when the checkmark clicked" },
            { "on-cancel", "The call back when the cross clicked" }
        };
    }

    [HtmlCompletionProvider(CompletionTypes.Values, "umb-confirm-action", "*")]
    [ContentType("htmlx")]
    class UmbConfirmActionValues : BaseValueCompletion
    {
        protected override Dictionary<string, List<string>> attribValues => new Dictionary<string, List<string>>()
        {
            { "direction", new List<string> { "up", "down", "left", "right" } }
        };
    }
}
