namespace CardBringer2
{
    partial class Kosarica
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
            this.KolicinaKarataLabela = new System.Windows.Forms.Label();
            this.ukupnaCijenaLabela = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.KosaricaLabelCijenaUnchanged = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.GumbKupi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // KolicinaKarataLabela
            // 
            this.KolicinaKarataLabela.AutoSize = true;
            this.KolicinaKarataLabela.ForeColor = System.Drawing.Color.White;
            this.KolicinaKarataLabela.Location = new System.Drawing.Point(894, 145);
            this.KolicinaKarataLabela.Name = "KolicinaKarataLabela";
            this.KolicinaKarataLabela.Size = new System.Drawing.Size(10, 13);
            this.KolicinaKarataLabela.TabIndex = 5;
            this.KolicinaKarataLabela.Text = "-";
            // 
            // ukupnaCijenaLabela
            // 
            this.ukupnaCijenaLabela.AutoSize = true;
            this.ukupnaCijenaLabela.ForeColor = System.Drawing.Color.White;
            this.ukupnaCijenaLabela.Location = new System.Drawing.Point(894, 109);
            this.ukupnaCijenaLabela.Name = "ukupnaCijenaLabela";
            this.ukupnaCijenaLabela.Size = new System.Drawing.Size(10, 13);
            this.ukupnaCijenaLabela.TabIndex = 6;
            this.ukupnaCijenaLabela.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(805, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Broj Karata:";
            // 
            // KosaricaLabelCijenaUnchanged
            // 
            this.KosaricaLabelCijenaUnchanged.AutoSize = true;
            this.KosaricaLabelCijenaUnchanged.ForeColor = System.Drawing.Color.White;
            this.KosaricaLabelCijenaUnchanged.Location = new System.Drawing.Point(787, 109);
            this.KosaricaLabelCijenaUnchanged.Name = "KosaricaLabelCijenaUnchanged";
            this.KosaricaLabelCijenaUnchanged.Size = new System.Drawing.Size(80, 13);
            this.KosaricaLabelCijenaUnchanged.TabIndex = 8;
            this.KosaricaLabelCijenaUnchanged.Text = "Ukupna Cijena:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.CausesValidation = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(755, 447);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Karte u košarici:";
            // 
            // GumbKupi
            // 
            this.GumbKupi.Location = new System.Drawing.Point(790, 213);
            this.GumbKupi.Name = "GumbKupi";
            this.GumbKupi.Size = new System.Drawing.Size(114, 48);
            this.GumbKupi.TabIndex = 9;
            this.GumbKupi.Text = "Kupi!!";
            this.GumbKupi.UseVisualStyleBackColor = true;
            this.GumbKupi.Click += new System.EventHandler(this.GumbKupi_Click);
            // 
            // Kosarica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1251, 603);
            this.Controls.Add(this.GumbKupi);
            this.Controls.Add(this.KolicinaKarataLabela);
            this.Controls.Add(this.ukupnaCijenaLabela);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KosaricaLabelCijenaUnchanged);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Kosarica";
            this.Text = "Kosarica";
            this.Load += new System.EventHandler(this.Kosarica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KolicinaKarataLabela;
        private System.Windows.Forms.Label ukupnaCijenaLabela;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label KosaricaLabelCijenaUnchanged;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GumbKupi;
    }
}