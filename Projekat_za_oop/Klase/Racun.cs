using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_za_oop.Klase
{
    public class Racun
    {

        protected string brRacuna;
        public double stanje;
        public double dozvoljeniMinus;
        public Klijent klijent;

        public Racun(string brRac,double stanje,double dozMin)
        {
            this.brRacuna = brRac;
            this.stanje = stanje;
            this.dozvoljeniMinus = dozMin;
        }

        public Racun()
        {
            this.brRacuna = "";
            this.stanje = 0;
            this.dozvoljeniMinus = 10000;
        }
        
        public string Ispis()
        {
            return "Broj Racuna: " + this.brRacuna +"Stanje:"+this.stanje+"Dozvoljeni minus:"+this.dozvoljeniMinus;
        }
         public void Uplata(double dodatnaUplata)
        {
             stanje += dodatnaUplata;
        }
        public void Isplata(double SkidanjeNovca)
        {
            stanje -= SkidanjeNovca;
        }
    }
}
        
