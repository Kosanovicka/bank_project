using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_za_oop.Klase
{
    public class DinarskiRacun : Racun
    {

        public DinarskiRacun(string brojRacuna) : base(brojRacuna)
        { }


        public DinarskiRacun(string brojRacuna, double pocetnoStanje) : base(brojRacuna, pocetnoStanje)
        { }


        protected override double ProvizijaNaUplatu(double iznos)
        {

            return 0;
        }


        protected override double ProvizijaNaIsplatu(double iznos)
        {

            double obracunataProvizija = 100 + (iznos * 3 / 100);
            return obracunataProvizija;
        }


        public override string VratiPodatkeORacunu()
        {

            return base.VratiPodatkeORacunu() + "\nTip racuna: Dinarski\n\n";
        }
    }
}
