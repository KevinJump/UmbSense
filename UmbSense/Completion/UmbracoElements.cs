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
            { UmbBadge.TagName, "Use this directive to render a badge." },
            { UmbBox.TagName,  "Use this directive to render an already styled empty div tag." },
            { UmbBreadcrumbs.TagName, "Use this directive to generate a list of breadcrumbs." },
            { UmbButton.TagName, "Use this directive to render an Umbraco button. The directive can be used to generate all types of buttons, set type, style, translation, shortcut and much more." },
            { UmbButtonGroup.TagName, "Use this directive to render a button with a dropdown of alternative actions." },
            { UmbChildSelector.TagName, "Use this directive to render a ui component for selecting child items to a parent node." },
            { UmbClipboard.TagName, "Use this directive to copy content to the clipboard" },
            { UmbCheckbox.TagName, "Use this directive to render an Umbraco checkbox" },
            { UmbCodeSnippet.TagName, "Use this directive to render a code snippet." },
            { UmbConfirm.TagName, "A confirmation dialog" },
            { UmbConfirmAction.TagName, "Use this directive to toggle a confirmation prompt for an action." },
            { UmbContentGrid.TagName, "Use this directive to generate a list of content items presented as a flexbox grid." },
            { UmbControlGroup.TagName, "" },
            { UmbColorSwatches.TagName, "Use this directive to generate color swatches to pick from." },
            { UmbDateTimePicker.TagName, "Use this directive to render a date time picker" },
            { UmbDrawer.TagName, "Drawer component is a global component and is already added to the umbraco markup. It is registered in globalState and can be opened and configured by raising events." },
            { UmbDrawerContent.TagName, "Use this directive to render drawer content." },
            { UmbDrawerFooter.TagName, "Use this directive to render a drawer footer." },
            { UmbDrawerHeader.TagName, "Use this directive to render a drawer header." },
            { UmbDrawerView.TagName, "Use this directive to render drawer view." },
            { UmbEditorView.TagName, "Use this directive to construct the main editor window." },
            { UmbEmptyState.TagName, "Use this directive to show an empty state message." },
            { UmbNodePreview.TagName, "Use this directive to render a node preview." },
            { UmbPane.TagName, "" },
            { UmbPanel.TagName, "" },
            { UmbTable.TagName, "Use this directive to render a data table." },
            { UmbToggle.TagName, "Use this directive to render an umbraco toggle." },
            { UmbTooltip.TagName, "Use this directive to render a tooltip." },
        };
    }
}

