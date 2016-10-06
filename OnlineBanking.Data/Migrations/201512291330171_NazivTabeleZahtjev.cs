namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NazivTabeleZahtjev : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Zahtijevs", newName: "Zahtjevs");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Zahtjevs", newName: "Zahtijevs");
        }
    }
}
