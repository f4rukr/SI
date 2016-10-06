namespace OnlineBanking.Data.Models {

    public enum StatusUplatnice { NaObradi = 1, Odobrena, Odbijena };

    public class Uplatnica : BaseEntity {
        public string UplatioJe { get; set; }
        public string SvrhaDoznake { get; set; }
        public string Primaoc { get; set; }
        public string RacunPrimaoca { get; set; }
        public string Datum { get; set; }
        public double Iznos { get; set; }
        public bool Hitno { get; set; }
        public string BrPoreznogObveznika { get; set; }
        public string VrstaPrihoda { get; set; }
        public string Opcina { get; set; }
        public string PocetakPoreznogPerioda { get; set; } //datum
        public string KrajPoreznogPerioda { get; set; } // datum
        public string BudzetskaOrganizacija { get; set; }
        public string PozivNaBroj { get; set; }
        public StatusUplatnice StatusUplatnice { get; set; }

        // FK kljucevi
        public int? RacunId { get; set; }
        public virtual Racun Racun { get; set; }

        public int? KlijentId { get; set; }
        public virtual Klijent Klijent { get; set; }

        public int? RadnikId { get; set; }
        public virtual Radnik Radnik { get; set; }

        public int? PredlozakId { get; set; }
        public virtual Predlozak Predlozak { get; set; }
    }
}