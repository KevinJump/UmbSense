using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "*")]
    [ContentType("htmlx")]
    class ValRegex : BaseCompletion
    {
        internal const string TagName = "val-regex";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { TagName, "A custom directive to allow for matching a value against a regex string. NOTE: there's already an ng-pattern but this requires that a regex expression is set, not a regex string" }
        };
    }
}