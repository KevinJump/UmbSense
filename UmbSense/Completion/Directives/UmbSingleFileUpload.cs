using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "*")]
    [ContentType("htmlx")]
    class UmbSingleFileUpload : BaseCompletion
    {
        internal const string TagName = "umb-single-file-upload";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { TagName, "A single file upload field that will reset itself based on the object passed in for the rebuild parameter. This is required because the only way to reset an upload control is to replace it's html." }
        };
    }
}
