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
            { UmbBox.TagName,  "Use this directive to render an already styled empty div tag." },
            { UmbBreadcrumbs.TagName, "Use this directive to generate a list of breadcrumbs." },
            { UmbButton.TagName, "Use this directive to render an Umbraco button. The directive can be used to generate all types of buttons, set type, style, translation, shortcut and much more." },
            { UmbButtonGroup.TagName, "Use this directive to render a button with a dropdown of alternative actions." },
            { UmbConfirm.TagName, "A confirmation dialog" },
            { "umb-confirm-action", "" },
            { "umb-editor-view", "" },
            { "umb-empty-state", "" },
            { "umb-pane", "" },
            { "umb-panal", "" },
            { "umb-toggle", "" }
        };
    }
}
