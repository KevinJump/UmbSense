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
            { "umb-button", "" },
            { "umb-button-group", "" },
            { "umb-confirm", "" },
            { "umb-confirm-action", "" },
            { "umb-editor-view", "" },
            { "umb-empty-state", "" },
            { "umb-pane", "" },
            { "umb-panal", "" },
            { "umb-toggle", "" }
        };
    }
}
