namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixCustomerBirthdateTry2 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = '1984-08-05' WHERE Id=1");
        }

        public override void Down()
        {
        }
    }
}
