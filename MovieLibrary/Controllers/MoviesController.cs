using MovieLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieLibrary.ViewModels;

namespace MovieLibrary.Controllers
{
    public class MoviesController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
        
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Id = 1, Name = "John Wick"};
            var customers = new List<Customer>()
            {
                new Customer() {Id = 1, Name = "Emir"},
                new Customer() {Id = 2, Name = "Enes"}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Customers = customers,
                Movie = movie
            };
            
            return View(viewModel);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}