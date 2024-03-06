using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RevisionWEB.Models
{
    public class RevisionWEBContext : DbContext
    {

        public RevisionWEBContext() : base("name=DefaultConnection")
        {
        }

        public DbSet<Customer> customers { get; set; }

    }
}