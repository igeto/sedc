using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkingWIthAjax.Models;

namespace WorkingWIthAjax.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ServerTime()
        {
            return this.Content(DateTime.Now.ToLongTimeString());
        }
        public JsonResult AllBooks()
        {
            var books = new List<Book>();

            books.Add(new Book(1, "Secrets Of The JavaScript Ninja", 314));
            books.Add(new Book(2, "The Clean Code", 422));
            books.Add(new Book(3, "Code - The Hiddent Language of Computers", 415));

            return Json(books, JsonRequestBehavior.AllowGet);
        }
    }
}