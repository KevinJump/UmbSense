using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Children, TagName)]
    [ContentType("htmlx")]
    class UmbEditorContainer : BaseCompletion
    {
        internal const string TagName = "umb-editor-container";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { UmbEditorSubHeader.TagName, "Use this directive to construct a sub header in the main editor window." }
        };
    }
}
