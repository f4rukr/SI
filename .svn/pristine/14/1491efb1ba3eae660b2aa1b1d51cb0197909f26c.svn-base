namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UplatnicaOpcina : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Uplatnicas", "Opcina", c => c.String());
            DropColumn("dbo.Uplatnicas", "VrstaUplate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Uplatnicas", "VrstaUplate", c => c.String());
            DropColumn("dbo.Uplatnicas", "Opcina");
        }
    }
}
