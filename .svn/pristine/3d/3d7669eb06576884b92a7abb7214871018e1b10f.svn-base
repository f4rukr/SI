using OnlineBanking.Data.DAL;
using OnlineBanking.Data.Models;
using OnlineBanking.Web.Areas.ModulKorisnik.ViewModels;
using OnlineBanking.Web.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBanking.Web.Areas.ModulKorisnik.Controllers
{
    [Autorizacija(dozvoljenoZaRadnika: false, dozvoljenoZaKorisnika: true)]
    public class NotifikacijaController : Controller
    {
        // GET: ModulKorisnik/Notifikacija
        DL_Context db = new DL_Context();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PrikaziSveNotifikacije(int KlijentId)
        {
            List<Notifikacija> lista = db.Notifikacije.Where(x => x.KlijentId == KlijentId).ToList();
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
            model.KlijentId = Autentifikacija.GetLogiraniKorisnik(HttpContext).Id;
            return View(model);
        }
    }
}