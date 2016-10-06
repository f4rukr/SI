namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsDeletedStednjaRadiSad : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stednjas", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Stednjas", "IsDeleted");
        }
    }
}
