using OnlineBanking.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBanking.Web.Areas.ModulRadnik.ViewModels {
    public class NoviKlijentVM {
        [Required(ErrorMessage = "Odaberite sliku!")]
        public HttpPostedFileBase File { get; set; }
        public int? KlijentId { get; set; }
        [Required (ErrorMessage ="Ime je obavezno polje!")]
        [StringLength (20,ErrorMessage ="Maksimalna veličina imena je 20 karaktera.")]
        public string Ime { get; set; }
        [Required (ErrorMessage = "Prezime je obavezno polje!")]
        [StringLength(30, ErrorMessage = "Maksimalna veličina prezimena je 30 karaktera.")]
        public string Prezime { get; set; }
        [EmailAddress (ErrorMessage ="Format e-mail adrese: primjer@mail.com")]
        [Required (ErrorMessage = "e-mail je obavezno polje!")]
        public string Email { get; set; }
        [Required (ErrorMessage = "JMBG je obavezno polje!")]
        [StringLength(13,ErrorMessage = "JMBG mora biti 13 karaktera", MinimumLength = 13)]
        public string JMBG { get; set; }
        [Required (ErrorMessage = "Telefon je obavezno polje!")]
        [RegularExpression("^(\\+?387)?-?[0-9]{2}-?[0-9]{3}?[0-9]{3}$",ErrorMessage ="Format telefona: +387-xx-xxxxxx")]
        public string Telefon { get; set; }
        [RegularExpression("^(?:(?:31(\\/|-|\\.)(?:0?[13578]|1[02]))\\1|(?:(?:29|30)(\\/|-|\\.)(?:0?[1,3-9]|1[0-2])\\2))(?:(?:1[6-9]|[2-9]\\d)?\\d{2})$|^(?:29(\\/|-|\\.)0?2\\3(?:(?:(?:1[6-9]|[2-9]\\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\\d|2[0-8])(\\/|-|\\.)(?:(?:0?[1-9])|(?:1[0-2]))\\4(?:(?:1[6-9]|[2-9]\\d)?\\d{2})$", ErrorMessage = "Format datuma: dd/mm/yyyy, dd-mm-yyyy, dd.mm.yyyy")]
        [Required(ErrorMessage = "Datum rodenja je obavezno polje!")]
        public string DatumRodjenja { get; set; }        
        public string Username { get; set; }        
        public string PasswordHash { get; set; }        
        public string Salt { get; set; }
        [Required (ErrorMessage = "Ulica je obavezno polje!")]
        [StringLength(40, ErrorMessage = "Maksimalna veličina je 40 karaktera")]
        public string Ulica { get; set; }
        [Required (ErrorMessage = "Broj ulice je obavezno polje!")]
        public string BrojUlice { get; set; }        
        public int BrojPokusajaLogiranja { get; set; }
        public bool IsActive { get; set; }
        [Required (ErrorMessage = "Opština je obavezno polje!")] 
        [Range (1,int.MaxValue, ErrorMessage= "Opština je obavezno polje!")]
        public int OpstinaId { get; set; }
        public List<SelectListItem> opstine { get; set; }
    }
}