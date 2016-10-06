using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBanking.Data.Models {
    public class Zahtjev : BaseEntity {

        public string Opis { get; set; }
        public string DatumKreiranja { get; set; }
        public string Status { get; set; }
        public int? TipRacunaId { get; set; }
        public int? RacunId { get; set; }
        //FK
        public  int? KlijentId { get; set; }
        public virtual Klijent Klijent { get; set; }

        public  int? RadnikId { get; set; }
        public virtual Radnik Radnik { get; set; }

        public  int? TipZahtjevaId { get; set; }
        public virtual TipZahtjeva TipZahtjeva { get; set; }
        public string TipValute { get; set; }
    }
}
