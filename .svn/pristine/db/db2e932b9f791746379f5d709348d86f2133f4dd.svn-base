namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SlikePath : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Klijents", "SlikaPath", c => c.String());
            AddColumn("dbo.Radniks", "SlikaPath", c => c.String());
            DropColumn("dbo.Klijents", "Slika");
            DropColumn("dbo.Radniks", "Slika");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Radniks", "Slika", c => c.String());
            AddColumn("dbo.Klijents", "Slika", c => c.String());
            DropColumn("dbo.Radniks", "SlikaPath");
            DropColumn("dbo.Klijents", "SlikaPath");
        }
    }
}
