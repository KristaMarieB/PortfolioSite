using MailKit.Net.Smtp;
using MimeKit;
using PortfolioSite.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PortfolioSite.Controllers
{
    public class HomeController : Controller
    {
        static HttpClient _Client = new HttpClient();
        static string _key = ConfigurationManager.AppSettings["BloggerAPIKey"];

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Resume()
        {
            return View();
        }

        public ActionResult Portfolio()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactForm vm)
        {
            if (ModelState.IsValid)
            {
                MimeMessage msg = new MimeMessage();
                msg.From.Add(new MailboxAddress(vm.Email)); // grabs email from contact form
                msg.To.Add(new MailboxAddress("dev.kristakat@gmail.com"));
                msg.Subject = vm.Subject;
                msg.Body = new TextPart("plain")
                {
                    Text = vm.Email + vm.Message
                };

                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, false);

                    string email = ConfigurationManager.AppSettings["toEmail"];
                    string pw = ConfigurationManager.AppSettings["toEmailPW"];
                    client.Authenticate(email, pw);

                    client.Send(msg);

                    client.Disconnect(true);
                    ViewBag.Message = "Your email has been sent!";

                    return View(vm);

                }

            }
            else
            {
                return View();
            }
        }
        
        // constructor for creating base address
        static HomeController()
        {
            _Client.BaseAddress = new Uri("https://www.googleapis.com/blogger/v3/");
        }

        // GET: Blog
        public async Task<ActionResult> Blog() // to write async code had to change it to type from ActionResult -> Task<ActionResult>
        {

            BloggerPostsResponse allPosts = await GetAllPostsAsync();

            return View(allPosts);
        }

        public static async Task<BloggerPostsResponse> GetAllPostsAsync()
        {
            // add a try/catch later

            HttpResponseMessage response = await _Client.GetAsync($"blogs/6944967079157211687/posts?key={_key}");
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