using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;


namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Children, TagName)]
    [ContentType("htmlx")]
    class UmbTourStep : BaseCompletion
    {
        internal const string TagName = "umb-tour-step";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { UmbTourStepContent.TagName, "The tour step content component is a component that can be used in custom views for tour steps. It's meant to be used in the umb-tour-step directive. All markup in the body of the directive will be shown after the content attribute" },
            { UmbTourStepCounter.TagName, "The tour step counter component is a component that can be used in custom views for tour steps. It's meant to be used in the umb-tour-step-footer directive. It will show the progress you have made in a tour eg. step 2/12" },
            { UmbTourStepFooter.TagName, "The tour step footer component is a component that can be used in custom views for tour steps. It's meant to be used in the umb-tour-step directive. All markup in the body of the directive will be shown as the footer of the tour step" },
            { UmbTourStepHeader.TagName, "The tour step header component is a component that can be used in custom views for tour steps. It's meant to be used in the umb-tour-step directive." }
        };
    }



    [HtmlCompletionProvider(CompletionTypes.Attributes, UmbTourStep.TagName)]
    [ContentType("htmlx")]
    class UmbTourStepAttributes : BaseCompletion
    {
        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "on-close", "The callback which should be performened when the close button of the tour step is clicked" },
            { "hide-close", "A boolean indicating if the close button needs to be shown" }
        };
    }



    [HtmlCompletionProvider(CompletionTypes.Values, UmbTourStep.TagName, "*")]
    [ContentType("htmlx")]
    class UmbTourStepValues : BaseValueCompletion
    {
        protected override Dictionary<string, List<string>> attribValues => new Dictionary<string, List<string>>()
        {
            { "hide-close", new List<string> { "true", "false" } }
        };
    }
}