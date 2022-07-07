using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_NorthwindAreas.Areas.Staff.Controllers
{
    public class OrderController : Controller
    {
        // GET: Staff/Order
        public ActionResult Index()
        {
            return View();
        }
    }
}