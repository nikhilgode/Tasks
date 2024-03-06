using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class MySopwatch
    {
      public void printtime()
        {
            Stopwatch s1 = new Stopwatch();
            Console.WriteLine("Pess Enter to start stopwath");
            Console.ReadLine();
            s1.Start();
            Console.WriteLine("Pess Enter to stop stopwath");
            Console.ReadLine();
            s1.Stop();
            Console.WriteLine($"Elapsed time is {s1.Elapsed}");

            s1.Reset();

            Console.WriteLine("Press enter to exit");

            Console.ReadLine();
        }

    }
}
