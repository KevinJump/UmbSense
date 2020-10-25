using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Children, TagName)]
    [ContentType("htmlx")]
    class UmbBox : BaseCompletion
    {
        internal const string TagName = "umb-box";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { UmbBoxHeader.TagName, "Use this directive to construct a title. Recommended to use it inside an umbBox directive. See documentation for umbBox." },
            { UmbBoxContent.TagName, "Use this directive to render an empty container. Recommended to use it inside an umbBox directive. See documentation for umbBox." }
        };
    }
}
