using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1._0
{
    public  class ConstructorDemo
    {

        public int a;
        public int b;
        public string c;


        public ConstructorDemo() { }
        public ConstructorDemo(int a) { this.a = a; }

        public ConstructorDemo(int a, int b)
        {
            this.a = a;
            this.b = b;
        }


      public ConstructorDemo(int a, string c):this(a)
        { this.c = c; }

      public void printvalues(int a,int b)
        {
            Console.WriteLine(a + b);
        }

        public void printvalues(int a, int b,String c)
        {
            Console.WriteLine(a + b+ c);
        }

    }
}
