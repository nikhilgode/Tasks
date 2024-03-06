namespace RentalMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populatigMovie : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Title, Price) VALUES ('Movie 1', 10)");
            Sql("INSERT INTO Movies (Title, Price) VALUES ('Movie 2', 15)");
            Sql("INSERT INTO Movies (Title, Price) VALUES ('Movie 3', 20)");

        }
        
        public override void Down()
        {
        }
    }
}
