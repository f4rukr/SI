using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBanking.Data.Models
{
    public class Notifikacija : BaseEntity
    {
        public bool Procitana { get; set; }
        public string DatumVrijeme { get; set; }
        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }
        public int Uspjeh { get; set; }
        public int? ObavijestId { get; set; }
        public int? KlijentId { get; set; }
        public virtual Klijent Klijent { get; set; }

        public int? ZahtjevId { get; set; }
        public virtual Zahtjev Zahtjev { get; set; }
    }
}
