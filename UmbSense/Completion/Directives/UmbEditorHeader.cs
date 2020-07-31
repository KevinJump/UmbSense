using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbEditorHeaderValues : BaseCompletion
    {
        internal const string TagName = "umb-editor-header";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "name", "The content name" },
            { "tabs", "Array of tabs" },
            { "navigation", "Array of sub views" },
            { "name-locked", "Set to true to lock the name" },
            { "menu", "Add a context menu to the editor" },
            { "icon", "Show and edit the content icon. Opens an overlay to change the icon." },
            { "hide-icon", "Set to true to hide icon" },
            { "alias", "show and edit the content alias" },
            { "hide-alias", "Set to true to hide alias" },
            { "description", "Add a description to the content" },
            { "hide-description", "Set to true to hide description" }
        };
    }
}
