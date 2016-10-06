namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PredlozakBrojRacuna : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Predlozaks", "RacunPosiljaoca", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Predlozaks", "RacunPosiljaoca");
        }
    }
}
