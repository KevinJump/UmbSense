using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WebTools.Languages.Html.Editor.Completion;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion
{
    abstract class BaseValueCompletion : BaseCompletion
    {
        protected override Dictionary<string, string> values => new Dictionary<string, string>();

        protected abstract Dictionary<string, List<string>> attribValues { get; }

        public override IList<HtmlCompletion> GetEntries(HtmlCompletionContext context)
        {
            if (context.Attribute != null && context.Element != null
                && context.Element.Name.Equals(this.elementName)
                && attribValues.ContainsKey(context.Attribute.Name))
            {
                return ValueList(attribValues[context.Attribute.Name], context.Session);
            }

            return new List<HtmlCompletion>();
           
        }
    }
}
