﻿namespace CardBringer2
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
            this.PocetanGumbDodajUKosaricu = new System.Windows.Forms.Button();
            this.PocetnaPretragaText = new System.Windows.Forms.TextBox();
            this.PocetnaPretragaGumbTrazi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PocetnaLabelSveKarte = new System.Windows.Forms.Label();
            this.PocetnaResetGumb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cijenaKarte = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prodavacKarte = new System.Windows.Forms.Label();
            this.imeKarte = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kolicinaKarata = new System.Windows.Forms.Label();
            this.opisKarte = new System.Windows.Forms.RichTextBox();
            this.pictureBoxSlikaKarte = new System.Windows.Forms.PictureBox();
            this.oglasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PocetnaBrojKarataZaKosaricu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlikaKarte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oglasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PocetanGumbDodajUKosaricu
            // 
            this.PocetanGumbDodajUKosaricu.Location = new System.Drawing.Point(676, 125);
            this.PocetanGumbDodajUKosaricu.Name = "PocetanGumbDodajUKosaricu";
            this.PocetanGumbDodajUKosaricu.Size = new System.Drawing.Size(83, 48);
            this.PocetanGumbDodajUKosaricu.TabIndex = 15;
            this.PocetanGumbDodajUKosaricu.Text = "U Kosaricu";
            this.PocetanGumbDodajUKosaricu.UseVisualStyleBackColor = true;
            this.PocetanGumbDodajUKosaricu.Click += new System.EventHandler(this.PocetanGumbDodajUKosaricu_Click);
            // 
            // PocetnaPretragaText
            // 
            this.PocetnaPretragaText.Location = new System.Drawing.Point(390, 61);
            this.PocetnaPretragaText.Name = "PocetnaPretragaText";
            this.PocetnaPretragaText.Size = new System.Drawing.Size(168, 20);
            this.PocetnaPretragaText.TabIndex = 14;
            this.PocetnaPretragaText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PocetnaPretragaText_KeyDown);
            // 
            // PocetnaPretragaGumbTrazi
            // 
            this.PocetnaPretragaGumbTrazi.Location = new System.Drawing.Point(564, 59);
            this.PocetnaPretragaGumbTrazi.Name = "PocetnaPretragaGumbTrazi";
            this.PocetnaPretragaGumbTrazi.Size = new System.Drawing.Size(48, 23);
            this.PocetnaPretragaGumbTrazi.TabIndex = 13;
            this.PocetnaPretragaGumbTrazi.Text = "Trazi!";
            this.PocetnaPretragaGumbTrazi.UseVisualStyleBackColor = true;
            this.PocetnaPretragaGumbTrazi.Click += new System.EventHandler(this.PocetnaPretragaGumbTrazi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.CausesValidation = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(659, 482);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // PocetnaLabelSveKarte
            // 
            this.PocetnaLabelSveKarte.AutoSize = true;
            this.PocetnaLabelSveKarte.ForeColor = System.Drawing.Color.White;
            this.PocetnaLabelSveKarte.Location = new System.Drawing.Point(674, 85);
            this.PocetnaLabelSveKarte.Name = "PocetnaLabelSveKarte";
            this.PocetnaLabelSveKarte.Size = new System.Drawing.Size(61, 13);
            this.PocetnaLabelSveKarte.TabIndex = 11;
            this.PocetnaLabelSveKarte.Text = "Broj karata:";
            // 
            // PocetnaResetGumb
            // 
            this.PocetnaResetGumb.Location = new System.Drawing.Point(618, 59);
            this.PocetnaResetGumb.Name = "PocetnaResetGumb";
            this.PocetnaResetGumb.Size = new System.Drawing.Size(53, 23);
            this.PocetnaResetGumb.TabIndex = 16;
            this.PocetnaResetGumb.Text = "Reset";
            this.PocetnaResetGumb.UseVisualStyleBackColor = true;
            this.PocetnaResetGumb.Click += new System.EventHandler(this.PocetnaResetGumb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(772, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cijena:";
            // 
            // cijenaKarte
            // 
            this.cijenaKarte.AutoSize = true;
            this.cijenaKarte.ForeColor = System.Drawing.Color.White;
            this.cijenaKarte.Location = new System.Drawing.Point(818, 498);
            this.cijenaKarte.Name = "cijenaKarte";
            this.cijenaKarte.Size = new System.Drawing.Size(35, 13);
            this.cijenaKarte.TabIndex = 19;
            this.cijenaKarte.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(758, 544);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Prodavač:";
            // 
            // prodavacKarte
            // 
            this.prodavacKarte.AutoSize = true;
            this.prodavacKarte.ForeColor = System.Drawing.Color.White;
            this.prodavacKarte.Location = new System.Drawing.Point(818, 544);
            this.prodavacKarte.Name = "prodavacKarte";
            this.prodavacKarte.Size = new System.Drawing.Size(35, 13);
            this.prodavacKarte.TabIndex = 19;
            this.prodavacKarte.Text = "label1";
            // 
            // imeKarte
            // 
            this.imeKarte.AutoSize = true;
            this.imeKarte.ForeColor = System.Drawing.Color.White;
            this.imeKarte.Location = new System.Drawing.Point(818, 477);
            this.imeKarte.Name = "imeKarte";
            this.imeKarte.Size = new System.Drawing.Size(35, 13);
            this.imeKarte.TabIndex = 19;
            this.imeKarte.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(758, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ime karte:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(772, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Količina:";
            // 
            // kolicinaKarata
            // 
            this.kolicinaKarata.AutoSize = true;
            this.kolicinaKarata.ForeColor = System.Drawing.Color.White;
            this.kolicinaKarata.Location = new System.Drawing.Point(818, 522);
            this.kolicinaKarata.Name = "kolicinaKarata";
            this.kolicinaKarata.Size = new System.Drawing.Size(35, 13);
            this.kolicinaKarata.TabIndex = 19;
            this.kolicinaKarata.Text = "label1";
            // 
            // opisKarte
            // 
            this.opisKarte.Location = new System.Drawing.Point(950, 477);
            this.opisKarte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.opisKarte.Name = "opisKarte";
            this.opisKarte.ReadOnly = true;
            this.opisKarte.Size = new System.Drawing.Size(267, 81);
            this.opisKarte.TabIndex = 33;
            this.opisKarte.Text = "";
            // 
            // pictureBoxSlikaKarte
            // 
            this.pictureBoxSlikaKarte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSlikaKarte.Location = new System.Drawing.Point(950, 101);
            this.pictureBoxSlikaKarte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxSlikaKarte.Name = "pictureBoxSlikaKarte";
            this.pictureBoxSlikaKarte.Size = new System.Drawing.Size(267, 351);
            this.pictureBoxSlikaKarte.TabIndex = 32;
            this.pictureBoxSlikaKarte.TabStop = false;
            // 
            // PocetnaBrojKarataZaKosaricu
            // 
            this.PocetnaBrojKarataZaKosaricu.Location = new System.Drawing.Point(676, 102);
            this.PocetnaBrojKarataZaKosaricu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PocetnaBrojKarataZaKosaricu.Name = "PocetnaBrojKarataZaKosaricu";
            this.PocetnaBrojKarataZaKosaricu.Size = new System.Drawing.Size(84, 20);
            this.PocetnaBrojKarataZaKosaricu.TabIndex = 34;
            this.PocetnaBrojKarataZaKosaricu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PocetnaBrojKarataZaKosaricu_KeyDown);
            this.PocetnaBrojKarataZaKosaricu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PocetnaBrojKarataZaKosaricu_KeyPress);
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1203, 603);
            this.Controls.Add(this.PocetnaBrojKarataZaKosaricu);
            this.Controls.Add(this.opisKarte);
            this.Controls.Add(this.pictureBoxSlikaKarte);
            this.Controls.Add(this.imeKarte);
            this.Controls.Add(this.prodavacKarte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kolicinaKarata);
            this.Controls.Add(this.cijenaKarte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PocetnaResetGumb);
            this.Controls.Add(this.PocetanGumbDodajUKosaricu);
            this.Controls.Add(this.PocetnaPretragaText);
            this.Controls.Add(this.PocetnaPretragaGumbTrazi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PocetnaLabelSveKarte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Pocetna";
            this.Text = "Pocetna";
            this.Load += new System.EventHandler(this.Pocetna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlikaKarte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oglasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PocetanGumbDodajUKosaricu;
        private System.Windows.Forms.TextBox PocetnaPretragaText;
        private System.Windows.Forms.Button PocetnaPretragaGumbTrazi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label PocetnaLabelSveKarte;
        private System.Windows.Forms.Button PocetnaResetGumb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cijenaKarte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label prodavacKarte;
        private System.Windows.Forms.Label imeKarte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label kolicinaKarata;
        private System.Windows.Forms.BindingSource oglasBindingSource;
        private System.Windows.Forms.RichTextBox opisKarte;
        private System.Windows.Forms.PictureBox pictureBoxSlikaKarte;
        private System.Windows.Forms.TextBox PocetnaBrojKarataZaKosaricu;
    }
}