using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "*")]
    [ContentType("htmlx")]
    class Hotkey : BaseCompletion
    {
        internal const string TagName = "hotkey";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { TagName, "" }
        };
    }
}