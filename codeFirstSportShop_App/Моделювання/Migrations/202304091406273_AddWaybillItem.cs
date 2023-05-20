namespace Моделювання.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWaybillItem : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WaybillItems",
                c => new
                    {
                        WaybillItemId = c.Int(nullable: false, identity: true),
                        WaybillId = c.Int(nullable: false),
                        SportItemId = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WaybillItemId)
                .ForeignKey("dbo.SportItems", t => t.SportItemId, cascadeDelete: true)
                .ForeignKey("dbo.Waybills", t => t.WaybillId, cascadeDelete: true)
                .Index(t => t.WaybillId)
                .Index(t => t.SportItemId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WaybillItems", "WaybillId", "dbo.Waybills");
            DropForeignKey("dbo.WaybillItems", "SportItemId", "dbo.SportItems");
            DropIndex("dbo.WaybillItems", new[] { "SportItemId" });
            DropIndex("dbo.WaybillItems", new[] { "WaybillId" });
            DropTable("dbo.WaybillItems");

            Sql("DELETE FROM Waybills WHERE Number= N'102' AND SportShopIdUpdate-Database – Verbose=1");
        }
    }
}
