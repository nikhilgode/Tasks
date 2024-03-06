using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    public class MethodOverriding
    {
         public virtual void methodovrid()
        {
            Console.WriteLine("In base class");
        }

    }


    public class Overidingclass:MethodOverriding 
    {
         public override void methodovrid() 
        {
            Console.WriteLine("Hello from inherited class");
        }
    }
}
