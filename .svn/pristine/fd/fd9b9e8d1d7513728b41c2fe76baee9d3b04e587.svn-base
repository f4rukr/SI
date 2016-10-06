using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBanking.Web.Areas.ModulRadnik.ViewModels
{
    public class NoviRacunVM
    {
        [Required(ErrorMessage = "Unesite stanje")]
        public float Stanje { get; set; }
        public string DatumOtvaranja { get; set; }
        [Required (ErrorMessage ="Unesite limit")]
        public float Limit { get; set; }
        public int? TipRacunaId { get; set; }
        public int? KlijentId { get; set; }
        public int? RadnikId { get; set; }
        [Required (ErrorMessage ="Odaberite valutu")]
        public string TipValute { get; set; }
        public List<SelectListItem> valute { get; set; }

        public int? ZahtjevId { get; set; }
    }
}