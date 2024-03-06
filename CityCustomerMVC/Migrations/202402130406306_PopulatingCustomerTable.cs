namespace CityCustomerMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingCustomerTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO customers (Name, city_Id) VALUES ('John Doe', 1)");
            Sql("INSERT INTO customers (Name, city_Id) VALUES ('Jane Smith', 2)");
            Sql("INSERT INTO customers (Name, city_Id) VALUES ('Michael Brown', 3)");
            Sql("INSERT INTO customers (Name, city_Id) VALUES ('Emily Johnson', 4)");
            Sql("INSERT INTO customers (Name, city_Id) VALUES ('David Wilson', 5)");
            Sql("INSERT INTO customers (Name, city_Id) VALUES ('Jessica Lee', 6)");
        }
        
        public override void Down()
        {
        }
    }
}
