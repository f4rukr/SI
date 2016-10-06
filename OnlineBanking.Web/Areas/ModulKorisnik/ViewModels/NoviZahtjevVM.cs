using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace OnlineBanking.Web.Areas.ModulKorisnik.ViewModels {

    public class NoviZahtjevVM {
        public int KlijentId { get; set; }
        public int? RadnikId { get; set; }

        [Required(ErrorMessage = "Opis je obavezno polje!")]
        public string Opis { get; set; }

        public string Status { get; set; }
        public string DatumKreiranja { get; set; }

        public int TipRacunaId { get; set; }

        [StringLength(30, MinimumLength = 2, ErrorMessage = "Valuta je obavezno polje!")]
        public string TipValute { get; set; }
        public List<SelectListItem> valute { get; set; }
        public List<SelectListItem> tipoviRacuna { get; set; }
        public int TipZahtjevaId { get; set; }
    }
}