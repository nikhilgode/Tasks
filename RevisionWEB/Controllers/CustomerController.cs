using Microsoft.Ajax.Utilities;
using Microsoft.AspNetCore.Mvc;
using RevisionWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using HttpDeleteAttribute = System.Web.Http.HttpDeleteAttribute;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using HttpPutAttribute = System.Web.Http.HttpPutAttribute;

namespace RevisionWEB.Controllers
{
    public class CustomerController : ApiController
    {


        [System.Web.Http.Authorize]
        [System.Web.Http.HttpGet]
        public IEnumerable<Customer> GetCustomers()
        {

            using (var _context = new RevisionWEBContext())
            {
                var c = _context.customers.ToList();

                return c;
            }
        }


        [HttpGet]
        public Customer GetCustomer(int id)
        {
            using (var _context = new RevisionWEBContext())
            {
                var c1 = _context.customers.SingleOrDefault(c => c.customer_id == id);

                if (c1 == null)
                {
                    throw new HttpResponseException(HttpStatusCode.NotFound);
                }

                return c1;
            }


        }


        [HttpPost]
        public Customer PostCustomer(Customer c1)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            using (var _context = new RevisionWEBContext())
            {

                _context.customers.Add(c1);
                _context.SaveChanges();
            }

            return c1;

        }

        [HttpPut]
        public Customer PutCustomer(string fn ,string ln , int id)
        {

            string s1 = fn;
            string s2 = ln;
            

            using(var _context = new RevisionWEBContext())
            {
                var c1 = _context.customers.SingleOrDefault(x => x.customer_id == id);
                c1.first_name = s1;
                c1.last_name = s2;

                _context.SaveChanges();

                return c1;
            }

            
        }

        [HttpDelete]
        public Customer Deletecustomer(int id)
        {
            using(var _context = new RevisionWEBContext())
            {

                var c1 =  _context.customers.SingleOrDefault(x => x.customer_id==id);
                _context.customers.Remove(c1);
                return c1;

            }
        }


    }   
    
}
