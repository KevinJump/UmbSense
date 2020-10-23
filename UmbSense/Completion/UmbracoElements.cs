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
            { UmbDropdown.TagName, "Use this component to render a dropdown menu." },
            { UmbEditorView.TagName, "Use this directive to construct the main editor window." },
            { UmbEmptyState.TagName, "Use this directive to show an empty state message." },
            { UmbFileDropzone.TagName, "" },
            { UmbFileIcon.TagName, "Use this directive to render a file icon." },
            { UmbFileUpload.TagName, "Listens for file input control changes and emits events when files are selected for use in other controllers." },
            { UmbFolderGrid.TagName, "Use this directive to generate a list of folders presented as a flexbox grid." },
            { UmbGenerateAlias.TagName, "Use this directive to generate a camelCased umbraco alias. When the aliasFrom value is changed the directive will get a formatted alias from the server and update the alias model. If \"enableLock\" is set to true the directive will use umbLockedField to lock and unlock the alias." },
            { UmbImageCrop.TagName, "" },
            { UmbImageLazyLoad.TagName, "Use this directive to lazy-load an image only when it is scrolled into view." },
            { UmbImageThumbnail.TagName, "" },
            { UmbKeyboardShortcutsOverview.TagName, "Use this directive to show an overview of keyboard shortcuts in an editor. The directive will render an overview trigger wich shows how the overview is opened. When this combination is hit an overview is opened with shortcuts based on the model sent to the directive." },
            { UmbLightbox.TagName, "Use this directive to open a gallery in a lightbox overlay." },
            { UmbLoader.TagName, "Use this directive to generate a loading indicator." },
            { UmbLoadIndicator.TagName, "Use this directive to generate a loading indicator." },
            { UmbLockedField.TagName, "Use this directive to render a value with a lock next to it. When the lock is clicked the value gets unlocked and can be edited." },
            { UmbMediaGrid.TagName, "Use this directive to generate a thumbnail grid of media items." },
            { UmbNavigation.TagName, "" },
            { UmbNodePreview.TagName, "Use this directive to render a node preview." },
            { UmbPagination.TagName, "Use this directive to generate a pagination." },
            { UmbPane.TagName, "" },
            { UmbPanel.TagName, "" },
            { UmbProgressBar.TagName, "Use this directive to generate a progress bar." },
            { UmbProgressCircle.TagName, "Use this directive to render a circular progressbar." },
            { UmbProperty.TagName, "" },
            { UmbPropertyEditor.TagName, "" },
            { UmbRadioButton.TagName, "Use this directive to render an umbraco radio button." },
            { UmbRangeSlider.TagName, "This directive is a wrapper of the noUiSlider library. Use it to render a slider. For extra details about options and events take a look here: https://refreshless.com/nouislider/" },
            { UmbSections.TagName, "" },
            { UmbSingleFileUpload.TagName, "A single file upload field that will reset itself based on the object passed in for the rebuild parameter. This is required because the only way to reset an upload control is to replace it's html." },
            { UmbTabContent.TagName, "Use this directive to render tab content. For an example see: umbTabContent" },
            { UmbTable.TagName, "Use this directive to render a data table." },
            { UmbToggle.TagName, "Use this directive to render an umbraco toggle." },
            { UmbTooltip.TagName, "Use this directive to render a tooltip." },
        };
    }
}

