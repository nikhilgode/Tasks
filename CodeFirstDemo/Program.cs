using System.Net;

namespace CodeFirstDemo
{

    public enum CourseLevel
    {
        Biginner=1,
        Intermidiate=2,
        Advance=3
    }


    public class Program
    {
        

        public static void Main(string[] args)
        {
           
        }


        public class Course()
        {
            public int id { get; set; }
            public string discripion { get; set; }
            public string Title { get; set; }
            public float Fullprice { get; set; }
            public Author Author { get; set; }
            public IList<Tag> Tags { get; set; }

        }

        public class Author()
        {
           public int id { get; set; }
        
           public string name { get; set;}

           public IList<Course> Courses { get; set; }
           
        }

        public class Tag
        {
            public int id { get; set; }

            public string name { get; set; }

            public IList<Course> Courses { get; set; }
        }
        
        
    }
  

}
