namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class izbacioSalt : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Klijents", "Salt");
            DropColumn("dbo.Radniks", "Salt");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Radniks", "Salt", c => c.String());
            AddColumn("dbo.Klijents", "Salt", c => c.String());
        }
    }
}
