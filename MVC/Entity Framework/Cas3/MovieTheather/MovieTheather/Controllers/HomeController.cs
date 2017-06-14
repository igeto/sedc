using Core.Context;
using Core.DAL;
using Core.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieTheather.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<User> _users = new Repository<User>();
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
    }
}