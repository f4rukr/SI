using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBanking.Web.Areas.ModulKorisnik.ViewModels {
    public class UplatnicaZaPrenosVM {
      
        [Required(ErrorMessage = "Naziv predloška je obavezno polje!")]
        public string NazivPredloska { get; set; }
        public string UplatioJe { get; set; }
        [Required(ErrorMessage = "SvrhaDoznake je obavezno polje!")]
        public string SvrhaDoznake { get; set; }
        [Required(ErrorMessage = "Primaoc je obavezno polje!")]
        public string Primaoc { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Račun primaoca se mora sastoji samo od brojeva!")]
        [StringLength(16, MinimumLength = 16, ErrorMessage = "Račun primaoca mora da ima 16 brojeva!")]
        [Required(ErrorMessage = "Račun primaoca je obavezno polje!")]
        public string RacunPrimaoca { get; set; }
        [Required(ErrorMessage = "Iznos je obavezno polje!")]
        [Range(1, Int32.MaxValue, ErrorMessage = "Iznos ne može biti 0 ili negativan!")]
        public double Iznos { get; set; }
        public bool Hitno { get; set; }
        public int KlijentId { get; set; }
        public int? RadnikId { get; set; }
        public int RacunId { get; set; }
 

        public List<SelectListItem> racuni { get; set; }
    }
}