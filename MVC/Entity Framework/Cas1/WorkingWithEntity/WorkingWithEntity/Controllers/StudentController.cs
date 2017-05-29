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
    public class StudentController : Controller
    {
        private SchoolContext db = new SchoolContext();
        // GET: Student
        public ActionResult Index()
        {
            List<Student> modelStudents = db.Students.ToList();
            return View(modelStudents);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(StudentViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                Student student = new Student();
                student.FirstName = model.FirstName;
                student.LastName = model.LastName;
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            Student student = db.Students.Where(x => x.Id == id).FirstOrDefault();
            StudentViewModel model = new StudentViewModel();
            model.Id = student.Id;
            model.FirstName = student.FirstName;
            model.LastName = student.LastName;
            return View(model);
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(StudentViewModel model)
        {
            try
            {
                // TODO: Add update logic here
                Student student = db.Students.Where(x => x.Id == model.Id).FirstOrDefault();
                student.FirstName = model.FirstName;
                student.LastName = model.LastName;
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            Student student = db.Students.Where(x => x.Id == id).FirstOrDefault();
            StudentViewModel model = new StudentViewModel();
            model.Id = student.Id;
            model.FirstName = student.FirstName;
            model.LastName = student.LastName;
            return View(model);
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(StudentViewModel model)
        {
            try
            {
                // TODO: Add delete logic here
                Student student = db.Students.Where(x => x.Id == model.Id).FirstOrDefault();
                db.Students.Remove(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
