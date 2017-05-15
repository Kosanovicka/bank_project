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
            this.b_klijent = new System.Windows.Forms.Button();
            this.lbl_Ime = new System.Windows.Forms.Label();
            this.lbl_prezime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gb1_login = new System.Windows.Forms.GroupBox();
            this.tb_godrodj = new System.Windows.Forms.TextBox();
            this.lb_godrodj = new System.Windows.Forms.Label();
            this.tb_jmbg = new System.Windows.Forms.TextBox();
            this.lb_jmbg = new System.Windows.Forms.Label();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.gb_lbl_racun = new System.Windows.Forms.Label();
            this.bt1_Dev = new System.Windows.Forms.Button();
            this.bt2_din = new System.Windows.Forms.Button();
            this.lbl2_trenstanje = new System.Windows.Forms.Label();
            this.lbl3_minus = new System.Windows.Forms.Label();
            this.stanjeporuka = new System.Windows.Forms.Label();
            this.minusporuka = new System.Windows.Forms.Label();
            this.lbl_podaciOklijentu = new System.Windows.Forms.Label();
            this.poruka_podaciklijent = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gb1_login.SuspendLayout();
            this.gb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Ime
            // 
            this.tb_Ime.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_Ime.Location = new System.Drawing.Point(317, 173);
            this.tb_Ime.Multiline = true;
            this.tb_Ime.Name = "tb_Ime";
            this.tb_Ime.Size = new System.Drawing.Size(278, 32);
            this.tb_Ime.TabIndex = 0;
            this.tb_Ime.TextChanged += new System.EventHandler(this.tb_Ime_TextChanged);
            // 
            // tb_prezime
            // 
            this.tb_prezime.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_prezime.Location = new System.Drawing.Point(317, 234);
            this.tb_prezime.Multiline = true;
            this.tb_prezime.Name = "tb_prezime";
            this.tb_prezime.Size = new System.Drawing.Size(278, 31);
            this.tb_prezime.TabIndex = 1;
            this.tb_prezime.TextChanged += new System.EventHandler(this.tb_prezime_TextChanged);
            // 
            // b_exit
            // 
            this.b_exit.Location = new System.Drawing.Point(384, 492);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(103, 38);
            this.b_exit.TabIndex = 4;
            this.b_exit.Text = "Izadji";
            this.b_exit.UseVisualStyleBackColor = true;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // b_klijent
            // 
            this.b_klijent.Location = new System.Drawing.Point(493, 492);
            this.b_klijent.Name = "b_klijent";
            this.b_klijent.Size = new System.Drawing.Size(103, 38);
            this.b_klijent.TabIndex = 5;
            this.b_klijent.Text = "Novi klijent";
            this.b_klijent.UseVisualStyleBackColor = true;
            this.b_klijent.Click += new System.EventHandler(this.b_klijent_Click);
            // 
            // lbl_Ime
            // 
            this.lbl_Ime.AutoSize = true;
            this.lbl_Ime.Font = new System.Drawing.Font("RomanT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Ime.Location = new System.Drawing.Point(189, 182);
            this.lbl_Ime.Name = "lbl_Ime";
            this.lbl_Ime.Size = new System.Drawing.Size(57, 23);
            this.lbl_Ime.TabIndex = 6;
            this.lbl_Ime.Text = "Ime:";
            this.lbl_Ime.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_prezime
            // 
            this.lbl_prezime.AutoSize = true;
            this.lbl_prezime.Font = new System.Drawing.Font("RomanT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_prezime.Location = new System.Drawing.Point(189, 242);
            this.lbl_prezime.Name = "lbl_prezime";
            this.lbl_prezime.Size = new System.Drawing.Size(107, 23);
            this.lbl_prezime.TabIndex = 7;
            this.lbl_prezime.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "ULOGUJTE SE NA NALOG";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(317, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 48);
            this.panel1.TabIndex = 9;
            // 
            // gb1_login
            // 
            this.gb1_login.Controls.Add(this.tb_godrodj);
            this.gb1_login.Controls.Add(this.lb_godrodj);
            this.gb1_login.Controls.Add(this.tb_jmbg);
            this.gb1_login.Controls.Add(this.lb_jmbg);
            this.gb1_login.Controls.Add(this.panel1);
            this.gb1_login.Controls.Add(this.b_klijent);
            this.gb1_login.Controls.Add(this.lbl_prezime);
            this.gb1_login.Controls.Add(this.b_exit);
            this.gb1_login.Controls.Add(this.tb_prezime);
            this.gb1_login.Controls.Add(this.lbl_Ime);
            this.gb1_login.Controls.Add(this.tb_Ime);
            this.gb1_login.Location = new System.Drawing.Point(12, 12);
            this.gb1_login.Name = "gb1_login";
            this.gb1_login.Size = new System.Drawing.Size(79, 56);
            this.gb1_login.TabIndex = 10;
            this.gb1_login.TabStop = false;
            this.gb1_login.Text = "Login";
            // 
            // tb_godrodj
            // 
            this.tb_godrodj.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_godrodj.Location = new System.Drawing.Point(418, 355);
            this.tb_godrodj.Multiline = true;
            this.tb_godrodj.Name = "tb_godrodj";
            this.tb_godrodj.Size = new System.Drawing.Size(177, 31);
            this.tb_godrodj.TabIndex = 13;
            this.tb_godrodj.TextChanged += new System.EventHandler(this.tb_godrodj_TextChanged);
            // 
            // lb_godrodj
            // 
            this.lb_godrodj.AutoSize = true;
            this.lb_godrodj.Font = new System.Drawing.Font("RomanT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_godrodj.Location = new System.Drawing.Point(189, 363);
            this.lb_godrodj.Name = "lb_godrodj";
            this.lb_godrodj.Size = new System.Drawing.Size(195, 23);
            this.lb_godrodj.TabIndex = 12;
            this.lb_godrodj.Text = "Godina Rodjenja:";
            // 
            // tb_jmbg
            // 
            this.tb_jmbg.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_jmbg.Location = new System.Drawing.Point(317, 294);
            this.tb_jmbg.Multiline = true;
            this.tb_jmbg.Name = "tb_jmbg";
            this.tb_jmbg.Size = new System.Drawing.Size(278, 31);
            this.tb_jmbg.TabIndex = 11;
            this.tb_jmbg.TextChanged += new System.EventHandler(this.tb_jmbg_TextChanged);
            // 
            // lb_jmbg
            // 
            this.lb_jmbg.AutoSize = true;
            this.lb_jmbg.Font = new System.Drawing.Font("RomanT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_jmbg.Location = new System.Drawing.Point(189, 302);
            this.lb_jmbg.Name = "lb_jmbg";
            this.lb_jmbg.Size = new System.Drawing.Size(72, 23);
            this.lb_jmbg.TabIndex = 10;
            this.lb_jmbg.Text = "Jmbg:";
            // 
            // gb2
            // 
            this.gb2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gb2.Controls.Add(this.poruka_podaciklijent);
            this.gb2.Controls.Add(this.lbl_podaciOklijentu);
            this.gb2.Controls.Add(this.minusporuka);
            this.gb2.Controls.Add(this.stanjeporuka);
            this.gb2.Controls.Add(this.lbl3_minus);
            this.gb2.Controls.Add(this.lbl2_trenstanje);
            this.gb2.Controls.Add(this.bt2_din);
            this.gb2.Controls.Add(this.bt1_Dev);
            this.gb2.Controls.Add(this.gb_lbl_racun);
            this.gb2.Location = new System.Drawing.Point(120, 12);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(138, 56);
            this.gb2.TabIndex = 11;
            this.gb2.TabStop = false;
            this.gb2.Text = "Racun Klijenta";
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
            // lbl2_trenstanje
            // 
            this.lbl2_trenstanje.AutoSize = true;
            this.lbl2_trenstanje.Location = new System.Drawing.Point(476, 61);
            this.lbl2_trenstanje.Name = "lbl2_trenstanje";
            this.lbl2_trenstanje.Size = new System.Drawing.Size(87, 13);
            this.lbl2_trenstanje.TabIndex = 3;
            this.lbl2_trenstanje.Text = "Trenutno stanje: ";
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
            // stanjeporuka
            // 
            this.stanjeporuka.AutoSize = true;
            this.stanjeporuka.Location = new System.Drawing.Point(607, 61);
            this.stanjeporuka.Name = "stanjeporuka";
            this.stanjeporuka.Size = new System.Drawing.Size(0, 13);
            this.stanjeporuka.TabIndex = 5;
            // 
            // minusporuka
            // 
            this.minusporuka.AutoSize = true;
            this.minusporuka.Location = new System.Drawing.Point(607, 98);
            this.minusporuka.Name = "minusporuka";
            this.minusporuka.Size = new System.Drawing.Size(0, 13);
            this.minusporuka.TabIndex = 6;
            // 
            // lbl_podaciOklijentu
            // 
            this.lbl_podaciOklijentu.AutoSize = true;
            this.lbl_podaciOklijentu.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_podaciOklijentu.Location = new System.Drawing.Point(17, 50);
            this.lbl_podaciOklijentu.Name = "lbl_podaciOklijentu";
            this.lbl_podaciOklijentu.Size = new System.Drawing.Size(208, 22);
            this.lbl_podaciOklijentu.TabIndex = 7;
            this.lbl_podaciOklijentu.Text = "Podaci o klijentu:";
            // 
            // poruka_podaciklijent
            // 
            this.poruka_podaciklijent.AutoSize = true;
            this.poruka_podaciklijent.Location = new System.Drawing.Point(152, 135);
            this.poruka_podaciklijent.Name = "poruka_podaciklijent";
            this.poruka_podaciklijent.Size = new System.Drawing.Size(0, 13);
            this.poruka_podaciklijent.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(986, 672);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1_login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "E-banka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb1_login.ResumeLayout(false);
            this.gb1_login.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Ime;
        private System.Windows.Forms.TextBox tb_prezime;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.Button b_klijent;
        private System.Windows.Forms.Label lbl_Ime;
        private System.Windows.Forms.Label lbl_prezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gb1_login;
        private System.Windows.Forms.GroupBox gb2;
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
    }
}

