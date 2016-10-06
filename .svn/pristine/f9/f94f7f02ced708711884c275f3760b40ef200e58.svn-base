namespace OnlineBanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Drzavas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Klijents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ime = c.String(),
                        Prezime = c.String(),
                        Titula = c.String(),
                        Email = c.String(),
                        JMBG = c.String(),
                        Telefon = c.String(),
                        Slika = c.String(),
                        DatumRodjenja = c.DateTime(nullable: false),
                        Spol = c.String(),
                        Username = c.String(),
                        PasswordHash = c.String(),
                        Salt = c.String(),
                        Ulica = c.String(),
                        BrojUlice = c.Int(nullable: false),
                        OpstinaId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Opstinas", t => t.OpstinaId)
                .Index(t => t.OpstinaId);
            
            CreateTable(
                "dbo.Opstinas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                        ZipCode = c.String(),
                        DrzavaId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Drzavas", t => t.DrzavaId)
                .Index(t => t.DrzavaId);
            
            CreateTable(
                "dbo.LogPrijavas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DatumVrijeme = c.DateTime(nullable: false),
                        IPadresa = c.String(),
                        Browser = c.String(),
                        Uspjesnost = c.Boolean(nullable: false),
                        KlijentId = c.Int(),
                        RadnikId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Klijents", t => t.KlijentId)
                .ForeignKey("dbo.Radniks", t => t.RadnikId)
                .Index(t => t.KlijentId)
                .Index(t => t.RadnikId);
            
            CreateTable(
                "dbo.Radniks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ime = c.String(),
                        Prezime = c.String(),
                        Titula = c.String(),
                        Email = c.String(),
                        JMBG = c.String(),
                        Telefon = c.String(),
                        Slika = c.String(),
                        DatumRodjenja = c.DateTime(nullable: false),
                        Spol = c.String(),
                        Username = c.String(),
                        PasswordHash = c.String(),
                        Salt = c.String(),
                        Ulica = c.String(),
                        BrojUlice = c.Int(nullable: false),
                        OpstinaId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Opstinas", t => t.OpstinaId)
                .Index(t => t.OpstinaId);
            
            CreateTable(
                "dbo.Obavijests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sadrzaj = c.String(),
                        DatumVrijeme = c.DateTime(nullable: false),
                        Naslov = c.String(),
                        RadnikId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Radniks", t => t.RadnikId)
                .Index(t => t.RadnikId);
            
            CreateTable(
                "dbo.Porukas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DatumVrijeme = c.DateTime(nullable: false),
                        Naslov = c.String(),
                        Sadrzaj = c.String(),
                        KlijentId = c.Int(),
                        RadnikId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Klijents", t => t.KlijentId)
                .ForeignKey("dbo.Radniks", t => t.RadnikId)
                .Index(t => t.KlijentId)
                .Index(t => t.RadnikId);
            
            CreateTable(
                "dbo.Predlozaks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NazivPredloska = c.String(),
                        SvrhaDoznake = c.String(),
                        Primaoc = c.String(),
                        RacunPrimaoca = c.String(),
                        Datum = c.DateTime(nullable: false),
                        Iznos = c.Double(nullable: false),
                        Hitno = c.Boolean(nullable: false),
                        BrPoreznogObveznika = c.String(),
                        VrstaPrihoda = c.String(),
                        VrstaUplate = c.String(),
                        PocetakPoreznogPerioda = c.DateTime(nullable: false),
                        KrajPoreznogPerioda = c.DateTime(nullable: false),
                        BudzetskaOrganizacija = c.String(),
                        PozivNaBroj = c.String(),
                        RacunId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Racuns", t => t.RacunId)
                .Index(t => t.RacunId);
            
            CreateTable(
                "dbo.Racuns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Stanje = c.Single(nullable: false),
                        DatumOtvaranja = c.DateTime(nullable: false),
                        Aktivan = c.Boolean(nullable: false),
                        Valuta = c.String(),
                        Limit = c.Single(nullable: false),
                        KorisnikId = c.Int(),
                        RadnikId = c.Int(),
                        Klijent_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Klijents", t => t.Klijent_Id)
                .ForeignKey("dbo.Radniks", t => t.RadnikId)
                .Index(t => t.RadnikId)
                .Index(t => t.Klijent_Id);
            
            CreateTable(
                "dbo.Stednjas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PocetakStednje = c.DateTime(nullable: false),
                        KrajStednje = c.DateTime(nullable: false),
                        IznosOrocenja = c.Double(nullable: false),
                        MjesecniIznos = c.Double(nullable: false),
                        KamatnaStopa = c.Double(nullable: false),
                        RacunId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Racuns", t => t.RacunId)
                .Index(t => t.RacunId);
            
            CreateTable(
                "dbo.TipZahtjevas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Transakcijas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Iznos = c.Double(nullable: false),
                        DatumVrijeme = c.DateTime(nullable: false),
                        Valuta = c.String(),
                        Opis = c.String(),
                        Eksterna = c.Boolean(nullable: false),
                        IznosPoreza = c.Double(),
                        RacunId = c.Int(),
                        UplatnicaId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Racuns", t => t.RacunId)
                .ForeignKey("dbo.Uplatnicas", t => t.UplatnicaId)
                .Index(t => t.RacunId)
                .Index(t => t.UplatnicaId);
            
            CreateTable(
                "dbo.Uplatnicas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SvrhaDoznake = c.String(),
                        Primaoc = c.String(),
                        RacunPrimaoca = c.String(),
                        Datum = c.DateTime(nullable: false),
                        Iznos = c.Single(nullable: false),
                        Hitno = c.Boolean(nullable: false),
                        BrPoreznogObveznika = c.String(),
                        VrstaPrihoda = c.String(),
                        VrstaUplate = c.String(),
                        PocetakPoreznogPerioda = c.DateTime(nullable: false),
                        KrajPoreznogPerioda = c.DateTime(nullable: false),
                        BudzetskaOrganizacija = c.String(),
                        PozivNaBroj = c.String(),
                        RacunId = c.Int(),
                        KlijentId = c.Int(),
                        RadnikId = c.Int(),
                        PredlozakId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Klijents", t => t.KlijentId)
                .ForeignKey("dbo.Predlozaks", t => t.PredlozakId)
                .ForeignKey("dbo.Racuns", t => t.RacunId)
                .ForeignKey("dbo.Radniks", t => t.RadnikId)
                .Index(t => t.RacunId)
                .Index(t => t.KlijentId)
                .Index(t => t.RadnikId)
                .Index(t => t.PredlozakId);
            
            CreateTable(
                "dbo.Zahtijevs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Opis = c.String(),
                        DatumKreiranja = c.DateTime(nullable: false),
                        Status = c.String(),
                        KlijentId = c.Int(),
                        RadnikId = c.Int(),
                        TipZahtjevaId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Klijents", t => t.KlijentId)
                .ForeignKey("dbo.Radniks", t => t.RadnikId)
                .ForeignKey("dbo.TipZahtjevas", t => t.TipZahtjevaId)
                .Index(t => t.KlijentId)
                .Index(t => t.RadnikId)
                .Index(t => t.TipZahtjevaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Zahtijevs", "TipZahtjevaId", "dbo.TipZahtjevas");
            DropForeignKey("dbo.Zahtijevs", "RadnikId", "dbo.Radniks");
            DropForeignKey("dbo.Zahtijevs", "KlijentId", "dbo.Klijents");
            DropForeignKey("dbo.Transakcijas", "UplatnicaId", "dbo.Uplatnicas");
            DropForeignKey("dbo.Uplatnicas", "RadnikId", "dbo.Radniks");
            DropForeignKey("dbo.Uplatnicas", "RacunId", "dbo.Racuns");
            DropForeignKey("dbo.Uplatnicas", "PredlozakId", "dbo.Predlozaks");
            DropForeignKey("dbo.Uplatnicas", "KlijentId", "dbo.Klijents");
            DropForeignKey("dbo.Transakcijas", "RacunId", "dbo.Racuns");
            DropForeignKey("dbo.Stednjas", "RacunId", "dbo.Racuns");
            DropForeignKey("dbo.Predlozaks", "RacunId", "dbo.Racuns");
            DropForeignKey("dbo.Racuns", "RadnikId", "dbo.Radniks");
            DropForeignKey("dbo.Racuns", "Klijent_Id", "dbo.Klijents");
            DropForeignKey("dbo.Porukas", "RadnikId", "dbo.Radniks");
            DropForeignKey("dbo.Porukas", "KlijentId", "dbo.Klijents");
            DropForeignKey("dbo.Obavijests", "RadnikId", "dbo.Radniks");
            DropForeignKey("dbo.LogPrijavas", "RadnikId", "dbo.Radniks");
            DropForeignKey("dbo.Radniks", "OpstinaId", "dbo.Opstinas");
            DropForeignKey("dbo.LogPrijavas", "KlijentId", "dbo.Klijents");
            DropForeignKey("dbo.Klijents", "OpstinaId", "dbo.Opstinas");
            DropForeignKey("dbo.Opstinas", "DrzavaId", "dbo.Drzavas");
            DropIndex("dbo.Zahtijevs", new[] { "TipZahtjevaId" });
            DropIndex("dbo.Zahtijevs", new[] { "RadnikId" });
            DropIndex("dbo.Zahtijevs", new[] { "KlijentId" });
            DropIndex("dbo.Uplatnicas", new[] { "PredlozakId" });
            DropIndex("dbo.Uplatnicas", new[] { "RadnikId" });
            DropIndex("dbo.Uplatnicas", new[] { "KlijentId" });
            DropIndex("dbo.Uplatnicas", new[] { "RacunId" });
            DropIndex("dbo.Transakcijas", new[] { "UplatnicaId" });
            DropIndex("dbo.Transakcijas", new[] { "RacunId" });
            DropIndex("dbo.Stednjas", new[] { "RacunId" });
            DropIndex("dbo.Racuns", new[] { "Klijent_Id" });
            DropIndex("dbo.Racuns", new[] { "RadnikId" });
            DropIndex("dbo.Predlozaks", new[] { "RacunId" });
            DropIndex("dbo.Porukas", new[] { "RadnikId" });
            DropIndex("dbo.Porukas", new[] { "KlijentId" });
            DropIndex("dbo.Obavijests", new[] { "RadnikId" });
            DropIndex("dbo.Radniks", new[] { "OpstinaId" });
            DropIndex("dbo.LogPrijavas", new[] { "RadnikId" });
            DropIndex("dbo.LogPrijavas", new[] { "KlijentId" });
            DropIndex("dbo.Opstinas", new[] { "DrzavaId" });
            DropIndex("dbo.Klijents", new[] { "OpstinaId" });
            DropTable("dbo.Zahtijevs");
            DropTable("dbo.Uplatnicas");
            DropTable("dbo.Transakcijas");
            DropTable("dbo.TipZahtjevas");
            DropTable("dbo.Stednjas");
            DropTable("dbo.Racuns");
            DropTable("dbo.Predlozaks");
            DropTable("dbo.Porukas");
            DropTable("dbo.Obavijests");
            DropTable("dbo.Radniks");
            DropTable("dbo.LogPrijavas");
            DropTable("dbo.Opstinas");
            DropTable("dbo.Klijents");
            DropTable("dbo.Drzavas");
        }
    }
}
