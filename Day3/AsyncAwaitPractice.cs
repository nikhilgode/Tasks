using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class AsyncAwaitPractice
    {
        public async void  method()
        {
            await Task.Run(new Action(method2));
            Console.WriteLine("In method 1");
        }

        public void method2() 
        {
            Thread.Sleep(20000);
            Console.WriteLine("In method 2");
        }
    }
}
