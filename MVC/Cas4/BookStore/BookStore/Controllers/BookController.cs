using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        static List<Book> Books = new List<Book>();
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            Book model = Books.Where(x => x.Id == id).FirstOrDefault();
            return View(model);
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        public ActionResult Create(Book model)
        {
            try
            {
                // TODO: Add insert logic here
                Books.Add(model);
                return RedirectToAction($"Details/{model.Id}");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            Book model = Books.Where(x => x.Id == id).FirstOrDefault();
            return View(model);
        }

        // POST: Book/Edit/5
        [HttpPost]
        public ActionResult Edit(Book model)
        {
            try
            {
                // TODO: Add update logic here
                foreach (var book in Books)
                {
                    if (book.Id == model.Id)
                    {
                        book.Title = model.Title;
                        book.Content = model.Content;
                        book.Sales = model.Sales;
                        book.Taxes = model.Taxes;
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Book/Delete/5
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
