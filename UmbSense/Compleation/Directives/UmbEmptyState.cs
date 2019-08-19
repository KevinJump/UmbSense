using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;
using System.Collections.Generic;

namespace UmbSense.Compleation.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "umb-empty-state")]
    [ContentType("htmlx")]
    class UmbEmptyState : BaseCompleation
    {
        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "size", "Set the size of the text " },
            { "position", "Set the position of the text" }
        };

    }

    [HtmlCompletionProvider(CompletionTypes.Values, "umb-empty-stage", "*")]
    [ContentType("htmlx")]
    class UmbEmptyStateValues : BaseValueCompleation
    {
        protected override Dictionary<string, List<string>> attribValues => new Dictionary<string, List<string>>()
        {
            { "size", new List<string> { "small", "large" } }
        };
    }

}
