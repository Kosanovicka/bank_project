using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_za_oop.Klase
{
    
        public class Klijent : Osoba:
        {
            public bool ImaRacun;
            public Racun Racun;
            public int SifraFilijale;


            public Klijent(string jmbg, int godRodj, bool ImaRac, Racun Racun,int SifraFilijale) : base(jmbg, godRodj)
            {
                this.ImaRacun = ImaRac;
                this.Racun = Racun;
                this.SifraFilijale = SifraFilijale;
            }


        public void Uplata(double dodatnaUplata)
        {
            
        }
        public int PromenaSF
        {
            get
            {
                return this.SifraFilijale;
            }
            set
            {
                if (value >10 || value<1)
                {
                    throw new Exception("Greska,Morate uneti vise od 1, a manje od 10 brojeva");
                }
                else
                {
                    this.SifraFilijale = value;
                }
            }
        }
    }

    }
}
