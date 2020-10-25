using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "*")]
    [ContentType("htmlx")]
    class Multi : BaseCompletion
    {
        internal const string TagName = "multi";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { TagName, "Used on input fields when you want to validate multiple fields at once." }
        };
    }
}