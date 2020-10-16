using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbBadge : BaseCompletion
    {
        internal const string TagName = "umb-badge";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "size", "The size (xxs, xs, s, m, l, xl)" },
            { "color", "The color of the highlight (primary, secondary, success, warning, danger, gray)." },
        };
    }

    [HtmlCompletionProvider(CompletionTypes.Values, UmbBadge.TagName, "*")]
    [ContentType("htmlx")]
    class UmbBadgeValues : BaseValueCompletion
    {
        protected override Dictionary<string, List<string>> attribValues => new Dictionary<string, List<string>>()
        {
            { "size", new List<string> { "xxs", "xs", "s", "m", "l", "xl" } },
            { "color", new List<string> { "primary", "secondary", "success", "warning", "danger", "gray" } },
        };
    }
}
