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
            this.lblKosaricaBrojKarataBroj = new System.Windows.Forms.Label();
            this.lblKosaricaCijenaKarataCijena = new System.Windows.Forms.Label();
            this.lblKosaricaBrojKarata = new System.Windows.Forms.Label();
            this.KosaricaLabelCijenaUnchanged = new System.Windows.Forms.Label();
            this.dgvKosaricaDatagridview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKosaricaKupi = new System.Windows.Forms.Button();
            this.btnKosaricaMakni = new System.Windows.Forms.Button();
            this.kosharicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKosaricaDatagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosharicaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKosaricaBrojKarataBroj
            // 
            this.lblKosaricaBrojKarataBroj.AutoSize = true;
            this.lblKosaricaBrojKarataBroj.ForeColor = System.Drawing.Color.White;
            this.lblKosaricaBrojKarataBroj.Location = new System.Drawing.Point(894, 145);
            this.lblKosaricaBrojKarataBroj.Name = "lblKosaricaBrojKarataBroj";
            this.lblKosaricaBrojKarataBroj.Size = new System.Drawing.Size(10, 13);
            this.lblKosaricaBrojKarataBroj.TabIndex = 5;
            this.lblKosaricaBrojKarataBroj.Text = "-";
            // 
            // lblKosaricaCijenaKarataCijena
            // 
            this.lblKosaricaCijenaKarataCijena.AutoSize = true;
            this.lblKosaricaCijenaKarataCijena.ForeColor = System.Drawing.Color.White;
            this.lblKosaricaCijenaKarataCijena.Location = new System.Drawing.Point(894, 109);
            this.lblKosaricaCijenaKarataCijena.Name = "lblKosaricaCijenaKarataCijena";
            this.lblKosaricaCijenaKarataCijena.Size = new System.Drawing.Size(10, 13);
            this.lblKosaricaCijenaKarataCijena.TabIndex = 6;
            this.lblKosaricaCijenaKarataCijena.Text = "-";
            // 
            // lblKosaricaBrojKarata
            // 
            this.lblKosaricaBrojKarata.AutoSize = true;
            this.lblKosaricaBrojKarata.ForeColor = System.Drawing.Color.White;
            this.lblKosaricaBrojKarata.Location = new System.Drawing.Point(805, 145);
            this.lblKosaricaBrojKarata.Name = "lblKosaricaBrojKarata";
            this.lblKosaricaBrojKarata.Size = new System.Drawing.Size(62, 13);
            this.lblKosaricaBrojKarata.TabIndex = 7;
            this.lblKosaricaBrojKarata.Text = "Broj Karata:";
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
            // dgvKosaricaDatagridview
            // 
            this.dgvKosaricaDatagridview.CausesValidation = false;
            this.dgvKosaricaDatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKosaricaDatagridview.Location = new System.Drawing.Point(12, 72);
            this.dgvKosaricaDatagridview.Name = "dgvKosaricaDatagridview";
            this.dgvKosaricaDatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKosaricaDatagridview.Size = new System.Drawing.Size(755, 447);
            this.dgvKosaricaDatagridview.TabIndex = 4;
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
            // btnKosaricaKupi
            // 
            this.btnKosaricaKupi.Location = new System.Drawing.Point(790, 213);
            this.btnKosaricaKupi.Name = "btnKosaricaKupi";
            this.btnKosaricaKupi.Size = new System.Drawing.Size(114, 48);
            this.btnKosaricaKupi.TabIndex = 9;
            this.btnKosaricaKupi.Text = "Kupi!!";
            this.btnKosaricaKupi.UseVisualStyleBackColor = true;
            this.btnKosaricaKupi.Click += new System.EventHandler(this.btnKosaricaKupi_Click);
            // 
            // btnKosaricaMakni
            // 
            this.btnKosaricaMakni.Location = new System.Drawing.Point(790, 293);
            this.btnKosaricaMakni.Name = "btnKosaricaMakni";
            this.btnKosaricaMakni.Size = new System.Drawing.Size(114, 48);
            this.btnKosaricaMakni.TabIndex = 9;
            this.btnKosaricaMakni.Text = "Makni!";
            this.btnKosaricaMakni.UseVisualStyleBackColor = true;
            this.btnKosaricaMakni.Click += new System.EventHandler(this.btnKosaricaMakni_Click);
            // 
            // kosharicaBindingSource
            // 
            this.kosharicaBindingSource.DataSource = typeof(CardBringer2.kosharica);
            // 
            // Kosarica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1203, 603);
            this.Controls.Add(this.btnKosaricaMakni);
            this.Controls.Add(this.btnKosaricaKupi);
            this.Controls.Add(this.lblKosaricaBrojKarataBroj);
            this.Controls.Add(this.lblKosaricaCijenaKarataCijena);
            this.Controls.Add(this.lblKosaricaBrojKarata);
            this.Controls.Add(this.KosaricaLabelCijenaUnchanged);
            this.Controls.Add(this.dgvKosaricaDatagridview);
            this.Controls.Add(this.label1);
            this.Name = "Kosarica";
            this.Text = "Kosarica";
            this.Load += new System.EventHandler(this.Kosarica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKosaricaDatagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosharicaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKosaricaBrojKarataBroj;
        private System.Windows.Forms.Label lblKosaricaCijenaKarataCijena;
        private System.Windows.Forms.Label lblKosaricaBrojKarata;
        private System.Windows.Forms.Label KosaricaLabelCijenaUnchanged;
        private System.Windows.Forms.DataGridView dgvKosaricaDatagridview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKosaricaKupi;
        private System.Windows.Forms.Button btnKosaricaMakni;
        private System.Windows.Forms.BindingSource kosharicaBindingSource;
    }
}