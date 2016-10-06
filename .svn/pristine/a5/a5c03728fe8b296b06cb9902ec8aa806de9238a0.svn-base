namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsActiveAtributKorisnik : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Klijents", "BrojPokusajaLogiranja", c => c.Int(nullable: false));
            AddColumn("dbo.Klijents", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Radniks", "BrojPokusajaLogiranja", c => c.Int(nullable: false));
            AddColumn("dbo.Radniks", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Radniks", "IsActive");
            DropColumn("dbo.Radniks", "BrojPokusajaLogiranja");
            DropColumn("dbo.Klijents", "IsActive");
            DropColumn("dbo.Klijents", "BrojPokusajaLogiranja");
        }
    }
}
