using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangingDataDemo_Day10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var context=new ChangingDataDemo();



            //-----------------------------------1ST WAY-----------------------------------------------//


            //var cities = context.cities.ToList();

            //var city1 = context.cities.Single(a => a.city_id == 0);

            //var customer = new customer
            //{
            //    customer_name = "Jeet Keni",
            //   city=city1
            //};

            //context.customers.Add(customer);

            //context.SaveChanges();

            //-------------------------------------2ND WAY---------------------------------------------//


            //var customer2 = new customer
            //{
            //    customer_name = "ABC ABS",
            //    city_id = 5
            //};

            //context.customers.Add(customer2);

            //context.SaveChanges();


            //-------------------------------------UPDATING OBJECTS-----------------------------------//


            //var cust = context.customers.Find(102);
            //cust.customer_name = "aaa bbb";
            //cust.city_id = 0;

            //context.SaveChanges();


            //-------------------REMOVING CITY AND ALL CUSTOMERS IN THAT CITY-----------------------//


            var cityTodelete= context.cities.Single(a => a.city_id == 0);
            var customTodelete= context.customers.Where( b => b.city_id == 0);
            context.customers.RemoveRange(customTodelete);
            context.cities.Remove(cityTodelete);
            context.SaveChanges();

        }
    }
}
