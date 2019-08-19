using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

using System.Collections.Generic;

namespace UmbSense.Compleation.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "localize")]
    [ContentType("htmlx")]
    class Localize : BaseCompleation
    {
        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            {  "key", "placeholder from xml file" }
        };
    }

    [HtmlCompletionProvider(CompletionTypes.Attributes, "input")]
    [ContentType("htmlx")]
    class LocalizeInput : BaseCompleation
    {
        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            {  "localize", "placeholder from xml file" }
        };
    }
}
