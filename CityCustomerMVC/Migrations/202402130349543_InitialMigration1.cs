namespace CityCustomerMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        city_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.city_Id)
                .Index(t => t.city_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "city_Id", "dbo.Cities");
            DropIndex("dbo.Customers", new[] { "city_Id" });
            DropTable("dbo.Customers");
            DropTable("dbo.Cities");
        }
    }
}
