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
            this.ListaZeljaButtonTrazi = new System.Windows.Forms.Button();
            this.ListaZeljaGumbDodaj = new System.Windows.Forms.Button();
            this.ListaZeljaTraziUSvimKartama = new System.Windows.Forms.TextBox();
            this.SveKarteDatagrid = new System.Windows.Forms.DataGridView();
            this.idKartaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeKarteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisKarteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slikaKarteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oglasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wishlistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kartaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ListaZeljaDataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GumbResetListaZelja = new System.Windows.Forms.Button();
            this.imeKarteListaZelja = new System.Windows.Forms.Label();
            this.opisKarteListaZelja = new System.Windows.Forms.RichTextBox();
            this.pictureBoxSlikaKarteListaZelja = new System.Windows.Forms.PictureBox();
            this.imeKarteSveKarte = new System.Windows.Forms.Label();
            this.opisKarteSveKarte = new System.Windows.Forms.RichTextBox();
            this.pictureBoxSlikaKarteSveKarte = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SveKarteDatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaZeljaDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlikaKarteListaZelja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlikaKarteSveKarte)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaZeljaGumbMakni
            // 
            this.ListaZeljaGumbMakni.Location = new System.Drawing.Point(751, 178);
            this.ListaZeljaGumbMakni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListaZeljaGumbMakni.Name = "ListaZeljaGumbMakni";
            this.ListaZeljaGumbMakni.Size = new System.Drawing.Size(100, 28);
            this.ListaZeljaGumbMakni.TabIndex = 14;
            this.ListaZeljaGumbMakni.Text = "---> Makni";
            this.ListaZeljaGumbMakni.UseVisualStyleBackColor = true;
            this.ListaZeljaGumbMakni.Click += new System.EventHandler(this.ListaZeljaGumbMakni_Click);
            // 
            // ListaZeljaButtonTrazi
            // 
            this.ListaZeljaButtonTrazi.Location = new System.Drawing.Point(1020, 92);
            this.ListaZeljaButtonTrazi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListaZeljaButtonTrazi.Name = "ListaZeljaButtonTrazi";
            this.ListaZeljaButtonTrazi.Size = new System.Drawing.Size(80, 28);
            this.ListaZeljaButtonTrazi.TabIndex = 13;
            this.ListaZeljaButtonTrazi.Text = "Trazi!";
            this.ListaZeljaButtonTrazi.UseVisualStyleBackColor = true;
            this.ListaZeljaButtonTrazi.Click += new System.EventHandler(this.ListaZeljaButtonTrazi_Click);
            // 
            // ListaZeljaGumbDodaj
            // 
            this.ListaZeljaGumbDodaj.Location = new System.Drawing.Point(751, 142);
            this.ListaZeljaGumbDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListaZeljaGumbDodaj.Name = "ListaZeljaGumbDodaj";
            this.ListaZeljaGumbDodaj.Size = new System.Drawing.Size(100, 28);
            this.ListaZeljaGumbDodaj.TabIndex = 12;
            this.ListaZeljaGumbDodaj.Text = "<--- Dodaj";
            this.ListaZeljaGumbDodaj.UseVisualStyleBackColor = true;
            this.ListaZeljaGumbDodaj.Click += new System.EventHandler(this.ListaZeljaGumbDodaj_Click);
            // 
            // ListaZeljaTraziUSvimKartama
            // 
            this.ListaZeljaTraziUSvimKartama.Location = new System.Drawing.Point(859, 95);
            this.ListaZeljaTraziUSvimKartama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListaZeljaTraziUSvimKartama.Name = "ListaZeljaTraziUSvimKartama";
            this.ListaZeljaTraziUSvimKartama.Size = new System.Drawing.Size(153, 22);
            this.ListaZeljaTraziUSvimKartama.TabIndex = 11;
            this.ListaZeljaTraziUSvimKartama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListaZeljaTrazi_KeyDown);
            // 
            // SveKarteDatagrid
            // 
            this.SveKarteDatagrid.AllowUserToAddRows = false;
            this.SveKarteDatagrid.AllowUserToDeleteRows = false;
            this.SveKarteDatagrid.AutoGenerateColumns = false;
            this.SveKarteDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SveKarteDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKartaDataGridViewTextBoxColumn,
            this.imeKarteDataGridViewTextBoxColumn,
            this.opisKarteDataGridViewTextBoxColumn,
            this.slikaKarteDataGridViewTextBoxColumn,
            this.oglasDataGridViewTextBoxColumn,
            this.wishlistDataGridViewTextBoxColumn});
            this.SveKarteDatagrid.DataSource = this.kartaBindingSource;
            this.SveKarteDatagrid.Location = new System.Drawing.Point(859, 142);
            this.SveKarteDatagrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SveKarteDatagrid.Name = "SveKarteDatagrid";
            this.SveKarteDatagrid.ReadOnly = true;
            this.SveKarteDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SveKarteDatagrid.Size = new System.Drawing.Size(329, 187);
            this.SveKarteDatagrid.TabIndex = 9;
            this.SveKarteDatagrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.SveKarteDatagrid_RowEnter);
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
            // ListaZeljaDataGrid
            // 
            this.ListaZeljaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaZeljaDataGrid.Location = new System.Drawing.Point(413, 142);
            this.ListaZeljaDataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListaZeljaDataGrid.Name = "ListaZeljaDataGrid";
            this.ListaZeljaDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaZeljaDataGrid.Size = new System.Drawing.Size(329, 187);
            this.ListaZeljaDataGrid.TabIndex = 10;
            this.ListaZeljaDataGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaZeljaDataGrid_RowEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(856, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sve Karte:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(411, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Karte na listi Zelja:";
            // 
            // GumbResetListaZelja
            // 
            this.GumbResetListaZelja.Location = new System.Drawing.Point(1108, 92);
            this.GumbResetListaZelja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GumbResetListaZelja.Name = "GumbResetListaZelja";
            this.GumbResetListaZelja.Size = new System.Drawing.Size(80, 28);
            this.GumbResetListaZelja.TabIndex = 15;
            this.GumbResetListaZelja.Text = "Reset";
            this.GumbResetListaZelja.UseVisualStyleBackColor = true;
            this.GumbResetListaZelja.Click += new System.EventHandler(this.GumbResetListaZelja_Click);
            // 
            // imeKarteListaZelja
            // 
            this.imeKarteListaZelja.AutoSize = true;
            this.imeKarteListaZelja.ForeColor = System.Drawing.Color.White;
            this.imeKarteListaZelja.Location = new System.Drawing.Point(27, 529);
            this.imeKarteListaZelja.Name = "imeKarteListaZelja";
            this.imeKarteListaZelja.Size = new System.Drawing.Size(79, 17);
            this.imeKarteListaZelja.TabIndex = 18;
            this.imeKarteListaZelja.Text = "Naziv karte";
            // 
            // opisKarteListaZelja
            // 
            this.opisKarteListaZelja.Location = new System.Drawing.Point(29, 555);
            this.opisKarteListaZelja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.opisKarteListaZelja.Name = "opisKarteListaZelja";
            this.opisKarteListaZelja.Size = new System.Drawing.Size(355, 99);
            this.opisKarteListaZelja.TabIndex = 17;
            this.opisKarteListaZelja.Text = "";
            // 
            // pictureBoxSlikaKarteListaZelja
            // 
            this.pictureBoxSlikaKarteListaZelja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSlikaKarteListaZelja.Location = new System.Drawing.Point(29, 92);
            this.pictureBoxSlikaKarteListaZelja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxSlikaKarteListaZelja.Name = "pictureBoxSlikaKarteListaZelja";
            this.pictureBoxSlikaKarteListaZelja.Size = new System.Drawing.Size(355, 432);
            this.pictureBoxSlikaKarteListaZelja.TabIndex = 16;
            this.pictureBoxSlikaKarteListaZelja.TabStop = false;
            // 
            // imeKarteSveKarte
            // 
            this.imeKarteSveKarte.AutoSize = true;
            this.imeKarteSveKarte.ForeColor = System.Drawing.Color.White;
            this.imeKarteSveKarte.Location = new System.Drawing.Point(1216, 529);
            this.imeKarteSveKarte.Name = "imeKarteSveKarte";
            this.imeKarteSveKarte.Size = new System.Drawing.Size(79, 17);
            this.imeKarteSveKarte.TabIndex = 21;
            this.imeKarteSveKarte.Text = "Naziv karte";
            // 
            // opisKarteSveKarte
            // 
            this.opisKarteSveKarte.Location = new System.Drawing.Point(1219, 555);
            this.opisKarteSveKarte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.opisKarteSveKarte.Name = "opisKarteSveKarte";
            this.opisKarteSveKarte.Size = new System.Drawing.Size(355, 99);
            this.opisKarteSveKarte.TabIndex = 20;
            this.opisKarteSveKarte.Text = "";
            // 
            // pictureBoxSlikaKarteSveKarte
            // 
            this.pictureBoxSlikaKarteSveKarte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSlikaKarteSveKarte.Location = new System.Drawing.Point(1219, 92);
            this.pictureBoxSlikaKarteSveKarte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxSlikaKarteSveKarte.Name = "pictureBoxSlikaKarteSveKarte";
            this.pictureBoxSlikaKarteSveKarte.Size = new System.Drawing.Size(355, 432);
            this.pictureBoxSlikaKarteSveKarte.TabIndex = 19;
            this.pictureBoxSlikaKarteSveKarte.TabStop = false;
            // 
            // ListaZelja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1604, 742);
            this.Controls.Add(this.imeKarteSveKarte);
            this.Controls.Add(this.opisKarteSveKarte);
            this.Controls.Add(this.pictureBoxSlikaKarteSveKarte);
            this.Controls.Add(this.imeKarteListaZelja);
            this.Controls.Add(this.opisKarteListaZelja);
            this.Controls.Add(this.pictureBoxSlikaKarteListaZelja);
            this.Controls.Add(this.GumbResetListaZelja);
            this.Controls.Add(this.ListaZeljaGumbMakni);
            this.Controls.Add(this.ListaZeljaButtonTrazi);
            this.Controls.Add(this.ListaZeljaGumbDodaj);
            this.Controls.Add(this.ListaZeljaTraziUSvimKartama);
            this.Controls.Add(this.SveKarteDatagrid);
            this.Controls.Add(this.ListaZeljaDataGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ListaZelja";
            this.Text = "ListaZelja";
            this.Load += new System.EventHandler(this.ListaZelja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SveKarteDatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaZeljaDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlikaKarteListaZelja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlikaKarteSveKarte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ListaZeljaGumbMakni;
        private System.Windows.Forms.Button ListaZeljaButtonTrazi;
        private System.Windows.Forms.Button ListaZeljaGumbDodaj;
        private System.Windows.Forms.TextBox ListaZeljaTraziUSvimKartama;
        private System.Windows.Forms.DataGridView SveKarteDatagrid;
        private System.Windows.Forms.DataGridView ListaZeljaDataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GumbResetListaZelja;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKartaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeKarteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisKarteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slikaKarteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oglasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wishlistDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource kartaBindingSource;
        private System.Windows.Forms.Label imeKarteListaZelja;
        private System.Windows.Forms.RichTextBox opisKarteListaZelja;
        private System.Windows.Forms.PictureBox pictureBoxSlikaKarteListaZelja;
        private System.Windows.Forms.Label imeKarteSveKarte;
        private System.Windows.Forms.RichTextBox opisKarteSveKarte;
        private System.Windows.Forms.PictureBox pictureBoxSlikaKarteSveKarte;
    }
}