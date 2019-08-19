using Microsoft.VisualStudio.Imaging.Interop;
using Microsoft.VisualStudio.Language.Intellisense;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.WebTools.Languages.Html.Editor.Completion;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace UmbSense.Completion
{
    abstract class BaseCompletion : IHtmlCompletionListProvider
    {
        public string CompletionType { get; }
        protected string elementName;

        protected BaseCompletion()
        {
            var thisType = GetType();
            var meta = thisType.GetCustomAttribute<HtmlCompletionProviderAttribute>(false);

            this.elementName = meta.ElementName;
            this.CompletionType = meta.CompletionType;
        }

        protected abstract Dictionary<string, string> values { get; }

        public virtual IList<HtmlCompletion> GetEntries(HtmlCompletionContext context)
        {
            if (context.Element != null 
                && (this.elementName == "*" || context.Element.Name.Equals(this.elementName)) )
            {
                return ValueList(values, context.Session);
            }

            return new List<HtmlCompletion>();
        }

        public IList<HtmlCompletion> ValueList(IDictionary<string, string> values, ICompletionSession session)
        {
            return values.Select(x => CreateItem(x.Key, x.Value, session))
                .ToList();
        }

        public IList<HtmlCompletion> ValueList(IList<string> values, ICompletionSession session)
        {
            return values.Select(x => CreateItem(x, string.Empty, session))
                .ToList();

        }

        protected HtmlCompletion CreateItem(string name, string description, ICompletionSession session)
        {
            string desc = "";
            if (!string.IsNullOrWhiteSpace(description))
            {
                desc = description + Environment.NewLine + Environment.NewLine + "Umbraco Backoffice UI";
            }

            return new HtmlCompletion(name, name, desc, _icon, null, session);
        }

        private static ImageSource _icon = GetImage(Images.UmbLogo, 16);

        public static BitmapSource GetImage(ImageMoniker moniker, int size)
        {
            ImageAttributes imageAttributes = new ImageAttributes
            {
                Flags = (uint)_ImageAttributesFlags.IAF_RequiredFlags,
                ImageType = (uint)_UIImageType.IT_Bitmap,
                Format = (uint)_UIDataFormat.DF_WPF,
                LogicalHeight = size,
                LogicalWidth = size,
                StructSize = Marshal.SizeOf(typeof(ImageAttributes))
            };

            ThreadHelper.ThrowIfNotOnUIThread();

            var imageService = (IVsImageService2)Package.GetGlobalService(typeof(SVsImageService));
            var image = imageService.GetImage(moniker, imageAttributes);

            object data;
            image.get_Data(out data);

            if (data == null)
                return null;

            return data as BitmapSource;
        }

    }
}
