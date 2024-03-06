namespace CodeFirstWithExstingDB_Day8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletingCustomertypeTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.CustomerTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CustomerTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        customertype = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
