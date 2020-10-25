using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbFileIcon : BaseCompletion
    {
        internal const string TagName = "umb-file-icon";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "size", "This parameter defines the size of the file icon (s, m)." }
        };
    }

    [HtmlCompletionProvider(CompletionTypes.Values, UmbFileIcon.TagName, "*")]
    [ContentType("htmlx")]
    class UmbFileIconValues : BaseValueCompletion
    {
        protected override Dictionary<string, List<string>> attribValues => new Dictionary<string, List<string>>()
        {
            { "size", new List<string> { "s", "m" } }
        };
    }
}
