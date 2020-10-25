using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "*")]
    [ContentType("htmlx")]
    class NoDirtyCheck : BaseCompletion
    {
        internal const string TagName = "no-dirty-check";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { TagName, "Can be attached to form inputs to prevent them from setting the form as dirty (https://stackoverflow.com/questions/17089090/prevent-input-from-setting-form-dirty-angularjs)" }
        };
    }
}