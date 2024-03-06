namespace CodeFirstWithExstingDB_Day8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletingDateTimeInCustomerllll : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.customer", "datetime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.customer", "datetime", c => c.DateTime());
        }
    }
}
