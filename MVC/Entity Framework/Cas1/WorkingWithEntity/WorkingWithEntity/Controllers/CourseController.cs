using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkingWithEntity.DAL;
using WorkingWithEntity.Domain;
using WorkingWithEntity.Models;

namespace WorkingWithEntity.Controllers
{
    public class CourseController : Controller
    {
        private SchoolContext db = new SchoolContext(); //instanca do baza
        // GET: Course
        public ActionResult Index()
        {
            List<Course> courses = db.Courses.ToList();
            List < CourseViewModel > model = new List<CourseViewModel>(); //za prefrlanje na lista od baza vo temp lista
            foreach (var course in courses)
            {
                model.Add(new CourseViewModel()
                {
                    Id = course.Id,
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
            Course entity = new Course();
            entity.Title = model.Title;
            entity.Credits = model.Credits;
            db.Courses.Add(entity);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Course course = db.Courses.Where(x => x.Id == id).FirstOrDefault();
            CourseViewModel model = new CourseViewModel();
            model.Id = course.Id;
            model.Title = course.Title;
            model.Credits = course.Credits;
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(CourseViewModel model)
        {
            Course course = db.Courses.Where(x => x.Id == model.Id).FirstOrDefault();
           
            course.Title = model.Title;
            course.Credits = model.Credits;
            db.Entry(course).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            Course course = db.Courses.Where(x => x.Id == id).FirstOrDefault();
            CourseViewModel model = new CourseViewModel();
            model.Id = course.Id;
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(CourseViewModel model)
        {
            Course course = db.Courses.Where(x => x.Id == model.Id).FirstOrDefault();
            db.Entry(course).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}