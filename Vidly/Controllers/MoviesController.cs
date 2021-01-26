using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movie = new Movie { id = 1, Name = "Shrek" };
            var movie2 = new Movie { id = 2, Name = "Titnaic" };
            var movie3 = new Movie { id = 3, Name = "8 mile" };
             var movie4 = new Movie { id = 1, Name = "Shrek" };
            var movie5 = new Movie { id = 2, Name = "Titnaic" };
            var movie7 = new Movie { id = 3, Name = "8 mile" };

            var movie4 = new Movie { id = 1, Name = "Shrek" };
            var movie5 = new Movie { id = 2, Name = "Titnaic" };
            var movie6 = new Movie { id = 3, Name = "8 mile" };

            /////TEST TEST TEST TEST 
            ///  /////TEST TEST TEST TEST 
            /////TEST TEST TEST TEST 
            /////TEST TEST TEST TEST 
            /////TEST TEST TEST TEST 
            /////TEST TEST TEST TEST 



            //List<Movie> movies = new List<Movie> { movie, movie2, movie3, movie4 };

            //ViewBag.Movies = movies;
            var movies = new List<Movie> { movie, movie2, movie3};

            var ListMovies = new MoviesViewModel { MoviesList = movies };

            return View(ListMovies);
        }


        public ActionResult Random()
        {
            return View();
        }
    }
}
