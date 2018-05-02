using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly2.Dtos;
using Vidly2.Models;
using AutoMapper;

namespace Vidly2.Controllers.API
{
    [AllowAnonymous]
    public class RentalsController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult RentlMovies(NewRentalDto rentalDto)
        {
            var movies = _context.Movies.Where(
                m => rentalDto.MovieIds.Contains(m.Id)).ToList();
            

            var customer = _context.Customers.SingleOrDefault(
                c => c.Id == rentalDto.CustomerId);

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available");

                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();
            
            return Ok();
        }
    }
}
