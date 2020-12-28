using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AuthenticationDemoProject.Models;
using System.Web.Security;

namespace AuthenticationDemoProject.Controllers
{
    public class LoginController : Controller
    {
        List<User> Users = new List<User>()
        {
            new User("Ashfaq","1234"),
            new User("Ahmed","3256")
        };
        public ActionResult UserDetails()
        {
            return View(Users);
        }
        // GET: Login
        public ActionResult UserLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserLogin(User user)
        {
            User Logedin = Users.Find(u => user.Username == u.Username && user.Password == u.Password);
            if (Logedin != null)
            {
                FormsAuthentication.SetAuthCookie(user.Username, false);
                TempData["user"] = user.Username;
                /*here we have set the persistentCookie to false even then the cookie is stored in the browser cause browser 
                overwrites our code*/
                return RedirectToAction("About", "Home");
            }
            return View();
        }
        [ChildActionOnly]
        //it denotes that it can be only used as a child partial view 
        //also this partial view can be used within the same controller as it is not in shared folder
        public ActionResult SamplePartial()
        {
            return View();
        }
    }
}