using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ChangingDataDemo_Day10
{
    public partial class ChangingDataDemo : DbContext
    {
        public ChangingDataDemo()
            : base("name=ChangingDataDemo")
        {
        }

        public virtual DbSet<city> cities { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

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
