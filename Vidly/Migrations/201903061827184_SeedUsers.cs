namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4392f829-75b5-4db9-ac40-81433d0276e8', N'guest@vidly.com', 0, N'AEljZWHj/IWKBLtWq7olFnfYz4U3Hng+YKqF5p8wX1gTY4QxVHzG6tMmZKIqMY/AmA==', N'bd951da3-4c84-4575-9f4b-14e3ce5b84fa', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'886b4580-c8bb-4b05-a385-5aa168967327', N'adminn@vidly.com', 0, N'AJttuS+Z40xpW2uBYmupWDeLlwtcpHZ0M2M7BeTKe6A48e0PrPcK0S/1whzJ66G3VQ==', N'30338195-fc5f-4c65-8aca-62b169c5d13a', NULL, 0, 0, NULL, 1, 0, N'adminn@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b21508cf-6159-480b-b7b1-8f72f25f03d8', N'admin@vidly.com', 0, N'AFnngAXz0YRkZms3jLriH68nRE+4+HhL4kW5Q8/iPsv+/2NMkws/l5zN3LiE3WOGyQ==', N'38636ce5-5781-488f-952d-183b0c8e97d3', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6ae4a16d-29d5-4f7c-b647-b808ed2347b2', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'886b4580-c8bb-4b05-a385-5aa168967327', N'6ae4a16d-29d5-4f7c-b647-b808ed2347b2')

");
        }
        
        public override void Down()
        {
        }
    }
}
