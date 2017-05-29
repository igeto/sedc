using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoStore.Models;

namespace VideoStore.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            var getMovies = GetMovies();
            return View(getMovies);
        }
        public IEnumerable<Movie> GetMovies()
        {
                        return new List<Movie>
            {
                new Models.Movie { Id = 1, Name = "Shreck" },
                new Movie { Id = 2, Name = "Wall-E" }
            };
        }
        public ActionResult Random()
        {
            Random random = new System.Random();
            int randomNumber = random.Next(0, 3);
            var getMovie = GetMovies().Where(x => x.Id == randomNumber).First();
            return View(getMovie);
        }
        //public Movie GetMovie()
        //{
        //    Random random = new System.Random();
        //    int randomNumber = random.Next(0, 2);
        //    var movies = new List<Movie>
        //    {
        //        new Models.Movie { Id = 1, Name = "Shreck" },
        //        new Movie { Id = 2, Name = "Wall-E" }
        //    };
        //    return movies[randomNumber];
        //}
        public ActionResult Select(int id /*,string orderBy*/)
        {
            var getMovie = GetMovies().Where(x => x.Id == id).First();
            return View(getMovie);
        }
    }
}