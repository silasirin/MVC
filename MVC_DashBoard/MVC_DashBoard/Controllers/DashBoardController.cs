using MVC_DashBoard.CustomFilters;
using MVC_DashBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_DashBoard.Controllers
{
    [AuthFilter]
    public class DashBoardController : Controller
    {
        // GET: DashBoard
        public ActionResult Index()
        {
            User user = Session["login"] as User;

            NorthwindEntities db = new NorthwindEntities();

            TempData["urunSayisi"] = db.Products.Count();
            TempData["calisanSayisi"] = db.Employees.Count();
            TempData["siparisSayisi"] = db.Orders.Count();
            TempData["musteriSayisi"] = db.Customers.Count();

            TempData["sonSiparisler"] = db.Orders.OrderByDescending(x => x.OrderID).Take(15).ToList();
            TempData["musteriler"] = db.Customers.ToList();

            return View(user);
            
        }
    }
}