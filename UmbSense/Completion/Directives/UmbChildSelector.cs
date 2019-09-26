using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "umb-child-selector")]
    [ContentType("htmlx")]
    class UmbChildSelector : BaseCompletion
    {
        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "selected-children", "Array of selected children" },
            { "available-children", "Array of items available for selection" },
            { "parent-name", "The parent name" },
            { "parent-icon", "The parent icon" },
            { "parent-id", "The parent id" },
            { "on-remove", "Callback when the remove button is clicked on an item" },
            { "on-add", "Callback when the add button is clicked" },
        };
    }
}
