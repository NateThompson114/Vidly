namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies(Name, DateReleased, DateAdded, Quantity, GenreId) VALUES ('Hangover', '2009-06-02', '2018-04-17', 12, 1)");
            Sql("INSERT INTO Movies(Name, DateReleased, DateAdded, Quantity, GenreId) VALUES ('Die Hard', '1988-07-15', '2018-04-17', 5, 2)");
            Sql("INSERT INTO Movies(Name, DateReleased, DateAdded, Quantity, GenreId) VALUES ('The Terminator', '1984-10-26', '2018-04-17', 2, 2)");
            Sql("INSERT INTO Movies(Name, DateReleased, DateAdded, Quantity, GenreId) VALUES ('Toy Story', '1995-11-22', '2018-04-17', 7, 3)");
            Sql("INSERT INTO Movies(Name, DateReleased, DateAdded, Quantity, GenreId) VALUES ('Titanic', '1997-12-19', '2018-04-17', 1, 4)");
        }
        
        public override void Down()
        {
        }
    }
}
