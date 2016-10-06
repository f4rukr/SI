using System.ComponentModel.DataAnnotations;

namespace OnlineBanking.Web.Areas.ModulKorisnik.ViewModels {

    public class PromjenaLozinkeVM {

        [Required(ErrorMessage = "Stara lozinka je obavezno polje!")]
        //[Compare("oldPasswordHidden", ErrorMessage = "Stara lozinka je pogrešna!")]
        public string oldPasswordShow { get; set; }

        // Nova lozinka mora sadrzavati najmanje: jedno malo slovo, jedno veliko slovo, broj...
        // Isti karakteri se mogu ponoviti najvise 3 puta
        // Velicina mora biti izmedju 8 i 16 karaktera
        [RegularExpression("^(?!.*(.)\\1{3})((?=.*[\\d])(?=.*[A-Za-z])|(?=.*[^\\w\\d\\s])(?=.*[A-Za-z])).{8,16}$", ErrorMessage = "Lozinka mora sadržavati mala i velika slova, brojeve i specijalne znakove!")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Lozinka mora biti veća od 8 karaktera!")]
        //[NotEqualTo("oldPasswordHidden", ErrorMessage = "Nova i stara lozinka ne smiju biti iste!")]
        [Required(ErrorMessage = "Nova lozinka je obavezno polje!")]
        public string newPassword { get; set; }

        [Required(ErrorMessage = "Potvrda lozinke je obavezno polje!")]
        [Compare("newPassword", ErrorMessage = "Nova lozinka i potvrda ne odgovaraju!")]
        public string confirmPassword { get; set; }
    }
}