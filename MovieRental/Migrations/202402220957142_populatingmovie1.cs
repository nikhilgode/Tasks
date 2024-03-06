namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populatingmovie1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movie1 (Title, Price) VALUES ('Kakan', 10)");
            Sql("INSERT INTO Movie1 (Title, Price) VALUES ('RHTDM', 20)");
            Sql("INSERT INTO Movie1 (Title, Price) VALUES ('Lagan', 30)");
        }
        
        public override void Down()
        {
        }
    }
}
