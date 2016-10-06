using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBanking.Data.Models {
    public class Poruka : BaseEntity {
        
        public string DatumVrijeme { get; set; }
        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }
        public bool Odgovorena { get; set; }
        public bool Procitana { get; set; }
        public bool IsDeletedRadnik { get; set; }
        public bool IsDeletedKlijent { get; set; }
        

        // FK 
        public int? KlijentId { get; set; }
        public virtual Klijent Klijent { get; set; }

        public int? RadnikId { get; set; }
        public virtual Radnik Radnik { get; set; }
    }
}
