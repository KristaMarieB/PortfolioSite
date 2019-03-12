using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolioSite.Models;
using System.Security.Cryptography.X509Certificates;
using Google.Apis.Auth.OAuth2;
using MimeKit;
using MailKit.Net.Smtp;
using System.Configuration;

namespace PortfolioSite.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
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
    }
}