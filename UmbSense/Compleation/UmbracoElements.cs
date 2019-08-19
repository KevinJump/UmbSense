using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

using System.Collections.Generic;

namespace UmbSense.Compleation
{
    [HtmlCompletionProvider(CompletionTypes.Children, "*")]
    [ContentType("htmlx")]
    class UmbracoElements : BaseCompleation
    {
        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "localize", "Localize a specific token to put into the HTML as an item" },
            { "umb-box",  "Use this directive to render an already styled empty div tag." },
            { "umb-breadcrumbs", "Use this directive to generate a list of breadcrumbs" },
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
