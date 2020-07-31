using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbCheckbox : BaseCompletion
    {
        internal const string TagName = "umb-checkbox";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "model", "Set to true or false to set the checkbox to checked or unchecked" },
            { "inputId", "Set the id of the checkbox" },
            { "value", "Set the value of the checkbox" },
            { "name", "Set the name of the checkbox" },
            { "text", "Set the text for the checkbox label" },
            { "label-key", "Set a dictinary/localization string for the checkbox label" },
            { "server-validation-field", "Set the val-server-field of the checkbox" },
            { "disabled", "Set the checkbox to be disabled" },
            { "required", "Set the checkbox to be required" },
            { "on-change", "Callback when the value of the checkbox change by interaction" },
            { "css-class", "Set a css class modifier" }
        };
    }

    [HtmlCompletionProvider(CompletionTypes.Values, UmbCheckbox.TagName, "*")]
    [ContentType("htmlx")]
    class UmbCheckboxValues : BaseValueCompletion
    {
        protected override Dictionary<string, List<string>> attribValues => new Dictionary<string, List<string>>()
        {
            { "model", new List<string> { "true", "false" } },
            { "disabled", new List<string> { "true", "false" } },
            { "required", new List<string> { "true", "false" } }
        };
    }
}
