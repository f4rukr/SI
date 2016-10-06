using OnlineBanking.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineBanking.Web.Areas.ModulRadnik.ViewModels {
    public class OdgovorNaPorukuVM {
        public int? KlijentId { get; set; }
        public int? RadnikId { get; set; }
        public string Naslov { get; set; }
        [Required (ErrorMessage ="Sadržaj je obavezno polje!")]
        [StringLength(300, ErrorMessage ="Maksimalan broj karaktera u poruci je 300!" )]
        public string Sadrzaj { get; set; }
        public int PorukaId { get; set; }
        public string ImePrezime { get; set; }

    }
}