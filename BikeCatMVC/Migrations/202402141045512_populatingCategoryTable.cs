namespace BikeCatMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populatingCategoryTable : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO cateories (Name) VALUES ('Dirt')");
            Sql("INSERT INTO cateories (Name) VALUES ('Adventure')");
            Sql("INSERT INTO cateories (Name) VALUES ('Sports')");
            Sql("INSERT INTO cateories (Name) VALUES ('Economical')");
          


        }
        
        public override void Down()
        {
        }
    }
}
