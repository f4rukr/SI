using OnlineBanking.Data.DAL;
using OnlineBanking.Data.Models;
using OnlineBanking.Web.Helper;
using OnlineBanking.Web.ViewModels;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Web.Mvc;
using FluentScheduler;

namespace OnlineBanking.Web.Controllers {

    public class HomeController : Controller {
        private DL_Context db = new DL_Context();
        int brojac = 1;


        public async Task<String> MyMethodAsync()
        {



            String result = await LongRunningOperationAsync();

            
            System.Diagnostics.Debug.WriteLine(result);

            return result;
        }


        public async Task<string> LongRunningOperationAsync()        {
            await Task.Delay(5000);
            return "radi" + brojac;
        }
        [HttpGet]
        public ActionResult Index() {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string username, string password) {
            KorisnikLoginVM korisnik = null;
            //password = Crypto.HashPassword(password);
            Klijent klijent = db.Klijenti.Where(x => x.Username == username).SingleOrDefault();
            Radnik radnik = db.Radnici.Where(x => x.Username == username).SingleOrDefault();

            if (klijent != null && klijent.IsDeleted) {
                ViewData["BlokiranRacun"] = "Vaš korisnički račun je blokiran! Obratite se najbližoj poslovnici.";
                return View();
            }
            if (radnik != null && radnik.IsDeleted) {
                ViewData["BlokiranRacun"] = "Vaš korisnički račun je blokiran! Obratite se najbližoj poslovnici.";
                return View();
            }
            
            if (klijent != null && (!Crypto.VerifyHashedPassword(klijent.PasswordHash, password) || klijent.Username != username)) {
                klijent.BrojPokusajaLogiranja++;
                db.SaveChanges();
                if (klijent.BrojPokusajaLogiranja > 5) {
                    klijent.IsDeleted = true;
                    db.SaveChanges();
                    klijent = null;
                    ViewData["BlokiranRacun"] = "Vaš korisnički račun je blokiran! Obratite se najbližoj poslovnici.";
                    return View();
                }
                ViewData["PogresanLogin"] = "Pogrešan username / password";
                return View();
            }
            
            if (radnik != null && (!Crypto.VerifyHashedPassword(radnik.PasswordHash, password) || radnik.Username != username)) {
                radnik.BrojPokusajaLogiranja++;
                db.SaveChanges();
                if (radnik.BrojPokusajaLogiranja > 5) {
                    radnik.IsDeleted = true;
                    db.SaveChanges();
                    radnik = null;
                    ViewData["BlokiranRacun"] = "Vaš korisnički račun je blokiran! Obratite se najbližoj poslovnici.";
                    return View();
                }
                ViewData["PogresanLogin"] = "Pogrešan username / password";
                return View();
            }

            if (radnik != null) {
                radnik.BrojPokusajaLogiranja = 0;
                db.SaveChanges();
            }

            if (klijent != null) {
                klijent.BrojPokusajaLogiranja = 0;
                db.SaveChanges();
            }

            if (klijent != null) {
                korisnik = new KorisnikLoginVM();
                korisnik.Id = klijent.Id;
                korisnik.Ime = klijent.Ime;
                korisnik.Prezime = korisnik.Prezime;
                korisnik.IsKlijent = true;
                korisnik.IsRadnik = false;
                korisnik.IsDeleted = klijent.IsDeleted;
                korisnik.SlikaPath = klijent.SlikaPath;
            }
            if (radnik != null) {
                korisnik = new KorisnikLoginVM();
                korisnik.Id = radnik.Id;
                korisnik.Ime = radnik.Ime;
                korisnik.Prezime = radnik.Prezime;
                korisnik.IsKlijent = false;
                korisnik.IsRadnik = true;
                korisnik.IsDeleted = radnik.IsDeleted;
                korisnik.SlikaPath = radnik.SlikaPath;

            }
            if (korisnik != null)
                Autentifikacija.PokreniNovuSesiju(korisnik, HttpContext, false);

            if (korisnik == null) {
                LogPrijava greska = new LogPrijava();
                greska = GetLogGreska();
                db.LogPrijave.Add(greska);
                db.SaveChanges();
                ViewData["PogresanLogin"] = "Pogrešan username / password";
                return View();
            }

            if (korisnik.IsKlijent) {
                LogPrijava log = GetLogPrijavaKlijent(korisnik.Id);
                db.LogPrijave.Add(log);
                db.SaveChanges();
                return RedirectToAction("Index", "ModulKorisnik/Obavijesti/PrikaziObavijesti");
            }

            if (korisnik.IsRadnik)
            {
                LogPrijava log = GetLogPrijavaRadnik(korisnik.Id);
                db.LogPrijave.Add(log);
                db.SaveChanges();
                return RedirectToAction("Index", "ModulRadnik/Obavijesti/PrikaziObavijesti");
            }

            
            return RedirectToAction("Index", "Home");
        }
        private LogPrijava GetLogGreska()
        {
            LogPrijava log = new LogPrijava();
            log.IPadresa = GetClientIP.GetIPAddress();
            log.DatumVrijeme = DateTime.Now.ToString();
            log.Browser = Request.Browser.Type;
            log.Uspjesnost = false;
            return log;
        }
        private LogPrijava GetLogPrijavaKlijent(int korisnikId)
        {
            LogPrijava log = new LogPrijava();
            log.IPadresa = GetClientIP.GetIPAddress();
            log.DatumVrijeme = DateTime.Now.ToString();
            log.Browser = Request.Browser.Type;
            log.Uspjesnost = true;
            log.KlijentId = korisnikId;
            return log;
        }
        private LogPrijava GetLogPrijavaRadnik(int korisnikId)
        {
            LogPrijava log = new LogPrijava();
            log.IPadresa = GetClientIP.GetIPAddress();
            log.DatumVrijeme = DateTime.Now.ToString();
            log.Browser = Request.Browser.Type;
            log.Uspjesnost = true;
            log.RadnikId = korisnikId;
            return log;
        }

        [HttpGet]
        public ActionResult Logout() {
            Autentifikacija.PokreniNovuSesiju(null, HttpContext, false);
            return RedirectToAction("Index");
        }
    }
}