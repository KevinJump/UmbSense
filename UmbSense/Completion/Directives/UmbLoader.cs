using System.Collections.Generic;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;
using Microsoft.VisualStudio.Utilities;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbLoader : BaseCompletion
    {
        internal const string TagName = "umb-loader";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "position", "The loader position (\"top\", \"bottom\")." }
        };
    }

    [HtmlCompletionProvider(CompletionTypes.Values, UmbLoader.TagName, "*")]
    [ContentType("htmlx")]
    class UmbLoaderValues : BaseValueCompletion
    {
        protected override Dictionary<string, List<string>> attribValues => new Dictionary<string, List<string>>()
        {
            { "position", new List<string> { "top", "bottom" } }
        };
    }
}
