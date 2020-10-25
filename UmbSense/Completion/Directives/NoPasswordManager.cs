using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "*")]
    [ContentType("htmlx")]
    class NoPasswordManager : BaseCompletion
    {
        internal const string TagName = "no-password-manager";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { TagName, "Added attributes to block password manager elements should as LastPass" }
        };
    }
}