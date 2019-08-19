using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Children, "umb-editor-view")]
    [ContentType("htmlx")]
    class UmbEditorView : BaseCompletion
    {
        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "umb-editor-header", "" },
            { "umb-editor-container", "" },
            { "umb-editor-footer", "" }
        };
    }
}
