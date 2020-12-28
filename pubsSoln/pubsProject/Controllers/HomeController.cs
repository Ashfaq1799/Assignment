using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pubsProject.Models;

namespace pubsProject.Controllers
{
    [HandleError]
    [Authorize]
    public class HomeController : Controller
    {
        pubsEntities entities = new pubsEntities();
        // GET: Home
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult ShowTitles()
        { 
            return View(entities.titles);
        }
        public ActionResult ShowAuthor()
        {
            return View(entities.authors);
        }
        public ActionResult ShowBooks(author author)
        {
            title ta = new title();
            var books = entities.sp_display().Where(t=>t.title_id==ta.title_id).ToList().FirstOrDefault();
            object obj = books.title;
            return View(obj);
        }
        public ActionResult Checkout()
        {
            Card card = new Card();
            return View();
        }
        [HttpPost]
        public ActionResult CheckOut(Card card)
        {
            return RedirectToAction("Success");
        }
        public ActionResult Success()
        {
            return View();
        }
    }
}