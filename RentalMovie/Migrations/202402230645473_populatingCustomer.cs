namespace RentalMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populatingCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers (Name, IsSubscribed) VALUES ('John Doe', 1)");
            Sql("INSERT INTO Customers (Name, IsSubscribed) VALUES ('Jane Smith', 0)");
            Sql("INSERT INTO Customers (Name, IsSubscribed) VALUES ('Alice Johnson', 1)");

        }
        
        public override void Down()
        {
        }
    }
}
