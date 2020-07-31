using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbCodeSnippet : BaseCompletion
    {
        internal const string TagName = "umb-code-snippet";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "language", "Language of the code snippet." }
        };
    }

    [HtmlCompletionProvider(CompletionTypes.Values, UmbCodeSnippet.TagName, "*")]
    [ContentType("htmlx")]
    class UmbCodeSnippetValues : BaseValueCompletion
    {
        protected override Dictionary<string, List<string>> attribValues => new Dictionary<string, List<string>>()
        {
            { "language", new List<string> { "csharp", "html", "css", "javascript" } }
        };
    }
}
