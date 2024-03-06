using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    public class Person
    {
        
        public string Name {  get; set; }

        public Person() { }

        public Person(String name) 
        {
           this.Name = name;
        }

        public void printname()
        {
          
            Console.WriteLine($"Hiii i am {this.Name}");
        }


        
    }


       public class Adress:Person
    {

        public string City;

        public Adress() { }

        public Adress(String name,String city) :base(name) 
        {
           this.City = city;
        }

        public void Printaddress()
        {
            Console.WriteLine($"My nam is {this.Name} im from {this.City}");
        }


       
    }
}
