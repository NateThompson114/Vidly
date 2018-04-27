namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1ea51d6a-853a-4408-88d4-953a5ffb706a', N'admin@vidly.com', 0, N'AF+M8n4YEcpk2mcuGUiTWSP6H1vD1jOujZhxcSFfTMm0ykCHYNn1/rxd+3j2juLGPw==', N'4383558b-c6d1-4330-a2b4-8026c823c4b2', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ecf1f03c-d089-4163-9b86-d9cd30da2c58', N'guest@vidly.com', 0, N'AHfes9z37thGNwoaZ2/o+oyBnmZJ/L3wFhEwQ2cSYfpLNdD9LrOpL/YhLHsav/S/Hw==', N'cccca2ee-be25-405e-8db9-ef8eb508aed3', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c474de53-dd85-4f95-94f7-7194f85f7060', N'CanManageMovies')
                
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1ea51d6a-853a-4408-88d4-953a5ffb706a', N'c474de53-dd85-4f95-94f7-7194f85f7060')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
