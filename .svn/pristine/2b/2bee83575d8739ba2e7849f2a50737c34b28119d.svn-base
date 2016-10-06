using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBanking.Web.Areas.ModulKorisnik.ViewModels {
    public class UplatnicaZaJPVM {
               
        public string UplatioJe { get; set; }
        [Required(ErrorMessage = "Svrha doznake je obavezno polje!")]
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
        public string Datum { get; set; }
        public int StatusUplatnice { get; set; }

        public int KlijentId { get; set; }
        public int? RadnikId { get; set; }

        public int RacunId { get; set; }
        public List<SelectListItem> racuni { get; set; }
        //-------------------------------------------------------------------------
        [RegularExpression("^[0-9]*$", ErrorMessage = "Broj poreznog obveznika se mora sastoji samo od brojeva!")]
        [StringLength(13, MinimumLength = 13, ErrorMessage = "Broj poreznog obveznika mora da ima 13 brojeva!")]
        [Required(ErrorMessage = "Broj poreznog obveznika je obavezno polje!")]
        public string BrPoreznogObveznika { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Vrsta prihoda se mora sastoji samo od brojeva!")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "Vrsta prihoda mora da ima 6 brojeva!")]
        [Required(ErrorMessage = "Vrsta prihoda je obavezno polje!")]
        public string VrstaPrihoda { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Općina se mora sastoji samo od brojeva!")]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "Općina mora da ima 3 broja!")]
        public string Opcina { get; set; }
        [Required(ErrorMessage = "Početak poreznog perioda je obavezno polje!")]
        public string PocetakPoreznogPerioda { get; set; } //datum
        [Required(ErrorMessage = "Kraj poreznog perioda je obavezno polje!")]
        public string KrajPoreznogPerioda { get; set; } // datum
        [RegularExpression("^[0-9]*$", ErrorMessage = "Budžetska organizacija se mora sastoji samo od brojeva!")]
        [StringLength(7, MinimumLength = 7, ErrorMessage = "Budžetska organizacija mora da ima 7 brojeva!")]
        [Required(ErrorMessage = "Budžetska organizacija je obavezno polje!")]
        public string BudzetskaOrganizacija { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Poziv na broj se mora sastoji samo od brojeva!")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Poziv na broj mora da ima 10 brojeva!")]
        [Required(ErrorMessage = "Poziv na broj je obavezno polje!")]
        public string PozivNaBroj { get; set; }

        

    }
}