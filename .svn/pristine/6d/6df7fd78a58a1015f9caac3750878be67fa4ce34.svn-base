namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class notifikacijaUspjeh : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Notifikacijas", "ObavijestId", c => c.Int());
            AlterColumn("dbo.Notifikacijas", "Uspjeh", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Notifikacijas", "Uspjeh", c => c.Boolean(nullable: false));
            DropColumn("dbo.Notifikacijas", "ObavijestId");
        }
    }
}
