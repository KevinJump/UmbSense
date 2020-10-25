using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "div")]
    [ContentType("htmlx")]
    class ResizeToContent : BaseCompletion
    {
        internal const string TagName = "resize-to-content";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { TagName, "Resize iframe's automatically to fit to the content they contain" }
        };
    }
}