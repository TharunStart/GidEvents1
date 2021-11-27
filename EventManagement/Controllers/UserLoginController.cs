using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventManagement.Model;

namespace EventManagement.Controllers
{
    public class UserLoginController : Controller
    {
        // GET: UserLogin
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public ActionResult answer(EventManagement.Model.user details)
        { 
            using(eventsEntities1 db = new eventsEntities1())
            {
                var userdetails = db.users.Where(x => x.name == details.name && x.password == details.password).FirstOrDefault();
                if (userdetails == null)
                {
                    details.LoginErrorMessage = "Invalid User";
                    return View("Login", details);
                }
                else
                {
                    return RedirectToAction("Index", "users");
                }
            }
            return View();
        }
    }
}