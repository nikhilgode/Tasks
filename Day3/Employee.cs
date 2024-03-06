using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Employee
    {
        public int id;
        public String name;

        //public Employee()
        //{
        //    this.id = id;   
        //    this.name = name;
        //}
    }

    class FrontendDevloper:Employee
    {
        public int sallary;
    }

    class BackEndDevloper:Employee
    { 
        public int sallary;
    }
}
