using OnlineBanking.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineBanking.Web.Areas.ModulRadnik.ViewModels {
    public class LicniPodaciVM {
        public int RadnikId { get; set; }
        public int KlijentId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        [Required(ErrorMessage = "e-mail je obavezno polje!")]
        [EmailAddress(ErrorMessage = "Format e-mail adrese mora biti: test@test.com!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefon je obavezno polje!")]
        [RegularExpression("^(\\+?387)?-?[0-9]{2}-?[0-9]{3}?[0-9]{3}$", ErrorMessage = "Format za telefon mora biti: +387-xx-xxxxxx")]
        public string Telefon { get; set; } 
        public string DatumRodjenja { get; set; }
        public string Ulica { get; set; }
        public string BrojUlice { get; set; }
        public Opstina Opstina { get; set; }
        public string SlikaPath { get; set; }
    }
}