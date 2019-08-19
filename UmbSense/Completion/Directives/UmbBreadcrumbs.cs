using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;
using System.Collections.Generic;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "umb-breadcrumbs")]
    [ContentType("htmlx")]
    class UmbBreadcrumbs : BaseCompletion
    {
        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "ancestors", "Array of ancestors" },
            { "entity-type", "The content entity type" },
            { "callback", "when an ancestor is clicked. It will override the default link behaviour" }
        };
    }

}
