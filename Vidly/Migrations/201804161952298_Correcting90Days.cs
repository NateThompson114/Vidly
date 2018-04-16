namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Correcting90Days : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = '90 Day' WHERE Id = 3");
        }
        
        public override void Down()
        {
        }
    }
}
