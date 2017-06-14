namespace Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hall",
                c => new
                    {
                        HallID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NumberOfSeats = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HallID);
            
            CreateTable(
                "dbo.Projection",
                c => new
                    {
                        ProjectionID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        MovieID = c.Int(nullable: false),
                        HallID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectionID)
                .ForeignKey("dbo.Hall", t => t.HallID, cascadeDelete: true)
                .ForeignKey("dbo.Movie", t => t.MovieID, cascadeDelete: true)
                .Index(t => t.MovieID)
                .Index(t => t.HallID);
            
            CreateTable(
                "dbo.Movie",
                c => new
                    {
                        MovieID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Duration = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MovieID);
            
            CreateTable(
                "dbo.Reservation",
                c => new
                    {
                        ReservationID = c.Int(nullable: false, identity: true),
                        HasAttended = c.Boolean(nullable: false),
                        ProjectionID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReservationID)
                .ForeignKey("dbo.Projection", t => t.ProjectionID, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.UserID, cascadeDelete: true)
                .Index(t => t.ProjectionID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservation", "UserID", "dbo.User");
            DropForeignKey("dbo.Reservation", "ProjectionID", "dbo.Projection");
            DropForeignKey("dbo.Projection", "MovieID", "dbo.Movie");
            DropForeignKey("dbo.Projection", "HallID", "dbo.Hall");
            DropIndex("dbo.Reservation", new[] { "UserID" });
            DropIndex("dbo.Reservation", new[] { "ProjectionID" });
            DropIndex("dbo.Projection", new[] { "HallID" });
            DropIndex("dbo.Projection", new[] { "MovieID" });
            DropTable("dbo.User");
            DropTable("dbo.Reservation");
            DropTable("dbo.Movie");
            DropTable("dbo.Projection");
            DropTable("dbo.Hall");
        }
    }
}
