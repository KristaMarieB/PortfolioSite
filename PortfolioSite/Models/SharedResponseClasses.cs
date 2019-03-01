using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortfolioSite.Models
{
    public class Blog
    {
        public string id { get; set; }
    }

    public class Image
    {
        public string url { get; set; }
    }

    public class Author
    {
        public string id { get; set; }
        public string displayName { get; set; }
        public string url { get; set; }
        public Image image { get; set; }
    }
}