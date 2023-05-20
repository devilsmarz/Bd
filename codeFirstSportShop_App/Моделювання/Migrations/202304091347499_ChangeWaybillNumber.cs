namespace Моделювання.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class ChangeWaybillNumber : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Waybills", "Number", c => c.String(maxLength: 12));
            Sql("UPDATE Waybills SET Number =CONVERT(varchar(3), SportShopId) + '-' + CONVERT(varchar(8), Date, 112) WHERE Number IS NULL");
        }

        public override void Down()
        {
            AlterColumn("dbo.Waybills", "Number", c => c.String(maxLength: 6));

            Sql("UPDATE Waybills SET Number = NULL WHERE Number = CONVERT(varchar(3), SportShopId) + '-' + CONVERT(varchar(8), Date, 112)");
            AlterColumn("dbo.Invoices", "Номер_накладної", c =>
            c.String(maxLength: 6));
        }
    }
}
