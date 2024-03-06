namespace DataAnnotationsDemo_Day8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MaintainingRlationship : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.TagCourses", newName: "CourseTags");
            DropPrimaryKey("dbo.CourseTags");
            AlterColumn("dbo.Courses", "Name", c => c.String(nullable: false, maxLength: 200));
            AddPrimaryKey("dbo.CourseTags", new[] { "Course_Id", "Tag_Id" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.CourseTags");
            AlterColumn("dbo.Courses", "Name", c => c.String());
            AddPrimaryKey("dbo.CourseTags", new[] { "Tag_Id", "Course_Id" });
            RenameTable(name: "dbo.CourseTags", newName: "TagCourses");
        }
    }
}
