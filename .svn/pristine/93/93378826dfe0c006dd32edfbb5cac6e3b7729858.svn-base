namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ZahtjevIdNotif : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Notifikacijas", "ZahtjevId", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Notifikacijas", "ZahtjevId");
        }
    }
}
