using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBanking.Data.Models {
    public class Predlozak : BaseEntity {

        public string NazivPredloska { get; set; }
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
        public string PocetakPoreznogPerioda { get; set; }
        public string KrajPoreznogPerioda { get; set; }
        public string BudzetskaOrganizacija { get; set; }
        public string PozivNaBroj { get; set; }
        public int KlijentId { get; set; }
        public string VrstaPredloska { get; set; }
        public bool IsDeleted { get; set; }

        // FK 
        public int RacunId { get; set; }
        public virtual Racun Racun { get; set; }
    }
}
