using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class AuthorController : Controller
    {
        static List<Author> Authors = new List<Author>();
        // GET: Author
        public ActionResult Index()
        {
            return View();
        }

        // GET: Author/Details/5
        public ActionResult Details(int id)
        {
            Author model = Authors.Where(x => x.Id == id).FirstOrDefault();
            return View(model);
        }

        // GET: Author/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Author/Create
        [HttpPost]
        public ActionResult Create(Author model)
        {
            try
            {

                // TODO: Add insert logic here
                Authors.Add(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Author/Edit/5
        public ActionResult Edit(int id)
        {
            Author model = Authors.Where(x => x.Id == id).FirstOrDefault();
            return View(model);
        }

        // POST: Author/Edit/5
        [HttpPost]
        public ActionResult Edit(Author model)
        {
            try
            {
                // TODO: Add update logic here
                foreach (var author in Authors)
                {
                    if (author.Id == model.Id)
                    {
                        author.FirstName = model.FirstName;
                        author.LastName = model.LastName;
                        author.Age = model.Age;
                        author.NumberOfBooks = model.NumberOfBooks;
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Author/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Author/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
