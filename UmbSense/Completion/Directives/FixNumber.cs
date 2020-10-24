using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "*")]
    [ContentType("htmlx")]
    class FixNumber : BaseCompletion
    {
        internal const string TagName = "fix-number";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { TagName, "Used in conjunction with type='number' input fields to ensure that the bound value is converted to a number when using ng-model because normally it thinks it's a string and also validation doesn't work correctly due to an angular bug." }
        };
    }
}