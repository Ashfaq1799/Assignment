using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using pubsProject.Models;

namespace pubsProject.Controllers
{
    [HandleError]
    public class LoginController : Controller
    {
        pubsEntities entities = new pubsEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            employee employee = new employee();
            return View(employee);
        }
        [HttpPost]
        public ActionResult Login(employee employee)
        {
           int count = entities.employees.Where(e => e.emp_id == employee.emp_id && e.fname == employee.fname).Count();
            if (count==1)
            {
                FormsAuthentication.SetAuthCookie(employee.emp_id, false);
                TempData["employee"] = employee.emp_id;
                return RedirectToAction("Home","Home");
            }
            else
            {
                TempData["employee"] = "";
                ViewBag.error = "Invalid username or password";
            }
            return View();
        }
    }
}