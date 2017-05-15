using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_za_oop.Klase
{
    class DinarskiRacun : Racun
    {
        protected Racun racun;
        protected double dozMinus;

        public DinarskiRacun(double stanje, Racun racun, string brRac, double dozMinus) : base()
        {
            this.dozMinus = 10000;
            this.racun = racun;

        }
        public void StanjeNaRacunu(double stanje)
        {
            this.stanje = 85000;

        }
        public double DozMinus
        {
            get
            {
                return this.dozMinus;
            }
            set
            {
                if (value > 10000)
                {
                    throw new Exception("Greska");
                }
                else
                {
                    this.dozMinus = value;
                }
            }
        }
    }
}

