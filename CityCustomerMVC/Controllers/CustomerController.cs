using CityCustomerMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using CityCustomerMVC.ViewModels;
using System.Data.Entity.Migrations;

namespace CityCustomerMVC.Controllers
{
    public class CustomerController : Controller
    {

        public ActionResult Index()
        {

            var context = new ApplicationDbContext();
            var allcust = context.customers.Include(c => c.city).ToList();
            return View(allcust);
        }


        public ActionResult NewCustomerForm()
        {
            var context = new ApplicationDbContext();
            var cities1 = context.cities.ToList();
            var viemodel = new CustomerCity()
            {
                cities = cities1,
            };

            return View(viemodel);
        }


        [HttpPost]
        public ActionResult Create(CustomerCity c1)
        {
            var context = new ApplicationDbContext();
            //context.customers.Add(c1.customer);


            //try
            //{
            //    context.SaveChanges();
            //}
            //catch (Exception ex) {
            //    Console.WriteLine(ex);
            //}

            //return RedirectToAction("Index","Customer");

            //----------------------------------------------------------------------//

            // Fetch the selected city based on the provided Id



           //if (!ModelState.IsValid)
           //{


           //return View("NewCustomerForm");
           //}

            try
            {
                var selectedCity = context.cities.FirstOrDefault(c => c.Id == c1.customer.city.Id);

                // Assign the selected city to the customer's city property
                c1.customer.city = selectedCity;

                context.customers.Add(c1.customer);


                context.SaveChanges();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            return RedirectToAction("Index", "Customer");
        }


        public ActionResult EditCustomer(int id,int id2) 
        {

            var context = new ApplicationDbContext();
            var customer2 = context.customers.Include(d=>d.city).SingleOrDefault(c => c.Id == id );
           
            
            var city= context.cities.SingleOrDefaultAsync(c => c.Id == id2);

             

            var city3 = context.cities.ToList();
            
            


              var cus2 = new CustomerCity();
               cus2.customer = customer2;
               cus2.cities = city3;
              
              


            return View(cus2);
            
            
        }

        

        public ActionResult SaveEditedCustomer(int id, int id2, String name)
        {

            var context = new ApplicationDbContext();
            //var selectedCity = context.cities.FirstOrDefault(c => c.Id == c1.customer.city.Id);
            //var selectedcustomer = context.customers.SingleOrDefault(c => c.Id == c1.customer.Id);
            //c1.customer.city = selectedCity;


            var toupdate = context.customers.FirstOrDefault(c => c.Id == id);


            //   toupdate.Name = name;
            //   toupdate.city.Id = id2;


            foreach (var cus in context.customers)
            {
                if (cus.Id == id)
                {
                    context.customers.AddOrUpdate(c=>c.Name);
                    // context.customers.AddOrUpdate(c => c.Id == c1.customer.Id);
                    context.customers.AddOrUpdate(c => c.city.Id);

                }

            }


                context.customers.AddOrUpdate(toupdate);


                context.SaveChanges();

                return RedirectToAction("Index", "Customer");
            }
        }
    
}