namespace CodeFirstWithExstingDB_Day8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingCustomerTypeInCustomerTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.customer", "customer_type_Id", c => c.Int());
            CreateIndex("dbo.customer", "customer_type_Id");
            AddForeignKey("dbo.customer", "customer_type_Id", "dbo.CustomerTypes", "Id");
            Sql("UPDATE customer SET customer_type_Id= 1 ");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.customer", "customer_type_Id", "dbo.CustomerTypes");
            DropIndex("dbo.customer", new[] { "customer_type_Id" });
            DropColumn("dbo.customer", "customer_type_Id");
        }
    }
}
