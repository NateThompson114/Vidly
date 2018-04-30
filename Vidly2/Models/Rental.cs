using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly2.Models
{
    public class Rental
    {
        public int Id { get; set; }

        //public int CustomerId { get; set; }

        //public int MovieId { get; set; }

        public DateTime DateRented { get; set; }

        public DateTime DateReturned { get; set; }
    }
}