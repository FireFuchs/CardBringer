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
            this.components = new System.ComponentModel.Container();
            this.KolicinaKarataLabela = new System.Windows.Forms.Label();
            this.ukupnaCijenaLabela = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.KosaricaLabelCijenaUnchanged = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.GumbKupi = new System.Windows.Forms.Button();
            this.GumbKosaricaMakni = new System.Windows.Forms.Button();
            this.kosharicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosharicaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // KolicinaKarataLabela
            // 
            this.KolicinaKarataLabela.AutoSize = true;
            this.KolicinaKarataLabela.ForeColor = System.Drawing.Color.White;
            this.KolicinaKarataLabela.Location = new System.Drawing.Point(1192, 178);
            this.KolicinaKarataLabela.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KolicinaKarataLabela.Name = "KolicinaKarataLabela";
            this.KolicinaKarataLabela.Size = new System.Drawing.Size(13, 17);
            this.KolicinaKarataLabela.TabIndex = 5;
            this.KolicinaKarataLabela.Text = "-";
            // 
            // ukupnaCijenaLabela
            // 
            this.ukupnaCijenaLabela.AutoSize = true;
            this.ukupnaCijenaLabela.ForeColor = System.Drawing.Color.White;
            this.ukupnaCijenaLabela.Location = new System.Drawing.Point(1192, 134);
            this.ukupnaCijenaLabela.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ukupnaCijenaLabela.Name = "ukupnaCijenaLabela";
            this.ukupnaCijenaLabela.Size = new System.Drawing.Size(13, 17);
            this.ukupnaCijenaLabela.TabIndex = 6;
            this.ukupnaCijenaLabela.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1073, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Broj Karata:";
            // 
            // KosaricaLabelCijenaUnchanged
            // 
            this.KosaricaLabelCijenaUnchanged.AutoSize = true;
            this.KosaricaLabelCijenaUnchanged.ForeColor = System.Drawing.Color.White;
            this.KosaricaLabelCijenaUnchanged.Location = new System.Drawing.Point(1049, 134);
            this.KosaricaLabelCijenaUnchanged.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KosaricaLabelCijenaUnchanged.Name = "KosaricaLabelCijenaUnchanged";
            this.KosaricaLabelCijenaUnchanged.Size = new System.Drawing.Size(104, 17);
            this.KosaricaLabelCijenaUnchanged.TabIndex = 8;
            this.KosaricaLabelCijenaUnchanged.Text = "Ukupna Cijena:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.CausesValidation = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 89);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1007, 550);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Karte u košarici:";
            // 
            // GumbKupi
            // 
            this.GumbKupi.Location = new System.Drawing.Point(1053, 262);
            this.GumbKupi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GumbKupi.Name = "GumbKupi";
            this.GumbKupi.Size = new System.Drawing.Size(152, 59);
            this.GumbKupi.TabIndex = 9;
            this.GumbKupi.Text = "Kupi!!";
            this.GumbKupi.UseVisualStyleBackColor = true;
            this.GumbKupi.Click += new System.EventHandler(this.GumbKupi_Click);
            // 
            // GumbKosaricaMakni
            // 
            this.GumbKosaricaMakni.Location = new System.Drawing.Point(1053, 361);
            this.GumbKosaricaMakni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GumbKosaricaMakni.Name = "GumbKosaricaMakni";
            this.GumbKosaricaMakni.Size = new System.Drawing.Size(152, 59);
            this.GumbKosaricaMakni.TabIndex = 9;
            this.GumbKosaricaMakni.Text = "Makni!";
            this.GumbKosaricaMakni.UseVisualStyleBackColor = true;
            this.GumbKosaricaMakni.Click += new System.EventHandler(this.GumbMakni);
            // 
            // kosharicaBindingSource
            // 
            this.kosharicaBindingSource.DataSource = typeof(CardBringer2.kosharica);
            // 
            // Kosarica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1668, 742);
            this.Controls.Add(this.GumbKosaricaMakni);
            this.Controls.Add(this.GumbKupi);
            this.Controls.Add(this.KolicinaKarataLabela);
            this.Controls.Add(this.ukupnaCijenaLabela);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KosaricaLabelCijenaUnchanged);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Kosarica";
            this.Text = "Kosarica";
            this.Load += new System.EventHandler(this.Kosarica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosharicaBindingSource)).EndInit();
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
        private System.Windows.Forms.Button GumbKosaricaMakni;
        private System.Windows.Forms.BindingSource kosharicaBindingSource;
    }
}