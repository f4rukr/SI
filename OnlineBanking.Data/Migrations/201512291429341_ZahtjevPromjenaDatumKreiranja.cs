namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ZahtjevPromjenaDatumKreiranja : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Zahtjevs", "DatumKreiranja", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Zahtjevs", "DatumKreiranja", c => c.DateTime(nullable: false));
        }
    }
}
