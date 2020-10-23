using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbRadioButton : BaseCompletion
    {
        internal const string TagName = "umb-radiobutton";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "model", "Set to true or false to set the radiobutton to checked or unchecked." },
            { "input-id", "Set the id of the radiobutton." },
            { "value", "Set the value of the radiobutton." },
            { "name", "Set the name of the radiobutton." },
            { "text", "Set the text for the radiobutton label." },
            { "label-key", "Set a dictinary/localization string for the checkbox label." },
            { "server-validation-field", "Set the val-server-field of the radiobutton." },
            { "disabled", "Set the radiobutton to be disabled." },
            { "required", "Set the radiobutton to be required." },
            { "on-change", "Callback when the value of the radiobutton change by interaction." },
            { "css-class", "Set a css class modifier." },
            { "icon-class", "Set an icon next to radiobutton." },
            { "disable-dirty-check", "Disable checking if the model is dirty." }
        };
    }

    [HtmlCompletionProvider(CompletionTypes.Values, UmbRadioButton.TagName)]
    [ContentType("htmlx")]
    class UmbRadioButtonValues : BaseValueCompletion
    {
        protected override Dictionary<string, List<string>> attribValues => new Dictionary<string, List<string>>()
        {
            { "model", new List<string> { "true", "false" } },
            { "disabled", new List<string> { "true", "false" } },
            { "required", new List<string> { "true", "false" } },
            { "disable-dirty-check", new List<string> { "true", "false" } }
        };
    }
}
