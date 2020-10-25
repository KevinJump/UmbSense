using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Children, TagName)]
    [ContentType("htmlx")]
    class UmbEditorSubHeader : BaseCompletion
    {
        internal const string TagName = "umb-editor-sub-header";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { UmbEditorSubHeaderContentRightRight.TagName, "Use this directive to rigt align content in a sub header in the main editor window." },
            { UmbEditorSubHeaderContentRightLeft.TagName, "Use this directive to left align content in a sub header in the main editor window." }
        };
    }
}
