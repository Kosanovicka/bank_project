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
        Klijent klijent;
        string[] RegistracijaFormaPolja;

        public Form1()
        {
            InitializeComponent();
        }

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

        private void b_exit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void tb_godrodj_TextChanged(object sender, EventArgs e)
        {
            ValidirajFormu();
        }

        private void gb_NoviKlijent_Enter(object sender, EventArgs e)
        {
            ValidirajFormu();
        }


        private void btn_Login_Click(object sender, EventArgs e)
        {

            if (tb_Login_Jmbg.Text == klijent.Jmbg && tb_Login_Lozinka.Text == klijent.Lozinka)
            {
                gb_Login.Visible = false;
                gb_GlavniEkran.Visible = true;
                lbl_Poruka.Text = "";
            }
            else
            {
                lbl_Poruka.ForeColor = Color.Red;
                lbl_Poruka.Text = "Neispravno uneti podaci!";
            }

        }

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
    }
}
