namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMovieAvailability : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberInStock", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "NumberAvailable", c => c.Int(nullable: false));

            Sql("UPDATE Movies SET NumberInStock = Quantity");
            Sql("UPDATE Movies SET NumberAvailable = NumberInStock");

            DropColumn("dbo.Movies", "Quantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Quantity", c => c.Int(nullable: false));
            DropColumn("dbo.Movies", "NumberAvailable");
            DropColumn("dbo.Movies", "NumberInStock");
        }
    }
}
