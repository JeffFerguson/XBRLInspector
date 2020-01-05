using JeffFerguson.Gepsio;
using System;
using System.Threading.Tasks;

namespace XBRLInspector.Blazor.Models
{
    /// <summary>
    /// A class to cache the loaded XBRL document as loaded by Gepsio.
    /// </summary>
    /// <remarks>
    /// This class is a hack to share state simply. It is a singleton class that
    /// keeps track of the loaded XBRL document between pages. In a more sophisticated
    /// system, this should be replaced with something more robust.
    /// </remarks>
    public class XbrlDocumentCacheModel
    {
        private static XbrlDocument doc;

        public static XbrlDocument Instance { get { return doc; } }

        private XbrlDocumentCacheModel()
        {
            doc = new XbrlDocument();
        }

        public static async Task LoadAsync(string path)
        {
            doc = new XbrlDocument();
            await doc.LoadAsync(path);
        }
    }
}
