using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "*")]
    [ContentType("htmlx")]
    class PreventDefault : BaseCompletion
    {
        internal const string TagName = "prevent-default";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { TagName, "Use this directive to prevent default action of an element. Effectively implementing jQuery's preventdefault" }
        };
    }
}