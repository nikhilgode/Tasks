using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWithExstingDB_Day8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var context = new CodefirstwithEstingDB_Day8();

            //-------------------------LINQ SYNTAX----------------------------//
            var query1 = from c in context.customers
                         where c.customer_name.StartsWith("J")
                         orderby c.customer_id
                         select c;

            foreach (var item in query1)
            {
                Console.WriteLine(item.customer_id + "     " + item.customer_name + "      " + item.city_id);
                //  Console.WriteLine(item.customer_name);
                //  Console.WriteLine(item.city_id);
            }

            //-------------------------EXTENSION SYNTAX-------------------------//
            Console.WriteLine("//-------------------------EXTENSION SYNTAX-------------------------//");

            var query2 = context.customers.Where(c => c.customer_name.StartsWith("j")).OrderBy(c => c.customer_id);

            foreach (var item in query2)
            {
                Console.WriteLine(item.customer_id + "     " + item.customer_name + "      " + item.city_id);

            }


            //------------------------GROUP BY USING LINQ SYNTAX----------------------------//

            var query3 = from c1 in context.customers
                         join c2 in context.cities on c1.city_id equals c2.city_id
                         select new { CustomerName = c1.customer_name, CityName = c2.city_name };

            foreach (var x in query3)
            {
                Console.WriteLine(x.CustomerName + "       " + x.CityName);
            }


            //------------------------GROUP BY USING EXTENSION METHOD----------------------------//


            Console.WriteLine("By Etension method");


            //var xx=    context.customers.Join(context.cities,
            //          c1 => c1.customer_id,
            //          c2 => c2.city_id, (customer, city) => new
            //          {
            //              CustomerName = customer.customer_name,
            //              CityName = city.city_name
            //          });


            var result = context.customers.Join(
                          context.cities,
                           customer => customer.city_id,
                            city => city.city_id,
                              (customer, city) => new
                              {
                                  CustomerName = customer.customer_name,
                                  CityName = city.city_name
                              }).ToList(); 


            foreach (var x in result)
                Console.WriteLine(x.CityName + "    " + x.CustomerName);



            //-------------------------------N+1---------------------------------------//

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var cus1= context.customers.ToList();

            foreach (var customer in cus1)
            {
                Console.WriteLine(customer.customer_name+"     "+customer.city.city_name);
            }

            //-------------------------EAGER LOADING-----------------------------//

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var cus2 = context.customers.Include("city").ToList();

            foreach (var customer in cus2)
            {
                Console.WriteLine(customer.customer_name + "     " + customer.city.city_name);
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            var cus3 = context.customers.Include( c=>c.city).ToList();
            foreach (var customer in cus3)
            {
                Console.WriteLine(customer.customer_name + "     " + customer.city.city_name);
            }

        }
    }

    
}
