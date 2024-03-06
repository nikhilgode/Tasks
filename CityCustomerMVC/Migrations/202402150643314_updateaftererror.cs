namespace CityCustomerMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateaftererror : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cities", "Name", c => c.String(nullable: false, maxLength: 25));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cities", "Name", c => c.String());
        }
    }
}
