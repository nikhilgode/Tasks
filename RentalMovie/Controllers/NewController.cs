using RentalMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentalMovie.Controllers
{
    public class NewController : Controller
    {
        ApplicationDbContext _context;

        public NewController()
        {
            _context = new ApplicationDbContext();
        }
        public IEnumerable<Customer> GetCustomer()
        {
            var v1 = _context.Customers.ToList();
            return v1;
        }
    }
}