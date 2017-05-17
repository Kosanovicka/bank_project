using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat_za_oop.Klase
{

    public class Klijent
    {

        public string ime;
        public string prezime;
        protected string jmbg;
        protected string lozinka;
        public int godRodj;

        public Klijent(string ime, string prezime, string jmbg, int godRodj, string lozinka)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
            this.godRodj = godRodj;
            this.lozinka = lozinka;
        }

        public string Jmbg
        {
            get
            {
                return this.jmbg;
            }
        }

        public string Lozinka
        {
            get
            {
                return this.lozinka;
            }
        }


    }
}







