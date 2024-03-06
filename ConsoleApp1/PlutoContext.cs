using System.Data.Entity;

namespace ConsoleApp1
{
    
        public class PlutoContext:DbContext
           {
                public DbSet<Course> Courses { get; set; }

                public DbSet<Tag> Tags { get;set; }

                public DbSet<Author> Author { get; set; }   
                  
                   public PlutoContext()
                                     :base("name=DefaultConnecion")
                    {
        
                    }
                  
           }


        

    
}
