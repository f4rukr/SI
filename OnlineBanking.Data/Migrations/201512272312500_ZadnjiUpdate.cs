namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ZadnjiUpdate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Klijents", "Titula");
            DropColumn("dbo.Klijents", "Spol");
            DropColumn("dbo.Radniks", "Titula");
            DropColumn("dbo.Radniks", "Spol");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Radniks", "Spol", c => c.String());
            AddColumn("dbo.Radniks", "Titula", c => c.String());
            AddColumn("dbo.Klijents", "Spol", c => c.String());
            AddColumn("dbo.Klijents", "Titula", c => c.String());
        }
    }
}
