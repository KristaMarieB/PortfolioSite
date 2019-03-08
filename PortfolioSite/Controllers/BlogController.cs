using PortfolioSite.Models;
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
        /*
         Blog ID: 6944967079157211687
        */
        static HttpClient Client = new HttpClient();

        // GET: Blog
        public async Task<ActionResult> BlogIndex() // to write async code had to change it to type from ActionResult -> Task<ActionResult>
        {
            BloggerPostsResponse allPosts = await GetAllPostsAsync();
            if(allPosts == null)
            {
                // TODO: ensure that if the object is null the page somehow says "No posts to display at this time"
                return View();
            }

            return View(allPosts);
        }


        public async Task<BloggerPostsResponse> GetAllPostsAsync()
        {
            // add a try/catch later
            Client.BaseAddress = new Uri("https://www.googleapis.com/blogger/v3/");
            HttpResponseMessage response = await Client.GetAsync("blogs/6944967079157211687/posts?key=myAPIKey");
            if (response.IsSuccessStatusCode)
            {
                BloggerPostsResponse blogPosts = await response.Content.ReadAsAsync<BloggerPostsResponse>();
                return blogPosts;
            }
            else
            {
                return null;
            }
            
        }
    }
}