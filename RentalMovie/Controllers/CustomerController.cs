using RentalMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace RentalMovie.Controllers
{
    public class CustomerController : Controller
    {
        ApplicationDbContext _context;
        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        //[HttpGet]
        //  [Route("getting")]
        public IEnumerable<Customer> GetCustomer()
        {
            var v1 = _context.Customers.ToList();
            return v1;
        }   
    }
}
