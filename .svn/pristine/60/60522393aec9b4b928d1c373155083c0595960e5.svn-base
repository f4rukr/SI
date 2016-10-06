using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineBanking.Data.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace OnlineBanking.Data.DAL {
    public class DL_Context : DbContext {
        public DbSet<Drzava> Drzave { get; set; }
        public DbSet<Klijent> Klijenti { get; set; }
        public DbSet<LogPrijava> LogPrijave { get; set; }
        public DbSet<Obavijest> Obavijesti { get; set; }
        public DbSet<Opstina> Opstina { get; set; }
        public DbSet<Poruka> Poruka { get; set; }
        public DbSet<Predlozak> Predlozak { get; set; }
        public DbSet<Racun> Racuni { get; set; }
        public DbSet<Radnik> Radnici { get; set; }
        public DbSet<Stednja> Stednje { get; set; }
        public DbSet<TipZahtjeva> TipoviZahtjeva { get; set; }
        public DbSet<Transakcija> Transakcije { get; set; }
        public DbSet<Uplatnica> Uplatnice { get; set; }
        public DbSet<Zahtjev> Zahtjevi { get; set; }
        public DbSet<Notifikacija> Notifikacije { get; set; }




        public DL_Context()
            : base("name=MyConnectionString") {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
