using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library___Manager
{
    public class MovieManager
    {
        List<Movie> movieList = new List<Movie>();

        public void AddMovie(Movie movie)
        {
            movieList.Add(movie);
        }
        public void RemoveMovie(Movie movieToDelete)
        {
            foreach (var movie in movieList)
            {
                if (movieToDelete.Id == movie.Id)
                {
                    movieList.Remove(movie);
                }
            }
        }
        public List<Movie> GetAllMovies()
        {
            return movieList;
        }
    }
}
