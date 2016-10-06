using OnlineBanking.Data.DAL;
using OnlineBanking.Data.Models;
using OnlineBanking.Web.Areas.ModulRadnik.ViewModels;
using OnlineBanking.Web.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace OnlineBanking.Web.Areas.ModulRadnik.Controllers
{
    [Autorizacija(dozvoljenoZaRadnika: true, dozvoljenoZaKorisnika: false)]

    public class UplatniceController : Controller {
        public DL_Context db = new DL_Context();

        public ActionResult Index() {
            return View();
        }

        public ActionResult PrikaziUplatnice() {
            List<Uplatnica> listaUplatnica = db.Uplatnice.Where(x => x.RadnikId == null && x.StatusUplatnice == (StatusUplatnice)1).ToList();
            return View(listaUplatnica);
        }

        public ActionResult PrikaziDetaljeUplatnice(int UplatnicaId) {
            Uplatnica uplatnica = db.Uplatnice.Find(UplatnicaId);
            UplatnicaVM model = new UplatnicaVM();
            Racun r = db.Racuni.Where(x => x.Id == uplatnica.RacunId).SingleOrDefault();
            model.UplatnicaId = uplatnica.Id;
            model.KlijentId = uplatnica.KlijentId;
            model.Klijent = db.Klijenti.Where(x => x.Id == model.KlijentId).SingleOrDefault();
            model.ImePrezimeTelefon = model.Klijent.Ime + " " + model.Klijent.Prezime;
            model.Datum = uplatnica.Datum;
            model.SvrhaDoznake = uplatnica.SvrhaDoznake;
            model.StatusUplatnice = (int)uplatnica.StatusUplatnice;
            model.Primaoc = uplatnica.Primaoc;
            model.RacunPrimaoca = uplatnica.RacunPrimaoca;
            model.Iznos = uplatnica.Iznos;
            model.Hitno = uplatnica.Hitno;
            model.RacunId = uplatnica.RacunId;
            model.BrojRacunaPošiljaoca = r.BrojRacuna;

            return View(model);
        }

        // NEDOVRŠENO
        // U slucaju odobravanja uplatnice potrebno je kreirati novu TRANSAKCIJU
        // Novi viewmodel za TRANSAKCIJU
        // racunati porez kod eksternih transakcija ! !
        public ActionResult OdobriUplatnicu(int UplatnicaId) {
            Uplatnica uplatnica = db.Uplatnice.Find(UplatnicaId);
            uplatnica.StatusUplatnice = (StatusUplatnice)2;
            uplatnica.RadnikId = Autentifikacija.GetLogiraniKorisnik(HttpContext).Id;
            Racun racun = db.Racuni.Find(uplatnica.RacunId);

            Poruka poruka = new Poruka();
            poruka.KlijentId = uplatnica.KlijentId;
            poruka.RadnikId = Autentifikacija.GetLogiraniKorisnik(HttpContext).Id;
            poruka.Naslov = "Uplatnica";
            poruka.Odgovorena = true;
            poruka.DatumVrijeme = DateTime.Now.ToString();
            poruka.Sadrzaj = "Uplatnica sa svrhom doznake \"" + uplatnica.SvrhaDoznake + "\" je odobrena. Kopija uplatnice bit će Vam poslana poštom.";
            db.Poruka.Add(poruka);
            string mail = "";
            Klijent klijent = db.Klijenti.Find(uplatnica.KlijentId);
            mail += "<h3> Poštovani " + klijent.Ime + " " + klijent.Prezime + ",</h3><br/><br/>";
            mail += "Uplatnica sa svrhom doznake <b>" + uplatnica.SvrhaDoznake + "</b> je odobrena. Kopija uplatnice bit će Vam poslana poštom.";

            Email.Posalji("FIT Banka", mail, klijent.Email);

            racun.Stanje -= uplatnica.Iznos;

            Racun racunPrimaoca = db.Racuni.Where(x => x.BrojRacuna == uplatnica.RacunPrimaoca).SingleOrDefault();
            // dodavanje novca primaocu u slucaju da ga nadje u bazi HEHE
            // magic
            if (racunPrimaoca != null) {
                racunPrimaoca.Stanje += uplatnica.Iznos;
                // potrebno doraditi konverziju valuta
            }
            if (racunPrimaoca.BrojRacuna.StartsWith("555000")) {
                Transakcija t = new Transakcija();
                t.Eksterna = false;
            }
            db.SaveChanges();
            return RedirectToAction("PrikaziUplatnice");
        }

        public ActionResult OdbijUplatnicu(int? UplatnicaId) {
            Uplatnica uplatnica = db.Uplatnice.Find(UplatnicaId);
            uplatnica.StatusUplatnice = (StatusUplatnice)3;
            uplatnica.RadnikId = Autentifikacija.GetLogiraniKorisnik(HttpContext).Id;
            Racun racun = db.Racuni.Find(uplatnica.RacunId);

            Poruka poruka = new Poruka();
            poruka.KlijentId = uplatnica.KlijentId;
            poruka.RadnikId = Autentifikacija.GetLogiraniKorisnik(HttpContext).Id;
            poruka.Naslov = "Uplatnica";
            poruka.Odgovorena = true;
            poruka.DatumVrijeme = DateTime.Now.ToString();
            poruka.Sadrzaj = "Uplatnica sa svrhom doznake \"" + uplatnica.SvrhaDoznake + "\" je odbijena.";
            db.Poruka.Add(poruka);
            string mail = "";
            Klijent klijent = db.Klijenti.Find(uplatnica.KlijentId);
            mail += "<h3> Poštovani " + klijent.Ime + " " + klijent.Prezime + ",</h3><br/><br/>";
            mail += "Uplatnica sa svrhom doznake <b>" + uplatnica.SvrhaDoznake + "</b> je odbijena";

            Email.Posalji("FIT Banka", mail, klijent.Email);
            db.SaveChanges();
            return RedirectToAction("PrikaziUplatnice");
        }
    }
}