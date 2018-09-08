namespace CardBringer2
{
    partial class ObjaviOglas
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
            this.dgvObjaviOglasSveKarte = new System.Windows.Forms.DataGridView();
            this.idKartaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeKarteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisKarteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slikaKarteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oglasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wishlistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kartaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblObjaviOglasIzaberiKartu = new System.Windows.Forms.Label();
            this.lblObjaviOglasUnesiCijenuKarte = new System.Windows.Forms.Label();
            this.tboxObjaviOglasCijena = new System.Windows.Forms.TextBox();
            this.lblObjaviOglasUnesiteKoličinuKarata = new System.Windows.Forms.Label();
            this.tboxObjaviOglasKolicina = new System.Windows.Forms.TextBox();
            this.btnObjaviOglasObjaviOglas = new System.Windows.Forms.Button();
            this.pboxObjaviOglasSlikaKarte = new System.Windows.Forms.PictureBox();
            this.rtboxObjaviOglasOpisKarte = new System.Windows.Forms.RichTextBox();
            this.lvlObjaviOglasNazivKarte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjaviOglasSveKarte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxObjaviOglasSlikaKarte)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvObjaviOglasSveKarte
            // 
            this.dgvObjaviOglasSveKarte.AutoGenerateColumns = false;
            this.dgvObjaviOglasSveKarte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjaviOglasSveKarte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKartaDataGridViewTextBoxColumn,
            this.imeKarteDataGridViewTextBoxColumn,
            this.opisKarteDataGridViewTextBoxColumn,
            this.slikaKarteDataGridViewTextBoxColumn,
            this.oglasDataGridViewTextBoxColumn,
            this.wishlistDataGridViewTextBoxColumn});
            this.dgvObjaviOglasSveKarte.DataSource = this.kartaBindingSource;
            this.dgvObjaviOglasSveKarte.GridColor = System.Drawing.Color.Gray;
            this.dgvObjaviOglasSveKarte.Location = new System.Drawing.Point(12, 88);
            this.dgvObjaviOglasSveKarte.Name = "dgvObjaviOglasSveKarte";
            this.dgvObjaviOglasSveKarte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObjaviOglasSveKarte.Size = new System.Drawing.Size(446, 359);
            this.dgvObjaviOglasSveKarte.TabIndex = 5;
            this.dgvObjaviOglasSveKarte.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // idKartaDataGridViewTextBoxColumn
            // 
            this.idKartaDataGridViewTextBoxColumn.DataPropertyName = "idKarta";
            this.idKartaDataGridViewTextBoxColumn.HeaderText = "idKarta";
            this.idKartaDataGridViewTextBoxColumn.Name = "idKartaDataGridViewTextBoxColumn";
            this.idKartaDataGridViewTextBoxColumn.Visible = false;
            // 
            // imeKarteDataGridViewTextBoxColumn
            // 
            this.imeKarteDataGridViewTextBoxColumn.DataPropertyName = "imeKarte";
            this.imeKarteDataGridViewTextBoxColumn.HeaderText = "Ime karte";
            this.imeKarteDataGridViewTextBoxColumn.Name = "imeKarteDataGridViewTextBoxColumn";
            // 
            // opisKarteDataGridViewTextBoxColumn
            // 
            this.opisKarteDataGridViewTextBoxColumn.DataPropertyName = "opisKarte";
            this.opisKarteDataGridViewTextBoxColumn.HeaderText = "Opis karte";
            this.opisKarteDataGridViewTextBoxColumn.Name = "opisKarteDataGridViewTextBoxColumn";
            // 
            // slikaKarteDataGridViewTextBoxColumn
            // 
            this.slikaKarteDataGridViewTextBoxColumn.DataPropertyName = "slikaKarte";
            this.slikaKarteDataGridViewTextBoxColumn.HeaderText = "slikaKarte";
            this.slikaKarteDataGridViewTextBoxColumn.Name = "slikaKarteDataGridViewTextBoxColumn";
            this.slikaKarteDataGridViewTextBoxColumn.Visible = false;
            // 
            // oglasDataGridViewTextBoxColumn
            // 
            this.oglasDataGridViewTextBoxColumn.DataPropertyName = "oglas";
            this.oglasDataGridViewTextBoxColumn.HeaderText = "oglas";
            this.oglasDataGridViewTextBoxColumn.Name = "oglasDataGridViewTextBoxColumn";
            this.oglasDataGridViewTextBoxColumn.Visible = false;
            // 
            // wishlistDataGridViewTextBoxColumn
            // 
            this.wishlistDataGridViewTextBoxColumn.DataPropertyName = "wishlist";
            this.wishlistDataGridViewTextBoxColumn.HeaderText = "wishlist";
            this.wishlistDataGridViewTextBoxColumn.Name = "wishlistDataGridViewTextBoxColumn";
            this.wishlistDataGridViewTextBoxColumn.Visible = false;
            // 
            // kartaBindingSource
            // 
            this.kartaBindingSource.DataSource = typeof(CardBringer2.karta);
            // 
            // lblObjaviOglasIzaberiKartu
            // 
            this.lblObjaviOglasIzaberiKartu.AutoSize = true;
            this.lblObjaviOglasIzaberiKartu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.lblObjaviOglasIzaberiKartu.ForeColor = System.Drawing.Color.White;
            this.lblObjaviOglasIzaberiKartu.Location = new System.Drawing.Point(12, 68);
            this.lblObjaviOglasIzaberiKartu.Name = "lblObjaviOglasIzaberiKartu";
            this.lblObjaviOglasIzaberiKartu.Size = new System.Drawing.Size(77, 13);
            this.lblObjaviOglasIzaberiKartu.TabIndex = 2;
            this.lblObjaviOglasIzaberiKartu.Text = "Izaberite kartu:";
            // 
            // lblObjaviOglasUnesiCijenuKarte
            // 
            this.lblObjaviOglasUnesiCijenuKarte.AutoSize = true;
            this.lblObjaviOglasUnesiCijenuKarte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.lblObjaviOglasUnesiCijenuKarte.ForeColor = System.Drawing.Color.White;
            this.lblObjaviOglasUnesiCijenuKarte.Location = new System.Drawing.Point(103, 453);
            this.lblObjaviOglasUnesiCijenuKarte.Name = "lblObjaviOglasUnesiCijenuKarte";
            this.lblObjaviOglasUnesiCijenuKarte.Size = new System.Drawing.Size(104, 13);
            this.lblObjaviOglasUnesiCijenuKarte.TabIndex = 2;
            this.lblObjaviOglasUnesiCijenuKarte.Text = "Unesite cijenu karte:";
            // 
            // tboxObjaviOglasCijena
            // 
            this.tboxObjaviOglasCijena.Location = new System.Drawing.Point(211, 453);
            this.tboxObjaviOglasCijena.Name = "tboxObjaviOglasCijena";
            this.tboxObjaviOglasCijena.Size = new System.Drawing.Size(120, 20);
            this.tboxObjaviOglasCijena.TabIndex = 1;
            this.tboxObjaviOglasCijena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxObjaviOglasCijena_KeyPress);
            // 
            // lblObjaviOglasUnesiteKoličinuKarata
            // 
            this.lblObjaviOglasUnesiteKoličinuKarata.AutoSize = true;
            this.lblObjaviOglasUnesiteKoličinuKarata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.lblObjaviOglasUnesiteKoličinuKarata.ForeColor = System.Drawing.Color.White;
            this.lblObjaviOglasUnesiteKoličinuKarata.Location = new System.Drawing.Point(88, 492);
            this.lblObjaviOglasUnesiteKoličinuKarata.Name = "lblObjaviOglasUnesiteKoličinuKarata";
            this.lblObjaviOglasUnesiteKoličinuKarata.Size = new System.Drawing.Size(118, 13);
            this.lblObjaviOglasUnesiteKoličinuKarata.TabIndex = 2;
            this.lblObjaviOglasUnesiteKoličinuKarata.Text = "Unesite količinu karata:";
            // 
            // tboxObjaviOglasKolicina
            // 
            this.tboxObjaviOglasKolicina.Location = new System.Drawing.Point(211, 492);
            this.tboxObjaviOglasKolicina.Name = "tboxObjaviOglasKolicina";
            this.tboxObjaviOglasKolicina.Size = new System.Drawing.Size(120, 20);
            this.tboxObjaviOglasKolicina.TabIndex = 2;
            this.tboxObjaviOglasKolicina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxObjaviOglasKolicina_KeyPress);
            // 
            // btnObjaviOglasObjaviOglas
            // 
            this.btnObjaviOglasObjaviOglas.ForeColor = System.Drawing.Color.Black;
            this.btnObjaviOglasObjaviOglas.Location = new System.Drawing.Point(338, 453);
            this.btnObjaviOglasObjaviOglas.Name = "btnObjaviOglasObjaviOglas";
            this.btnObjaviOglasObjaviOglas.Size = new System.Drawing.Size(120, 56);
            this.btnObjaviOglasObjaviOglas.TabIndex = 3;
            this.btnObjaviOglasObjaviOglas.Text = "Objavi Oglas";
            this.btnObjaviOglasObjaviOglas.UseVisualStyleBackColor = true;
            this.btnObjaviOglasObjaviOglas.Click += new System.EventHandler(this.btnObjaviOglasObjaviOglas_Click);
            // 
            // pboxObjaviOglasSlikaKarte
            // 
            this.pboxObjaviOglasSlikaKarte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxObjaviOglasSlikaKarte.Location = new System.Drawing.Point(484, 88);
            this.pboxObjaviOglasSlikaKarte.Margin = new System.Windows.Forms.Padding(2);
            this.pboxObjaviOglasSlikaKarte.Name = "pboxObjaviOglasSlikaKarte";
            this.pboxObjaviOglasSlikaKarte.Size = new System.Drawing.Size(267, 351);
            this.pboxObjaviOglasSlikaKarte.TabIndex = 6;
            this.pboxObjaviOglasSlikaKarte.TabStop = false;
            // 
            // rtboxObjaviOglasOpisKarte
            // 
            this.rtboxObjaviOglasOpisKarte.Location = new System.Drawing.Point(484, 464);
            this.rtboxObjaviOglasOpisKarte.Margin = new System.Windows.Forms.Padding(2);
            this.rtboxObjaviOglasOpisKarte.Name = "rtboxObjaviOglasOpisKarte";
            this.rtboxObjaviOglasOpisKarte.ReadOnly = true;
            this.rtboxObjaviOglasOpisKarte.Size = new System.Drawing.Size(267, 81);
            this.rtboxObjaviOglasOpisKarte.TabIndex = 7;
            this.rtboxObjaviOglasOpisKarte.Text = "";
            // 
            // lvlObjaviOglasNazivKarte
            // 
            this.lvlObjaviOglasNazivKarte.AutoSize = true;
            this.lvlObjaviOglasNazivKarte.ForeColor = System.Drawing.Color.White;
            this.lvlObjaviOglasNazivKarte.Location = new System.Drawing.Point(482, 443);
            this.lvlObjaviOglasNazivKarte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lvlObjaviOglasNazivKarte.Name = "lvlObjaviOglasNazivKarte";
            this.lvlObjaviOglasNazivKarte.Size = new System.Drawing.Size(61, 13);
            this.lvlObjaviOglasNazivKarte.TabIndex = 8;
            this.lvlObjaviOglasNazivKarte.Text = "Naziv karte";
            // 
            // ObjaviOglas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1203, 603);
            this.Controls.Add(this.lvlObjaviOglasNazivKarte);
            this.Controls.Add(this.rtboxObjaviOglasOpisKarte);
            this.Controls.Add(this.pboxObjaviOglasSlikaKarte);
            this.Controls.Add(this.btnObjaviOglasObjaviOglas);
            this.Controls.Add(this.tboxObjaviOglasKolicina);
            this.Controls.Add(this.lblObjaviOglasUnesiteKoličinuKarata);
            this.Controls.Add(this.tboxObjaviOglasCijena);
            this.Controls.Add(this.lblObjaviOglasUnesiCijenuKarte);
            this.Controls.Add(this.lblObjaviOglasIzaberiKartu);
            this.Controls.Add(this.dgvObjaviOglasSveKarte);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ObjaviOglas";
            this.Text = "ObjaviOglas";
            this.Load += new System.EventHandler(this.ObjaviOglas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjaviOglasSveKarte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxObjaviOglasSlikaKarte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvObjaviOglasSveKarte;
        private System.Windows.Forms.Label lblObjaviOglasIzaberiKartu;
        private System.Windows.Forms.Label lblObjaviOglasUnesiCijenuKarte;
        private System.Windows.Forms.TextBox tboxObjaviOglasCijena;
        private System.Windows.Forms.Label lblObjaviOglasUnesiteKoličinuKarata;
        private System.Windows.Forms.TextBox tboxObjaviOglasKolicina;
        private System.Windows.Forms.Button btnObjaviOglasObjaviOglas;
        private System.Windows.Forms.PictureBox pboxObjaviOglasSlikaKarte;
        private System.Windows.Forms.RichTextBox rtboxObjaviOglasOpisKarte;
        private System.Windows.Forms.Label lvlObjaviOglasNazivKarte;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKartaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeKarteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisKarteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slikaKarteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oglasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wishlistDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource kartaBindingSource;
    }
}