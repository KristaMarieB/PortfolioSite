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
        const string key = "AIzaSyA_ska9fWvLpsowXMqNgLUp6t7xOL0psxY";

        // GET: Blog
        public async Task<ActionResult> Blog() // to write async code had to change it to type from ActionResult -> Task<ActionResult>
        {
            BloggerPostsResponse allPosts = await GetAllPostsAsync();

            return View(allPosts);
        }


        public async Task<BloggerPostsResponse> GetAllPostsAsync()
        {
            // add a try/catch later
            Client.BaseAddress = new Uri("https://www.googleapis.com/blogger/v3/");
            HttpResponseMessage response = await Client.GetAsync($"blogs/6944967079157211687/posts?key={key}");
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