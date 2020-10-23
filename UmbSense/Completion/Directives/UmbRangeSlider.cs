using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbRangeSlider : BaseCompletion
    {
        internal const string TagName = "umb-range-slider";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "ng-model", "Value for the slider." },
            { "options", "Config object for the date picker." },  // TODO: Revisit this language from the documentation -- its referring to datepicker
            { "on-setup", "Gets triggered when the slider is initialized" },
            { "on-update", "Fires every time the slider values are changed." },
            { "on-slide", "Gets triggered when the handle is being dragged." },
            { "on-set", "Will trigger every time a slider stops changing." },
            { "on-change", "Fires when a user stops sliding, or when a slider value is changed by 'tap'." },
            { "on-start", "Fires when a handle is clicked (mousedown, or the equivalent touch events)." },
            { "on-end", "Fires when a handle is released (mouseup etc), or when a slide is canceled due to other reasons." }
        };
    }


}
