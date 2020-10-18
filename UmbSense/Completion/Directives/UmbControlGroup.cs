using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, UmbControlGroup.TagName)]
    [ContentType("htmlx")]
    class UmbControlGroup : BaseCompletion
    {
        internal const string TagName = "umb-control-group";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "label", "The label for the control group field." },
            { "description", "The description for the control group field." },
            { "hideLabel", "Set to true to hide the label." },
            { "alias", "The alias of the field within the control group." },
            { "labelFor", "The alias of the field that the label is for, used for validation." },
            { "required", "Set to true to mark the field as required." },
        };
    }

    [HtmlCompletionProvider(CompletionTypes.Values, UmbControlGroup.TagName, "*")]
    [ContentType("htmlx")]
    class UmbControlGroupValues : BaseValueCompletion
    {
        protected override Dictionary<string, List<string>> attribValues => new Dictionary<string, List<string>>()
        {
            { "hideLabel", new List<string> { "true", "false" } },
            { "required", new List<string> { "true", "false" } }
        };
    }
}
