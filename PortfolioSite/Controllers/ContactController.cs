using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolioSite.Models;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using MailKit.Net.Imap;
using System.Security.Cryptography.X509Certificates;
using Google.Apis.Auth.OAuth2;

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
        public async ActionResult Contact(ContactForm vm)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    MimeMessage msg = new MimeMessage();
                    msg.From.Add(new MailboxAddress(vm.Email)); // grabs email from contact form
                    msg.To.Add(new MailboxAddress("dev.kristakat@gmail.com"));
                    msg.Subject = vm.Subject;
                    msg.Body = new TextPart("plain")
                    {
                        Text = vm.Message
                    };

                    using (ImapClient client = new ImapClient())
                    {
                        client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                        client.Connect("smtp.gmail.com", 465, true); // bool refers to using SSL...

                        // do stuff...

                        client.Authenticate("user@gmail.com", );

                        // Code Bones
                        var certificate = new X509Certificate();
                        var credential = new ServiceAccountCredential((){
                            Scopes = new[] { "" },
                            User = "user@gmail.com";
                        }.FromCertificate(certificate));

                    bool result = await credential.RequestAccessTokenAsync(cancel.Token);

                    var oauth2 = new SaslMechanismOAuth2("user@gmail.com", credential.Token.AccessToken);

                    client.Authenticate(oauth2);

                    client.disconnect(true);
                    
                    }
                }
            }
        }
    }
}