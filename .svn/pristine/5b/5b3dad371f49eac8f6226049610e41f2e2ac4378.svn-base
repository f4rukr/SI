namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class brojOpstine : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Opstinas", "BrojOpstine", c => c.String());
            DropColumn("dbo.Opstinas", "ZipCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Opstinas", "ZipCode", c => c.String());
            DropColumn("dbo.Opstinas", "BrojOpstine");
        }
    }
}
