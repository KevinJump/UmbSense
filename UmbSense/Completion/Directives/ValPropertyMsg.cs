using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "textarea")]
    [ContentType("htmlx")]
    class ValPropertyMsg : BaseCompletion
    {
        internal const string TagName = "val-property-msg";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { TagName, "This directive is used to control the display of the property level validation message. We will listen for server side validation changes and when an error is detected for this property we'll show the error message. In order for this directive to work, the valFormManager directive must be placed on the containing form. We don't set the validity of this validator to false when client side validation fails, only when server side validation fails however we do respond to the client side validation changes to display error and adjust UI state." }
        };
    }
}