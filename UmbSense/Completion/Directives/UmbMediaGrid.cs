using System.Collections.Generic;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;
using Microsoft.VisualStudio.Utilities;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbMediaGrid : BaseCompletion
    {
        internal const string TagName = "umb-media-grid";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "items", "Array of media items." },
            { "on-details-hover", "Callback method when the details icon is hovered." },
            { "on-click", "Callback method to handle click events on the media item." },
            { "on-click-name", "Callback method to handle click events on the media item name." },
            { "filter-by", "String to filter media items by" },
            { "item-max-width", "Sets a max width on the media item thumbnails." },
            { "item-max-height", "Sets a max height on the media item thumbnails." },
            { "item-min-width", "Sets a min width on the media item thumbnails." },
            { "item-min-height", "Sets a min height on the media item thumbnails." }
        };
    }
}
