using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;


namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbUserGroupPreview : BaseCompletion
    {
        internal const string TagName = "umb-user-group-preview";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "icon", "The user group icon." },
            { "name", "The user group name." },
            { "sections", "Lists out the sections where the user has authority to edit." },
            { "content-start-node", "The starting point in the tree of the content section.  So the user has no authority to work on other branches, only on this branch in the content section." },
            { "hide-content-start-node", "Hides the contentStartNode." },
            { "media-start-node", "The starting point in the tree of the media section.  So the user has no authority to work on other branches, only on this branch in the media section." },
            { "hide-media-start-node", "Hides the mediaStartNode." },
            { "permissions", "A list of permissions, the user can have." },
            { "allow-remove", "Shows or Hides the remove button." },
            { "on-remove", "Callback function when the remove button is clicked." },
            { "allow-edit", "Shows or Hides the edit button." },
            { "on-edit", "Callback function when the edit button is clicked." },
        };
    }

    [HtmlCompletionProvider(CompletionTypes.Values, UmbUserGroupPreview.TagName, "*")]
    [ContentType("htmlx")]
    class UmbUserGroupPreviewValues : BaseValueCompletion
    {
        protected override Dictionary<string, List<string>> attribValues => new Dictionary<string, List<string>>()
        {
            { "hide-content-start-node", new List<string> { "true", "false" } },
            { "hide-media-start-node", new List<string> { "true", "false" } },
            { "allow-remove", new List<string> { "true", "false" } },
            { "allow-edit", new List<string> { "true", "false" } },
        };
    }
}