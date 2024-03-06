using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CodeFirstWithExstingDB_Day8
{
    public partial class CodefirstwithEstingDB_Day8 : DbContext
    {
        public CodefirstwithEstingDB_Day8()
            : base("name=CodefirstwithEstingDB_Day8")
        {
        }

        public virtual DbSet<city> cities { get; set; }
        public virtual DbSet<customer> customers { get; set; }

       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<city>()
                .Property(e => e.city_name)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.customer_name)
                .IsUnicode(false);
        }
    }
}
