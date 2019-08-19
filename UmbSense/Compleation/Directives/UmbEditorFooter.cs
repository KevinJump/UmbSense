using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmbSense.Compleation.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Children, "umb-editor-view")]
    [ContentType("htmlx")]
    class UmbEditorFooter : BaseCompleation
    {
        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "umb-editor-footer-content-left", "" },
            { "umb-editor-footer-content-right", "" }
        };
    }
}
