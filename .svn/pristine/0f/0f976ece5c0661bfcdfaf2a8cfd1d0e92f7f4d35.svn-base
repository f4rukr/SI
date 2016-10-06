using OnlineBanking.Data.DAL;
using OnlineBanking.Data.Models;
using OnlineBanking.Web.Areas.ModulRadnik.ViewModels;
using OnlineBanking.Web.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBanking.Web.Areas.ModulRadnik.Controllers
{
    [Autorizacija(dozvoljenoZaRadnika: true, dozvoljenoZaKorisnika: false)]
    public class NotifikacijaController : Controller
    {
        // GET: ModulKorisnik/Notifikacija
        DL_Context db = new DL_Context();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PrikaziSveNotifikacije()
        {
            List<Notifikacija> lista = db.Notifikacije.Where(x => x.ZahtjevId != null).ToList();
            return View(lista);
        }
        public ActionResult ProcitajNotifikaciju(int NotifikacijaId)
        {
            Notifikacija notifikacija = new Notifikacija();
            notifikacija = db.Notifikacije.Find(NotifikacijaId);
            notifikacija.Procitana = true;
            db.SaveChanges();
            NotifikacijaVM model = new NotifikacijaVM();
            model.DatumVrijeme = notifikacija.DatumVrijeme;
            model.Naslov = notifikacija.Naslov;
            model.Sadrzaj = notifikacija.Sadrzaj;
            return View(model);
        }
    }
}