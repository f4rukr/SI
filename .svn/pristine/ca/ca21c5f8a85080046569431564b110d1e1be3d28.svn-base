namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsAtiveGone : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Radniks", "IsDeleted", c => c.Boolean(nullable: false));
            DropColumn("dbo.Klijents", "IsActive");
            DropColumn("dbo.Radniks", "IsActive");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Radniks", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Klijents", "IsActive", c => c.Boolean(nullable: false));
            DropColumn("dbo.Radniks", "IsDeleted");
        }
    }
}
