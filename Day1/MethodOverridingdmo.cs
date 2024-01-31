using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1._0
{
    public class MethodOverridingdmo
    {
           int a {  get; set; }
           int b { get; set; }


        public virtual void drawshape()
        {
          
        }

    }

    public class triangl : MethodOverridingdmo
    {

        public override void drawshape()
        {
            Console.WriteLine("This Is Tringle");
        }

    }
    

    public class circle  : MethodOverridingdmo
    {
        public override void drawshape()
        {
            Console.WriteLine("This is circle");
        }
    }
            


}
