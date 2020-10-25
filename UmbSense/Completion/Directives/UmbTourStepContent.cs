using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;


namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbTourStepContent : BaseCompletion
    {
        internal const string TagName = "umb-tour-step-content";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "content", "The content that needs to be shown" }
        };
    }
}
