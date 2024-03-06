namespace CodeFirstWithExstingDB_Day8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingDateTimeInCustomerllll : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.customer", "datetime", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.customer", "datetime");
        }
    }
}
