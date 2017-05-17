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
        string[] RegistracijaFormaPolja;
        public Klijent klijent { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        // Inicijalizacija forme
        private void Form1_Load(object sender, EventArgs e)
        {
            //Labels
            lbl_Poruka.Text = "";

            //Buttons
            btn_KreirajKlijenta.Enabled = false;

            //Group boxes
            gb_NoviKlijent.Visible = true;
            gb_GlavniEkran.Visible = false;
            gb_Login.Visible = false;

            //Arrays
            RegistracijaFormaPolja = new string[5];
        }

        private void b_uplati_Click(object sender, EventArgs e)
        {
            string iznos = tb_iznos.Text;
            string brRacuna = tb_brRacuna.Text;
        }


        private void b_klijent_Click(object sender, EventArgs e)
        {
            int godRodj = Convert.ToInt32(tb_godrodj.Text);

            try
            {
                klijent = new Klijent(tb_Ime.Text, tb_prezime.Text, tb_jmbg.Text, godRodj, tb_Lozinka.Text);
                PrikaziLogin();
            }
            catch (Exception ex)
            {
                lbl_Poruka.ForeColor = Color.Red;
                lbl_Poruka.Text = ex.Message.ToString();
            }

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            if (tb_Login_Jmbg.Text == klijent.Jmbg && tb_Login_Lozinka.Text == klijent.Lozinka)
            {
                gb_Login.Visible = false;
                gb_GlavniEkran.Visible = true;
                lbl_Poruka.Text = "";

                lbl_KlijentIme.Text = "Ime: " + klijent.ime;
                lbl_KlijentPrezime.Text ="Prezime: " + klijent.prezime;
                lbl_KlijentJbmg.Text = "Jmbg: " + klijent.Jmbg;
                lbl_KlijentGodRodj.Text = "Godina rodjenja: " + klijent.godRodj.ToString();
            }
            else
            {
                lbl_Poruka.ForeColor = Color.Red;
                lbl_Poruka.Text = "Neispravno uneti podaci!";
            }
        }

        #region Form Change Events

        private void tb_Ime_TextChanged(object sender, EventArgs e)
        {
            ValidirajFormu();
        }

        private void tb_prezime_TextChanged(object sender, EventArgs e)
        {
            ValidirajFormu();
        }
        private void tb_jmbg_TextChanged(object sender, EventArgs e)
        {
            ValidirajFormu();
        }

        private void tb_Lozinka_TextChanged(object sender, EventArgs e)
        {
            ValidirajFormu();
        }

        private void tb_godrodj_TextChanged(object sender, EventArgs e)
        {
            ValidirajFormu();
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
                richTB_poruka.AppendText("Podaci o racunu posle isplate: \n" + racuni0.VratiPodatkeORacunu());
                richTB_poruka.AppendText("Isplata sa racuna " + brRacuna + " u iznosu od " + iznos + " din.\n");
                racuni1.IsplatiSaRacuna(iznos1);
                richTB_poruka.AppendText("Podaci o racunu posle isplate: \n" +
                racuni1.VratiPodatkeORacunu());

            }
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Helpers
        private void PrikaziLogin()
        {
            gb_NoviKlijent.Visible = false;
            gb_Login.Visible = true;
        }

        private void ValidirajFormu()
        {
            RegistracijaFormaPolja[0] = tb_Ime.Text;
            RegistracijaFormaPolja[1] = tb_prezime.Text;
            RegistracijaFormaPolja[2] = tb_jmbg.Text;
            RegistracijaFormaPolja[3] = tb_godrodj.Text;
            RegistracijaFormaPolja[4] = tb_Lozinka.Text;

            for (int i = 0; i < RegistracijaFormaPolja.Length; i++)
            {
                if (RegistracijaFormaPolja[i] == "")
                {
                    btn_KreirajKlijenta.Enabled = false;
                    break;
                }
                else
                {
                    btn_KreirajKlijenta.Enabled = true;
                }
            }
        }

        private void Logout()
        {
            // todo;;
        }

        #endregion

        

        private void b_uplati_Click_1(object sender, EventArgs e)
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

                
                richTB_poruka.AppendText("Uplata na racun " + brRacuna + " u iznosu od " + iznos1 +" din.\n");
                racuni0.UplatiNaRacun(iznos1);
                richTB_poruka.AppendText("Podaci o racunu posle uplate: \n" +racuni0.VratiPodatkeORacunu());

                richTB_poruka.AppendText("Uplata na racun " + brRacuna + " u iznosu od " + iznos1 +" din.\n");
                racuni1.UplatiNaRacun(iznos1);
                
                richTB_poruka.AppendText("Podaci o racunu posle uplate: \n" +
                racuni1.VratiPodatkeORacunu());

            }
        }

        private void b_isplati_Click_1(object sender, EventArgs e)
       
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
                richTB_poruka.AppendText("Podaci o racunu posle isplate: \n" + racuni0.VratiPodatkeORacunu());
                richTB_poruka.AppendText("Isplata sa racuna " + brRacuna + " u iznosu od " + iznos + " din.\n");
                racuni1.IsplatiSaRacuna(iznos1);
                richTB_poruka.AppendText("Podaci o racunu posle isplate: \n" + racuni1.VratiPodatkeORacunu());

            }
        }
    }
}
    



