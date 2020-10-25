using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "*")]
    [ContentType("htmlx")]
    class ValServer : BaseCompletion
    {
        internal const string TagName = "val-server";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { TagName, "This directive is used to associate a content property with a server-side validation response so that the validators in angular are updated based on server-side feedback." }
        };
    }
}