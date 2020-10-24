using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbToggleGroup : BaseCompletion
    {
        internal const string TagName = "umb-toggle-group";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "items", "The items to list in the toggle group" },
            { "on-click", "The function which should be called when the toggle is clicked for one of the items." }
        };
    }
}