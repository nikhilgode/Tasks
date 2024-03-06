namespace CodeFirstWithExstingDB_Day8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletingCustomertypeFromCustomer : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.customer", "customer_type_Id", "dbo.CustomerTypes");
            DropIndex("dbo.customer", new[] { "customer_type_Id" });
            DropColumn("dbo.customer", "customer_type_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.customer", "customer_type_Id", c => c.Int());
            CreateIndex("dbo.customer", "customer_type_Id");
            AddForeignKey("dbo.customer", "customer_type_Id", "dbo.CustomerTypes", "Id");
        }
    }
}
