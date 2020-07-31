using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;
using UmbSense.Completion.Directives;

namespace UmbSense.Completion
{
    [HtmlCompletionProvider(CompletionTypes.Children, "*")]
    [ContentType("htmlx")]
    class UmbracoElements : BaseCompletion
    {
        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { Localize.TagName, "Localize a specific token to put into the HTML as an item." },
            { UmbAvatar.TagName, "Use this directive to render an avatar." },
            { UmbBox.TagName,  "Use this directive to render an already styled empty div tag." },
            { UmbBreadcrumbs.TagName, "Use this directive to generate a list of breadcrumbs." },
            { UmbButton.TagName, "Use this directive to render an Umbraco button. The directive can be used to generate all types of buttons, set type, style, translation, shortcut and much more." },
            { UmbButtonGroup.TagName, "Use this directive to render a button with a dropdown of alternative actions." },
            { UmbChildSelector.TagName, "Use this directive to render a ui component for selecting child items to a parent node." },
            { UmbConfirm.TagName, "A confirmation dialog" },
            { UmbConfirmAction.TagName, "Use this directive to toggle a confirmation prompt for an action." },
            { UmbContentGrid.TagName, "Use this directive to generate a list of content items presented as a flexbox grid." },
            { UmbColorSwatches.TagName, "Use this directive to generate color swatches to pick from." },
            { UmbEditorView.TagName, "Use this directive to construct the main editor window." },
            { UmbEmptyState.TagName, "Use this directive to show an empty state message." },
            { UmbNodePreview.TagName, "Use this directive to render a node preview." },
            { "umb-pane", "" },
            { "umb-panel", "" },
            { UmbTable.TagName, "Use this directive to render a data table." },
            { UmbToggle.TagName, "Use this directive to render an umbraco toggle." },
            { UmbTooltip.TagName, "Use this directive to render a tooltip." },
        };
    }
}
