using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{

    [HtmlCompletionProvider(CompletionTypes.Children, TagName)]
    [ContentType("htmlx")]
    class UmbDropdown : BaseCompletion
    {
        internal const string TagName = "umb-dropdown";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { UmbDropdownItem.TagName, "Use this directive to construct a dropdown item." },
            { UmbKeyboardList.TagName, "Use this directive to add arrow up and down keyboard shortcuts to a list." }
        };
    }


    [HtmlCompletionProvider(CompletionTypes.Attributes, UmbDropdown.TagName)]
    [ContentType("htmlx")]
    class UmbDropdownAttributes : BaseCompletion
    {
        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "on-close", "Callback when the dropdown menu closes. When you click outside or press esc." }
        };
    }
}
