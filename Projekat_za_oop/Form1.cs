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

        private void b_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void b_klijent_Click(object sender, EventArgs e)
        {
            int godrodj = Convert.ToInt32(tb_godrodj.Text);
            this.Klijent = new Klijent(tb_Ime, tb_prezime, tb_jmbg, tb_godrodj.Text);


        }

        private void tb_Ime_TextChanged(object sender, EventArgs e)
        {
            
            

        }

        private void tb_prezime_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_jmbg_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_godrodj_TextChanged(object sender, EventArgs e)
        {
            int godrodj = Convert.ToInt32(tb_godrodj.Text);
        }
    }
}
