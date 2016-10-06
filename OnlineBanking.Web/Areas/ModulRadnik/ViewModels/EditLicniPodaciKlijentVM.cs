using OnlineBanking.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBanking.Web.Areas.ModulRadnik.ViewModels
{
    public class EditLicniPodaciKlijentVM
    {
        public string DatumRodjenja { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public int KlijentId { get; set; }
        [StringLength (20,ErrorMessage ="Maksimalna veličina imena je 20 slova")]
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string SlikaPath { get; set; }        
        public string Ulica { get; set; }
        public string BrojUlice { get; set; }
        public bool IsActive { get; set; }
        public virtual int? OpstinaId { get; set; }
        public virtual Opstina Opstina { get; set; }
        
        public List<SelectListItem> opstine { get; set; }
    }
}