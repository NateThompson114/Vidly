using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly2.Dtos;
using Vidly2.Models;

namespace Vidly2.Controllers.API
{
    public class RentalController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public RentalController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult RentlMovies(RentalDto rental)
        {
            var cust = _context.Customers.SingleOrDefault(m => m.Id == rental.CustomerId);

            if (cust == null)
                return NotFound();

            if (!rental.MovieIds.Any())
                return NotFound();

            return Ok();
        }
    }
}
