namespace CardBringer2
{
    partial class Administracija
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
            this.buttonDodajNovuKartu = new System.Windows.Forms.Button();
            this.buttonUlogeKorisnika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDodajNovuKartu
            // 
            this.buttonDodajNovuKartu.Location = new System.Drawing.Point(62, 93);
            this.buttonDodajNovuKartu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDodajNovuKartu.Name = "buttonDodajNovuKartu";
            this.buttonDodajNovuKartu.Size = new System.Drawing.Size(162, 67);
            this.buttonDodajNovuKartu.TabIndex = 22;
            this.buttonDodajNovuKartu.Text = "Dodavanje nove karte";
            this.buttonDodajNovuKartu.UseVisualStyleBackColor = true;
            this.buttonDodajNovuKartu.Click += new System.EventHandler(this.buttonDodajNovuKartu_Click);
            // 
            // buttonUlogeKorisnika
            // 
            this.buttonUlogeKorisnika.Location = new System.Drawing.Point(62, 193);
            this.buttonUlogeKorisnika.Name = "buttonUlogeKorisnika";
            this.buttonUlogeKorisnika.Size = new System.Drawing.Size(162, 67);
            this.buttonUlogeKorisnika.TabIndex = 23;
            this.buttonUlogeKorisnika.Text = "Promjena uloga korisnika";
            this.buttonUlogeKorisnika.UseVisualStyleBackColor = true;
            this.buttonUlogeKorisnika.Click += new System.EventHandler(this.buttonUlogeKorisnika_Click);
            // 
            // Administracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1579, 937);
            this.Controls.Add(this.buttonUlogeKorisnika);
            this.Controls.Add(this.buttonDodajNovuKartu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Administracija";
            this.Text = "Administracija";
            this.Load += new System.EventHandler(this.Administracija_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDodajNovuKartu;
        private System.Windows.Forms.Button buttonUlogeKorisnika;
    }
}