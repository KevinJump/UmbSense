using System.Collections.Generic;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;
using Microsoft.VisualStudio.Utilities;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbLightbox : BaseCompletion
    {
        internal const string TagName = "umb-lightbox";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "items", "Array of gallery items." },
            { "on-close", "Callback when the lightbox is closed." },
            { "active-item-index", "Index of active item." }
        };
    }
}
