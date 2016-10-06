using OnlineBanking.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBanking.Web.ViewModels
{
    public class KorisnikLoginVM
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public bool IsRadnik { get; set; }
        public bool IsKlijent { get; set; }
        public bool IsDeleted { get; set; }
        public string SlikaPath { get; set; }

    }
}