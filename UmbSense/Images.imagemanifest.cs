using Microsoft.VisualStudio.Imaging.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmbSense
{
    public static class Images
    {
        private static Guid _guid = new Guid("{3b2a6f15-801e-4a0a-8dc2-4ae02ceb847f}");
        public static ImageMoniker UmbLogo =>
            new ImageMoniker { Guid = _guid, Id = 0 };
    }
}
