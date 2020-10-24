using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "*")]
    [ContentType("htmlx")]
    class HexBgColor : BaseCompletion
    {
        internal const string TagName = "hex-bg-color";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { TagName, "Used to set a hex background color on an element, this will detect valid hex and when it is valid it will set the color, otherwise a color will not be set." }
        };
    }
}