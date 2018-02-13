namespace Stuudent.Migrations.IdentityMigration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'38543d7c-6622-4cde-bb80-31d5adafbae7', N'iftekhar.rasul7@gmail.com', 0, N'ALn6b0hA8iMld2024T/rMtcZaiioixzrtV6TZSO6WDWdum0iSK5iKIJc/I6zeGFSDQ==', N'37db4b22-725b-4dd3-a0c7-ffc0b4675478', NULL, 0, 0, NULL, 1, 0, N'iftekhar.rasul7@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'43b12314-94bf-41f9-b38e-097530cb76ed', N'fouzianishat@gmail.com', 0, N'AIKoj5B0MbG4hH8Y0xvDnmYjYlPOcRVFZI0Rt7YjV0lp8ZJYXKlj6Zu34AD/J11g1g==', N'aecf6ea5-4715-45d4-aaea-b2052865d2e3', NULL, 0, 0, NULL, 1, 0, N'fouzianishat@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a603d945-bc29-4401-85c0-f434db70b823', N'CanManage')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'43b12314-94bf-41f9-b38e-097530cb76ed', N'a603d945-bc29-4401-85c0-f434db70b823')

");
        }
        
        public override void Down()
        {
        }
    }
}
