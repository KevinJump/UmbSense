using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "*")]
    [ContentType("htmlx")]
    class ValServerMatch : BaseCompletion
    {
        internal const string TagName = "val-server-match";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { TagName, @"A custom validator applied to a form/ng-form within an umbProperty that validates server side validation data contained within the serverValidationManager. The data can be matched on 'exact', 'prefix', 'suffix' or 'contains' matches against a property validation key. The attribute value can be in multiple value types:
                STRING = The property validation key to have an exact match on. If matched, then the form will have a valServerMatch validator applied.
                OBJECT = A dictionary where the key is the match type: 'contains', 'prefix', 'suffix' and the value is either:
                    ARRAY = A list of property validation keys to match on. If any are matched then the form will have a valServerMatch validator applied.
                    OBJECT = A dictionary where the key is the validator error name applied to the form and the value is the STRING of the property validation key to match on" }
        };
    }
}