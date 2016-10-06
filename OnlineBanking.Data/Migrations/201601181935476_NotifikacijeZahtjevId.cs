namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NotifikacijeZahtjevId : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Notifikacijas", "ZahtjevId");
            AddForeignKey("dbo.Notifikacijas", "ZahtjevId", "dbo.Zahtjevs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notifikacijas", "ZahtjevId", "dbo.Zahtjevs");
            DropIndex("dbo.Notifikacijas", new[] { "ZahtjevId" });
        }
    }
}
