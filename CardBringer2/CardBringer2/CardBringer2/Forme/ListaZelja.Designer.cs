﻿namespace CardBringer2
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
            this.ListaZeljaGumbMakni.Location = new System.Drawing.Point(563, 145);
            this.ListaZeljaGumbMakni.Name = "ListaZeljaGumbMakni";
            this.ListaZeljaGumbMakni.Size = new System.Drawing.Size(75, 23);
            this.ListaZeljaGumbMakni.TabIndex = 14;
            this.ListaZeljaGumbMakni.Text = "---> Makni";
            this.ListaZeljaGumbMakni.UseVisualStyleBackColor = true;
            this.ListaZeljaGumbMakni.Click += new System.EventHandler(this.ListaZeljaGumbMakni_Click);
            // 
            // ListaZeljaButtonTrazi
            // 
            this.ListaZeljaButtonTrazi.Location = new System.Drawing.Point(765, 75);
            this.ListaZeljaButtonTrazi.Name = "ListaZeljaButtonTrazi";
            this.ListaZeljaButtonTrazi.Size = new System.Drawing.Size(60, 23);
            this.ListaZeljaButtonTrazi.TabIndex = 13;
            this.ListaZeljaButtonTrazi.Text = "Trazi!";
            this.ListaZeljaButtonTrazi.UseVisualStyleBackColor = true;
            this.ListaZeljaButtonTrazi.Click += new System.EventHandler(this.ListaZeljaButtonTrazi_Click);
            // 
            // ListaZeljaGumbDodaj
            // 
            this.ListaZeljaGumbDodaj.Location = new System.Drawing.Point(563, 115);
            this.ListaZeljaGumbDodaj.Name = "ListaZeljaGumbDodaj";
            this.ListaZeljaGumbDodaj.Size = new System.Drawing.Size(75, 23);
            this.ListaZeljaGumbDodaj.TabIndex = 12;
            this.ListaZeljaGumbDodaj.Text = "<--- Dodaj";
            this.ListaZeljaGumbDodaj.UseVisualStyleBackColor = true;
            this.ListaZeljaGumbDodaj.Click += new System.EventHandler(this.ListaZeljaGumbDodaj_Click);
            // 
            // ListaZeljaTraziUSvimKartama
            // 
            this.ListaZeljaTraziUSvimKartama.Location = new System.Drawing.Point(644, 77);
            this.ListaZeljaTraziUSvimKartama.Name = "ListaZeljaTraziUSvimKartama";
            this.ListaZeljaTraziUSvimKartama.Size = new System.Drawing.Size(116, 20);
            this.ListaZeljaTraziUSvimKartama.TabIndex = 11;
            this.ListaZeljaTraziUSvimKartama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListaZeljaTrazi_KeyDown);
            // 
            // SveKarteDatagrid
            // 
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
            this.SveKarteDatagrid.Location = new System.Drawing.Point(644, 115);
            this.SveKarteDatagrid.Name = "SveKarteDatagrid";
            this.SveKarteDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SveKarteDatagrid.Size = new System.Drawing.Size(247, 152);
            this.SveKarteDatagrid.TabIndex = 9;
            this.SveKarteDatagrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.SveKarteDatagrid_RowEnter);
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
            this.oglasDataGridViewTextBoxColumn.HeaderText = "Oglas";
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
            // ListaZeljaDataGrid
            // 
            this.ListaZeljaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaZeljaDataGrid.Location = new System.Drawing.Point(310, 115);
            this.ListaZeljaDataGrid.Name = "ListaZeljaDataGrid";
            this.ListaZeljaDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaZeljaDataGrid.Size = new System.Drawing.Size(247, 152);
            this.ListaZeljaDataGrid.TabIndex = 10;
            this.ListaZeljaDataGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaZeljaDataGrid_RowEnter);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(308, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Karte na listi Zelja:";
            // 
            // GumbResetListaZelja
            // 
            this.GumbResetListaZelja.Location = new System.Drawing.Point(831, 75);
            this.GumbResetListaZelja.Name = "GumbResetListaZelja";
            this.GumbResetListaZelja.Size = new System.Drawing.Size(60, 23);
            this.GumbResetListaZelja.TabIndex = 15;
            this.GumbResetListaZelja.Text = "Reset";
            this.GumbResetListaZelja.UseVisualStyleBackColor = true;
            this.GumbResetListaZelja.Click += new System.EventHandler(this.GumbResetListaZelja_Click);
            // 
            // imeKarteListaZelja
            // 
            this.imeKarteListaZelja.AutoSize = true;
            this.imeKarteListaZelja.ForeColor = System.Drawing.Color.White;
            this.imeKarteListaZelja.Location = new System.Drawing.Point(20, 430);
            this.imeKarteListaZelja.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.imeKarteListaZelja.Name = "imeKarteListaZelja";
            this.imeKarteListaZelja.Size = new System.Drawing.Size(61, 13);
            this.imeKarteListaZelja.TabIndex = 18;
            this.imeKarteListaZelja.Text = "Naziv karte";
            // 
            // opisKarteListaZelja
            // 
            this.opisKarteListaZelja.Location = new System.Drawing.Point(22, 451);
            this.opisKarteListaZelja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.opisKarteListaZelja.Name = "opisKarteListaZelja";
            this.opisKarteListaZelja.ReadOnly = true;
            this.opisKarteListaZelja.Size = new System.Drawing.Size(267, 81);
            this.opisKarteListaZelja.TabIndex = 17;
            this.opisKarteListaZelja.Text = "";
            // 
            // pictureBoxSlikaKarteListaZelja
            // 
            this.pictureBoxSlikaKarteListaZelja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSlikaKarteListaZelja.Location = new System.Drawing.Point(22, 75);
            this.pictureBoxSlikaKarteListaZelja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxSlikaKarteListaZelja.Name = "pictureBoxSlikaKarteListaZelja";
            this.pictureBoxSlikaKarteListaZelja.Size = new System.Drawing.Size(267, 351);
            this.pictureBoxSlikaKarteListaZelja.TabIndex = 16;
            this.pictureBoxSlikaKarteListaZelja.TabStop = false;
            // 
            // imeKarteSveKarte
            // 
            this.imeKarteSveKarte.AutoSize = true;
            this.imeKarteSveKarte.ForeColor = System.Drawing.Color.White;
            this.imeKarteSveKarte.Location = new System.Drawing.Point(912, 430);
            this.imeKarteSveKarte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.imeKarteSveKarte.Name = "imeKarteSveKarte";
            this.imeKarteSveKarte.Size = new System.Drawing.Size(61, 13);
            this.imeKarteSveKarte.TabIndex = 21;
            this.imeKarteSveKarte.Text = "Naziv karte";
            // 
            // opisKarteSveKarte
            // 
            this.opisKarteSveKarte.Location = new System.Drawing.Point(914, 451);
            this.opisKarteSveKarte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.opisKarteSveKarte.Name = "opisKarteSveKarte";
            this.opisKarteSveKarte.ReadOnly = true;
            this.opisKarteSveKarte.Size = new System.Drawing.Size(267, 81);
            this.opisKarteSveKarte.TabIndex = 20;
            this.opisKarteSveKarte.Text = "";
            // 
            // pictureBoxSlikaKarteSveKarte
            // 
            this.pictureBoxSlikaKarteSveKarte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSlikaKarteSveKarte.Location = new System.Drawing.Point(914, 75);
            this.pictureBoxSlikaKarteSveKarte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxSlikaKarteSveKarte.Name = "pictureBoxSlikaKarteSveKarte";
            this.pictureBoxSlikaKarteSveKarte.Size = new System.Drawing.Size(267, 351);
            this.pictureBoxSlikaKarteSveKarte.TabIndex = 19;
            this.pictureBoxSlikaKarteSveKarte.TabStop = false;
            // 
            // ListaZelja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1203, 603);
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