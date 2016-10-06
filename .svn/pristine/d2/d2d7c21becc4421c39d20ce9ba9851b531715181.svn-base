namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StednjaDatumKreiranja : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stednjas", "DatumKreiranja", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Stednjas", "DatumKreiranja");
        }
    }
}
