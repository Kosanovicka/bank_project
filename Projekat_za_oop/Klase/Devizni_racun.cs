using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_za_oop.Klase
{
    public class DevizniRacun : Racun
    {

        public DevizniRacun(string brojRacuna) : base(brojRacuna)
        { }


        public DevizniRacun(string brojRacuna, double pocetnoStanje) : base(brojRacuna, pocetnoStanje)
        { }


        protected override double ProvizijaNaUplatu(double iznos)
        {

            double obracunataProvizija = 100 + (iznos * 5 / 100);
            return obracunataProvizija;
        }


        protected override double ProvizijaNaIsplatu(double iznos)
        {

            double obracunataProvizija = 100 + (iznos * 5 / 100);
            return obracunataProvizija;
        }


        public override string VratiPodatkeORacunu()
        {

            return base.VratiPodatkeORacunu() + "\nTipRacuna: DEVIZNI\n\n";
        }
    }
}
