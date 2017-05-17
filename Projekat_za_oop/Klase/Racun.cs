using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_za_oop.Klase
{
    public abstract class Racun
    {

        private double stanje;
        private string brojRacuna;


        protected abstract double ProvizijaNaUplatu(double iznos);
        protected abstract double ProvizijaNaIsplatu(double iznos);


        public Racun(string brojRacuna, double pocetnoStanje)
        {
            this.stanje = pocetnoStanje;
            this.brojRacuna = brojRacuna;
        }

        public Racun(string brojRacuna) : this(brojRacuna, 0) { }


        public double VratiStanje()
        {
            return stanje;
        }


        public void UplatiNaRacun(double iznos)
        {

            stanje += iznos - ProvizijaNaUplatu(iznos);
        }


        public void IsplatiSaRacuna(double iznos)
        {

            stanje -= iznos + ProvizijaNaIsplatu(iznos);
        }


        public virtual string VratiPodatkeORacunu()
        {
            string podaci = "Racun broj: " + brojRacuna + "\nIznos na racunu: " + stanje;
            return podaci;
        }
    }
}
