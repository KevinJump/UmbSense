using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Children, TagName)]
    [ContentType("htmlx")]
    class UmbEditorFooter : BaseCompletion
    {
        internal const string TagName = "umb-editor-footer";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "umb-editor-footer-content-left", "" },
            { "umb-editor-footer-content-right", "" }
        };
    }
}
