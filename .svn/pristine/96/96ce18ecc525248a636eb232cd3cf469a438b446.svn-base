using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineBanking.Web.Areas.ModulRadnik.ViewModels
{
    public class DodajNovuObavijestVM
    {
        public int Id { get; set; }

        [Required (ErrorMessage ="Sadržaj je obavezno polje!")]
        [StringLength (500, ErrorMessage ="Maksimalna veličina sadržaja obavijesti je 500 karaktera.")]
        public string Sadrzaj { get; set; }
        public string DatumVrijeme { get; set; }

        [Required (ErrorMessage ="Naslov je obavezno polje!")]
        [StringLength (50, ErrorMessage ="Maksimalna veličina naslova je 50 karaktera.")]
        public string Naslov { get; set; }
        public int? RadnikId { get; set; }
    }
}