namespace Моделювання.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemDocs",
                c => new
                    {
                        ItemDocId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Count = c.Int(nullable: false),
                        SportItemId = c.Int(nullable: false),
                        SportShopId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ItemDocId)
                .ForeignKey("dbo.SportItems", t => t.SportItemId, cascadeDelete: true)
                .ForeignKey("dbo.SportShops", t => t.SportShopId, cascadeDelete: true)
                .Index(t => t.SportItemId)
                .Index(t => t.SportShopId);
            
            CreateTable(
                "dbo.SportItems",
                c => new
                    {
                        SportItemId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.SportItemId);
            
            CreateTable(
                "dbo.SportShops",
                c => new
                    {
                        SportShopId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.SportShopId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemDocs", "SportShopId", "dbo.SportShops");
            DropForeignKey("dbo.ItemDocs", "SportItemId", "dbo.SportItems");
            DropIndex("dbo.ItemDocs", new[] { "SportShopId" });
            DropIndex("dbo.ItemDocs", new[] { "SportItemId" });
            DropTable("dbo.SportShops");
            DropTable("dbo.SportItems");
            DropTable("dbo.ItemDocs");
        }
    }
}
