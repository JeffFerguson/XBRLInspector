using JeffFerguson.Gepsio;
using System;

namespace XBRLInspector.Blazor.Models
{
    public class XbrlDocumentCacheModel
    {
        private static readonly Lazy<XbrlDocument> lazy = new Lazy<XbrlDocument>(() => new XbrlDocument());

        public static XbrlDocument Instance { get { return lazy.Value; } }

        private XbrlDocumentCacheModel()
        {
        }
    }
}
