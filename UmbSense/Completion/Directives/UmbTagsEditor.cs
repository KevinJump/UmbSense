using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "*")]
    [ContentType("htmlx")]
    class UmbTagsEditor : BaseCompletion
    {
        internal const string TagName = "umb-tags-editor";

        protected override Dictionary<string, string> values => new Dictionary<string, string>();
    }
}
