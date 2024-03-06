using CityCustomerMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CityCustomerMVC.ViewModels
{
    public class CustomerCity
    {

        public IEnumerable<City> cities { get; set; }

        public Customer customer { get; set; }
    }
}