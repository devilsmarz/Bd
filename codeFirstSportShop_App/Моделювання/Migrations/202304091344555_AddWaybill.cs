namespace Моделювання.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWaybill : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Waybills",
                c => new
                    {
                        WaybillId = c.Int(nullable: false, identity: true),
                        Number = c.String(maxLength: 6),
                        Date = c.DateTime(nullable: false),
                        SportShopId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WaybillId)
                .ForeignKey("dbo.SportShops", t => t.SportShopId, cascadeDelete: true)
                .Index(t => t.SportShopId);
            
            AlterColumn("dbo.SportItems", "Name", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.SportShops", "Name", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.SportShops", "Address", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Waybills", "SportShopId", "dbo.SportShops");
            DropIndex("dbo.Waybills", new[] { "SportShopId" });
            AlterColumn("dbo.SportShops", "Address", c => c.String());
            AlterColumn("dbo.SportShops", "Name", c => c.String());
            AlterColumn("dbo.SportItems", "Name", c => c.String());
            DropTable("dbo.Waybills");
        }
    }
}
