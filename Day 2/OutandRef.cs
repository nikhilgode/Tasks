using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    internal class OutandRef
    {
        public void addition1(ref int a)
        {
            a = a + 10;

        }

        public void addition2(out int a)
        {
            a = 100;
            a = a + 10;
        }

    }
}
