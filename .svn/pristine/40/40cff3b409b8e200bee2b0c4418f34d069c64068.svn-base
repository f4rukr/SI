using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBanking.Data.Models {
    public class Klijent : BaseEntity {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string JMBG { get; set; }
        public string Telefon { get; set; }
        public string SlikaPath { get; set; }
        public string DatumRodjenja { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Ulica { get; set; }
        public string BrojUlice { get; set; }
        public int BrojPokusajaLogiranja { get; set; }
        public bool IsDeleted { get; set; }

        // FK
        public int? OpstinaId { get; set; }
        public virtual Opstina Opstina { get; set; }

    }
}
