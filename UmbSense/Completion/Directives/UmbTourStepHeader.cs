using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;


namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbTourStepHeader : BaseCompletion
    {
        internal const string TagName = "umb-tour-step-header";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "title", "The title that needs to be shown" }
        };
    }
}