using MVC_MailSenderExample.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_MailSenderExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Email()
        {
            MailSender.SendEMail("furkansemihgunes@gmail.com", "Test email", "En ere wyzeul egembelu en thekunched fyom ere viragnac de");

            return View();
        }
    }
}