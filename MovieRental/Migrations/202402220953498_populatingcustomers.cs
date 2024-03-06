namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populatingcustomers : DbMigration
    {
        public override void Up()
        {
           Sql("INSERT INTO Customers ( Name, IsSubscribed) VALUES ('John Doe', 1)");
           Sql("INSERT INTO Customers ( Name, IsSubscribed) VALUES ('Jane Smith', 0)");
        }
        
        public override void Down()
        {

        }
    }
}
