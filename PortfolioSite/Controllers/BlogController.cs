using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PortfolioSite.Controllers
{
    public class BlogController : Controller
    {
        static HttpClient Client = new HttpClient();

        // GET: Blog
        public ActionResult BlogIndex()
        {
            // create httpclient
            // intitalize properties for client
            // using GET methods, blogger has addresses would be using
            // make a class based off the json response



            return View();
        }


        public async Task<Uri> GetPostListAsync()
        {
            try
            {
                Client.BaseAddress = new Uri("https://www.googleapis.com/blogger/v3/blogs/6944967079157211687/posts");
                HttpResponseMessage response = Client.G;
                resposne.

            }
        }
    }
}