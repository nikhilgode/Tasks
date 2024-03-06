namespace CityCustomerMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingCityTable : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO cities (Name) VALUES ('Mumbai')");
            Sql("INSERT INTO cities (Name) VALUES ('Pune')");
            Sql("INSERT INTO cities (Name) VALUES ('Banglore')");
            Sql("INSERT INTO cities (Name) VALUES ('Gurgaon')");
            Sql("INSERT INTO cities (Name) VALUES ('Hydrabad')");
            Sql("INSERT INTO cities (Name) VALUES ('Nashik')");
        }
        
        public override void Down()
        {
        }
    }
}
