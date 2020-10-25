using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "*")]
    [ContentType("htmlx")]
    class NavResize : BaseCompletion
    {
        internal const string TagName = "nav-resize";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { TagName, "Handles how the navigation responds to window resizing and controls how the draggable resize panel works" }
        };
    }
}