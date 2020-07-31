using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbAvatar : BaseCompletion
    {
        internal const string TagName = "umb-avatar";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "size", "The size of the avatar (xs, s, m, l, xl)" },
            { "img-src", "The image source to the avatar" },
            { "img-srcset", "Reponsive support for the image source" }
        };
    }
}
