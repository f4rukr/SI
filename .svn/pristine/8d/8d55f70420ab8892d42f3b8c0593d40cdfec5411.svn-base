namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PredlozakBrojRacuna1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Uplatnicas", "UplatioJe", c => c.String());
            AddColumn("dbo.Uplatnicas", "RacunPosiljaoca", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Uplatnicas", "RacunPosiljaoca");
            DropColumn("dbo.Uplatnicas", "UplatioJe");
        }
    }
}
