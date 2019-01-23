namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, CreationDate, NumberInStock) VALUES ('Die Hard', 'Action', 11/6/2009, 5/4/2016, 2)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, CreationDate, NumberInStock) VALUES ('Terminator', 'Action', 11/6/2009, 5/4/2016, 3)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, CreationDate, NumberInStock) VALUES ('Toy Story', 'Family', 11/6/2009, 5/4/2016, 4)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, CreationDate, NumberInStock) VALUES ('Titanic', 'Romance', 11/6/2009, 5/4/2016, 4)");
        }
        
        public override void Down()
        {
        }
    }
}
