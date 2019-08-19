using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "umb-tooltip")]
    [ContentType("htmlx")]
    class UmbTooltip : BaseCompletion
    {
        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "event", "Set the $event from the target element to position the tooltip relative to the mouse cursor." },
        };
    }
}
