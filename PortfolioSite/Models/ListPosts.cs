using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortfolioSite.Models
{
    public class Replies
    {
        public string totalItems { get; set; }
        public string selfLink { get; set; }
    }

    public class Item
    {
        public string kind { get; set; }
        public string id { get; set; }
        public Blog blog { get; set; }
        public DateTime published { get; set; }
        public DateTime updated { get; set; }
        public string url { get; set; }
        public string selfLink { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public Author author { get; set; }
        public Replies replies { get; set; }
    }

    public class BloggerPostsResponse
    {
        public string kind { get; set; }
        public string nextPageToken { get; set; }
        public string prevPageToken { get; set; }
        public List<Item> items { get; set; }
    }
}