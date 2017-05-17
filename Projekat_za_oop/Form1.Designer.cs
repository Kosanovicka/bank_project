namespace Projekat_za_oop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_Ime = new System.Windows.Forms.TextBox();
            this.tb_prezime = new System.Windows.Forms.TextBox();
            this.b_exit = new System.Windows.Forms.Button();
            this.btn_KreirajKlijenta = new System.Windows.Forms.Button();
            this.lbl_Ime = new System.Windows.Forms.Label();
            this.lbl_prezime = new System.Windows.Forms.Label();
            this.gb_NoviKlijent = new System.Windows.Forms.GroupBox();
            this.tb_Lozinka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_godrodj = new System.Windows.Forms.TextBox();
            this.lb_godrodj = new System.Windows.Forms.Label();
            this.tb_jmbg = new System.Windows.Forms.TextBox();
            this.lb_jmbg = new System.Windows.Forms.Label();
            this.gb_GlavniEkran = new System.Windows.Forms.GroupBox();
            this.poruka_podaciklijent = new System.Windows.Forms.Label();
            this.lbl_podaciOklijentu = new System.Windows.Forms.Label();
            this.minusporuka = new System.Windows.Forms.Label();
            this.stanjeporuka = new System.Windows.Forms.Label();
            this.lbl3_minus = new System.Windows.Forms.Label();
            this.lbl2_trenstanje = new System.Windows.Forms.Label();
            this.bt2_din = new System.Windows.Forms.Button();
            this.bt1_Dev = new System.Windows.Forms.Button();
            this.gb_lbl_racun = new System.Windows.Forms.Label();
            this.lbl_Poruka = new System.Windows.Forms.Label();
            this.gb_Login = new System.Windows.Forms.GroupBox();
            this.tb_Login_Jmbg = new System.Windows.Forms.TextBox();
            this.tb_Login_Lozinka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_KlijentIme = new System.Windows.Forms.Label();
            this.lbl_KlijentPrezime = new System.Windows.Forms.Label();
            this.lbl_KlijentJbmg = new System.Windows.Forms.Label();
            this.lbl_KlijentGodRodj = new System.Windows.Forms.Label();
            this.gb_NoviKlijent.SuspendLayout();
            this.gb_GlavniEkran.SuspendLayout();
            this.gb_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Ime
            // 
            this.tb_Ime.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_Ime.Location = new System.Drawing.Point(376, 68);
            this.tb_Ime.Multiline = true;
            this.tb_Ime.Name = "tb_Ime";
            this.tb_Ime.Size = new System.Drawing.Size(250, 25);
            this.tb_Ime.TabIndex = 0;
            this.tb_Ime.TextChanged += new System.EventHandler(this.tb_Ime_TextChanged);
            // 
            // tb_prezime
            // 
            this.tb_prezime.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_prezime.Location = new System.Drawing.Point(376, 119);
            this.tb_prezime.Multiline = true;
            this.tb_prezime.Name = "tb_prezime";
            this.tb_prezime.Size = new System.Drawing.Size(250, 25);
            this.tb_prezime.TabIndex = 1;
            this.tb_prezime.TextChanged += new System.EventHandler(this.tb_prezime_TextChanged);
            // 
            // b_exit
            // 
            this.b_exit.Location = new System.Drawing.Point(442, 376);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(103, 38);
            this.b_exit.TabIndex = 99;
            this.b_exit.Text = "Izadji";
            this.b_exit.UseVisualStyleBackColor = true;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // btn_KreirajKlijenta
            // 
            this.btn_KreirajKlijenta.Location = new System.Drawing.Point(551, 376);
            this.btn_KreirajKlijenta.Name = "btn_KreirajKlijenta";
            this.btn_KreirajKlijenta.Size = new System.Drawing.Size(103, 38);
            this.btn_KreirajKlijenta.TabIndex = 5;
            this.btn_KreirajKlijenta.Text = "Kreiraj";
            this.btn_KreirajKlijenta.UseVisualStyleBackColor = true;
            this.btn_KreirajKlijenta.Click += new System.EventHandler(this.b_klijent_Click);
            // 
            // lbl_Ime
            // 
            this.lbl_Ime.AutoSize = true;
            this.lbl_Ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Ime.Location = new System.Drawing.Point(248, 70);
            this.lbl_Ime.Name = "lbl_Ime";
            this.lbl_Ime.Size = new System.Drawing.Size(44, 20);
            this.lbl_Ime.TabIndex = 6;
            this.lbl_Ime.Text = "Ime:";
            // 
            // lbl_prezime
            // 
            this.lbl_prezime.AutoSize = true;
            this.lbl_prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_prezime.Location = new System.Drawing.Point(248, 130);
            this.lbl_prezime.Name = "lbl_prezime";
            this.lbl_prezime.Size = new System.Drawing.Size(78, 20);
            this.lbl_prezime.TabIndex = 7;
            this.lbl_prezime.Text = "Prezime:";
            // 
            // gb_NoviKlijent
            // 
            this.gb_NoviKlijent.Controls.Add(this.tb_Lozinka);
            this.gb_NoviKlijent.Controls.Add(this.label1);
            this.gb_NoviKlijent.Controls.Add(this.tb_godrodj);
            this.gb_NoviKlijent.Controls.Add(this.lb_godrodj);
            this.gb_NoviKlijent.Controls.Add(this.tb_jmbg);
            this.gb_NoviKlijent.Controls.Add(this.lb_jmbg);
            this.gb_NoviKlijent.Controls.Add(this.btn_KreirajKlijenta);
            this.gb_NoviKlijent.Controls.Add(this.lbl_prezime);
            this.gb_NoviKlijent.Controls.Add(this.b_exit);
            this.gb_NoviKlijent.Controls.Add(this.tb_prezime);
            this.gb_NoviKlijent.Controls.Add(this.lbl_Ime);
            this.gb_NoviKlijent.Controls.Add(this.tb_Ime);
            this.gb_NoviKlijent.Location = new System.Drawing.Point(12, 12);
            this.gb_NoviKlijent.Name = "gb_NoviKlijent";
            this.gb_NoviKlijent.Size = new System.Drawing.Size(969, 562);
            this.gb_NoviKlijent.TabIndex = 3;
            this.gb_NoviKlijent.TabStop = false;
            this.gb_NoviKlijent.Enter += new System.EventHandler(this.gb_NoviKlijent_Enter);
            // 
            // tb_Lozinka
            // 
            this.tb_Lozinka.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_Lozinka.Location = new System.Drawing.Point(376, 240);
            this.tb_Lozinka.Multiline = true;
            this.tb_Lozinka.Name = "tb_Lozinka";
            this.tb_Lozinka.Size = new System.Drawing.Size(250, 25);
            this.tb_Lozinka.TabIndex = 3;
            this.tb_Lozinka.TabStop = false;
            this.tb_Lozinka.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(248, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Lozinka";
            // 
            // tb_godrodj
            // 
            this.tb_godrodj.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_godrodj.Location = new System.Drawing.Point(476, 296);
            this.tb_godrodj.Multiline = true;
            this.tb_godrodj.Name = "tb_godrodj";
            this.tb_godrodj.Size = new System.Drawing.Size(150, 25);
            this.tb_godrodj.TabIndex = 4;
            this.tb_godrodj.TextChanged += new System.EventHandler(this.tb_godrodj_TextChanged);
            // 
            // lb_godrodj
            // 
            this.lb_godrodj.AutoSize = true;
            this.lb_godrodj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_godrodj.Location = new System.Drawing.Point(248, 304);
            this.lb_godrodj.Name = "lb_godrodj";
            this.lb_godrodj.Size = new System.Drawing.Size(148, 20);
            this.lb_godrodj.TabIndex = 12;
            this.lb_godrodj.Text = "Godina Rodjenja:";
            // 
            // tb_jmbg
            // 
            this.tb_jmbg.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_jmbg.Location = new System.Drawing.Point(376, 178);
            this.tb_jmbg.Multiline = true;
            this.tb_jmbg.Name = "tb_jmbg";
            this.tb_jmbg.Size = new System.Drawing.Size(250, 25);
            this.tb_jmbg.TabIndex = 2;
            this.tb_jmbg.TextChanged += new System.EventHandler(this.tb_jmbg_TextChanged);
            // 
            // lb_jmbg
            // 
            this.lb_jmbg.AutoSize = true;
            this.lb_jmbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_jmbg.Location = new System.Drawing.Point(248, 190);
            this.lb_jmbg.Name = "lb_jmbg";
            this.lb_jmbg.Size = new System.Drawing.Size(57, 20);
            this.lb_jmbg.TabIndex = 10;
            this.lb_jmbg.Text = "Jmbg:";
            // 
            // gb_GlavniEkran
            // 
            this.gb_GlavniEkran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gb_GlavniEkran.Controls.Add(this.lbl_KlijentGodRodj);
            this.gb_GlavniEkran.Controls.Add(this.lbl_KlijentJbmg);
            this.gb_GlavniEkran.Controls.Add(this.lbl_KlijentPrezime);
            this.gb_GlavniEkran.Controls.Add(this.lbl_KlijentIme);
            this.gb_GlavniEkran.Controls.Add(this.poruka_podaciklijent);
            this.gb_GlavniEkran.Controls.Add(this.lbl_podaciOklijentu);
            this.gb_GlavniEkran.Controls.Add(this.minusporuka);
            this.gb_GlavniEkran.Controls.Add(this.stanjeporuka);
            this.gb_GlavniEkran.Controls.Add(this.lbl3_minus);
            this.gb_GlavniEkran.Controls.Add(this.lbl2_trenstanje);
            this.gb_GlavniEkran.Controls.Add(this.bt2_din);
            this.gb_GlavniEkran.Controls.Add(this.bt1_Dev);
            this.gb_GlavniEkran.Controls.Add(this.gb_lbl_racun);
            this.gb_GlavniEkran.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gb_GlavniEkran.Location = new System.Drawing.Point(12, 21);
            this.gb_GlavniEkran.Name = "gb_GlavniEkran";
            this.gb_GlavniEkran.Size = new System.Drawing.Size(963, 547);
            this.gb_GlavniEkran.TabIndex = 11;
            this.gb_GlavniEkran.TabStop = false;
            this.gb_GlavniEkran.Enter += new System.EventHandler(this.gb_GlavniEkran_Enter);
            // 
            // poruka_podaciklijent
            // 
            this.poruka_podaciklijent.AutoSize = true;
            this.poruka_podaciklijent.Location = new System.Drawing.Point(152, 135);
            this.poruka_podaciklijent.Name = "poruka_podaciklijent";
            this.poruka_podaciklijent.Size = new System.Drawing.Size(0, 13);
            this.poruka_podaciklijent.TabIndex = 8;
            // 
            // lbl_podaciOklijentu
            // 
            this.lbl_podaciOklijentu.AutoSize = true;
            this.lbl_podaciOklijentu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_podaciOklijentu.Location = new System.Drawing.Point(17, 50);
            this.lbl_podaciOklijentu.Name = "lbl_podaciOklijentu";
            this.lbl_podaciOklijentu.Size = new System.Drawing.Size(170, 24);
            this.lbl_podaciOklijentu.TabIndex = 7;
            this.lbl_podaciOklijentu.Text = "Podaci o klijentu:";
            // 
            // minusporuka
            // 
            this.minusporuka.AutoSize = true;
            this.minusporuka.Location = new System.Drawing.Point(607, 98);
            this.minusporuka.Name = "minusporuka";
            this.minusporuka.Size = new System.Drawing.Size(0, 13);
            this.minusporuka.TabIndex = 6;
            // 
            // stanjeporuka
            // 
            this.stanjeporuka.AutoSize = true;
            this.stanjeporuka.Location = new System.Drawing.Point(607, 61);
            this.stanjeporuka.Name = "stanjeporuka";
            this.stanjeporuka.Size = new System.Drawing.Size(0, 13);
            this.stanjeporuka.TabIndex = 5;
            // 
            // lbl3_minus
            // 
            this.lbl3_minus.AutoSize = true;
            this.lbl3_minus.Location = new System.Drawing.Point(474, 98);
            this.lbl3_minus.Name = "lbl3_minus";
            this.lbl3_minus.Size = new System.Drawing.Size(89, 13);
            this.lbl3_minus.TabIndex = 4;
            this.lbl3_minus.Text = "Dozvoljeni minus:";
            // 
            // lbl2_trenstanje
            // 
            this.lbl2_trenstanje.AutoSize = true;
            this.lbl2_trenstanje.Location = new System.Drawing.Point(476, 61);
            this.lbl2_trenstanje.Name = "lbl2_trenstanje";
            this.lbl2_trenstanje.Size = new System.Drawing.Size(87, 13);
            this.lbl2_trenstanje.TabIndex = 3;
            this.lbl2_trenstanje.Text = "Trenutno stanje: ";
            // 
            // bt2_din
            // 
            this.bt2_din.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2_din.Location = new System.Drawing.Point(468, 206);
            this.bt2_din.Name = "bt2_din";
            this.bt2_din.Size = new System.Drawing.Size(237, 59);
            this.bt2_din.TabIndex = 2;
            this.bt2_din.Text = "Dinarski racun";
            this.bt2_din.UseVisualStyleBackColor = true;
            // 
            // bt1_Dev
            // 
            this.bt1_Dev.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1_Dev.Location = new System.Drawing.Point(468, 294);
            this.bt1_Dev.Name = "bt1_Dev";
            this.bt1_Dev.Size = new System.Drawing.Size(235, 58);
            this.bt1_Dev.TabIndex = 1;
            this.bt1_Dev.Text = "Devizni racun";
            this.bt1_Dev.UseVisualStyleBackColor = true;
            // 
            // gb_lbl_racun
            // 
            this.gb_lbl_racun.AutoSize = true;
            this.gb_lbl_racun.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gb_lbl_racun.Location = new System.Drawing.Point(476, 16);
            this.gb_lbl_racun.Name = "gb_lbl_racun";
            this.gb_lbl_racun.Size = new System.Drawing.Size(58, 23);
            this.gb_lbl_racun.TabIndex = 0;
            this.gb_lbl_racun.Text = "Racun";
            // 
            // lbl_Poruka
            // 
            this.lbl_Poruka.AutoSize = true;
            this.lbl_Poruka.Location = new System.Drawing.Point(224, 5);
            this.lbl_Poruka.Name = "lbl_Poruka";
            this.lbl_Poruka.Size = new System.Drawing.Size(35, 13);
            this.lbl_Poruka.TabIndex = 16;
            this.lbl_Poruka.Text = "label2";
            // 
            // gb_Login
            // 
            this.gb_Login.Controls.Add(this.label4);
            this.gb_Login.Controls.Add(this.label3);
            this.gb_Login.Controls.Add(this.btn_Login);
            this.gb_Login.Controls.Add(this.label2);
            this.gb_Login.Controls.Add(this.tb_Login_Lozinka);
            this.gb_Login.Controls.Add(this.tb_Login_Jmbg);
            this.gb_Login.Location = new System.Drawing.Point(12, 21);
            this.gb_Login.Name = "gb_Login";
            this.gb_Login.Size = new System.Drawing.Size(969, 553);
            this.gb_Login.TabIndex = 17;
            this.gb_Login.TabStop = false;
            // 
            // tb_Login_Jmbg
            // 
            this.tb_Login_Jmbg.Location = new System.Drawing.Point(415, 245);
            this.tb_Login_Jmbg.Name = "tb_Login_Jmbg";
            this.tb_Login_Jmbg.Size = new System.Drawing.Size(148, 20);
            this.tb_Login_Jmbg.TabIndex = 0;
            // 
            // tb_Login_Lozinka
            // 
            this.tb_Login_Lozinka.Location = new System.Drawing.Point(415, 287);
            this.tb_Login_Lozinka.Name = "tb_Login_Lozinka";
            this.tb_Login_Lozinka.Size = new System.Drawing.Size(148, 20);
            this.tb_Login_Lozinka.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Uloguj se na sistem";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(442, 333);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(87, 28);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Uloguj se";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lozinka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "JMBG";
            // 
            // lbl_KlijentIme
            // 
            this.lbl_KlijentIme.AutoSize = true;
            this.lbl_KlijentIme.Location = new System.Drawing.Point(18, 98);
            this.lbl_KlijentIme.Name = "lbl_KlijentIme";
            this.lbl_KlijentIme.Size = new System.Drawing.Size(35, 13);
            this.lbl_KlijentIme.TabIndex = 9;
            this.lbl_KlijentIme.Text = "label5";
            // 
            // lbl_KlijentPrezime
            // 
            this.lbl_KlijentPrezime.AutoSize = true;
            this.lbl_KlijentPrezime.Location = new System.Drawing.Point(18, 121);
            this.lbl_KlijentPrezime.Name = "lbl_KlijentPrezime";
            this.lbl_KlijentPrezime.Size = new System.Drawing.Size(35, 13);
            this.lbl_KlijentPrezime.TabIndex = 10;
            this.lbl_KlijentPrezime.Text = "label6";
            // 
            // lbl_KlijentJbmg
            // 
            this.lbl_KlijentJbmg.AutoSize = true;
            this.lbl_KlijentJbmg.Location = new System.Drawing.Point(18, 145);
            this.lbl_KlijentJbmg.Name = "lbl_KlijentJbmg";
            this.lbl_KlijentJbmg.Size = new System.Drawing.Size(35, 13);
            this.lbl_KlijentJbmg.TabIndex = 11;
            this.lbl_KlijentJbmg.Text = "label7";
            // 
            // lbl_KlijentGodRodj
            // 
            this.lbl_KlijentGodRodj.AutoSize = true;
            this.lbl_KlijentGodRodj.Location = new System.Drawing.Point(18, 169);
            this.lbl_KlijentGodRodj.Name = "lbl_KlijentGodRodj";
            this.lbl_KlijentGodRodj.Size = new System.Drawing.Size(35, 13);
            this.lbl_KlijentGodRodj.TabIndex = 12;
            this.lbl_KlijentGodRodj.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(986, 672);
            this.Controls.Add(this.lbl_Poruka);
            this.Controls.Add(this.gb_GlavniEkran);
            this.Controls.Add(this.gb_Login);
            this.Controls.Add(this.gb_NoviKlijent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "E-banka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_NoviKlijent.ResumeLayout(false);
            this.gb_NoviKlijent.PerformLayout();
            this.gb_GlavniEkran.ResumeLayout(false);
            this.gb_GlavniEkran.PerformLayout();
            this.gb_Login.ResumeLayout(false);
            this.gb_Login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Ime;
        private System.Windows.Forms.TextBox tb_prezime;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.Button btn_KreirajKlijenta;
        private System.Windows.Forms.Label lbl_Ime;
        private System.Windows.Forms.Label lbl_prezime;
        private System.Windows.Forms.GroupBox gb_NoviKlijent;
        private System.Windows.Forms.GroupBox gb_GlavniEkran;
        private System.Windows.Forms.Label gb_lbl_racun;
        private System.Windows.Forms.Label lb_jmbg;
        private System.Windows.Forms.TextBox tb_jmbg;
        private System.Windows.Forms.TextBox tb_godrodj;
        private System.Windows.Forms.Label lb_godrodj;
        private System.Windows.Forms.Label poruka_podaciklijent;
        private System.Windows.Forms.Label lbl_podaciOklijentu;
        private System.Windows.Forms.Label minusporuka;
        private System.Windows.Forms.Label stanjeporuka;
        private System.Windows.Forms.Label lbl3_minus;
        private System.Windows.Forms.Label lbl2_trenstanje;
        private System.Windows.Forms.Button bt2_din;
        private System.Windows.Forms.Button bt1_Dev;
        private System.Windows.Forms.TextBox tb_Lozinka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Poruka;
        private System.Windows.Forms.GroupBox gb_Login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Login_Lozinka;
        private System.Windows.Forms.TextBox tb_Login_Jmbg;
        private System.Windows.Forms.Label lbl_KlijentGodRodj;
        private System.Windows.Forms.Label lbl_KlijentJbmg;
        private System.Windows.Forms.Label lbl_KlijentPrezime;
        private System.Windows.Forms.Label lbl_KlijentIme;
    }
}

