using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBanking.Data.Models {
    public class LogPrijava : BaseEntity {

        public string DatumVrijeme { get; set; }
        public string IPadresa { get; set; }
        public string Browser { get; set; }
        public bool Uspjesnost { get; set; }
        

        // FK

        public int? KlijentId { get; set; }
        public virtual Klijent Klijent { get; set; }

        public int? RadnikId { get; set; }
        public virtual Radnik Radnik { get; set; }
    }
}
