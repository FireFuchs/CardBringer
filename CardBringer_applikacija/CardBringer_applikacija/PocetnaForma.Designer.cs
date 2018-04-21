namespace CardBringer_applikacija
{
    partial class PocetnaForma
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
            this.unosGumbLoginPocetnaForma = new System.Windows.Forms.Button();
            this.unosGumbRegistrirajPocetnaForma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // unosGumbLoginPocetnaForma
            // 
            this.unosGumbLoginPocetnaForma.Location = new System.Drawing.Point(12, 12);
            this.unosGumbLoginPocetnaForma.Name = "unosGumbLoginPocetnaForma";
            this.unosGumbLoginPocetnaForma.Size = new System.Drawing.Size(113, 55);
            this.unosGumbLoginPocetnaForma.TabIndex = 0;
            this.unosGumbLoginPocetnaForma.Text = "Login";
            this.unosGumbLoginPocetnaForma.UseVisualStyleBackColor = true;
            this.unosGumbLoginPocetnaForma.Click += new System.EventHandler(this.unosGumbLoginPocetnaForma_Click);
            // 
            // unosGumbRegistrirajPocetnaForma
            // 
            this.unosGumbRegistrirajPocetnaForma.Location = new System.Drawing.Point(159, 12);
            this.unosGumbRegistrirajPocetnaForma.Name = "unosGumbRegistrirajPocetnaForma";
            this.unosGumbRegistrirajPocetnaForma.Size = new System.Drawing.Size(113, 55);
            this.unosGumbRegistrirajPocetnaForma.TabIndex = 0;
            this.unosGumbRegistrirajPocetnaForma.Text = "Registriraj";
            this.unosGumbRegistrirajPocetnaForma.UseVisualStyleBackColor = true;
            this.unosGumbRegistrirajPocetnaForma.Click += new System.EventHandler(this.unosGumbRegistrirajPocetnaForma_Click);
            // 
            // PocetnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 82);
            this.Controls.Add(this.unosGumbRegistrirajPocetnaForma);
            this.Controls.Add(this.unosGumbLoginPocetnaForma);
            this.Name = "PocetnaForma";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button unosGumbLoginPocetnaForma;
        private System.Windows.Forms.Button unosGumbRegistrirajPocetnaForma;
    }
}

