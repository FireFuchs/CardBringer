namespace CardBringer2
{
    partial class UnosKartice
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
            this.tboxUnoskarticeBrojKarice = new System.Windows.Forms.TextBox();
            this.tboxUnoskarticeMjesec = new System.Windows.Forms.TextBox();
            this.tboxUnoskarticeGodina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxUnosKarticeKorisnikKartice = new System.Windows.Forms.TextBox();
            this.lblUnosKarticeKorisnikKartice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxUnoskarticeCVV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUnosKarticePlati = new System.Windows.Forms.Button();
            this.btnUnosKarticeOtkazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxUnoskarticeBrojKarice
            // 
            this.tboxUnoskarticeBrojKarice.Location = new System.Drawing.Point(12, 80);
            this.tboxUnoskarticeBrojKarice.Name = "tboxUnoskarticeBrojKarice";
            this.tboxUnoskarticeBrojKarice.Size = new System.Drawing.Size(299, 20);
            this.tboxUnoskarticeBrojKarice.TabIndex = 1;
            this.tboxUnoskarticeBrojKarice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxUnoskarticeBrojKarice_KeyPress);
            // 
            // tboxUnoskarticeMjesec
            // 
            this.tboxUnoskarticeMjesec.Location = new System.Drawing.Point(106, 109);
            this.tboxUnoskarticeMjesec.Name = "tboxUnoskarticeMjesec";
            this.tboxUnoskarticeMjesec.Size = new System.Drawing.Size(31, 20);
            this.tboxUnoskarticeMjesec.TabIndex = 2;
            this.tboxUnoskarticeMjesec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxUnoskarticeMjesec_KeyPress);
            // 
            // tboxUnoskarticeGodina
            // 
            this.tboxUnoskarticeGodina.Location = new System.Drawing.Point(138, 109);
            this.tboxUnoskarticeGodina.Name = "tboxUnoskarticeGodina";
            this.tboxUnoskarticeGodina.Size = new System.Drawing.Size(31, 20);
            this.tboxUnoskarticeGodina.TabIndex = 3;
            this.tboxUnoskarticeGodina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxUnoskarticeGodina_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Broj kartice:";
            // 
            // tboxUnosKarticeKorisnikKartice
            // 
            this.tboxUnosKarticeKorisnikKartice.Location = new System.Drawing.Point(12, 41);
            this.tboxUnosKarticeKorisnikKartice.Name = "tboxUnosKarticeKorisnikKartice";
            this.tboxUnosKarticeKorisnikKartice.Size = new System.Drawing.Size(299, 20);
            this.tboxUnosKarticeKorisnikKartice.TabIndex = 0;
            // 
            // lblUnosKarticeKorisnikKartice
            // 
            this.lblUnosKarticeKorisnikKartice.AutoSize = true;
            this.lblUnosKarticeKorisnikKartice.ForeColor = System.Drawing.Color.White;
            this.lblUnosKarticeKorisnikKartice.Location = new System.Drawing.Point(9, 25);
            this.lblUnosKarticeKorisnikKartice.Name = "lblUnosKarticeKorisnikKartice";
            this.lblUnosKarticeKorisnikKartice.Size = new System.Drawing.Size(82, 13);
            this.lblUnosKarticeKorisnikKartice.TabIndex = 1;
            this.lblUnosKarticeKorisnikKartice.Text = "Korisnik kartice:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Datum isteka:";
            // 
            // tboxUnoskarticeCVV
            // 
            this.tboxUnoskarticeCVV.Location = new System.Drawing.Point(106, 135);
            this.tboxUnoskarticeCVV.Name = "tboxUnoskarticeCVV";
            this.tboxUnoskarticeCVV.Size = new System.Drawing.Size(50, 20);
            this.tboxUnoskarticeCVV.TabIndex = 4;
            this.tboxUnoskarticeCVV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxUnoskarticeCVV_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "CVV Kartice:";
            // 
            // btnUnosKarticePlati
            // 
            this.btnUnosKarticePlati.Location = new System.Drawing.Point(59, 177);
            this.btnUnosKarticePlati.Name = "btnUnosKarticePlati";
            this.btnUnosKarticePlati.Size = new System.Drawing.Size(116, 23);
            this.btnUnosKarticePlati.TabIndex = 5;
            this.btnUnosKarticePlati.Text = "Plati!";
            this.btnUnosKarticePlati.UseVisualStyleBackColor = true;
            this.btnUnosKarticePlati.Click += new System.EventHandler(this.btnUnosKarticePlati_Click);
            // 
            // btnUnosKarticeOtkazi
            // 
            this.btnUnosKarticeOtkazi.Location = new System.Drawing.Point(181, 177);
            this.btnUnosKarticeOtkazi.Name = "btnUnosKarticeOtkazi";
            this.btnUnosKarticeOtkazi.Size = new System.Drawing.Size(116, 23);
            this.btnUnosKarticeOtkazi.TabIndex = 5;
            this.btnUnosKarticeOtkazi.Text = "Otkaži!";
            this.btnUnosKarticeOtkazi.UseVisualStyleBackColor = true;
            this.btnUnosKarticeOtkazi.Click += new System.EventHandler(this.btnUnosKarticeOtkazi_Click);
            // 
            // UnosKartice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(359, 212);
            this.Controls.Add(this.btnUnosKarticeOtkazi);
            this.Controls.Add(this.btnUnosKarticePlati);
            this.Controls.Add(this.lblUnosKarticeKorisnikKartice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxUnoskarticeGodina);
            this.Controls.Add(this.tboxUnoskarticeCVV);
            this.Controls.Add(this.tboxUnoskarticeMjesec);
            this.Controls.Add(this.tboxUnosKarticeKorisnikKartice);
            this.Controls.Add(this.tboxUnoskarticeBrojKarice);
            this.Name = "UnosKartice";
            this.Text = "UnosKartice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxUnoskarticeBrojKarice;
        private System.Windows.Forms.TextBox tboxUnoskarticeMjesec;
        private System.Windows.Forms.TextBox tboxUnoskarticeGodina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxUnosKarticeKorisnikKartice;
        private System.Windows.Forms.Label lblUnosKarticeKorisnikKartice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxUnoskarticeCVV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUnosKarticePlati;
        private System.Windows.Forms.Button btnUnosKarticeOtkazi;
    }
}