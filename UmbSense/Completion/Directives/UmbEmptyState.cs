using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbEmptyState : BaseCompletion
    {
        internal const string TagName = "umb-empty-state";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "size", "Set the size of the text " },
            { "position", "Set the position of the text" }
        };
    }

    [HtmlCompletionProvider(CompletionTypes.Values, UmbEmptyState.TagName, "*")]
    [ContentType("htmlx")]
    class UmbEmptyStateValues : BaseValueCompletion
    {
        protected override Dictionary<string, List<string>> attribValues => new Dictionary<string, List<string>>()
        {
            { "size", new List<string> { "small", "large" } }
        };
    }
}
