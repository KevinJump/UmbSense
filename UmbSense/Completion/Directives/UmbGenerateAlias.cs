using System.Collections.Generic;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;
using Microsoft.VisualStudio.Utilities;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbGenerateAlias : BaseCompletion
    {
        internal const string TagName = "umb-generate-alias";
        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "alias", "The model where the alias is bound." },
            { "alias-from", "The model to generate the alias from." },
            { "validation-position", "The position of the validation. Set to 'left' or 'right'." },
            { "enable-lock", "Set to true to add a lock next to the alias from where it can be unlocked and changed." }
        };
    }


    [HtmlCompletionProvider(CompletionTypes.Values, UmbGenerateAlias.TagName, "*")]
    [ContentType("htmlx")]
    class UmbGenerateAliasValues : BaseValueCompletion
    {
        protected override Dictionary<string, List<string>> attribValues => new Dictionary<string, List<string>>()
        {
            { "validation-position", new List<string> { "left", "right" } },
            { "enable-lock", new List<string> { "true", "false" } }
        };
    }
}
