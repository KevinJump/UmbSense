using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

using System.Collections.Generic;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "umb-toggle")]
    [ContentType("htmlx")]
    class UmbToggle : BaseCompletion
    {
        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "checked", "Set to true or false to toggle the switch" } ,
            { "on-click", "The function which should be called when the toggle is clicked" },
            { "show-labels", "Set to true or false to show a \"On\" or \"Off\" label" },
            { "label-on", "Set a custom label for when the switched is turned on" },
            { "label-off", "Set a custom label for when the switched is turned off" },
            { "label-position", "Sets the label position to the left or right of the switch." },
            { "hide-icons", "Set to true or false to hide the icons on the switch" }
        };
    }

    [HtmlCompletionProvider(CompletionTypes.Values, "umb-toggle")]
    [ContentType("htmlx")]
    class UmbToggleValues : BaseValueCompletion
    {
        protected override Dictionary<string, List<string>> attribValues => new Dictionary<string, List<string>>()
        {
            { "label-position", new List<string> { "left", "right" } },
            { "show-labels", new List<string> { "true", "false"} },
            { "hide-icons", new List<string> { "true", "false"} },
        };
    }
}
