using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBanking.Web.Areas.ModulKorisnik.ViewModels
{
    public class KalkulatorVM
    {
        public List<SelectListItem> mjeseciOrocenja { get; set; }
        [Range(1, Int32.MaxValue, ErrorMessage = "Rok oročenja je obavezno polje!")]
        public int MjesecOrocenjaId { get; set; }

        [Required(ErrorMessage = "Iznos je obavezno polje!")]
        [Range(1, double.MaxValue, ErrorMessage = "Iznos ne može biti 0 ili negativan!")]
        public double IznosOrocenja { get; set; }
        public double KoeficijentStopa { get; set; }
        public double UkupnoKamata { get; set; }
        public double Saldo { get; set; }
        public string KamatnaStopa { get; internal set; }
    }
}