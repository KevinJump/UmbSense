using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbProgressBar : BaseCompletion
    {
        internal const string TagName = "umb-progress-bar";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "percentage", "The progress in percentage." },
            { "size", "The size (s, m)." }
        };
    }

    [HtmlCompletionProvider(CompletionTypes.Values, UmbProgressBar.TagName)]
    [ContentType("htmlx")]
    class UmbProgressBarValues : BaseValueCompletion
    {
        protected override Dictionary<string, List<string>> attribValues => new Dictionary<string, List<string>>()
        {
            { "size", new List<string> { "s", "m" } }
        };
    }
}
