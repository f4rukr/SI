namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatumRodjenjaString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Klijents", "DatumRodjenja", c => c.String());
            AlterColumn("dbo.Radniks", "DatumRodjenja", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Radniks", "DatumRodjenja", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Klijents", "DatumRodjenja", c => c.DateTime(nullable: false));
        }
    }
}
