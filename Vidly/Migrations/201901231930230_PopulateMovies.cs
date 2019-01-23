namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, Genre, NumberInStock) VALUES ('Hangover', 'Comedy', 5)");
        }
        
        public override void Down()
        {
        }
    }
}
