using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBanking.Web.Areas.ModulRadnik.ViewModels
{
    public class StanjeRacunaVM
    {
        public string BrojRacuna { get; set; }
        public List<SelectListItem> tipoviRacuna { get; set; }
        public string KlijentImePrezime { get; set; }
    }
}