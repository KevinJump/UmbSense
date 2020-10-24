using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "div")]
    [ContentType("htmlx")]
    class AutoScale : BaseCompletion
    {
        internal const string TagName = "auto-scale";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { AutoScale.TagName, "Resize div's automatically to fit to the bottom of the screen, as an optional parameter an y-axis offset can be set So if you only want to scale the div to 70 pixels from the bottom you pass \"70\"" }
        };
    }
}