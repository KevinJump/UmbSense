using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbDateTimePicker : BaseCompletion
    {
        internal const string TagName = "umb-date-time-picker";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "ng-model", "Config object for the date picker." },
            { "options", "Config object for the date picker." },
            { "on-setup", "(callback): onSetup gets triggered when the date picker is initialized" },
            { "on-change", "(callback): onChange gets triggered when the user selects a date, or changes the time on a selected date." },
            { "on-open", "(callback): onOpen gets triggered when the calendar is opened." },
            { "on-close", "(callback): onClose gets triggered when the calendar is closed." },
            { "on-month-change", "(callback): onMonthChange gets triggered when the month is changed, either by the user or programmatically." },
            { "on-year-change", "(callback): onMonthChange gets triggered when the year is changed, either by the user or programmatically." },
            { "on-ready", "(callback): onReady gets triggered once the calendar is in a ready state." },
            { "on-value-update", "(callback): onValueUpdate gets triggered when the input value is updated with a new date string." },
            { "on-day-create", "(callback): Take full control of every date cell with the onDayCreate() hook." },
        };
    }
}
