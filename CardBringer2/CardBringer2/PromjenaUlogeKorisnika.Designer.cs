﻿namespace CardBringer2
{
    partial class PromjenaUlogeKorisnika
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDodajAdmina = new System.Windows.Forms.Button();
            this.buttonMakniAdmina = new System.Windows.Forms.Button();
            this.buttonIzbrisiKorisnika = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(803, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonDodajAdmina
            // 
            this.buttonDodajAdmina.Location = new System.Drawing.Point(844, 156);
            this.buttonDodajAdmina.Name = "buttonDodajAdmina";
            this.buttonDodajAdmina.Size = new System.Drawing.Size(169, 72);
            this.buttonDodajAdmina.TabIndex = 1;
            this.buttonDodajAdmina.Text = "Daj administratorske privilegije";
            this.buttonDodajAdmina.UseVisualStyleBackColor = true;
            this.buttonDodajAdmina.Click += new System.EventHandler(this.buttonDodajAdmina_Click);
            // 
            // buttonMakniAdmina
            // 
            this.buttonMakniAdmina.Location = new System.Drawing.Point(844, 234);
            this.buttonMakniAdmina.Name = "buttonMakniAdmina";
            this.buttonMakniAdmina.Size = new System.Drawing.Size(169, 72);
            this.buttonMakniAdmina.TabIndex = 1;
            this.buttonMakniAdmina.Text = "Makni administratorske privilegije";
            this.buttonMakniAdmina.UseVisualStyleBackColor = true;
            this.buttonMakniAdmina.Click += new System.EventHandler(this.buttonMakniAdmina_Click);
            // 
            // buttonIzbrisiKorisnika
            // 
            this.buttonIzbrisiKorisnika.Location = new System.Drawing.Point(844, 312);
            this.buttonIzbrisiKorisnika.Name = "buttonIzbrisiKorisnika";
            this.buttonIzbrisiKorisnika.Size = new System.Drawing.Size(169, 72);
            this.buttonIzbrisiKorisnika.TabIndex = 1;
            this.buttonIzbrisiKorisnika.Text = "Izbriši korisnika";
            this.buttonIzbrisiKorisnika.UseVisualStyleBackColor = true;
            this.buttonIzbrisiKorisnika.Click += new System.EventHandler(this.buttonIzbrisiKorisnika_Click);
            // 
            // PromjenaUlogeKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 450);
            this.Controls.Add(this.buttonIzbrisiKorisnika);
            this.Controls.Add(this.buttonMakniAdmina);
            this.Controls.Add(this.buttonDodajAdmina);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PromjenaUlogeKorisnika";
            this.Text = "PromjenaUlogeKorisnika";
            this.Load += new System.EventHandler(this.PromjenaUlogeKorisnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDodajAdmina;
        private System.Windows.Forms.Button buttonMakniAdmina;
        private System.Windows.Forms.Button buttonIzbrisiKorisnika;
    }
}