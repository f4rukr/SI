namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BrojUliceString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Klijents", "BrojUlice", c => c.String());
            AlterColumn("dbo.Radniks", "BrojUlice", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Radniks", "BrojUlice", c => c.Int(nullable: false));
            AlterColumn("dbo.Klijents", "BrojUlice", c => c.Int(nullable: false));
        }
    }
}
