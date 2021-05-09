using System.Collections.Generic;
using MovieLibrary.Models;

namespace MovieLibrary.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}