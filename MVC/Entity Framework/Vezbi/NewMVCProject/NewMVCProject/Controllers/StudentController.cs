using NewMVCProject.DAL;
using NewMVCProject.Domain;
using NewMVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewMVCProject.Controllers
{
    public class StudentController : Controller
    {
        private DatabaseContext db = new DatabaseContext();
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            var model = db.Students.Include("Enrollment").ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Create(StudentViewModel model)
        {
            return View();
        }
    }
}