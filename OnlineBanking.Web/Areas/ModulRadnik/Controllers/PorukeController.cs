using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineBanking.Web.ViewModels;
using OnlineBanking.Web.Helper;
using OnlineBanking.Web.Areas.ModulRadnik.ViewModels;
using OnlineBanking.Data.DAL;
using OnlineBanking.Data.Models;
using System.Data.Entity;

namespace OnlineBanking.Web.Areas.ModulRadnik.Controllers
{
    [Autorizacija(dozvoljenoZaRadnika: true, dozvoljenoZaKorisnika: false)]

    public class PorukeController : Controller {
        DL_Context db = new DL_Context();
        // GET: ModulRadnik/Poruke
        public ActionResult Index() {
            return View();
        }

        public ActionResult ProcitajPoruku(int PorukaId) {
            OdgovorNaPorukuVM model = new OdgovorNaPorukuVM();
            Poruka poruka = db.Poruka.Include(x => x.Klijent).Where(y => y.Id == PorukaId).SingleOrDefault();
            model.Sadrzaj = poruka.Sadrzaj;
            model.Naslov = poruka.Naslov;
            model.ImePrezime = poruka.Klijent.Ime + " " + poruka.Klijent.Prezime;
            model.KlijentId = poruka.KlijentId;
            model.RadnikId = Autentifikacija.GetLogiraniKorisnik(HttpContext).Id;       
            model.PorukaId = PorukaId;

            return View(model);
        }
        [ValidateAntiForgeryToken]
        public ActionResult OdgovorNaPoruku(OdgovorNaPorukuVM model) {
            Poruka poruka = db.Poruka.Include(x => x.Klijent).Where(y => y.Id == model.PorukaId ).SingleOrDefault();
            OdgovorNaPorukuVM modelOdgovor = new OdgovorNaPorukuVM();
            modelOdgovor.KlijentId = poruka.KlijentId;
            modelOdgovor.RadnikId = model.RadnikId;
            modelOdgovor.Naslov = poruka.Naslov;
            modelOdgovor.PorukaId = poruka.Id;
            modelOdgovor.ImePrezime = poruka.Klijent.Ime + " " + poruka.Klijent.Prezime;
            ModelState.Clear();
            return View(modelOdgovor);
        }
        [ValidateAntiForgeryToken]
        public ActionResult SnimiOdgovorNaPoruku(OdgovorNaPorukuVM model) {

            if (!ModelState.IsValid) {
                return View("OdgovorNaPoruku", model);
            }
            Poruka poruka = new Poruka();
            poruka.DatumVrijeme = DateTime.Now.ToString();
            poruka.Odgovorena = true;
            poruka.KlijentId = model.KlijentId;
            poruka.RadnikId = model.RadnikId;
            poruka.Sadrzaj = model.Sadrzaj;
            poruka.Naslov = model.Naslov;
            Poruka korisnikPoruka = db.Poruka.Find(model.PorukaId);
            korisnikPoruka.Odgovorena = true;
            db.Poruka.Add(poruka);
            db.SaveChanges();

            ViewData["PoslanaPoruka"] = "Poruka je uspješno poslana!";
            ModelState.Clear();
            return View("OdgovorNaPoruku");
        }
        
        public ActionResult PrikaziPrimljenePoruke() {
            // nije potreban uslov x.odgovorena == false, ali za sada neka stoji
            List<Poruka> PrimljenePoruke = db.Poruka.Where(x => x.Odgovorena == false && x.RadnikId == null).Include(x => x.Klijent).ToList();
            return View(PrimljenePoruke);
        }
        public ActionResult PrikaziPoslanePoruke()
        {
            int RadnikId = Autentifikacija.GetLogiraniKorisnik(HttpContext).Id;
            List<Poruka> PoslanePoruke = db.Poruka.Where(x => x.IsDeletedRadnik == false && x.RadnikId == RadnikId).Include(x => x.Radnik).ToList();
            return View(PoslanePoruke);
        }
        public ActionResult ProcitajPoslanuPoruku(int PorukaId)
        {
            OdgovorNaPorukuVM model = new OdgovorNaPorukuVM();
            Poruka poruka = db.Poruka.Include(x => x.Klijent).Where(y => y.Id == PorukaId).SingleOrDefault();
            model.Sadrzaj = poruka.Sadrzaj;
            model.Naslov = poruka.Naslov;
            model.ImePrezime = poruka.Klijent.Ime + " " + poruka.Klijent.Prezime;
            model.PorukaId = PorukaId;

            return View(model);
        }
        [ValidateAntiForgeryToken]
        public ActionResult ObrisiPoslanuPoruku(OdgovorNaPorukuVM model)
        {
            Poruka poruka = db.Poruka.Find(model.PorukaId);
            poruka.IsDeletedRadnik = true;
            db.SaveChanges();
            ViewData["PorukaObrisana"] = "Poruka je uspješno obrisana!";
            ModelState.Clear();
            return View("ProcitajPoslanuPoruku");
        }
        public ActionResult ObrisiPoslanuPorukuBtn(int PorukaId)
        {
            Poruka poruka = db.Poruka.Find(PorukaId);
            poruka.IsDeletedRadnik = true;
            db.SaveChanges();
            ModelState.Clear();
            return RedirectToAction("PrikaziPoslanePoruke");
        }
    }
}