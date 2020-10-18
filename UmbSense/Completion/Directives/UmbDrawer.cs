using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Children, TagName)]
    [ContentType("htmlx")]
    class UmbDrawer : BaseCompletion
    {
        internal const string TagName = "umb-drawer";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { UmbDrawerView.TagName, "Use this directive to render drawer view." },
            { UmbDrawerHeader.TagName, "Use this directive to render a drawer header." },
            { UmbDrawerContent.TagName, "Use this directive to render drawer content." },
            { UmbDrawerFooter.TagName, "Use this directive to render a drawer footer." }
        };
    }



    [HtmlCompletionProvider(CompletionTypes.Attributes, UmbDrawer.TagName)]
    [ContentType("htmlx")]
    class UmbDrawerAttributes : BaseCompletion
    {
        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "view", "Set the drawer view" },
            { "model", "Pass in custom data to the drawer" }
        };
    }




}
