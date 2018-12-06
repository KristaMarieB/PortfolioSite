using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PortfolioSite.Models
{
    public class Blog
    {
        [Key]
        public int PostID { get; set; }

        public string Title { get; set; }

        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        public string Author { get; set; }

        //public string Description { get; set; }

        public string URL { get; set; }

    }
}