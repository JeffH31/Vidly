namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7629a2ba-804b-4ae1-b6cc-dec0ddb98fd3', N'admin@vidly.com', 0, N'AP5wf/uMNag1D1C7B3iUxLdaYgzJyRerY8WNzngPxiZtaod3yFtCHKEuQqFSH4F6bg==', N'4f150443-755f-4363-b337-d91b8247a071', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b067fae5-f5b5-429b-9400-20627e0a4564', N'guest@vidly.com', 0, N'AIralG1LaMfL8Dfv7ygNFmAiNoKlgeF3DWPb+wp6Bnw2fJL8wxBGqWlTvhGgHototw==', N'b2f3cbb8-7484-44ee-8cb9-aa7765994303', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'05380d75-c305-45de-ba7c-53831e5fa020', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7629a2ba-804b-4ae1-b6cc-dec0ddb98fd3', N'05380d75-c305-45de-ba7c-53831e5fa020')

");
        }
        
        public override void Down()
        {
        }
    }
}
