using RentalMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RentalMovie.Controllers.Api
{

    
    public class CustomerController : ApiController
    {
        ApplicationDbContext _context;



        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }



        [HttpGet]
        public IEnumerable<Customer> GetCustomer()
        {
            var v1 = _context.Customers.ToList();
            return v1;
        }

    }
}
