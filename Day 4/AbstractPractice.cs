using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
     public abstract class AbstractPractice
    {

        public abstract void implementabstract();

        public void print() { Console.WriteLine("Hello+++===>>>>!"); }
    }

    public class AbstracExtendedd:AbstractPractice
    {
        public override void implementabstract()
        {
            Console.WriteLine("THis is hii from abstraced method");
        }
    }
}
