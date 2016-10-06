using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBanking.Web.Areas.ModulKorisnik.ViewModels {
    public class ZahtjevBrisanjeRacunaVM {
        public int KlijentId { get; set; }
        public int? RadnikId { get; set; }
        public int TipZahtjevaId { get; set; }
        public int TipRacunaId { get; set; }

        [Required(ErrorMessage = "Opis je obavezno polje!")]
        public string Opis { get; set; }

        public string Status { get; set; }
        public string DatumKreiranja { get; set; }

        public int RacunId { get; set; }
        public List<SelectListItem> racuni { get; set; }
    }
}