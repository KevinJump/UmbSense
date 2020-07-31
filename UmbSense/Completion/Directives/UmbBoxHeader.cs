using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbBoxHeader : BaseCompletion
    {
        internal const string TagName = "umb-box-header";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "title", "Custom title text" },
            { "titleKey", "The translation key from the language xml files" },
            { "description", "Custom description text" },
            { "descriptionKey", "The translation key from the language xml file" }
        };
    }
}
