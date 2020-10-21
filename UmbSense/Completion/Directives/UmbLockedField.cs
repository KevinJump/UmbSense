using System.Collections.Generic;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;
using Microsoft.VisualStudio.Utilities;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbLockedField : BaseCompletion
    {
        internal const string TagName = "umb-locked-field";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "ng-model", "The locked text." },
            { "locked", "true by default. Set to false to unlock the text." },
            { "placeholder-text", "If ngModel is empty this text will be shown." },
            { "regex-validation", "Set a regex expression for validation of the field." },
            { "validation-position", "The position of the validation. Set to 'left' or 'right'." },
            { "server-validation-field", "Set a server validation field." }
        };
    }

    [HtmlCompletionProvider(CompletionTypes.Values, UmbLockedField.TagName, "*")]
    [ContentType("htmlx")]
    class UmbLockedFieldGroupValues : BaseValueCompletion
    {
        protected override Dictionary<string, List<string>> attribValues => new Dictionary<string, List<string>>()
        {
            { "locked", new List<string> { "true", "false" } },
            { "validation-position", new List<string> { "left", "right" } }
        };
    }
}
