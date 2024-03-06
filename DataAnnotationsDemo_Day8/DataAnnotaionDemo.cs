using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotationsDemo_Day8
{
    public class DataAnnotaionDemo:DbContext
    {
        public DbSet<Course> Courses { get; set; }

        public DbSet<Author> Author { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DataAnnotaionDemo() : base("name=DefaultConnecion111") 
        {
        
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Course>()
                        .HasMany(c => c.tags)
                        .WithMany(t => t.courses);

            modelBuilder.Entity<Course>()
                         .HasRequired(c => c.cover)
                         .WithRequiredPrincipal(c => c.Course);
        }

    }
}
