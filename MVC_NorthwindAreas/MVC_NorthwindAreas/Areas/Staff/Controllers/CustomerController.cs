using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_NorthwindAreas.Areas.Staff.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Staff/Customer
        public ActionResult Index()
        {
            return View();
        }
    }
}