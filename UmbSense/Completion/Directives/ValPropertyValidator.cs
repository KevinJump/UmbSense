using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "*")]
    [ContentType("htmlx")]
    class ValPropertyEditor : BaseCompletion
    {
        internal const string TagName = "val-property-validator";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { TagName, "Performs any custom property value validation checks on the client side. This allows property editors to be highly flexible when it comes to validation on the client side. Typically if a property editor stores a primitive value (i.e. string) then the client side validation can easily be taken care of with standard angular directives such as ng-required. However since some property editors store complex data such as JSON, a given property editor might require custom validation. This directive can be used to validate an Umbraco property in any way that a developer would like by specifying a callback method to perform the validation. The result of this method must return an object in the format of {isValid: true, errorKey: 'required', errorMsg: 'Something went wrong' } The error message returned will also be displayed for the property level validation message. This directive should only be used when dealing with complex models, if custom validation needs to be performed with primitive values, use the simpler angular validation directives instead since this will watch the entire model." }
        };
    }
}