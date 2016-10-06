namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracijaStednja : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Stednjas", "isDeleted");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Stednjas", "isDeleted", c => c.Int(nullable: false));
        }
    }
}
