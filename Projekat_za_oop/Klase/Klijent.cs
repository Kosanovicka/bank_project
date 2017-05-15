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
        public int godRodj;
        public Racun Racun;
        private TextBox tb_Ime;
        private TextBox tb_prezime;
        private TextBox tb_jmbg;
        private string text;

        public Klijent(string jmbg )
        {
            this.ime = "";
            this.prezime = "";
            this.jmbg = jmbg;
            this.godRodj = 0;
        }
        public Klijent(string ime, string prezime, string jmbg,int godRodj, Racun Racun)
        {
            this.ime = "";
            this.prezime = "";
            this.jmbg = jmbg;
            this.godRodj = godRodj;   
            this.Racun = Racun;
        }

        public Klijent(TextBox tb_Ime, TextBox tb_prezime, TextBox tb_jmbg, string text)
        {
            this.tb_Ime = tb_Ime;
            this.tb_prezime = tb_prezime;
            this.tb_jmbg = tb_jmbg;
            this.text = text;
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
        
                

                
                

        
