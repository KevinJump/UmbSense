using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "*")]
    [ContentType("htmlx")]
    class ValEmail : BaseCompletion
    {
        internal const string TagName = "val-email";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { TagName, "A custom directive to validate an email address string, this is required because angular's default validator is incorrect." }
        };
    }
}