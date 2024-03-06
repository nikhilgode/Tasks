namespace CodefirstWithExistingDatabse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        discripion = c.String(),
                        Title = c.String(),
                        Fullprice = c.Single(nullable: false),
                        Author_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Authors", t => t.Author_id)
                .Index(t => t.Author_id);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TagCourses",
                c => new
                    {
                        Course_id = c.Int(nullable: false),
                        Tag_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Course_id, t.Tag_id })
                .ForeignKey("dbo.Courses", t => t.Course_id, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.Tag_id, cascadeDelete: true)
                .Index(t => t.Course_id)
                .Index(t => t.Tag_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Author_id", "dbo.Authors");
            DropForeignKey("dbo.TagCourses", "Tag_id", "dbo.Tags");
            DropForeignKey("dbo.TagCourses", "Course_id", "dbo.Courses");
            DropIndex("dbo.TagCourses", new[] { "Tag_id" });
            DropIndex("dbo.TagCourses", new[] { "Course_id" });
            DropIndex("dbo.Courses", new[] { "Author_id" });
            DropTable("dbo.TagCourses");
            DropTable("dbo.Tags");
            DropTable("dbo.Courses");
            DropTable("dbo.Authors");
        }
    }
}
