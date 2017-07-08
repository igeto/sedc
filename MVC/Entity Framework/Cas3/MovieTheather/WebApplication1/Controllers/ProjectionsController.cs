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

namespace WebApplication1.Controllers
{
    public class ProjectionsController : Controller
    {
        private TheaterContext db = new TheaterContext();

        // GET: Projections
        public ActionResult Index()
        {
            return View();
        }

        // GET: Projections/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Projection projection = db.Projections.Find(id);
            if (projection == null)
            {
                return HttpNotFound();
            }
            return View(projection);
        }

        // GET: Projections/Create
        public ActionResult Create()
        {
            ViewBag.HallID = new SelectList(db.Halls, "Id", "Name");
            ViewBag.MovieID = new SelectList(db.Movies, "Id", "Name");
            return View();
        }

        // POST: Projections/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Date,MovieID,HallID")] Projection projection)
        {
            if (ModelState.IsValid)
            {
                db.Projections.Add(projection);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.HallID = new SelectList(db.Halls, "Id", "Name", projection.HallID);
            ViewBag.MovieID = new SelectList(db.Movies, "Id", "Name", projection.MovieID);
            return View(projection);
        }

        // GET: Projections/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Projection projection = db.Projections.Find(id);
            if (projection == null)
            {
                return HttpNotFound();
            }
            ViewBag.HallID = new SelectList(db.Halls, "Id", "Name", projection.HallID);
            ViewBag.MovieID = new SelectList(db.Movies, "Id", "Name", projection.MovieID);
            return View(projection);
        }

        // POST: Projections/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Date,MovieID,HallID")] Projection projection)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projection).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.HallID = new SelectList(db.Halls, "Id", "Name", projection.HallID);
            ViewBag.MovieID = new SelectList(db.Movies, "Id", "Name", projection.MovieID);
            return View(projection);
        }

        // GET: Projections/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Projection projection = db.Projections.Find(id);
            if (projection == null)
            {
                return HttpNotFound();
            }
            return View(projection);
        }

        // POST: Projections/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Projection projection = db.Projections.Find(id);
            db.Projections.Remove(projection);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
