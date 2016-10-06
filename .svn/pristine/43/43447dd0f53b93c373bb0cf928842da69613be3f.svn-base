using OnlineBanking.Data.DAL;
using OnlineBanking.Data.Models;
using OnlineBanking.Web.Areas.ModulKorisnik.ViewModels;
using OnlineBanking.Web.Helper;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace OnlineBanking.Web.Areas.ModulKorisnik.Controllers {

    [Autorizacija(dozvoljenoZaRadnika: false, dozvoljenoZaKorisnika: true)]

    public class ObavijestiController : Controller {
        private DL_Context db = new DL_Context();

        public ActionResult Index() {
            return View();
        }

        public ActionResult PrikaziObavijesti() {
            List<Obavijest> obavijesti = db.Obavijesti.ToList();
            return View(obavijesti);
        }

        public ActionResult PrikaziObavijest(int ObavijestId) {
            Obavijest obavijest = db.Obavijesti.Find(ObavijestId);

            int KlijentId = Autentifikacija.GetLogiraniKorisnik(HttpContext).Id;
            Notifikacija notifikacija = db.Notifikacije.Where(x => x.KlijentId == KlijentId && x.ObavijestId == ObavijestId).SingleOrDefault();
            notifikacija.Procitana = true;
            db.SaveChanges();

            return View(obavijest);
        }
    }
}