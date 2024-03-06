using RentalMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RentalMovie.Controllers.Api
{
    public class RentalController : ApiController
    {

        ApplicationDbContext _contex;
        public RentalController()
        {
            _contex = new ApplicationDbContext();
        }

        [HttpPost]
        public void PostRental(NewRental n1)
        {
            
            var id= n1.Customer.Id;
            var cus = _contex.Customers.SingleOrDefault(c => c.Id == id);


            foreach(var movie in n1.Movies) 
            {
              Rental r1 = new Rental();

                r1.Customer = cus;
                r1.Movie = movie;
                r1.DateRented = DateTime.Now;
              
            }





        }

    }
}
