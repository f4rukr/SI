namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zadnja : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Notifikacijas", "RadnikId", "dbo.Radniks");
            DropIndex("dbo.Notifikacijas", new[] { "RadnikId" });
            DropColumn("dbo.Notifikacijas", "RadnikId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Notifikacijas", "RadnikId", c => c.Int());
            CreateIndex("dbo.Notifikacijas", "RadnikId");
            AddForeignKey("dbo.Notifikacijas", "RadnikId", "dbo.Radniks", "Id");
        }
    }
}
