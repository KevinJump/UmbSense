using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbTreeItem : BaseCompletion
    {
        internal const string TagName = "umb-tree-item";

        protected override Dictionary<string, string> values => new Dictionary<string, string>();
    }

    [HtmlCompletionProvider(CompletionTypes.Attributes, "*")]
    [ContentType("htmlx")]
    class UmbTreeItemAttributeSelf : BaseCompletion
    {
        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { UmbTreeItem.TagName, "Renders a list item, representing a single node in the tree. Includes element to toggle children, and a menu toggling button" }
        };
    }
}
