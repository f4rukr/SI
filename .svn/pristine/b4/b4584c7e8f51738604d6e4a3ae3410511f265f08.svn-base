namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class isDeletedStednje : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stednjas", "isDeleted", c => c.Int(nullable: false));
            AddColumn("dbo.Stednjas", "KlijentId", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Stednjas", "KlijentId");
            DropColumn("dbo.Stednjas", "isDeleted");
        }
    }
}
