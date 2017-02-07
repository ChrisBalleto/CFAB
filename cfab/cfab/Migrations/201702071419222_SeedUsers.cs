namespace cfab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'34533fb8-04e3-4ede-91d7-7c04a40e7bc6', N'Guest@gmail.com', 0, N'AGS/ePJeb3lspsOiRc+waXzqNfLFmkI66UkNwZ0IwXtM650ErTtI6Psrs+BkmfVTAg==', N'2652aa50-5998-4683-9546-85b0d27f6a04', NULL, 0, 0, NULL, 1, 0, N'Guest@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'de576611-5cd8-45c6-bc9e-faab36804dd6', N'Admin@CFAB.com', 0, N'ANJlXn84iD2V+VxTVktTKzM7BW6NpaK6tbETetXBPfXhAA/WyAOg5toz3Oqp76DEKg==', N'41e43332-1ef4-4e3b-af16-f6b463c6fb5f', NULL, 0, 0, NULL, 1, 0, N'Admin@CFAB.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'0d094a25-f8df-42c2-b9b0-bdf59c589bd3', N'Admin')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'de576611-5cd8-45c6-bc9e-faab36804dd6', N'0d094a25-f8df-42c2-b9b0-bdf59c589bd3')

");
        }
        
        public override void Down()
        {
        }
    }
}
