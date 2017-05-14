using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_za_oop.Klase
{
    public class Osoba
    {
        public string ime;
        public string prezime;
        protected string jmbg;
        public int godRodj;

        public Osoba(string jmbg, int godRodj)
        {
            this.ime = "";
            this.prezime = "";
            this.jmbg = jmbg;
            this.godRodj = godRodj;
        }

        public string Jmbg
        {
            get
            {
                return this.jmbg;
            }
            set
            {
                if (value == null || value == "")
                {
                    throw new Exception("Greska");
                }
                else
                {
                    this.jmbg = value;
                }
            }
        }
    }
}
