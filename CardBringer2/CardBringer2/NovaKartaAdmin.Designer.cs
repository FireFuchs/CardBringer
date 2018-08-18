namespace CardBringer2
{
    partial class NovaKartaAdmin
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
            this.buttonSpremiKartu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.unosImeKarte = new System.Windows.Forms.TextBox();
            this.unosOpisKarte = new System.Windows.Forms.TextBox();
            this.pictureBoxSlikaKarte = new System.Windows.Forms.PictureBox();
            this.buttonIzaberiSliku = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlikaKarte)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSpremiKartu
            // 
            this.buttonSpremiKartu.Location = new System.Drawing.Point(101, 200);
            this.buttonSpremiKartu.Name = "buttonSpremiKartu";
            this.buttonSpremiKartu.Size = new System.Drawing.Size(75, 23);
            this.buttonSpremiKartu.TabIndex = 1;
            this.buttonSpremiKartu.Text = "Spremi kartu";
            this.buttonSpremiKartu.UseVisualStyleBackColor = true;
            this.buttonSpremiKartu.Click += new System.EventHandler(this.buttonSpremiKartu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // unosImeKarte
            // 
            this.unosImeKarte.Location = new System.Drawing.Point(187, 54);
            this.unosImeKarte.Name = "unosImeKarte";
            this.unosImeKarte.Size = new System.Drawing.Size(100, 22);
            this.unosImeKarte.TabIndex = 4;
            // 
            // unosOpisKarte
            // 
            this.unosOpisKarte.Location = new System.Drawing.Point(187, 119);
            this.unosOpisKarte.Name = "unosOpisKarte";
            this.unosOpisKarte.Size = new System.Drawing.Size(100, 22);
            this.unosOpisKarte.TabIndex = 5;
            // 
            // pictureBoxSlikaKarte
            // 
            this.pictureBoxSlikaKarte.Location = new System.Drawing.Point(434, 2);
            this.pictureBoxSlikaKarte.Name = "pictureBoxSlikaKarte";
            this.pictureBoxSlikaKarte.Size = new System.Drawing.Size(331, 375);
            this.pictureBoxSlikaKarte.TabIndex = 6;
            this.pictureBoxSlikaKarte.TabStop = false;
            // 
            // buttonIzaberiSliku
            // 
            this.buttonIzaberiSliku.Location = new System.Drawing.Point(628, 406);
            this.buttonIzaberiSliku.Name = "buttonIzaberiSliku";
            this.buttonIzaberiSliku.Size = new System.Drawing.Size(75, 23);
            this.buttonIzaberiSliku.TabIndex = 7;
            this.buttonIzaberiSliku.Text = "Izaberi sliku";
            this.buttonIzaberiSliku.UseVisualStyleBackColor = true;
            this.buttonIzaberiSliku.Click += new System.EventHandler(this.buttonIzaberiSliku_Click);
            // 
            // NovaKartaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonIzaberiSliku);
            this.Controls.Add(this.pictureBoxSlikaKarte);
            this.Controls.Add(this.unosOpisKarte);
            this.Controls.Add(this.unosImeKarte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSpremiKartu);
            this.Name = "NovaKartaAdmin";
            this.Text = "NovaKartaAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlikaKarte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSpremiKartu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox unosImeKarte;
        private System.Windows.Forms.TextBox unosOpisKarte;
        private System.Windows.Forms.PictureBox pictureBoxSlikaKarte;
        private System.Windows.Forms.Button buttonIzaberiSliku;
    }
}