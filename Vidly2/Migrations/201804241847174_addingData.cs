namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Name) VALUES ('Comedy')");
            Sql("INSERT INTO Genres(Name) VALUES ('Action')");
            Sql("INSERT INTO Genres(Name) VALUES ('Family')");
            Sql("INSERT INTO Genres(Name) VALUES ('Romance')");

            Sql("INSERT INTO MembershipTypes(Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (1, 'Free', 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes(Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (2, 'Monthly', 30, 1, 10)");
            Sql("INSERT INTO MembershipTypes(Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (3, '90 Day', 90, 3, 15)");
            Sql("INSERT INTO MembershipTypes(Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (4, 'Annual', 300, 12, 20)");

        }
        
        public override void Down()
        {
        }
    }
}
