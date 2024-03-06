﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalMovie.Models
{
    public class NewRental
    {
        public Customer Customer { get; set; }

        public IList<Movie> Movies { get; set; }

    }
}