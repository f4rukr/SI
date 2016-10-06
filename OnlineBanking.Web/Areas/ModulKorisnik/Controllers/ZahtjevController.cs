using OnlineBanking.Data.DAL;
using OnlineBanking.Data.Models;
using OnlineBanking.Web.Areas.ModulKorisnik.ViewModels;
using OnlineBanking.Web.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace OnlineBanking.Web.Areas.ModulKorisnik.Controllers {
    [Autorizacija(dozvoljenoZaRadnika: false, dozvoljenoZaKorisnika: true)]

    public class ZahtjevController : Controller {

        // GET: ModulKorisnik/Zahtjev
        private DL_Context db = new DL_Context();

        public ActionResult Index() {
            return View();
        }
        public ActionResult NoviZahtjev(int? uspjeh) {
            NoviZahtjevVM model = new NoviZahtjevVM();
            model.KlijentId = Autentifikacija.GetLogiraniKorisnik(HttpContext).Id;
            model.DatumKreiranja = DateTime.Now.ToString();
            model.TipZahtjevaId = 1;
            model.tipoviRacuna = GetTipoviRacuna();
            model.valute = GetValute();
            if (uspjeh == 1) {
                ViewData["ZahtjevPoslan"] = "Novi zahtjev je uspješno poslan.";
                model.DatumKreiranja = "";
            }
            return View(model);
        }
        [ValidateAntiForgeryToken()]
        public ActionResult SnimiNoviZahtjev(NoviZahtjevVM model) {
            if (!ModelState.IsValid) {
                model.tipoviRacuna = GetTipoviRacuna();
                model.valute = GetValute();
                return View("NoviZahtjev", model);
            }
            Zahtjev noviZahtjev = new Zahtjev();
            noviZahtjev.RadnikId = null;
            noviZahtjev.KlijentId = model.KlijentId;
            noviZahtjev.TipZahtjevaId = model.TipZahtjevaId;
            noviZahtjev.TipRacunaId = model.TipRacunaId;
            noviZahtjev.DatumKreiranja = model.DatumKreiranja;
            noviZahtjev.Opis = model.Opis;
            noviZahtjev.Status = "Na obradi";
            noviZahtjev.TipValute = model.TipValute;
            db.Zahtjevi.Add(noviZahtjev);

            Notifikacija notifikacija = new Notifikacija();
            notifikacija.Sadrzaj = model.Opis;
            notifikacija.DatumVrijeme = DateTime.Now.ToString();
            notifikacija.ZahtjevId = noviZahtjev.Id;
            notifikacija.Naslov = "Zahtjev za novi bankovni račun";
            db.Notifikacije.Add(notifikacija);
            db.SaveChanges();
            ModelState.Clear();
            return RedirectToAction("NoviZahtjev", new { uspjeh = 1 });
        }

        public ActionResult ZahtjevZaBrisanjeBankovnogRacuna(int? uspjeh) {
            ZahtjevBrisanjeRacunaVM model = new ZahtjevBrisanjeRacunaVM();
            model.KlijentId = Autentifikacija.GetLogiraniKorisnik(HttpContext).Id;
            model.TipZahtjevaId = 3;
            model.DatumKreiranja = DateTime.Now.ToString();

            List<Racun> ListaRacuna = db.Racuni.Where(x => x.KlijentId == model.KlijentId && x.IsDeleted == false).ToList();
            model.racuni = new List<SelectListItem>();
            model.racuni.Add(new SelectListItem { Value = "0", Text = "Odaberite račun" }); 
            model.racuni.AddRange(ListaRacuna.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = (TipRacuna)x.TipRacuna + " - " + x.BrojRacuna }));

            if (uspjeh == 1) {
                ViewData["ZahtjevPoslan"] = "Novi zahtjev je uspješno poslan.";
                model.DatumKreiranja = "";
            }
            return View(model);
        }
        [ValidateAntiForgeryToken()]
        public ActionResult SnimiZahtjevZaBrisanjeBankovnogRacuna(ZahtjevBrisanjeRacunaVM model) {
            if (!ModelState.IsValid) {
                List<Racun> ListaRacuna = db.Racuni.Where(x => x.KlijentId == model.KlijentId && x.IsDeleted == false).ToList();
                model.racuni = new List<SelectListItem>();
                model.racuni.Add(new SelectListItem { Value = "0", Text = "Odaberite račun" });
                model.racuni.AddRange(ListaRacuna.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.BrojRacuna })); 

                return View("ZahtjevZaBrisanjeBankovnogRacuna", model);
            }
            Racun racun = db.Racuni.Where(x => x.Id == model.RacunId).SingleOrDefault();
            Zahtjev noviZahtjev = new Zahtjev();
            noviZahtjev.RadnikId = null;
            noviZahtjev.KlijentId = model.KlijentId;
            noviZahtjev.TipZahtjevaId = model.TipZahtjevaId;
            noviZahtjev.DatumKreiranja = model.DatumKreiranja;
            noviZahtjev.RacunId = model.RacunId;
            noviZahtjev.TipRacunaId = (int)racun.TipRacuna;
            noviZahtjev.Opis = model.Opis;
            noviZahtjev.Status = "Na obradi";
            db.Zahtjevi.Add(noviZahtjev);

            Notifikacija notifikacija = new Notifikacija();
            notifikacija.Sadrzaj = model.Opis;
            notifikacija.DatumVrijeme = DateTime.Now.ToString();
            notifikacija.ZahtjevId = noviZahtjev.Id;
            notifikacija.Naslov = "Zahtjev za brisanje bankovnog računa";
            db.Notifikacije.Add(notifikacija);
            db.SaveChanges();
            ModelState.Clear();

            return RedirectToAction("ZahtjevZaBrisanjeBankovnogRacuna", new { uspjeh = 1 });
        }

        private List<SelectListItem> GetTipoviRacuna() {
            return (Enum.GetValues(typeof(TipRacuna))
                    .Cast<TipRacuna>()
                    .Select(x => new SelectListItem { Text = x.ToString(), Value = ((int)x).ToString() })).ToList();
        }

        //private List<SelectListItem> GetTipoveZahtjeva() {
        //    List<SelectListItem> tipoviZahtjeva = new List<SelectListItem>();
        //    tipoviZahtjeva.Add(new SelectListItem { Value = "0", Text = "Odaberite zahtjev" });
        //    tipoviZahtjeva.AddRange(db.TipoviZahtjeva.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Naziv }));
        //    return tipoviZahtjeva;
        //}
        private List<SelectListItem> GetValute()
        {
            List<SelectListItem> valute = new List<SelectListItem>();
            valute.Add(new SelectListItem { Value = "0", Text = "Odaberite valutu" });
            valute.Add(new SelectListItem { Value = "BAM", Text = "BAM" });
            valute.Add(new SelectListItem { Value = "Euro", Text = "Euro" });
            valute.Add(new SelectListItem { Value = "GBP", Text = "GBP" });
            valute.Add(new SelectListItem { Value = "CHF", Text = "CHF" });
            valute.Add(new SelectListItem { Value = "USD", Text = "USD" });
            valute.Add(new SelectListItem { Value = "CAD", Text = "CAD" });
            return valute;

        }
    }
}