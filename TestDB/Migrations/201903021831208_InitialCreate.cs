namespace TestDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Magazins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tovars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        About = c.String(),
                        Price = c.Single(nullable: false),
                        MagazId = c.Int(nullable: false),
                        Magazin_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Magazins", t => t.Magazin_Id)
                .Index(t => t.Magazin_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tovars", "Magazin_Id", "dbo.Magazins");
            DropIndex("dbo.Tovars", new[] { "Magazin_Id" });
            DropTable("dbo.Tovars");
            DropTable("dbo.Magazins");
        }
    }
}
