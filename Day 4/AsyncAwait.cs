using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    public class AsyncAwait
    {
        public static async void Method()
        {
            await Task.Run(new Action(Longtask));
            Console.WriteLine("new thread...!");
        }

        public static void Longtask()
        { 
               Thread.Sleep(20000);
        }

        
    }
}
