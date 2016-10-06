using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBanking.Data.Models {
    public class Opstina : BaseEntity {
        public string Naziv { get; set; }
        public string BrojOpstine { get; set; }

        // FK
        public int? DrzavaId { get; set; }
        public virtual Drzava Drzava { get; set; }
    }
}
