using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbNodePreview : BaseCompletion
    {
        internal const string TagName = "umb-node-preview";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "icon", "The node icon." },
            { "name", "The node name." },
            { "alias", "The node document type alias will be displayed on hover if in debug mode or logged in as admin." },
            { "description", "A short description." },
            { "permissions", "Displays the user group permissions, (if applicable)" },
            { "published", "The node published state." },
            { "sortable", "Will add a move cursor on the node preview. Can used in combination with ui-sortable." },
            { "allow-open", "Show/Hide the open button." },
            { "allow-remove", "Show/Hide the remove button." },
            { "allow-edit", "Show/Hide the edit button (Added in version 7.7.0)." },
            { "on-open", " Callback function when the open button is clicked." },
            { "on-remove", "Callback function when the remove button is clicked." },
            { "on-edit", "Callback function when the edit button is clicked (Added in version 7.7.0)." },
            { "open-url", "Fallback URL for <code>onOpen</code> (Added in version 7.12.0)." },
            { "edit-url", "Fallback URL for <code>onEdit</code> (Added in version 7.12.0)." },
            { "remove-url", "Fallback URL for <code>onRemove</code> (Added in version 7.12.0)." },
        };
    }

    [HtmlCompletionProvider(CompletionTypes.Values, UmbNodePreview.TagName)]
    [ContentType("htmlx")]
    class UmbNodePreviewValues : BaseValueCompletion
    {
        protected override Dictionary<string, List<string>> attribValues => new Dictionary<string, List<string>>()
        {
            { "published", new List<string> { "true", "false" } },
            { "sortable", new List<string> { "true", "false" } },
            { "allow-open", new List<string> { "true", "false" } },
            { "allow-remove", new List<string> { "true", "false" } },
            { "allow-edit", new List<string> { "true", "false" } },
        };
    }
}
