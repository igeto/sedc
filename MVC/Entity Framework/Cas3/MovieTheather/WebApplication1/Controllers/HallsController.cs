using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Core.Context;
using Core.DAL;
using Core.ORM;

namespace WebApplication1.Controllers
{
    public class HallsController : Controller
    {
        private IRepository<Hall> db = new Repository<Hall>();
        //private TheaterContext db = new TheaterContext();
        // GET: Halls
        public ActionResult Index()
        {
            return View(db.GetAll().ToList());
        }

        // GET: Halls/Details/5
        public ActionResult Details(long id)
        {
            Hall hall = db.GetById(id);
            if (hall == null)
            {
                return HttpNotFound();
            }
            return View(hall);
        }

        // GET: Halls/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Halls/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,NumberOfSeats")] Hall hall)
        {
            if (ModelState.IsValid)
            {
                db.Add(hall);
                return RedirectToAction("Index");
            }

            return View(hall);
        }

        // GET: Halls/Edit/5
        public ActionResult Edit(long id)
        {
            Hall hall = db.GetById(id);
            if (hall == null)
            {
                return HttpNotFound();
            }
            return View(hall);
        }

        // POST: Halls/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,NumberOfSeats")] Hall hall)
        {
            if (ModelState.IsValid)
            {
                db.Update(hall);
                return RedirectToAction("Index");
            }
            return View(hall);
        }

        // GET: Halls/Delete/5
        public ActionResult Delete(long id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hall hall = db.GetById(id);
            if (hall == null)
            {
                return HttpNotFound();
            }
            return View(hall);
        }

        // POST: Halls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Hall hall = db.GetById(id);
            db.Delete(hall);
            return RedirectToAction("Index");
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
