namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PromjenaEnumeracijeKodUplatnice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Uplatnicas", "StatusUplatnice", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Uplatnicas", "StatusUplatnice");
        }
    }
}
