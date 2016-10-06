namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class predlozak : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Predlozaks", "Opcina", c => c.String());
            DropColumn("dbo.Predlozaks", "VrstaUplate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Predlozaks", "VrstaUplate", c => c.String());
            DropColumn("dbo.Predlozaks", "Opcina");
        }
    }
}
