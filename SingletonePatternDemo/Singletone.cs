using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonePatternDemo
{
    public sealed class Singletone
    {
        private static int countr = 0;
        private static Singletone instance= null;

        public static Singletone Getinstance
        {
            get 
            {
               if(instance == null)
                    instance = new Singletone();
               return instance;
            }
        }

        private Singletone() 
        {
            countr++;
            Console.WriteLine("Counter value="+ countr.ToString());
        }

        public void printDetaild(string message)
        {

            Console.WriteLine(message); 
        }


    }
}
