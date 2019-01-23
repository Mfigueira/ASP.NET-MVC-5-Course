namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDateTime : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET ReleaseDate = CAST('2009-11-06' AS DATETIME) WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
