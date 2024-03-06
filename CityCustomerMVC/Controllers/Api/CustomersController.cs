using AutoMapper;
using CityCustomerMVC.Dto;
using CityCustomerMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using HttpDeleteAttribute = System.Web.Http.HttpDeleteAttribute;
using HttpPostAttribute = System.Web.Mvc.HttpPostAttribute;
using HttpPutAttribute = System.Web.Http.HttpPutAttribute;




namespace CityCustomerMVC.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController() 
        {
          _context = new ApplicationDbContext();
        }

        public IEnumerable <Customer> GetCustomers() 
        {
             return _context.customers.ToList();
        }

        public Customer GetCustomer(int id) 
        {
           var cus = _context.customers.SingleOrDefault(x => x.Id == id);

          if(cus == null) 
            {
              throw new  HttpResponseException(HttpStatusCode.NotFound);
            }

          return cus;
        }

        [HttpPost]
        public Customer CreateCustomer(Customer c1)
        {
            if(!ModelState.IsValid) 
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            _context.customers.Add(c1);
            _context.SaveChanges();

            return c1;           
        }


        [HttpPut]
        public void UpdateCustomer(int id, Customer c2)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var ExistingCusomer= _context.customers.SingleOrDefault(c => c.Id == id);

            if(ExistingCusomer == null) 
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            ExistingCusomer.Name = c2.Name;
            ExistingCusomer.city.Id = c2.city.Id;
            ExistingCusomer.city.Name = c2.city.Name;

            _context.SaveChanges();
        }

        
        //[HttpDelete]
        //[System.Web.Http.Route("api/Customers/{id}")]
        //public void DeleteCustomer(int id) 
        //{
        //    var cus = _context.customers.SingleOrDefault(x => x.Id == id);

        //    if (cus == null)
        //    {
        //        throw new HttpResponseException(HttpStatusCode.NotFound);

        //    }

        //    _context.customers.Remove(cus);
        //    _context.SaveChanges();

             
        //}


        [HttpDelete]
        public HttpResponseMessage DeleteUser(int id)
        {

          
            
                Customer user = _context.customers.Find(id);
                if (user != null)
                {
                    _context.customers.Remove(user);
                    _context.SaveChanges();
                    HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
                    return response;
                }
                else
                {
                    HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NotFound);
                    return response;
                }
            
        }
                //-----------------------USING AUTOMAPPER--------------------------//


                // public IEnumerable<CustomerDto> GetCustomers1()
                //{
                //    return _context.customers.ToList().Select(Mapper.Map<Customer, CustomerDto>);
                //}


                //public CustomerDto GetCustomer1(int id)
                //{
                //    var cus = _context.customers.SingleOrDefault(x => x.Id == id);

                //    if (cus == null)
                //    {
                //        throw new HttpResponseException(HttpStatusCode.NotFound);
                //    }

                //    return Mapper.Map<Customer,CustomerDto>(cus) ;
                //}




            }
}
