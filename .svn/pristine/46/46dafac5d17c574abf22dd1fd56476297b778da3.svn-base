namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodavanjeVirtualFK : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Porukas", "IsDeletedRadnik", c => c.Boolean(nullable: false));
            AddColumn("dbo.Porukas", "IsDeletedKlijent", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Porukas", "IsDeletedKlijent");
            DropColumn("dbo.Porukas", "IsDeletedRadnik");
        }
    }
}
