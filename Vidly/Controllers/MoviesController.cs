using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;
using System.Linq;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre);

            return View(movies);
        }

        [Route(@"Movies/id/{id}")]
        public ActionResult Movie(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(c => c.Id == id);

            return View(movie);
        }

        public ActionResult New()
        {
            var genres = _context.Genres.ToList();

            var viewModel = new MovieFormViewModel
            {
                Genres = genres
            };

            return View("MovieForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            var addMovie = new Movie
            {
                DateAdded = DateTime.Now,
                DateReleased = movie.DateReleased,
                GenreId = movie.GenreId,
                Name = movie.Name,
                Quantity = movie.Quantity
            };
            _context.Movies.Add(addMovie);
            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }
    }
}