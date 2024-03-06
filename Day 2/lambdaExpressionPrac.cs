using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Day_2
{
    public class lambdaExpressionPrac
    {
        int n;

        public void uselambda(int n)
       {
            this.n = n;
            Func<int, int> lmb1 = number => number * number;
            Console.WriteLine(lmb1(n));


            Func<int,int,int,int> lmb2= (a,b,c) => a+b+c;
            Console.WriteLine(lmb2(4,5,6));
       }
    }
}
