namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ZahtjevTipValute : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Zahtjevs", "TipValute", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Zahtjevs", "TipValute");
        }
    }
}
