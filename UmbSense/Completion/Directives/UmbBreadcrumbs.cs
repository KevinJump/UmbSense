using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbBreadcrumbs : BaseCompletion
    {
        internal const string TagName = "umb-breadcrumbs";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "ancestors", "Array of ancestors." },
            { "entity-type", "The content entity type." },
            { "callback", "When an ancestor is clicked. It will override the default link behaviour." }
        };
    }
}
