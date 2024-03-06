using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRental.Models
{
    public class Rental
    {
        public int Id { get; set; }

        public DateTime DateRented { get; set; }

        public DateTime DateReturned { get; set; }

        [Required]
        public Customer1 Customer { get; set; }

        [Required]
        public Movie1 Movie { get; set; }



    }
}