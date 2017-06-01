using NewMVCProject.DAL;
using NewMVCProject.Domain;
using NewMVCProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewMVCProject.Controllers
{
    public class CoursesController : Controller
    {
        DatabaseContext db = new DatabaseContext();
        // GET: Courses
        public ActionResult Index()
        {
            List<Course> courses = db.Courses.ToList();
            List<CourseViewModel> model = new List<CourseViewModel>();
            foreach (var course in courses)
            {
                model.Add(new CourseViewModel()
                {
                    ID = course.ID,
                    Title = course.Title,
                    Credits = course.Credits
                });
            }
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(CourseViewModel model)
        {
            Course course = new Course();
            course.Title = model.Title;
            course.Credits = model.Credits;
            db.Courses.Add(course);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            Course course = db.Courses.Where(x => x.ID == id).FirstOrDefault();
            CourseViewModel model = new CourseViewModel();
            model.ID = course.ID;
            model.Title = course.Title;
            model.Credits = course.Credits;
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(CourseViewModel model)
        {
            Course course = db.Courses.Where(x => x.ID == model.ID).FirstOrDefault();
            course.Title = model.Title;
            course.Credits = model.Credits;
            db.Entry(course).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            Course course = db.Courses.Where(x => x.ID == id).FirstOrDefault();
            CourseViewModel model = new CourseViewModel();
            model.ID = course.ID;
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(CourseViewModel model)
        {
            Course course = db.Courses.Where(x => x.ID == model.ID).FirstOrDefault();
            db.Entry(course).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}