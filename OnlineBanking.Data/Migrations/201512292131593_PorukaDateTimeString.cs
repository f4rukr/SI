namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PorukaDateTimeString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Porukas", "DatumVrijeme", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Porukas", "DatumVrijeme", c => c.DateTime(nullable: false));
        }
    }
}
