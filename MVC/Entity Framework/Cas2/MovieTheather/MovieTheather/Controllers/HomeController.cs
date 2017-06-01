using Core.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieTheather.Controllers
{
    public class HomeController : Controller
    {
        private TheaterContext db = new TheaterContext();
        public ActionResult Index()
        {
            db.Users.Add(new Core.DAL.User() { FirstName = "Filip", LastName = "Selvievski", Type = Core.DAL.UserType.Admin });
            db.SaveChanges();
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
    }
}