using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBanking.Data.Models {
    public class Stednja : BaseEntity {

        public string DatumKreiranja { get; set; }
        public DateTime KrajStednje { get; set; }
        public double IznosOrocenja { get; set; }
        public double IznosNaGlavnicu { get; set; }
        public string KamatnaStopa { get; set; }
        public double KoeficijentStopa { get; set; }
        public int? KlijentId { get; set; }
        public bool IsDeleted { get; set; }

        // FK
        public int? RacunId { get; set; }
        public virtual Racun Racun { get; set; }

    }
}
