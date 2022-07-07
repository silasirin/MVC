using MVC_DashBoard.Models;
using MVC_DashBoard.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_DashBoard.Controllers
{
    public class HomeController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult _OrderDetails(int id)
        {
            var order = db.Orders.Find(id);
            return PartialView(order);
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AppUser appUser)
        {
            if (ModelState.IsValid) //Required alanlar dolu ve uygun bir sekilde geliyorsa User'i database'e ekle.
            {
                try
                {
                    if (db.Users.Any(x => x.UserName == appUser.UserName && x.Password == appUser.Password))
                    {
                        //TempData["success"] = "Giris basarili.";
                        User user = db.Users.Where(x => x.UserName == appUser.UserName && x.Password == appUser.Password).FirstOrDefault();

                        Session["login"] = user;
                        return RedirectToAction("Index", "DashBoard");
                    }
                    else
                    {
                        TempData["userError"] = "Kullanici adi ve sifre hatali!";
                        return View(appUser);//userValidation kontrolu icin tekrar userLogin'e gonderilir.
                    }
                }
                catch
                {
                    return View();
                }
            }
            else //uygun degilse basa don.
            {
                return View(appUser);
            }
        }
    }
}