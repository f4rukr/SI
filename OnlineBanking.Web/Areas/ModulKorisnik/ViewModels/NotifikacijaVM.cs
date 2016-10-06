using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBanking.Web.Areas.ModulKorisnik.ViewModels
{
    public class NotifikacijaVM
    {
        public bool Procitana { get; set; }
        public string DatumVrijeme { get; set; }
        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }
        public bool Uspjeh { get; set; }
        public int? KlijentId { get; set; }
    }
}