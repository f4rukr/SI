namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UplatniceTabela : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Predlozaks", new[] { "RacunId" });
            AddColumn("dbo.Predlozaks", "UplatioJe", c => c.String());
            AlterColumn("dbo.Predlozaks", "Datum", c => c.String());
            AlterColumn("dbo.Predlozaks", "PocetakPoreznogPerioda", c => c.String());
            AlterColumn("dbo.Predlozaks", "KrajPoreznogPerioda", c => c.String());
            AlterColumn("dbo.Predlozaks", "RacunId", c => c.Int(nullable: false));
            CreateIndex("dbo.Predlozaks", "RacunId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Predlozaks", new[] { "RacunId" });
            AlterColumn("dbo.Predlozaks", "RacunId", c => c.Int());
            AlterColumn("dbo.Predlozaks", "KrajPoreznogPerioda", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Predlozaks", "PocetakPoreznogPerioda", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Predlozaks", "Datum", c => c.DateTime(nullable: false));
            DropColumn("dbo.Predlozaks", "UplatioJe");
            CreateIndex("dbo.Predlozaks", "RacunId");
        }
    }
}
