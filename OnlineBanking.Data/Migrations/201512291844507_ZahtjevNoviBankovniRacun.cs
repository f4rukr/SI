namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ZahtjevNoviBankovniRacun : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Racuns", name: "Klijent_Id", newName: "KlijentId");
            RenameIndex(table: "dbo.Racuns", name: "IX_Klijent_Id", newName: "IX_KlijentId");
            AddColumn("dbo.Zahtjevs", "TipRacunaId", c => c.Int());
            AlterColumn("dbo.Racuns", "DatumOtvaranja", c => c.String());
            DropColumn("dbo.Racuns", "KorisnikId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Racuns", "KorisnikId", c => c.Int());
            AlterColumn("dbo.Racuns", "DatumOtvaranja", c => c.DateTime(nullable: false));
            DropColumn("dbo.Zahtjevs", "TipRacunaId");
            RenameIndex(table: "dbo.Racuns", name: "IX_KlijentId", newName: "IX_Klijent_Id");
            RenameColumn(table: "dbo.Racuns", name: "KlijentId", newName: "Klijent_Id");
        }
    }
}
