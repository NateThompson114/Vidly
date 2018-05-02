﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly2.Models;

namespace Vidly2.Dtos
{
    public class NewRentalDto
    {
        public int CustomerId { get; set; }

        public IEnumerable<int> MovieIds { get; set; }
    }
}