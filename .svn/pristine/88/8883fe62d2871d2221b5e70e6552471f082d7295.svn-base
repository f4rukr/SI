namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OdgovorenaPorukaBoolAtribut : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Porukas", "Odgovorena", c => c.Boolean(nullable: false));
            DropColumn("dbo.Porukas", "Procitana");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Porukas", "Procitana", c => c.Boolean(nullable: false));
            DropColumn("dbo.Porukas", "Odgovorena");
        }
    }
}
