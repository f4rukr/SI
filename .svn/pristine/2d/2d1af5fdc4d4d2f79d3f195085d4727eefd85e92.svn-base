namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EnumeracijaTipRacuna : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Racuns", "TipRacuna", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Racuns", "TipRacuna");
        }
    }
}
