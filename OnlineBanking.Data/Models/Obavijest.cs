using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBanking.Data.Models {
    public class Obavijest : BaseEntity {

        public string Sadrzaj { get; set; }
        public DateTime DatumVrijeme { get; set; }
        public string Naslov { get; set; }

        //FK
        public int? RadnikId { get; set; }
        public virtual Radnik Radnik { get; set; }
    }
}
