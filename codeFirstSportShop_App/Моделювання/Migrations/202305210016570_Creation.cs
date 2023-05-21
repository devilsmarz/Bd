namespace Моделювання.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Creation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClothDocs",
                c => new
                    {
                        ClothDocId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Count = c.Int(nullable: false),
                        ClothId = c.Int(nullable: false),
                        ClothShopId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClothDocId)
                .ForeignKey("dbo.Clothes", t => t.ClothId, cascadeDelete: true)
                .ForeignKey("dbo.ClothShops", t => t.ClothShopId, cascadeDelete: true)
                .Index(t => t.ClothId)
                .Index(t => t.ClothShopId);
            
            CreateTable(
                "dbo.Clothes",
                c => new
                    {
                        ClothId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 25),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ClothId);
            
            CreateTable(
                "dbo.ClothShops",
                c => new
                    {
                        ClothShopId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        Address = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.ClothShopId);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        InvoiceId = c.Int(nullable: false, identity: true),
                        Number = c.String(maxLength: 12),
                        Date = c.DateTime(nullable: false),
                        ClothShopId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InvoiceId)
                .ForeignKey("dbo.ClothShops", t => t.ClothShopId, cascadeDelete: true)
                .Index(t => t.ClothShopId);
            
            CreateTable(
                "dbo.InvoiceItems",
                c => new
                    {
                        InvoiceItemId = c.Int(nullable: false, identity: true),
                        InvoiceId = c.Int(nullable: false),
                        ClothId = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InvoiceItemId)
                .ForeignKey("dbo.Clothes", t => t.ClothId, cascadeDelete: true)
                .ForeignKey("dbo.Invoices", t => t.InvoiceId, cascadeDelete: true)
                .Index(t => t.InvoiceId)
                .Index(t => t.ClothId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InvoiceItems", "InvoiceId", "dbo.Invoices");
            DropForeignKey("dbo.InvoiceItems", "ClothId", "dbo.Clothes");
            DropForeignKey("dbo.Invoices", "ClothShopId", "dbo.ClothShops");
            DropForeignKey("dbo.ClothDocs", "ClothShopId", "dbo.ClothShops");
            DropForeignKey("dbo.ClothDocs", "ClothId", "dbo.Clothes");
            DropIndex("dbo.InvoiceItems", new[] { "ClothId" });
            DropIndex("dbo.InvoiceItems", new[] { "InvoiceId" });
            DropIndex("dbo.Invoices", new[] { "ClothShopId" });
            DropIndex("dbo.ClothDocs", new[] { "ClothShopId" });
            DropIndex("dbo.ClothDocs", new[] { "ClothId" });
            DropTable("dbo.InvoiceItems");
            DropTable("dbo.Invoices");
            DropTable("dbo.ClothShops");
            DropTable("dbo.Clothes");
            DropTable("dbo.ClothDocs");
        }
    }
}
