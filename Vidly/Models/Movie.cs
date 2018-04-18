using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required, StringLength(255)]
        public string Name { get; set; }

        [Required, Display(Name = "Release Date")]
        public DateTime DateReleased { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required, Display(Name = "Number in Stock"), Range(0,100)]
        public int Quantity { get; set; }

        public Genre Genre { get; set; }

        [Required, Display(Name = "Genre")]
        public int GenreId { get; set; }
    }
}