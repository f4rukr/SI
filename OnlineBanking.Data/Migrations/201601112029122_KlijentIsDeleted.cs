namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KlijentIsDeleted : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Klijents", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Klijents", "IsDeleted");
        }
    }
}
