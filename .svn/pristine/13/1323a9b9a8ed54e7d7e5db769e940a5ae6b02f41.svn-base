using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBanking.Data.Models {

    public enum TipRacuna{  Tekuci = 1, Ziro, Studentski, Penzionerski, Devizni };

    public class Racun : BaseEntity {
        public double Stanje { get; set; }
        public string DatumOtvaranja { get; set; }
        public bool IsDeleted { get; set; }
        public string Valuta { get; set; }
        public double Limit { get; set; }
        public TipRacuna TipRacuna { get;set;}
        public string BrojRacuna { get; set; }
        // FK  

        public int? KlijentId { get; set; }
        public virtual Klijent Klijent{ get; set; }

        public int? RadnikId { get; set; }
        public virtual Radnik Radnik { get; set; }



    }
}
