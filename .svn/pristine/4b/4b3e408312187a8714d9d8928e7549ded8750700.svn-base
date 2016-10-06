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

    public class ObavijestiController : Controller
    {
        DL_Context db = new DL_Context();
        // GET: ModulRadnik/Obavijesti
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PrikaziObavijesti()
        {
            List<Obavijest> obavijesti = db.Obavijesti.ToList();
            return View(obavijesti);
        }
        public ActionResult DodajNovuObavijest()
        {
            DodajNovuObavijestVM model = new DodajNovuObavijestVM();
            model.RadnikId = Autentifikacija.GetLogiraniKorisnik(HttpContext).Id;
            return View(model);
        }
        [ValidateAntiForgeryToken]
        public ActionResult SnimiObavijest(DodajNovuObavijestVM model)
        {
            if (!ModelState.IsValid)
            {
                return View("DodajNovuObavijest",model);
            }
            Obavijest obavijest = new Obavijest();
            obavijest.RadnikId = model.RadnikId;
            obavijest.Naslov = model.Naslov;
            obavijest.Sadrzaj = model.Sadrzaj;
            obavijest.DatumVrijeme = DateTime.Now;
            db.Obavijesti.Add(obavijest);
            db.SaveChanges();
            
            int[] pk = db.Klijenti.Select(x => x.Id).ToArray();
            foreach (int item in pk)
            {
                Notifikacija notifikacija = new Notifikacija();
                notifikacija.DatumVrijeme = DateTime.Now.ToString();
                notifikacija.Naslov = obavijest.Naslov;
                notifikacija.Sadrzaj = obavijest.Sadrzaj;
                notifikacija.Uspjeh = 2;
                notifikacija.ObavijestId = obavijest.Id;
                notifikacija.KlijentId = item;
                db.Notifikacije.Add(notifikacija);
            }

            db.SaveChanges();
            ViewData["ObavijestPoslana"] = "Obavijest je uspješno postavljena!";
            ModelState.Clear();
            return View("DodajNovuObavijest");
        }
        public ActionResult PrikaziObavijest(int ObavijestId)
        {   
            return View(db.Obavijesti.Find(ObavijestId));
        }
        public ActionResult ObrisiObavijest(int ObavijestId)
        {
            Obavijest obavijest = db.Obavijesti.Find(ObavijestId);
            db.Obavijesti.Remove(obavijest);
            db.SaveChanges();
            ViewData["ObavijestObrisana"] = "Obavijest je uspješno obrisana!";
            ModelState.Clear();
            return View("PrikaziObavijest");
        }
        public ActionResult ObrisiObavijestIzListe(int ObavijestId)
        {
            Obavijest obavijest = db.Obavijesti.Find(ObavijestId);
            db.Obavijesti.Remove(obavijest);
            db.SaveChanges();
            return RedirectToAction("PrikaziObavijesti");
        }
        public ActionResult PrikaziMojeObavijesti()
        {
            int RadnikId = Autentifikacija.GetLogiraniKorisnik(HttpContext).Id;
            List<Obavijest> obavijesti = db.Obavijesti.Where(x => x.RadnikId == RadnikId).ToList();
            return View("PrikaziObavijesti", obavijesti);
        }
    }
}