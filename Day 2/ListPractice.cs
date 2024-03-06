using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    public class ListPractice
    {
        List <int> list1 = new List<int>();
     

        public void printlist()
        {
                foreach (int num in list1)
                Console.WriteLine(num);
        }

        public void addinlist(int num)
        { list1.Add(num); }

        public void addoutlist(int num) {  list1.Remove(num); }

        public void addrangeinlisr(int[] num) { list1.AddRange(num); }

        public void removefromlist(int num)
        { 
            for(int i = 0;i< list1.Count; i++)
            {
                if (list1[i] == num)
                    list1.Remove(list1[i]);
            }
        }

    }
}
