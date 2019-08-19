using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "umb-button")]
    [ContentType("htmlx")]
    class UmbButton : BaseCompletion
    {
        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "action", "The button action which should be performed when the button is clicked." },
            { "href", "Url/Path to navigato to" },
            { "type", "Set the button type (\"button\" or \"submit\")" },
            { "button-style", "Set the style of the button" },
            { "state", "Set a progress state on the button" },
            { "shortcut", "Set a keyboard shortcut for the button" },
            { "label", "Set the button label" },
            { "label-key", "Set a localization key to make a multi lingual button" },
            { "icon", "Set a button icon" },
            { "size", "Set a button icon" },
            { "disabled", "Set to true to disable the button" },
            { "add-ellipsis", "Adds an ellipsis character (…) to the button label" },
            { "show-caret", "Shows a caret on the right side of the button label" }
        };
    }

    [HtmlCompletionProvider(CompletionTypes.Values, "umb-button", "*")]
    [ContentType("htmlx")]
    class UmbButtonValues : BaseValueCompletion
    {
        protected override Dictionary<string, List<string>> attribValues => new Dictionary<string, List<string>>()
        {
            { "button-style", new List<string> { "action", "primary", "info", "success", "warning", "danger", "inverse", "link", "block" } },
            { "type", new List<string> { "button", "submit" } },
            { "size", new List<string> { "xs", "m", "l", "xl" } }
        };
    }
}
