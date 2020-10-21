using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;
using System.Collections.Generic;


namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbFolderGrid : BaseCompletion
    {
        internal const string TagName = "umb-folder-grid";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "folders", "Array of folders" },
            { "onClick", "Callback method to handle click events on the folder." },
            { "onSelect", "Callback method to handle click events on the checkmark icon." }
        };
    }
}
