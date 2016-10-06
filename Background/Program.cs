using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineBanking.Data.DAL;
using OnlineBanking.Data.Models;
using System.Data.Entity;

namespace Background
{
    class Program
    {
        static void Main(string[] args)
        {

            DL_Context db = new DL_Context();

            DateTime danas = DateTime.Now.Date;
            List<Stednja> stednje = db.Stednje.Where(x => x.IsDeleted == false && danas == x.KrajStednje).ToList();

            foreach (Stednja item in stednje)
            {
                Racun racun = db.Racuni.Find(item.RacunId);
                racun.Stanje += (item.IznosOrocenja + item.IznosNaGlavnicu);
                item.IsDeleted = true;
                Notifikacija not = new Notifikacija();
                not.DatumVrijeme = DateTime.Now.ToString();
                not.Naslov = "Oročena štednja za Vaš " + racun.TipRacuna + " - " + racun.BrojRacuna + " bankovni račun.";
                not.Sadrzaj = "Oročena štednja za Vaš " + racun.TipRacuna + " - " + racun.BrojRacuna + " bankovni račun je završena. Provjerite stanje na vašem računu. Vaša banka.";
                not.Uspjeh = 2;
                not.KlijentId = item.KlijentId;
                db.Notifikacije.Add(not);
            }
            db.SaveChanges();
            
        }
    }
}
