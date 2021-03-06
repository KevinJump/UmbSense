﻿using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Children, TagName)]
    [ContentType("htmlx")]
    class UmbEditorView : BaseCompletion
    {
        internal const string TagName = "umb-editor-view";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { UmbEditorHeaderValues.TagName, "Use this directive to construct a header inside the main editor window." },
            { UmbEditorContainer.TagName, "Use this directive to construct a main content area inside the main editor window." },
            { UmbEditorFooter.TagName, "Use this directive to construct a footer inside the main editor window." }
        };
    }

    [HtmlCompletionProvider(CompletionTypes.Attributes, UmbEditorView.TagName)]
    [ContentType("htmlx")]
    class UmbEditorViewAttributes : BaseCompletion
    {
        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "footer", "Set to display the footer." },
        };
    }

    [HtmlCompletionProvider(CompletionTypes.Values, UmbEditorView.TagName, "*")]
    [ContentType("htmlx")]
    class UmbEditorViewValues : BaseValueCompletion
    {
        protected override Dictionary<string, List<string>> attribValues => new Dictionary<string, List<string>>()
        {
            { "footer", new List<string> { "true", "false" } },
        };
    }
}
