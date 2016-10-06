using OnlineBanking.Data.DAL;
using OnlineBanking.Data.Models;
using OnlineBanking.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBanking.Web.Helper
{
    public class Autentifikacija
    {
        private const string LogiraniKorisnik = "logirani_korisnik";

        public static void PokreniNovuSesiju(KorisnikLoginVM korisnik, HttpContextBase context, bool zapamtiPassword)
        {

            context.Session.Add(LogiraniKorisnik, korisnik);

            //Cookie...
            //if (zapamtiPassword)
            //{
            //    HttpCookie cookie = new HttpCookie("_mvc_session", korisnik?.Id.ToString() ?? "");
            //    cookie.Expires = DateTime.Now.AddDays(10);
            //    context.Response.Cookies.Add(cookie);
            //}
        }


        public static KorisnikLoginVM GetLogiraniKorisnik(HttpContextBase context)
        {

            KorisnikLoginVM korisnik = (KorisnikLoginVM)context.Session[LogiraniKorisnik];

            if (korisnik != null)
                return korisnik;
            
            HttpCookie cookie = context.Request.Cookies.Get("_mvc_session");

            if (cookie == null)
                return null;

            long userId;
            try
            {
                userId = Int64.Parse(cookie.Value);
            }
            catch
            {
                return null;
            }


            DL_Context db = new DL_Context();

            KorisnikLoginVM k = new KorisnikLoginVM();
            if (korisnik.IsRadnik)
            {
                Radnik r = db.Radnici
                     .SingleOrDefault(x => x.Id == userId);
                k.Ime = r.Ime;
                k.Prezime = r.Prezime;
                k.Id = r.Id;
                k.IsKlijent = korisnik.IsKlijent;
                k.IsRadnik = korisnik.IsRadnik;
            }

            if (korisnik.IsKlijent)
            {
                Klijent r = db.Klijenti
                     .SingleOrDefault(x => x.Id == userId);
                k.Ime = r.Ime;
                k.Prezime = r.Prezime;
                k.Id = r.Id;
                k.IsKlijent = korisnik.IsKlijent;
                k.IsRadnik = korisnik.IsRadnik;
            }
            PokreniNovuSesiju(k, context, true);
            return k;
        }
    }
}