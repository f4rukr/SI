namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LogDateTimeString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.LogPrijavas", "DatumVrijeme", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.LogPrijavas", "DatumVrijeme", c => c.DateTime(nullable: false));
        }
    }
}
