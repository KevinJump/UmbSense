using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;


namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbTourStepCounter : BaseCompletion
    {
        internal const string TagName = "umb-tour-step-counter";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "current-step", "The current step the tour is on" },
            { "total-steps", "The current step the tour is on" }
        };
    }
}
