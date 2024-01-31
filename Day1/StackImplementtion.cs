using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1._0
{
    public class StackImplementtion
    {
        List <Object> list = new List <Object> ();


        public void push(Object obj)
        {
            if (obj==null) 
            {
                Console.WriteLine("You cannot addd null value");
            }
            else 
            {
                list.Add (obj);
                Console.WriteLine("Added element is   "+ obj);
            }
        }

        public void pop()
        {
            if(list.Count ==0)
            {
                Console.WriteLine("the stack is empty");
            }
            else
            {
               int x= list.Count-1;
               object y = list[x];
               list.RemoveAt (x);
               Console.WriteLine("Poped element is "+y);
            }
        }

        public void showstack()
        {
            foreach (Object obj in list) 
            {
               Console.WriteLine(obj.ToString());
            }
        }
    }
}
