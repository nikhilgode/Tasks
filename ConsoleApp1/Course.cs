using System.Collections.Generic;

namespace ConsoleApp1
{
   
        public class Course
            {
                public int id { get; set; }
                public string discripion { get; set; }
                public string Title { get; set; }
                public float Fullprice { get; set; }
                public Author Author { get; set; }
                public IList<Tag> Tags { get; set; }

            }


        

    
}
