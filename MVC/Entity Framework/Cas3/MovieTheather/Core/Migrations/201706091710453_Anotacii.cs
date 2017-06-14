namespace Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Anotacii : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Hall", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Movie", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.User", "FirstName", c => c.String(maxLength: 30));
            AlterColumn("dbo.User", "LastName", c => c.String(maxLength: 60));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "LastName", c => c.String());
            AlterColumn("dbo.User", "FirstName", c => c.String());
            AlterColumn("dbo.Movie", "Name", c => c.String());
            AlterColumn("dbo.Hall", "Name", c => c.String());
        }
    }
}
