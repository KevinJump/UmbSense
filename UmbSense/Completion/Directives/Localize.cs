using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "localize")]
    [ContentType("htmlx")]
    class Localize : BaseCompletion
    {
        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "key", "placeholder from xml file" }
        };
    }

    [HtmlCompletionProvider(CompletionTypes.Attributes, "input")]
    [ContentType("htmlx")]
    class LocalizeInput : BaseCompletion
    {
        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "localize", "placeholder from xml file" }
        };
    }
}
