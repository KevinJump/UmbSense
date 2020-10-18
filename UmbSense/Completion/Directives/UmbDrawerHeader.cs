using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, TagName)]
    [ContentType("htmlx")]
    class UmbDrawerHeader : BaseCompletion
    {
        internal const string TagName = "umb-drawer-header";

        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "title", "Set a drawer title." },
            { "description", "Set a drawer description." }
        };
    }
}
