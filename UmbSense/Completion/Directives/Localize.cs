using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class Localize : BaseCompletion
    {
        internal const string TagName = "localize";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "key", "Localize a specific token to put into the HTML as an item." }
        };
    }

    [HtmlCompletionProvider(CompletionTypes.Attributes, "*")]
    [ContentType("htmlx")]
    class LocalizeInput : BaseCompletion
    {
        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { Localize.TagName, "Add a HTML attribute to an element containing the HTML attribute name you wish to localise Using the format of '@section_key' or 'section_key'." }
        };
    }
}
