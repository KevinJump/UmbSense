using System.Collections.Generic;

using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    class UmbEditorSubHeaderContentRightLeftBase : BaseCompletion
    {
        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "umb-editor-sub-header-section", "Use this directive to create sections, divided by borders, in a sub header in the main editor window." },
        };
    }

    [HtmlCompletionProvider(CompletionTypes.Children, TagName)]
    [ContentType("htmlx")]
    class UmbEditorSubHeaderContentRightLeft : UmbEditorSubHeaderContentRightLeftBase
    {
        internal const string TagName = "umb-editor-sub-header-content-left";
    }

    [HtmlCompletionProvider(CompletionTypes.Children, TagName)]
    [ContentType("htmlx")]
    class UmbEditorSubHeaderContentRightRight : UmbEditorSubHeaderContentRightLeftBase
    {
        internal const string TagName = "umb-editor-sub-header-content-right";
    }




}
