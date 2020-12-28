using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AuthenticationDemoProject.Models;

namespace AuthenticationDemoProject.Controllers
{
    //if we provide this ActionFilter then the user is permitted to visit any of the methods only if the user gets authorized
    //set Authorization mode as Forms and set the Forms LoginUrl to the login page to authenticate the user
    [Authorize]
    public class HomeController : Controller
    {
        List<User> Users = new List<User>()
        {
            new User("Ashfaq","1234"),
            new User("Ahmed","3256")
        };
        [AllowAnonymous]
        // GET: Home
        //it denotes that without logging in we can access this method alone 
        public ActionResult Index()
        {
            string un = TempData.Peek("user").ToString();
            User user = Users.Find(u => u.Username == un);
            return View(user);
        }
        [ActionName("About")]
        public ActionResult AboutUs()
        {
            return View();
        }
        [HttpPost]
        public ActionResult About(FormCollection fc)
        {
            FormsAuthentication.SignOut();
            return View();
        }
    }
}