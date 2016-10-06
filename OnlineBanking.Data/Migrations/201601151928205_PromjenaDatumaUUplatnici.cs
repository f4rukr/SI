namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PromjenaDatumaUUplatnici : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Uplatnicas", "Datum", c => c.String());
            AlterColumn("dbo.Uplatnicas", "PocetakPoreznogPerioda", c => c.String());
            AlterColumn("dbo.Uplatnicas", "KrajPoreznogPerioda", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Uplatnicas", "KrajPoreznogPerioda", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Uplatnicas", "PocetakPoreznogPerioda", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Uplatnicas", "Datum", c => c.DateTime(nullable: false));
        }
    }
}
