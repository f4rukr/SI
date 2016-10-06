using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBanking.Data.Models {
    public class Transakcija : BaseEntity {

        public double Iznos { get; set; }
        public DateTime DatumVrijeme { get; set; }
        public string Valuta { get; set; }
        public string Opis { get; set; }
        public bool Eksterna { get; set; }
        public double? IznosPoreza { get; set; }


        // FK kljucevi

        public int? RacunId { get; set; }
        public virtual Racun Racun { get; set; }

        public int? UplatnicaId { get; set; }
        public virtual Uplatnica Uplatnica { get; set; }  //ali će imati max 1 transakciju
    }
}
