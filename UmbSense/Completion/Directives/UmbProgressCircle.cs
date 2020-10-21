using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbProgressCircle : BaseCompletion
    {
        internal const string TagName = "umb-progress-circle";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "size", "This parameter defines the width and the height of the circle in pixels." },
            { "percentage", "Takes a number between 0 and 100 and applies it to the circle's highlight length." },
            { "color", "The color of the highlight (primary, secondary, success, warning, danger). Success by default." }            
        };
    }

    [HtmlCompletionProvider(CompletionTypes.Values, UmbProgressCircle.TagName)]
    [ContentType("htmlx")]
    class UmbProgressCircleValues : BaseValueCompletion
    {
        protected override Dictionary<string, List<string>> attribValues => new Dictionary<string, List<string>>()
        {
            { "color", new List<string> { "primary", "secondary", "success", "warning", "danger" } }
        };
    }
}
