using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

using System.Collections.Generic;

namespace UmbSense.Compleation.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Children, "umb-editor-view")]
    [ContentType("htmlx")]
    class UmbEditorView : BaseCompleation
    {
        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "umb-editor-header", "" },
            { "umb-editor-container", "" },
            { "umb-editor-footer", "" }
        };
    }
}
