using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_za_oop.Klase
{
    public class Racun
    {

        public string brRacuna;
        public int godIzdavanja;
        public int mesecIzdavanja;
        public double iznos;
        public double dozvoljeniMinus;

        public Racun(string brRac, int godIz, int mesIz,double iznos,double dozMin)
        {
            this.brRacuna = brRac;
            this.godIzdavanja = godIz;
            this.mesecIzdavanja = mesIz;
            this.iznos = iznos;

            this.dozvoljeniMinus = dozMin;

        }

        public string Ispis()
        {
            return "Broj Racuna: " + this.brRacuna + " Godina izdavanja: " + this.godIzdavanja + " Mesec izdavanja: " + this.mesecIzdavanja+"Iznos:"+this.iznos+"Dozvoljeni minus:"+this.dozvoljeniMinus;
        }
         public void Uplata(double dodatnaUplata)
        {
             iznos += dodatnaUplata;
        }
        
    }
}
        
