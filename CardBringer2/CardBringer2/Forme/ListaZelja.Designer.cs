namespace CardBringer2
{
    partial class ListaZelja
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
            this.ListaZeljaGumbMakni = new System.Windows.Forms.Button();
            this.btnListaZeljaTrazigumb = new System.Windows.Forms.Button();
            this.btnListaZeljaDodajGumb = new System.Windows.Forms.Button();
            this.tboxListaZeljaTraziSveKarteTbox = new System.Windows.Forms.TextBox();
            this.dgvListaZeljaSveKarteDGV = new System.Windows.Forms.DataGridView();
            this.idKartaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeKarteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisKarteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slikaKarteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oglasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wishlistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kartaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvListaZeljaKarteNaListi = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblListaZeljaKarteNaListi = new System.Windows.Forms.Label();
            this.btnListaZeljaResetGumb = new System.Windows.Forms.Button();
            this.lblListaZeljaImeKarte = new System.Windows.Forms.Label();
            this.rtboxListaZeljaOpisKarte = new System.Windows.Forms.RichTextBox();
            this.pboxListaZeljaSlikaKarte = new System.Windows.Forms.PictureBox();
            this.lblListaZeljaSveKarteIme = new System.Windows.Forms.Label();
            this.rtboxListaZeljaOpisKarteSveKarte = new System.Windows.Forms.RichTextBox();
            this.pboxListaZeljaSlikaSveKarte = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaZeljaSveKarteDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaZeljaKarteNaListi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxListaZeljaSlikaKarte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxListaZeljaSlikaSveKarte)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaZeljaGumbMakni
            // 
            this.ListaZeljaGumbMakni.Location = new System.Drawing.Point(563, 145);
            this.ListaZeljaGumbMakni.Name = "ListaZeljaGumbMakni";
            this.ListaZeljaGumbMakni.Size = new System.Drawing.Size(75, 23);
            this.ListaZeljaGumbMakni.TabIndex = 14;
            this.ListaZeljaGumbMakni.Text = "---> Makni";
            this.ListaZeljaGumbMakni.UseVisualStyleBackColor = true;
            this.ListaZeljaGumbMakni.Click += new System.EventHandler(this.ListaZeljaGumbMakni_Click);
            // 
            // btnListaZeljaTrazigumb
            // 
            this.btnListaZeljaTrazigumb.Location = new System.Drawing.Point(765, 75);
            this.btnListaZeljaTrazigumb.Name = "btnListaZeljaTrazigumb";
            this.btnListaZeljaTrazigumb.Size = new System.Drawing.Size(60, 23);
            this.btnListaZeljaTrazigumb.TabIndex = 13;
            this.btnListaZeljaTrazigumb.Text = "Trazi!";
            this.btnListaZeljaTrazigumb.UseVisualStyleBackColor = true;
            this.btnListaZeljaTrazigumb.Click += new System.EventHandler(this.btnListaZeljaTrazigumb_Click);
            // 
            // btnListaZeljaDodajGumb
            // 
            this.btnListaZeljaDodajGumb.Location = new System.Drawing.Point(563, 115);
            this.btnListaZeljaDodajGumb.Name = "btnListaZeljaDodajGumb";
            this.btnListaZeljaDodajGumb.Size = new System.Drawing.Size(75, 23);
            this.btnListaZeljaDodajGumb.TabIndex = 12;
            this.btnListaZeljaDodajGumb.Text = "<--- Dodaj";
            this.btnListaZeljaDodajGumb.UseVisualStyleBackColor = true;
            this.btnListaZeljaDodajGumb.Click += new System.EventHandler(this.btnListaZeljaDodajGumb_Click);
            // 
            // tboxListaZeljaTraziSveKarteTbox
            // 
            this.tboxListaZeljaTraziSveKarteTbox.Location = new System.Drawing.Point(644, 77);
            this.tboxListaZeljaTraziSveKarteTbox.Name = "tboxListaZeljaTraziSveKarteTbox";
            this.tboxListaZeljaTraziSveKarteTbox.Size = new System.Drawing.Size(116, 20);
            this.tboxListaZeljaTraziSveKarteTbox.TabIndex = 11;
            this.tboxListaZeljaTraziSveKarteTbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxListaZeljaTraziSveKarteTbox_KeyDown);
            // 
            // dgvListaZeljaSveKarteDGV
            // 
            this.dgvListaZeljaSveKarteDGV.AllowUserToAddRows = false;
            this.dgvListaZeljaSveKarteDGV.AllowUserToDeleteRows = false;
            this.dgvListaZeljaSveKarteDGV.AutoGenerateColumns = false;
            this.dgvListaZeljaSveKarteDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaZeljaSveKarteDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKartaDataGridViewTextBoxColumn,
            this.imeKarteDataGridViewTextBoxColumn,
            this.opisKarteDataGridViewTextBoxColumn,
            this.slikaKarteDataGridViewTextBoxColumn,
            this.oglasDataGridViewTextBoxColumn,
            this.wishlistDataGridViewTextBoxColumn});
            this.dgvListaZeljaSveKarteDGV.DataSource = this.kartaBindingSource;
            this.dgvListaZeljaSveKarteDGV.Location = new System.Drawing.Point(644, 115);
            this.dgvListaZeljaSveKarteDGV.Name = "dgvListaZeljaSveKarteDGV";
            this.dgvListaZeljaSveKarteDGV.ReadOnly = true;
            this.dgvListaZeljaSveKarteDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaZeljaSveKarteDGV.Size = new System.Drawing.Size(247, 152);
            this.dgvListaZeljaSveKarteDGV.TabIndex = 9;
            this.dgvListaZeljaSveKarteDGV.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaZeljaSveKarteDGV_RowEnter);
            // 
            // idKartaDataGridViewTextBoxColumn
            // 
            this.idKartaDataGridViewTextBoxColumn.DataPropertyName = "idKarta";
            this.idKartaDataGridViewTextBoxColumn.HeaderText = "idKarta";
            this.idKartaDataGridViewTextBoxColumn.Name = "idKartaDataGridViewTextBoxColumn";
            this.idKartaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idKartaDataGridViewTextBoxColumn.Visible = false;
            // 
            // imeKarteDataGridViewTextBoxColumn
            // 
            this.imeKarteDataGridViewTextBoxColumn.DataPropertyName = "imeKarte";
            this.imeKarteDataGridViewTextBoxColumn.HeaderText = "Ime karte";
            this.imeKarteDataGridViewTextBoxColumn.Name = "imeKarteDataGridViewTextBoxColumn";
            this.imeKarteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisKarteDataGridViewTextBoxColumn
            // 
            this.opisKarteDataGridViewTextBoxColumn.DataPropertyName = "opisKarte";
            this.opisKarteDataGridViewTextBoxColumn.HeaderText = "Opis karte";
            this.opisKarteDataGridViewTextBoxColumn.Name = "opisKarteDataGridViewTextBoxColumn";
            this.opisKarteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // slikaKarteDataGridViewTextBoxColumn
            // 
            this.slikaKarteDataGridViewTextBoxColumn.DataPropertyName = "slikaKarte";
            this.slikaKarteDataGridViewTextBoxColumn.HeaderText = "slikaKarte";
            this.slikaKarteDataGridViewTextBoxColumn.Name = "slikaKarteDataGridViewTextBoxColumn";
            this.slikaKarteDataGridViewTextBoxColumn.ReadOnly = true;
            this.slikaKarteDataGridViewTextBoxColumn.Visible = false;
            // 
            // oglasDataGridViewTextBoxColumn
            // 
            this.oglasDataGridViewTextBoxColumn.DataPropertyName = "oglas";
            this.oglasDataGridViewTextBoxColumn.HeaderText = "Oglas";
            this.oglasDataGridViewTextBoxColumn.Name = "oglasDataGridViewTextBoxColumn";
            this.oglasDataGridViewTextBoxColumn.ReadOnly = true;
            this.oglasDataGridViewTextBoxColumn.Visible = false;
            // 
            // wishlistDataGridViewTextBoxColumn
            // 
            this.wishlistDataGridViewTextBoxColumn.DataPropertyName = "wishlist";
            this.wishlistDataGridViewTextBoxColumn.HeaderText = "wishlist";
            this.wishlistDataGridViewTextBoxColumn.Name = "wishlistDataGridViewTextBoxColumn";
            this.wishlistDataGridViewTextBoxColumn.ReadOnly = true;
            this.wishlistDataGridViewTextBoxColumn.Visible = false;
            // 
            // kartaBindingSource
            // 
            this.kartaBindingSource.DataSource = typeof(CardBringer2.karta);
            // 
            // dgvListaZeljaKarteNaListi
            // 
            this.dgvListaZeljaKarteNaListi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaZeljaKarteNaListi.Location = new System.Drawing.Point(310, 115);
            this.dgvListaZeljaKarteNaListi.Name = "dgvListaZeljaKarteNaListi";
            this.dgvListaZeljaKarteNaListi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaZeljaKarteNaListi.Size = new System.Drawing.Size(247, 152);
            this.dgvListaZeljaKarteNaListi.TabIndex = 10;
            this.dgvListaZeljaKarteNaListi.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaZeljaKarteNaListi_RowEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(642, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sve Karte:";
            // 
            // lblListaZeljaKarteNaListi
            // 
            this.lblListaZeljaKarteNaListi.AutoSize = true;
            this.lblListaZeljaKarteNaListi.ForeColor = System.Drawing.Color.White;
            this.lblListaZeljaKarteNaListi.Location = new System.Drawing.Point(308, 98);
            this.lblListaZeljaKarteNaListi.Name = "lblListaZeljaKarteNaListi";
            this.lblListaZeljaKarteNaListi.Size = new System.Drawing.Size(93, 13);
            this.lblListaZeljaKarteNaListi.TabIndex = 7;
            this.lblListaZeljaKarteNaListi.Text = "Karte na listi Zelja:";
            // 
            // btnListaZeljaResetGumb
            // 
            this.btnListaZeljaResetGumb.Location = new System.Drawing.Point(831, 75);
            this.btnListaZeljaResetGumb.Name = "btnListaZeljaResetGumb";
            this.btnListaZeljaResetGumb.Size = new System.Drawing.Size(60, 23);
            this.btnListaZeljaResetGumb.TabIndex = 15;
            this.btnListaZeljaResetGumb.Text = "Reset";
            this.btnListaZeljaResetGumb.UseVisualStyleBackColor = true;
            this.btnListaZeljaResetGumb.Click += new System.EventHandler(this.btnListaZeljaResetGumb_Click);
            // 
            // lblListaZeljaImeKarte
            // 
            this.lblListaZeljaImeKarte.AutoSize = true;
            this.lblListaZeljaImeKarte.ForeColor = System.Drawing.Color.White;
            this.lblListaZeljaImeKarte.Location = new System.Drawing.Point(20, 430);
            this.lblListaZeljaImeKarte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListaZeljaImeKarte.Name = "lblListaZeljaImeKarte";
            this.lblListaZeljaImeKarte.Size = new System.Drawing.Size(61, 13);
            this.lblListaZeljaImeKarte.TabIndex = 18;
            this.lblListaZeljaImeKarte.Text = "Naziv karte";
            // 
            // rtboxListaZeljaOpisKarte
            // 
            this.rtboxListaZeljaOpisKarte.Location = new System.Drawing.Point(22, 451);
            this.rtboxListaZeljaOpisKarte.Margin = new System.Windows.Forms.Padding(2);
            this.rtboxListaZeljaOpisKarte.Name = "rtboxListaZeljaOpisKarte";
            this.rtboxListaZeljaOpisKarte.ReadOnly = true;
            this.rtboxListaZeljaOpisKarte.Size = new System.Drawing.Size(267, 81);
            this.rtboxListaZeljaOpisKarte.TabIndex = 17;
            this.rtboxListaZeljaOpisKarte.Text = "";
            // 
            // pboxListaZeljaSlikaKarte
            // 
            this.pboxListaZeljaSlikaKarte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxListaZeljaSlikaKarte.Location = new System.Drawing.Point(22, 75);
            this.pboxListaZeljaSlikaKarte.Margin = new System.Windows.Forms.Padding(2);
            this.pboxListaZeljaSlikaKarte.Name = "pboxListaZeljaSlikaKarte";
            this.pboxListaZeljaSlikaKarte.Size = new System.Drawing.Size(267, 351);
            this.pboxListaZeljaSlikaKarte.TabIndex = 16;
            this.pboxListaZeljaSlikaKarte.TabStop = false;
            // 
            // lblListaZeljaSveKarteIme
            // 
            this.lblListaZeljaSveKarteIme.AutoSize = true;
            this.lblListaZeljaSveKarteIme.ForeColor = System.Drawing.Color.White;
            this.lblListaZeljaSveKarteIme.Location = new System.Drawing.Point(912, 430);
            this.lblListaZeljaSveKarteIme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListaZeljaSveKarteIme.Name = "lblListaZeljaSveKarteIme";
            this.lblListaZeljaSveKarteIme.Size = new System.Drawing.Size(61, 13);
            this.lblListaZeljaSveKarteIme.TabIndex = 21;
            this.lblListaZeljaSveKarteIme.Text = "Naziv karte";
            // 
            // rtboxListaZeljaOpisKarteSveKarte
            // 
            this.rtboxListaZeljaOpisKarteSveKarte.Location = new System.Drawing.Point(914, 451);
            this.rtboxListaZeljaOpisKarteSveKarte.Margin = new System.Windows.Forms.Padding(2);
            this.rtboxListaZeljaOpisKarteSveKarte.Name = "rtboxListaZeljaOpisKarteSveKarte";
            this.rtboxListaZeljaOpisKarteSveKarte.ReadOnly = true;
            this.rtboxListaZeljaOpisKarteSveKarte.Size = new System.Drawing.Size(267, 81);
            this.rtboxListaZeljaOpisKarteSveKarte.TabIndex = 20;
            this.rtboxListaZeljaOpisKarteSveKarte.Text = "";
            // 
            // pboxListaZeljaSlikaSveKarte
            // 
            this.pboxListaZeljaSlikaSveKarte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxListaZeljaSlikaSveKarte.Location = new System.Drawing.Point(914, 75);
            this.pboxListaZeljaSlikaSveKarte.Margin = new System.Windows.Forms.Padding(2);
            this.pboxListaZeljaSlikaSveKarte.Name = "pboxListaZeljaSlikaSveKarte";
            this.pboxListaZeljaSlikaSveKarte.Size = new System.Drawing.Size(267, 351);
            this.pboxListaZeljaSlikaSveKarte.TabIndex = 19;
            this.pboxListaZeljaSlikaSveKarte.TabStop = false;
            // 
            // ListaZelja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1203, 603);
            this.Controls.Add(this.lblListaZeljaSveKarteIme);
            this.Controls.Add(this.rtboxListaZeljaOpisKarteSveKarte);
            this.Controls.Add(this.pboxListaZeljaSlikaSveKarte);
            this.Controls.Add(this.lblListaZeljaImeKarte);
            this.Controls.Add(this.rtboxListaZeljaOpisKarte);
            this.Controls.Add(this.pboxListaZeljaSlikaKarte);
            this.Controls.Add(this.btnListaZeljaResetGumb);
            this.Controls.Add(this.ListaZeljaGumbMakni);
            this.Controls.Add(this.btnListaZeljaTrazigumb);
            this.Controls.Add(this.btnListaZeljaDodajGumb);
            this.Controls.Add(this.tboxListaZeljaTraziSveKarteTbox);
            this.Controls.Add(this.dgvListaZeljaSveKarteDGV);
            this.Controls.Add(this.dgvListaZeljaKarteNaListi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblListaZeljaKarteNaListi);
            this.Name = "ListaZelja";
            this.Text = "ListaZelja";
            this.Load += new System.EventHandler(this.ListaZelja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaZeljaSveKarteDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaZeljaKarteNaListi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxListaZeljaSlikaKarte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxListaZeljaSlikaSveKarte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ListaZeljaGumbMakni;
        private System.Windows.Forms.Button btnListaZeljaTrazigumb;
        private System.Windows.Forms.Button btnListaZeljaDodajGumb;
        private System.Windows.Forms.TextBox tboxListaZeljaTraziSveKarteTbox;
        private System.Windows.Forms.DataGridView dgvListaZeljaSveKarteDGV;
        private System.Windows.Forms.DataGridView dgvListaZeljaKarteNaListi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblListaZeljaKarteNaListi;
        private System.Windows.Forms.Button btnListaZeljaResetGumb;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKartaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeKarteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisKarteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slikaKarteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oglasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wishlistDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource kartaBindingSource;
        private System.Windows.Forms.Label lblListaZeljaImeKarte;
        private System.Windows.Forms.RichTextBox rtboxListaZeljaOpisKarte;
        private System.Windows.Forms.PictureBox pboxListaZeljaSlikaKarte;
        private System.Windows.Forms.Label lblListaZeljaSveKarteIme;
        private System.Windows.Forms.RichTextBox rtboxListaZeljaOpisKarteSveKarte;
        private System.Windows.Forms.PictureBox pboxListaZeljaSlikaSveKarte;
    }
}