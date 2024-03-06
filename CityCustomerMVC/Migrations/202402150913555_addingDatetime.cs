namespace CityCustomerMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingDatetime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "DateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "DateTime");
        }
    }
}
