namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class predlozakIsdeleted : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Predlozaks", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Predlozaks", "IsDeleted");
        }
    }
}
