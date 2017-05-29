using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkingWithEntity.DAL;

namespace WorkingWithEntity.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //SchoolContext context = new SchoolContext();
            //context.Students.Add(new Domain.Student("Filip", "Selvievski"));
            //context.SaveChanges();
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