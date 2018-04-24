﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Vidly2.Models;

namespace Vidly2.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateReleased { get; set; }

        public DateTime DateAdded { get; set; }

        public int Quantity { get; set; }
        
        [IgnoreDataMember]
        public int GenreId { get; set; }

        public GenreDto Genre { get; set; }
    }
}