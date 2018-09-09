namespace CardBringer2
{
    partial class Pocetna
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
            this.components = new System.ComponentModel.Container();
            this.btnPocetanGumbDodajUKosaricu = new System.Windows.Forms.Button();
            this.tboxPocetnaPretragabox = new System.Windows.Forms.TextBox();
            this.btnPocetnaTrazigumb = new System.Windows.Forms.Button();
            this.dgvPocetnaDatagridSviOglasi = new System.Windows.Forms.DataGridView();
            this.lblPocetnaBrojKarata = new System.Windows.Forms.Label();
            this.btnPocetnaResetgumb = new System.Windows.Forms.Button();
            this.lblPocetnaCijenaKarte = new System.Windows.Forms.Label();
            this.lblPocetnaIspisCijenaKarte = new System.Windows.Forms.Label();
            this.lblPocetnaProdavac = new System.Windows.Forms.Label();
            this.lblPocetnaIspisProdavac = new System.Windows.Forms.Label();
            this.lblPocetnaIspisImeKarte = new System.Windows.Forms.Label();
            this.lblPocetnaImeKarte = new System.Windows.Forms.Label();
            this.lblPocetnaKolicina = new System.Windows.Forms.Label();
            this.lblPocetnaIspisKolicina = new System.Windows.Forms.Label();
            this.rtboxPocetnaOpisKarte = new System.Windows.Forms.RichTextBox();
            this.pboxPocetnaSlikaKarte = new System.Windows.Forms.PictureBox();
            this.oglasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tboxPocetnaBrojKarataZaKosaricu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPocetnaDatagridSviOglasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPocetnaSlikaKarte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oglasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPocetanGumbDodajUKosaricu
            // 
            this.btnPocetanGumbDodajUKosaricu.Location = new System.Drawing.Point(676, 125);
            this.btnPocetanGumbDodajUKosaricu.Name = "btnPocetanGumbDodajUKosaricu";
            this.btnPocetanGumbDodajUKosaricu.Size = new System.Drawing.Size(83, 48);
            this.btnPocetanGumbDodajUKosaricu.TabIndex = 15;
            this.btnPocetanGumbDodajUKosaricu.Text = "U Kosaricu";
            this.btnPocetanGumbDodajUKosaricu.UseVisualStyleBackColor = true;
            this.btnPocetanGumbDodajUKosaricu.Click += new System.EventHandler(this.btnPocetanGumbDodajUKosaricu_Click);
            // 
            // tboxPocetnaPretragabox
            // 
            this.tboxPocetnaPretragabox.Location = new System.Drawing.Point(390, 61);
            this.tboxPocetnaPretragabox.Name = "tboxPocetnaPretragabox";
            this.tboxPocetnaPretragabox.Size = new System.Drawing.Size(168, 20);
            this.tboxPocetnaPretragabox.TabIndex = 14;
            this.tboxPocetnaPretragabox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxPocetnaPretragabox_KeyDown);
            // 
            // btnPocetnaTrazigumb
            // 
            this.btnPocetnaTrazigumb.Location = new System.Drawing.Point(564, 59);
            this.btnPocetnaTrazigumb.Name = "btnPocetnaTrazigumb";
            this.btnPocetnaTrazigumb.Size = new System.Drawing.Size(48, 23);
            this.btnPocetnaTrazigumb.TabIndex = 13;
            this.btnPocetnaTrazigumb.Text = "Trazi!";
            this.btnPocetnaTrazigumb.UseVisualStyleBackColor = true;
            this.btnPocetnaTrazigumb.Click += new System.EventHandler(this.btnPocetnaTrazigumb_Click);
            // 
            // dgvPocetnaDatagridSviOglasi
            // 
            this.dgvPocetnaDatagridSviOglasi.AllowUserToAddRows = false;
            this.dgvPocetnaDatagridSviOglasi.AllowUserToDeleteRows = false;
            this.dgvPocetnaDatagridSviOglasi.CausesValidation = false;
            this.dgvPocetnaDatagridSviOglasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPocetnaDatagridSviOglasi.Location = new System.Drawing.Point(12, 85);
            this.dgvPocetnaDatagridSviOglasi.Name = "dgvPocetnaDatagridSviOglasi";
            this.dgvPocetnaDatagridSviOglasi.ReadOnly = true;
            this.dgvPocetnaDatagridSviOglasi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPocetnaDatagridSviOglasi.Size = new System.Drawing.Size(659, 482);
            this.dgvPocetnaDatagridSviOglasi.TabIndex = 12;
            this.dgvPocetnaDatagridSviOglasi.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPocetnaDatagridSviOglasi_RowEnter);
            // 
            // lblPocetnaBrojKarata
            // 
            this.lblPocetnaBrojKarata.AutoSize = true;
            this.lblPocetnaBrojKarata.ForeColor = System.Drawing.Color.White;
            this.lblPocetnaBrojKarata.Location = new System.Drawing.Point(674, 85);
            this.lblPocetnaBrojKarata.Name = "lblPocetnaBrojKarata";
            this.lblPocetnaBrojKarata.Size = new System.Drawing.Size(61, 13);
            this.lblPocetnaBrojKarata.TabIndex = 11;
            this.lblPocetnaBrojKarata.Text = "Broj karata:";
            // 
            // btnPocetnaResetgumb
            // 
            this.btnPocetnaResetgumb.Location = new System.Drawing.Point(618, 59);
            this.btnPocetnaResetgumb.Name = "btnPocetnaResetgumb";
            this.btnPocetnaResetgumb.Size = new System.Drawing.Size(53, 23);
            this.btnPocetnaResetgumb.TabIndex = 16;
            this.btnPocetnaResetgumb.Text = "Reset";
            this.btnPocetnaResetgumb.UseVisualStyleBackColor = true;
            this.btnPocetnaResetgumb.Click += new System.EventHandler(this.btnPocetnaResetgumb_Click);
            // 
            // lblPocetnaCijenaKarte
            // 
            this.lblPocetnaCijenaKarte.AutoSize = true;
            this.lblPocetnaCijenaKarte.ForeColor = System.Drawing.Color.White;
            this.lblPocetnaCijenaKarte.Location = new System.Drawing.Point(772, 498);
            this.lblPocetnaCijenaKarte.Name = "lblPocetnaCijenaKarte";
            this.lblPocetnaCijenaKarte.Size = new System.Drawing.Size(39, 13);
            this.lblPocetnaCijenaKarte.TabIndex = 19;
            this.lblPocetnaCijenaKarte.Text = "Cijena:";
            // 
            // lblPocetnaIspisCijenaKarte
            // 
            this.lblPocetnaIspisCijenaKarte.AutoSize = true;
            this.lblPocetnaIspisCijenaKarte.ForeColor = System.Drawing.Color.White;
            this.lblPocetnaIspisCijenaKarte.Location = new System.Drawing.Point(818, 498);
            this.lblPocetnaIspisCijenaKarte.Name = "lblPocetnaIspisCijenaKarte";
            this.lblPocetnaIspisCijenaKarte.Size = new System.Drawing.Size(35, 13);
            this.lblPocetnaIspisCijenaKarte.TabIndex = 19;
            this.lblPocetnaIspisCijenaKarte.Text = "label1";
            // 
            // lblPocetnaProdavac
            // 
            this.lblPocetnaProdavac.AutoSize = true;
            this.lblPocetnaProdavac.ForeColor = System.Drawing.Color.White;
            this.lblPocetnaProdavac.Location = new System.Drawing.Point(758, 544);
            this.lblPocetnaProdavac.Name = "lblPocetnaProdavac";
            this.lblPocetnaProdavac.Size = new System.Drawing.Size(56, 13);
            this.lblPocetnaProdavac.TabIndex = 19;
            this.lblPocetnaProdavac.Text = "Prodavač:";
            // 
            // lblPocetnaIspisProdavac
            // 
            this.lblPocetnaIspisProdavac.AutoSize = true;
            this.lblPocetnaIspisProdavac.ForeColor = System.Drawing.Color.White;
            this.lblPocetnaIspisProdavac.Location = new System.Drawing.Point(818, 544);
            this.lblPocetnaIspisProdavac.Name = "lblPocetnaIspisProdavac";
            this.lblPocetnaIspisProdavac.Size = new System.Drawing.Size(35, 13);
            this.lblPocetnaIspisProdavac.TabIndex = 19;
            this.lblPocetnaIspisProdavac.Text = "label1";
            // 
            // lblPocetnaIspisImeKarte
            // 
            this.lblPocetnaIspisImeKarte.AutoSize = true;
            this.lblPocetnaIspisImeKarte.ForeColor = System.Drawing.Color.White;
            this.lblPocetnaIspisImeKarte.Location = new System.Drawing.Point(818, 477);
            this.lblPocetnaIspisImeKarte.Name = "lblPocetnaIspisImeKarte";
            this.lblPocetnaIspisImeKarte.Size = new System.Drawing.Size(35, 13);
            this.lblPocetnaIspisImeKarte.TabIndex = 19;
            this.lblPocetnaIspisImeKarte.Text = "label1";
            // 
            // lblPocetnaImeKarte
            // 
            this.lblPocetnaImeKarte.AutoSize = true;
            this.lblPocetnaImeKarte.ForeColor = System.Drawing.Color.White;
            this.lblPocetnaImeKarte.Location = new System.Drawing.Point(758, 477);
            this.lblPocetnaImeKarte.Name = "lblPocetnaImeKarte";
            this.lblPocetnaImeKarte.Size = new System.Drawing.Size(54, 13);
            this.lblPocetnaImeKarte.TabIndex = 19;
            this.lblPocetnaImeKarte.Text = "Ime karte:";
            // 
            // lblPocetnaKolicina
            // 
            this.lblPocetnaKolicina.AutoSize = true;
            this.lblPocetnaKolicina.ForeColor = System.Drawing.Color.White;
            this.lblPocetnaKolicina.Location = new System.Drawing.Point(772, 522);
            this.lblPocetnaKolicina.Name = "lblPocetnaKolicina";
            this.lblPocetnaKolicina.Size = new System.Drawing.Size(47, 13);
            this.lblPocetnaKolicina.TabIndex = 19;
            this.lblPocetnaKolicina.Text = "Količina:";
            // 
            // lblPocetnaIspisKolicina
            // 
            this.lblPocetnaIspisKolicina.AutoSize = true;
            this.lblPocetnaIspisKolicina.ForeColor = System.Drawing.Color.White;
            this.lblPocetnaIspisKolicina.Location = new System.Drawing.Point(818, 522);
            this.lblPocetnaIspisKolicina.Name = "lblPocetnaIspisKolicina";
            this.lblPocetnaIspisKolicina.Size = new System.Drawing.Size(35, 13);
            this.lblPocetnaIspisKolicina.TabIndex = 19;
            this.lblPocetnaIspisKolicina.Text = "label1";
            // 
            // rtboxPocetnaOpisKarte
            // 
            this.rtboxPocetnaOpisKarte.Location = new System.Drawing.Point(950, 477);
            this.rtboxPocetnaOpisKarte.Margin = new System.Windows.Forms.Padding(2);
            this.rtboxPocetnaOpisKarte.Name = "rtboxPocetnaOpisKarte";
            this.rtboxPocetnaOpisKarte.ReadOnly = true;
            this.rtboxPocetnaOpisKarte.Size = new System.Drawing.Size(267, 81);
            this.rtboxPocetnaOpisKarte.TabIndex = 33;
            this.rtboxPocetnaOpisKarte.Text = "";
            // 
            // pboxPocetnaSlikaKarte
            // 
            this.pboxPocetnaSlikaKarte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxPocetnaSlikaKarte.Location = new System.Drawing.Point(950, 101);
            this.pboxPocetnaSlikaKarte.Margin = new System.Windows.Forms.Padding(2);
            this.pboxPocetnaSlikaKarte.Name = "pboxPocetnaSlikaKarte";
            this.pboxPocetnaSlikaKarte.Size = new System.Drawing.Size(267, 351);
            this.pboxPocetnaSlikaKarte.TabIndex = 32;
            this.pboxPocetnaSlikaKarte.TabStop = false;
            // 
            // tboxPocetnaBrojKarataZaKosaricu
            // 
            this.tboxPocetnaBrojKarataZaKosaricu.Location = new System.Drawing.Point(676, 102);
            this.tboxPocetnaBrojKarataZaKosaricu.Margin = new System.Windows.Forms.Padding(2);
            this.tboxPocetnaBrojKarataZaKosaricu.Name = "tboxPocetnaBrojKarataZaKosaricu";
            this.tboxPocetnaBrojKarataZaKosaricu.Size = new System.Drawing.Size(84, 20);
            this.tboxPocetnaBrojKarataZaKosaricu.TabIndex = 34;
            this.tboxPocetnaBrojKarataZaKosaricu.Text = "1";
            this.tboxPocetnaBrojKarataZaKosaricu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PocetnaBrojKarataZaKosaricu_KeyDown);
            this.tboxPocetnaBrojKarataZaKosaricu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PocetnaBrojKarataZaKosaricu_KeyPress);
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1203, 603);
            this.Controls.Add(this.tboxPocetnaBrojKarataZaKosaricu);
            this.Controls.Add(this.rtboxPocetnaOpisKarte);
            this.Controls.Add(this.pboxPocetnaSlikaKarte);
            this.Controls.Add(this.lblPocetnaIspisImeKarte);
            this.Controls.Add(this.lblPocetnaIspisProdavac);
            this.Controls.Add(this.lblPocetnaImeKarte);
            this.Controls.Add(this.lblPocetnaProdavac);
            this.Controls.Add(this.lblPocetnaIspisKolicina);
            this.Controls.Add(this.lblPocetnaIspisCijenaKarte);
            this.Controls.Add(this.lblPocetnaKolicina);
            this.Controls.Add(this.lblPocetnaCijenaKarte);
            this.Controls.Add(this.btnPocetnaResetgumb);
            this.Controls.Add(this.btnPocetanGumbDodajUKosaricu);
            this.Controls.Add(this.tboxPocetnaPretragabox);
            this.Controls.Add(this.btnPocetnaTrazigumb);
            this.Controls.Add(this.dgvPocetnaDatagridSviOglasi);
            this.Controls.Add(this.lblPocetnaBrojKarata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Pocetna";
            this.Text = "Pocetna";
            this.Load += new System.EventHandler(this.Pocetna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPocetnaDatagridSviOglasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPocetnaSlikaKarte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oglasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPocetanGumbDodajUKosaricu;
        private System.Windows.Forms.TextBox tboxPocetnaPretragabox;
        private System.Windows.Forms.Button btnPocetnaTrazigumb;
        private System.Windows.Forms.DataGridView dgvPocetnaDatagridSviOglasi;
        private System.Windows.Forms.Label lblPocetnaBrojKarata;
        private System.Windows.Forms.Button btnPocetnaResetgumb;
        private System.Windows.Forms.Label lblPocetnaCijenaKarte;
        private System.Windows.Forms.Label lblPocetnaIspisCijenaKarte;
        private System.Windows.Forms.Label lblPocetnaProdavac;
        private System.Windows.Forms.Label lblPocetnaIspisProdavac;
        private System.Windows.Forms.Label lblPocetnaIspisImeKarte;
        private System.Windows.Forms.Label lblPocetnaImeKarte;
        private System.Windows.Forms.Label lblPocetnaKolicina;
        private System.Windows.Forms.Label lblPocetnaIspisKolicina;
        private System.Windows.Forms.BindingSource oglasBindingSource;
        private System.Windows.Forms.RichTextBox rtboxPocetnaOpisKarte;
        private System.Windows.Forms.PictureBox pboxPocetnaSlikaKarte;
        private System.Windows.Forms.TextBox tboxPocetnaBrojKarataZaKosaricu;
    }
}