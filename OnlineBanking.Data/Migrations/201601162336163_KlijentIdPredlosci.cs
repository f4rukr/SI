namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KlijentIdPredlosci : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Predlozaks", "KlijentId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Predlozaks", "KlijentId");
        }
    }
}
