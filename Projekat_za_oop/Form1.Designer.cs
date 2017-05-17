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
            this.lbl_brRac = new System.Windows.Forms.Label();
            this.lbl_Iznos = new System.Windows.Forms.Label();
            this.lbl_podaciONovcu = new System.Windows.Forms.Label();
            this.tb_brRacuna = new System.Windows.Forms.TextBox();
            this.tb_iznos = new System.Windows.Forms.TextBox();
            this.richTB_poruka = new System.Windows.Forms.RichTextBox();
            this.b_uplati = new System.Windows.Forms.Button();
            this.b_isplati = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_brRac
            // 
            this.lbl_brRac.AutoSize = true;
            this.lbl_brRac.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_brRac.Location = new System.Drawing.Point(486, 55);
            this.lbl_brRac.Name = "lbl_brRac";
            this.lbl_brRac.Size = new System.Drawing.Size(81, 18);
            this.lbl_brRac.TabIndex = 0;
            this.lbl_brRac.Text = "Broj racuna:";
            // 
            // lbl_Iznos
            // 
            this.lbl_Iznos.AutoSize = true;
            this.lbl_Iznos.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Iznos.Location = new System.Drawing.Point(486, 121);
            this.lbl_Iznos.Name = "lbl_Iznos";
            this.lbl_Iznos.Size = new System.Drawing.Size(44, 18);
            this.lbl_Iznos.TabIndex = 1;
            this.lbl_Iznos.Text = "Iznos:";
            // 
            // lbl_podaciONovcu
            // 
            this.lbl_podaciONovcu.AutoSize = true;
            this.lbl_podaciONovcu.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_podaciONovcu.Location = new System.Drawing.Point(486, 399);
            this.lbl_podaciONovcu.Name = "lbl_podaciONovcu";
            this.lbl_podaciONovcu.Size = new System.Drawing.Size(168, 18);
            this.lbl_podaciONovcu.TabIndex = 2;
            this.lbl_podaciONovcu.Text = "Podaci o stanju na racunu:";
            // 
            // tb_brRacuna
            // 
            this.tb_brRacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_brRacuna.Location = new System.Drawing.Point(573, 51);
            this.tb_brRacuna.Name = "tb_brRacuna";
            this.tb_brRacuna.Size = new System.Drawing.Size(202, 24);
            this.tb_brRacuna.TabIndex = 3;
            // 
            // tb_iznos
            // 
            this.tb_iznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_iznos.Location = new System.Drawing.Point(573, 117);
            this.tb_iznos.Name = "tb_iznos";
            this.tb_iznos.Size = new System.Drawing.Size(202, 24);
            this.tb_iznos.TabIndex = 4;
            this.tb_iznos.TextChanged += new System.EventHandler(this.tb_iznos_TextChanged);
            // 
            // richTB_poruka
            // 
            this.richTB_poruka.Location = new System.Drawing.Point(681, 399);
            this.richTB_poruka.Name = "richTB_poruka";
            this.richTB_poruka.Size = new System.Drawing.Size(243, 139);
            this.richTB_poruka.TabIndex = 5;
            this.richTB_poruka.Text = "";
            // 
            // b_uplati
            // 
            this.b_uplati.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_uplati.Location = new System.Drawing.Point(573, 235);
            this.b_uplati.Name = "b_uplati";
            this.b_uplati.Size = new System.Drawing.Size(84, 39);
            this.b_uplati.TabIndex = 6;
            this.b_uplati.Text = "UPLATA";
            this.b_uplati.UseVisualStyleBackColor = true;
            this.b_uplati.Click += new System.EventHandler(this.b_uplati_Click);
            // 
            // b_isplati
            // 
            this.b_isplati.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_isplati.Location = new System.Drawing.Point(691, 235);
            this.b_isplati.Name = "b_isplati";
            this.b_isplati.Size = new System.Drawing.Size(84, 39);
            this.b_isplati.TabIndex = 7;
            this.b_isplati.Text = "ISPLATA";
            this.b_isplati.UseVisualStyleBackColor = true;
            this.b_isplati.Click += new System.EventHandler(this.b_isplati_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_cancel.Location = new System.Drawing.Point(691, 578);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(84, 39);
            this.b_cancel.TabIndex = 8;
            this.b_cancel.Text = "IZADJI";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(986, 672);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_isplati);
            this.Controls.Add(this.b_uplati);
            this.Controls.Add(this.richTB_poruka);
            this.Controls.Add(this.tb_iznos);
            this.Controls.Add(this.tb_brRacuna);
            this.Controls.Add(this.lbl_podaciONovcu);
            this.Controls.Add(this.lbl_Iznos);
            this.Controls.Add(this.lbl_brRac);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "E-banka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_brRac;
        private System.Windows.Forms.Label lbl_Iznos;
        private System.Windows.Forms.Label lbl_podaciONovcu;
        private System.Windows.Forms.TextBox tb_brRacuna;
        private System.Windows.Forms.TextBox tb_iznos;
        private System.Windows.Forms.RichTextBox richTB_poruka;
        private System.Windows.Forms.Button b_uplati;
        private System.Windows.Forms.Button b_isplati;
        private System.Windows.Forms.Button b_cancel;
    }
}

