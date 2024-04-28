namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agreements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        LandlordId = c.Int(nullable: false),
                        PropertyId = c.Int(nullable: false),
                        BuyerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Buyers", t => t.BuyerId, cascadeDelete: false)
                .ForeignKey("dbo.Landlords", t => t.LandlordId, cascadeDelete: false)
                .ForeignKey("dbo.Properties", t => t.PropertyId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: false)
                .Index(t => t.UserId)
                .Index(t => t.LandlordId)
                .Index(t => t.PropertyId)
                .Index(t => t.BuyerId);
            
            CreateTable(
                "dbo.Buyers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Contact = c.String(nullable: false),
                        Address = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Landlords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        UserId = c.Int(nullable: false),
                        Address = c.String(nullable: false),
                        Contact = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: false)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Properties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LandlordId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Landlords", t => t.LandlordId, cascadeDelete: false)
                .Index(t => t.LandlordId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Agreements", "UserId", "dbo.Users");
            DropForeignKey("dbo.Agreements", "PropertyId", "dbo.Properties");
            DropForeignKey("dbo.Agreements", "LandlordId", "dbo.Landlords");
            DropForeignKey("dbo.Landlords", "UserId", "dbo.Users");
            DropForeignKey("dbo.Properties", "LandlordId", "dbo.Landlords");
            DropForeignKey("dbo.Agreements", "BuyerId", "dbo.Buyers");
            DropIndex("dbo.Properties", new[] { "LandlordId" });
            DropIndex("dbo.Landlords", new[] { "UserId" });
            DropIndex("dbo.Agreements", new[] { "BuyerId" });
            DropIndex("dbo.Agreements", new[] { "PropertyId" });
            DropIndex("dbo.Agreements", new[] { "LandlordId" });
            DropIndex("dbo.Agreements", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.Properties");
            DropTable("dbo.Landlords");
            DropTable("dbo.Buyers");
            DropTable("dbo.Agreements");
        }
    }
}
