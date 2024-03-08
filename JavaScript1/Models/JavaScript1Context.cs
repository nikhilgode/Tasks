using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace JavaScript1.Models
{
    public class javascript1context : DbContext
    {
        public javascript1context() : base("name=defaultconnection")
        {

        }

        public DbSet<User> users { get; set; }
    }
}