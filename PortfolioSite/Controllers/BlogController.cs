using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioSite.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            // create httpclient
            // intitalize properties for client
            // using GET methods, blogger has addresses would be using
            // make a class based off the json response
            return View();
        }
    }
}