using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    public  class BookRepo
    {
       
        public  List<book>  allbooks() 
        {
           return  new List<book>
            {
                new book() {id=111,price=70},
                new book() {id=112,price=120},
                new book() {id=113,price=44},
                new book() {id=114,price=45},
            };
        }
    }
}
