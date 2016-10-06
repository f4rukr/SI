namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class boolProcitanaPoruka : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Porukas", "Procitana", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Porukas", "Procitana");
        }
    }
}
