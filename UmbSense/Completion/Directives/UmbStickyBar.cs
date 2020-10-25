using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "*")]
    [ContentType("htmlx")]
    class UmbStickyBar : BaseCompletion
    {
        internal const string TagName = "umb-sticky-bar";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { UmbStickyBar.TagName, "Use this directive make an element sticky and follow the page when scrolling. umb-sticky-bar--active class is applied when the element is stuck" }
        };
    }
}
