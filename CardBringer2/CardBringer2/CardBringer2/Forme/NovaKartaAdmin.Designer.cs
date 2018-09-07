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
            this.pictureBoxSlikaKarte = new System.Windows.Forms.PictureBox();
            this.buttonIzaberiSliku = new System.Windows.Forms.Button();
            this.unosOpisKarte = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlikaKarte)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSpremiKartu
            // 
            this.buttonSpremiKartu.Location = new System.Drawing.Point(12, 565);
            this.buttonSpremiKartu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSpremiKartu.Name = "buttonSpremiKartu";
            this.buttonSpremiKartu.Size = new System.Drawing.Size(595, 85);
            this.buttonSpremiKartu.TabIndex = 1;
            this.buttonSpremiKartu.Text = "Spremi kartu";
            this.buttonSpremiKartu.UseVisualStyleBackColor = true;
            this.buttonSpremiKartu.Click += new System.EventHandler(this.buttonSpremiKartu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(420, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ime karte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(420, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Opis karte:";
            // 
            // unosImeKarte
            // 
            this.unosImeKarte.Location = new System.Drawing.Point(423, 150);
            this.unosImeKarte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unosImeKarte.Name = "unosImeKarte";
            this.unosImeKarte.Size = new System.Drawing.Size(184, 22);
            this.unosImeKarte.TabIndex = 4;
            // 
            // pictureBoxSlikaKarte
            // 
            this.pictureBoxSlikaKarte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSlikaKarte.Location = new System.Drawing.Point(12, 25);
            this.pictureBoxSlikaKarte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxSlikaKarte.Name = "pictureBoxSlikaKarte";
            this.pictureBoxSlikaKarte.Size = new System.Drawing.Size(389, 521);
            this.pictureBoxSlikaKarte.TabIndex = 6;
            this.pictureBoxSlikaKarte.TabStop = false;
            // 
            // buttonIzaberiSliku
            // 
            this.buttonIzaberiSliku.Location = new System.Drawing.Point(423, 25);
            this.buttonIzaberiSliku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIzaberiSliku.Name = "buttonIzaberiSliku";
            this.buttonIzaberiSliku.Size = new System.Drawing.Size(184, 71);
            this.buttonIzaberiSliku.TabIndex = 7;
            this.buttonIzaberiSliku.Text = "Izaberi sliku";
            this.buttonIzaberiSliku.UseVisualStyleBackColor = true;
            this.buttonIzaberiSliku.Click += new System.EventHandler(this.buttonIzaberiSliku_Click);
            // 
            // unosOpisKarte
            // 
            this.unosOpisKarte.Location = new System.Drawing.Point(423, 217);
            this.unosOpisKarte.Name = "unosOpisKarte";
            this.unosOpisKarte.Size = new System.Drawing.Size(184, 269);
            this.unosOpisKarte.TabIndex = 8;
            this.unosOpisKarte.Text = "";
            // 
            // NovaKartaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(621, 659);
            this.Controls.Add(this.unosOpisKarte);
            this.Controls.Add(this.buttonIzaberiSliku);
            this.Controls.Add(this.pictureBoxSlikaKarte);
            this.Controls.Add(this.unosImeKarte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSpremiKartu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.PictureBox pictureBoxSlikaKarte;
        private System.Windows.Forms.Button buttonIzaberiSliku;
        private System.Windows.Forms.RichTextBox unosOpisKarte;
    }
}