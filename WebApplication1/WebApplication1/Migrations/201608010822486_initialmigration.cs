namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Active = c.Boolean(nullable: false),
                        Name = c.String(nullable: false),
                        Distance = c.Int(),
                        Destination1Id = c.Int(),
                        Destination2Id = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.Destination1Id)
                .ForeignKey("dbo.Locations", t => t.Destination2Id)
                .Index(t => t.Destination1Id)
                .Index(t => t.Destination2Id);
            
            CreateTable(
                "dbo.Factions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Active = c.Boolean(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Monsters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Active = c.Boolean(nullable: false),
                        Name = c.String(nullable: false),
                        WieldedItemId = c.Int(nullable: false),
                        HP = c.Int(nullable: false),
                        FactionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Factions", t => t.FactionId, cascadeDelete: true)
                .ForeignKey("dbo.Items", t => t.WieldedItemId, cascadeDelete: true)
                .Index(t => t.WieldedItemId)
                .Index(t => t.FactionId);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Active = c.Boolean(nullable: false),
                        Name = c.String(nullable: false),
                        HPGained = c.Int(),
                        Damage = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Active = c.Boolean(nullable: false),
                        Name = c.String(nullable: false),
                        WieldedItemId = c.Int(nullable: false),
                        HP = c.Int(nullable: false),
                        FactionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Factions", t => t.FactionId, cascadeDelete: true)
                .ForeignKey("dbo.Items", t => t.WieldedItemId, cascadeDelete: true)
                .Index(t => t.WieldedItemId)
                .Index(t => t.FactionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Locations", "Destination2Id", "dbo.Locations");
            DropForeignKey("dbo.Locations", "Destination1Id", "dbo.Locations");
            DropForeignKey("dbo.Players", "WieldedItemId", "dbo.Items");
            DropForeignKey("dbo.Players", "FactionId", "dbo.Factions");
            DropForeignKey("dbo.Monsters", "WieldedItemId", "dbo.Items");
            DropForeignKey("dbo.Monsters", "FactionId", "dbo.Factions");
            DropIndex("dbo.Players", new[] { "FactionId" });
            DropIndex("dbo.Players", new[] { "WieldedItemId" });
            DropIndex("dbo.Monsters", new[] { "FactionId" });
            DropIndex("dbo.Monsters", new[] { "WieldedItemId" });
            DropIndex("dbo.Locations", new[] { "Destination2Id" });
            DropIndex("dbo.Locations", new[] { "Destination1Id" });
            DropTable("dbo.Players");
            DropTable("dbo.Items");
            DropTable("dbo.Monsters");
            DropTable("dbo.Factions");
            DropTable("dbo.Locations");
        }
    }
}
