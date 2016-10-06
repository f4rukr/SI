namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ZahtjevRacunID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Racuns", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Zahtjevs", "RacunId", c => c.Int());
            DropColumn("dbo.Racuns", "Aktivan");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Racuns", "Aktivan", c => c.Boolean(nullable: false));
            DropColumn("dbo.Zahtjevs", "RacunId");
            DropColumn("dbo.Racuns", "IsDeleted");
        }
    }
}
