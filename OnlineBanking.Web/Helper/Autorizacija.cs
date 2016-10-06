using OnlineBanking.Data.Models;
using OnlineBanking.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBanking.Web.Helper
{
    public class Autorizacija : FilterAttribute, IAuthorizationFilter
    {
        private readonly bool _dozvoljenoZaKorisnika;
        private readonly bool _dozvoljenoZaRadnika;
       

        public Autorizacija(bool dozvoljenoZaRadnika, bool dozvoljenoZaKorisnika)
        {
            _dozvoljenoZaKorisnika = dozvoljenoZaKorisnika;
            _dozvoljenoZaRadnika = dozvoljenoZaRadnika;
        }

        public void OnAuthorization(AuthorizationContext filterContext)
        {

            KorisnikLoginVM korisnik = Autentifikacija.GetLogiraniKorisnik(filterContext.HttpContext);


            if (korisnik == null)
            {
                filterContext.HttpContext.Response.Redirect("/Home");
                return;
            }
            if (_dozvoljenoZaKorisnika == true && korisnik.IsKlijent == true)
                return;
            if (_dozvoljenoZaRadnika == true && korisnik.IsRadnik == true)
                return;

            filterContext.HttpContext.Response.Redirect("/Home");

        }
    }
}