using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekat_za_oop.Klase;

namespace Projekat_za_oop
{
    public partial class Form1 : Form
    {
        public Klijent Klijent { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b_uplati_Click(object sender, EventArgs e)
        {
            string iznos = tb_iznos.Text;
            string brRacuna = tb_brRacuna.Text;

            if (iznos == "" || brRacuna == "")
                MessageBox.Show("Najpre unesite broj racuna i iznos!");
            else
            {

                int iznos1 = int.Parse(iznos);

                DinarskiRacun racuni0 = new DinarskiRacun(brRacuna, 0);
                DevizniRacun racuni1 = new DevizniRacun(brRacuna, 0);

                
                richTB_poruka.Text = "";

                richTB_poruka.AppendText("Uplata na racun " + brRacuna + " u iznosu od " + iznos + " din.\n");
                racuni0.UplatiNaRacun(iznos1);
                richTB_poruka.AppendText("Podaci o racunu posle uplate: \n" + racuni0.VratiPodatkeORacunu());

                richTB_poruka.AppendText("Uplata na racun " + brRacuna + " u iznosu od " + iznos +" din.\n");
                racuni1.UplatiNaRacun(iznos1);
                richTB_poruka.AppendText("Podaci o racunu posle uplate: \n" + racuni1.VratiPodatkeORacunu());
            }
        }

        private void b_isplati_Click(object sender, EventArgs e)
        {
            
            string iznos = tb_iznos.Text;
            string brRacuna = tb_brRacuna.Text;

            
            if (iznos == "" || brRacuna == "")
                MessageBox.Show("Najpre unesite broj racuna i iznos!");
            else
            {

                double iznos1 = double.Parse(iznos);
                

                DinarskiRacun racuni0 = new DinarskiRacun(brRacuna, 0);
                DevizniRacun racuni1 = new DevizniRacun(brRacuna, 0);

                
                richTB_poruka.Text = "";

                richTB_poruka.AppendText("Isplata sa racuna " + brRacuna + " u iznosu od " + iznos + " din.\n");
                racuni0.IsplatiSaRacuna(iznos1);
                richTB_poruka.AppendText("Podaci o racunu posle isplate: \n" +racuni0.VratiPodatkeORacunu());
                richTB_poruka.AppendText("Isplata sa racuna " + brRacuna + " u iznosu od " + iznos + " din.\n");
                racuni1.IsplatiSaRacuna(iznos1);
                richTB_poruka.AppendText("Podaci o racunu posle isplate: \n" +
                racuni1.VratiPodatkeORacunu());

            }
        }

        private void tb_iznos_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
    

