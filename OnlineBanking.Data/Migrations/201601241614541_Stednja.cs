namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Stednja : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stednjas", "IznosNaGlavnicu", c => c.Double(nullable: false));
            AddColumn("dbo.Stednjas", "KoeficijentStopa", c => c.Double(nullable: false));
            AlterColumn("dbo.Stednjas", "KamatnaStopa", c => c.String());
            DropColumn("dbo.Stednjas", "PocetakStednje");
            DropColumn("dbo.Stednjas", "MjesecniIznos");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Stednjas", "MjesecniIznos", c => c.Double(nullable: false));
            AddColumn("dbo.Stednjas", "PocetakStednje", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Stednjas", "KamatnaStopa", c => c.Double(nullable: false));
            DropColumn("dbo.Stednjas", "KoeficijentStopa");
            DropColumn("dbo.Stednjas", "IznosNaGlavnicu");
        }
    }
}
