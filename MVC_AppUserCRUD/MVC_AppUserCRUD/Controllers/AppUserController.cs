using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_AppUserCRUD.Models;

namespace MVC_AppUserCRUD.Controllers
{
    
    public class AppUserController : Controller
    {
        public static List<AppUser> userList = new List<AppUser>()
        {
            new AppUser{Id = 1,UserName="silasi", FirstName ="Sila",LastName ="Sirin",Email="silasirin@fdsf.com",Password="1234"}
        };
        // GET: AppUser
        public ActionResult Index()
        {
            return View(userList);
        }

        public ActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddUser(AppUser user)
        {
            user.Id = userList.Count + 1; //ID'leri otomatik olarak birer birer artir.
            userList.Add(user);
            return RedirectToAction("Index");
        }

        //Details
        public ActionResult Details(int id)
        {
            var userDetails = userList.Find(x => x.Id == id);
            return View(userDetails);
        }

        //Update
        public ActionResult Update(int id,string userName, string firstName, string lastName,string email, string password)
        {
            var update = userList.Find(x=>x.Id == id);
            update.Id = id;
            update.UserName = userName;
            update.FirstName= firstName;
            update.LastName= lastName;
            update.Email= email;
            update.Password= password;

            return View(update);
        }

        //Delete
        public ActionResult Delete(int id)
        {
            var delete = userList.Find(x => x.Id == id);
            userList.Remove(delete);
            return RedirectToAction("Index","AppUser");
        }
    }
}