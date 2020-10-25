using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "*")]
    [ContentType("htmlx")]
    class ValServerField : BaseCompletion
    {
        internal const string TagName = "val-server-field";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { TagName, "This directive is used to associate a field with a server-side validation response so that the validators in angular are updated based on server-side feedback. (For validation of user defined content properties on content/media/members, the valServer directive is used)" }
        };
    }
}