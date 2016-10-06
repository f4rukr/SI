namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VrstaPredloska : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Predlozaks", "VrstaPredloska", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Predlozaks", "VrstaPredloska");
        }
    }
}
