﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly2.Models
{
    public class NewRental
    {
        public int CustomerId { get; set; }

        public IEnumerable<Movie> Movies { get; set; }
    }
}