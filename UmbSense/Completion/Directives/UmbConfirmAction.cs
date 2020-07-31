using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbConfirmAction : BaseCompletion
    {
        internal const string TagName = "umb-confirm-action";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "direction", "The direction the prompt opens." },
            { "on-confirm", "The callback when the checkmark clicked." },
            { "on-cancel", "The callback when the cross clicked." }
        };
    }

    [HtmlCompletionProvider(CompletionTypes.Values, UmbConfirmAction.TagName, "*")]
    [ContentType("htmlx")]
    class UmbConfirmActionValues : BaseValueCompletion
    {
        protected override Dictionary<string, List<string>> attribValues => new Dictionary<string, List<string>>()
        {
            { "direction", new List<string> { "up", "down", "left", "right" } }
        };
    }
}
