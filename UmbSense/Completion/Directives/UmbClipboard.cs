using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbClipboard : BaseCompletion
    {
        internal const string TagName = "umb-clipboard";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "umb-clipboard-success", "Callback function when the content is copied." },
            { "umb-clipboard-error", "Callback function if the copy fails." },
            { "umb-clipboard-target", "The target element to copy." },
            { "umb-clipboard-action", "Specify if you want to copy or cut content (\"copy\", \"cut\"). Cut only works on input and textarea elements." },
            { "umb-clipboard-text", "Use this attribute if you don't have an element to copy from." },
        };
    }

    [HtmlCompletionProvider(CompletionTypes.Values, UmbClipboard.TagName, "*")]
    [ContentType("htmlx")]
    class UmbClipboardValues : BaseValueCompletion
    {
        protected override Dictionary<string, List<string>> attribValues => new Dictionary<string, List<string>>()
        {
            { "umb-clipboard-action", new List<string> { "copy", "cut" } }
        };
    }
}
