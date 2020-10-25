using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "*")]
    [ContentType("htmlx")]
    class ValSubView : BaseCompletion
    {
        internal const string TagName = "val-sub-view";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { TagName, "Used to show validation warnings for a editor sub view (used in conjunction with: umb-editor-sub-view or umb-editor-sub-views) to indicate that the section content has validation errors in its data. In order for this directive to work, the valFormManager directive must be placed on the containing form. When applied to" }
        };
    }
}