namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RacunPosiljaocaUplatnica : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Racuns", "Stanje", c => c.Double(nullable: false));
            AlterColumn("dbo.Racuns", "Limit", c => c.Double(nullable: false));
            AlterColumn("dbo.Uplatnicas", "Iznos", c => c.Double(nullable: false));
            DropColumn("dbo.Uplatnicas", "RacunPosiljaoca");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Uplatnicas", "RacunPosiljaoca", c => c.String());
            AlterColumn("dbo.Uplatnicas", "Iznos", c => c.Single(nullable: false));
            AlterColumn("dbo.Racuns", "Limit", c => c.Single(nullable: false));
            AlterColumn("dbo.Racuns", "Stanje", c => c.Single(nullable: false));
        }
    }
}
