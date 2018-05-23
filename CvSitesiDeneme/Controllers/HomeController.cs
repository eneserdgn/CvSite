using CvSitesiDeneme.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace CvSitesiDeneme.Controllers
{
    public class HomeController : Controller
    {
        CvContext context = new CvContext();


        AllOf all = new AllOf();
        

        // GET: Home
        public ActionResult Index()
        {
            all.Aboutme = context.AboutMes.ToList();
            all.Certificated = context.Certificateds.ToList();
            all.Contact = context.Contacts.ToList();
            all.Education = context.Educations.ToList();
            all.Experiance = context.Experiances.ToList();
            all.Entery = context.Enteries.ToList();
            all.Skills = context.Skills.ToList();

            return View(all);
        }
        [HttpPost]
        public ActionResult Index(Contact model)
        {
            all.Aboutme = context.AboutMes.ToList();
            all.Certificated = context.Certificateds.ToList();
            all.Contact = context.Contacts.ToList();
            all.Education = context.Educations.ToList();
            all.Experiance = context.Experiances.ToList();
            all.Entery = context.Enteries.ToList();
            all.Skills = context.Skills.ToList();
            string server = ConfigurationManager.AppSettings["server"];
            int port = int.Parse(ConfigurationManager.AppSettings["port"]);
            bool ssl = ConfigurationManager.AppSettings["ssl"].ToString() == "1" ? true : false;

            string from = ConfigurationManager.AppSettings["from"];
            string password = ConfigurationManager.AppSettings["password"];
            string fromname = ConfigurationManager.AppSettings["fromname"];
            string to = ConfigurationManager.AppSettings["to"];

            var client = new SmtpClient();
            client.Host = server;
            client.Port = port;
            client.EnableSsl = ssl;
            client.UseDefaultCredentials = true;
            client.Credentials = new System.Net.NetworkCredential(from, password);

            var email = new MailMessage();
            email.From = new MailAddress(from, fromname);
            email.To.Add(to);

            email.Subject = model.Subject;
            email.IsBodyHtml = true;
            email.Body = $"ad soyad : {model.Name} \n konu : {model.Subject} \n mesaj : {model.Message} \n eposta : {model.Email}";
            try
            {
                client.Send(email);
                ViewData["result"] = true;
            }
            catch
            {
                ViewData["result"] = false;
            }
            return View(all);
        }
        public ActionResult AboutMe()
        {         
            return View();
        }

        public ActionResult Entery()
        {
            return View();
        }

        public ActionResult Certificated()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
     

        public ActionResult Education()
        {
            return View();
        }

        public ActionResult Experiance()
        {
            return View();
        }

        public ActionResult Skill()
        {
            return View();
        }


    }
}