namespace CityCustomerMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class seedusers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
              INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8f801172-69ac-4f40-b2ae-57cf0f494356', N'guestuser@gmail.com', 0, N'AByW+heGEPzLJCWb2nKsPzkrA8jEnrRiE58tYgZIusxD6hh9QQ0mpbX1e09AionA+g==', N'4562cc8d-31db-41fb-a67e-fca2561116de', NULL, 0, 0, NULL, 1, 0, N'guestuser@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f48ed61a-85ce-4191-bc02-8582fdbdca72', N'manageruser@gmail.com', 0, N'APSBq4HK+jWLjOwlMPbivvjud9ko0jDWWUAgYEWxWYYSn/xX2RGIZK1SRejiiPW1wQ==', N'ad8d3cbf-5bf9-41cf-8dc2-496704f1063c', NULL, 0, 0, NULL, 1, 0, N'manageruser@gmail.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'94e36482-6a1f-4c78-815e-6c093d7f9a20', N'CanManageMovie')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f48ed61a-85ce-4191-bc02-8582fdbdca72', N'94e36482-6a1f-4c78-815e-6c093d7f9a20')

");
        }

        public override void Down()
        {
        }
    }
}
