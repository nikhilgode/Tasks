using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public static class OutRff
    {
       public static void printno(ref int a)
        {
            a += 5;
            
        }

       public static void printno2(out int a)
        {
            a = 5000;
            a += 5;

        }

    }
}
