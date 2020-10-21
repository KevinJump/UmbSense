using System.Collections.Generic;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;
using Microsoft.VisualStudio.Utilities;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbKeyboardShortcutsOverview : BaseCompletion
    {
        internal const string TagName = "umb-keyboard-shortcuts-overview";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "model", "Keyboard shortcut model. See description and example at https://our.umbraco.com/apidocs/v8/ui/#/api/umbraco.directives.directive:umbkeyboardShortcutsOverview." }
        };
    }
}
