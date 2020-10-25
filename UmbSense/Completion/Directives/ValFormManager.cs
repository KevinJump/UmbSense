using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "*")]
    [ContentType("htmlx")]
    class ValFormManager : BaseCompletion
    {
        internal const string TagName = "val-form-manager";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { TagName, "Used to broadcast an event to all elements inside this one to notify that form validation has changed. If we don't use this that means you have to put a watch for each directive on a form's validation changing which would result in much higher processing. We need to actually watch the whole $error collection of a form because just watching $valid or $invalid doesn't acurrately trigger form validation changing. This also sets the show-validation (or a custom) css class on the element when the form is invalid - this lets us css target elements to be displayed when the form is submitting/submitted. Another thing this directive does is to ensure that any .control-group that contains form elements that are invalid will be marked with the 'error' css class. This ensures that labels included in that control group are styled correctly." }
        };
    }
}