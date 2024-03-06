namespace CodeFirstWithExstingDB_Day8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: false),
                        customertype = c.String(),
                    })
                .PrimaryKey(t => t.Id);

            Sql("INSERT INTO CustomerTypes VALUES (1,'GOLD')");
            Sql("INSERT INTO CustomerTypes VALUES (2,'BRONZE')");
            Sql("INSERT INTO CustomerTypes VALUES (3,'SILVER')");

        }
        
        public override void Down()
        {
            DropTable("dbo.CustomerTypes");
        }
    }
}
