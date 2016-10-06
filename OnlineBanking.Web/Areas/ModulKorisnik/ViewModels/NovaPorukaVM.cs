using OnlineBanking.Data.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineBanking.Web.Areas.ModulKorisnik.ViewModels
{

    public class NovaPorukaVM
    {
        public int KlijentId { get; set; }
        public DateTime DatumVrijeme { get; set; }

        [Required(ErrorMessage = "Naslov je obavezno polje!")]
        [StringLength(40, ErrorMessage = "Naslov poruke ne može biti veći od 40 slova.")]
        public string Naslov { get; set; }

        [Required(ErrorMessage = "Sadržaj je obavezno polje!")]
        [StringLength(500, ErrorMessage = "Sadržaj poruke ne može biti veći od 500 slova.")]
        public string Sadrzaj { get; set; }

        public bool Odgovorena { get; set; }

    }
}