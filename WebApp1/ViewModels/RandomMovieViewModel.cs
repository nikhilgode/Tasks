﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp1.Models;

namespace WebApp1.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }

        public List<Customer> Customer { get; set; }

    }
}