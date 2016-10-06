namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dodavanjeVarijableBrojRacuna : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Racuns", "BrojRacuna", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Racuns", "BrojRacuna");
        }
    }
}
