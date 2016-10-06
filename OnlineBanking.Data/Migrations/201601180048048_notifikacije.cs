namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class notifikacije : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Notifikacijas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Procitana = c.Boolean(nullable: false),
                        DatumVrijeme = c.String(),
                        Naslov = c.String(),
                        Sadrzaj = c.String(),
                        Uspjeh = c.Boolean(nullable: false),
                        KlijentId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Klijents", t => t.KlijentId)
                .Index(t => t.KlijentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notifikacijas", "KlijentId", "dbo.Klijents");
            DropIndex("dbo.Notifikacijas", new[] { "KlijentId" });
            DropTable("dbo.Notifikacijas");
        }
    }
}
