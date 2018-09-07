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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idKartaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeKarteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisKarteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slikaKarteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oglasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wishlistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kartaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.unosCijeneKarteObjaviOglas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.unosKolicineKarteObjaviOglas = new System.Windows.Forms.TextBox();
            this.buttonObjaviOglas = new System.Windows.Forms.Button();
            this.pictureBoxSlikaKarte = new System.Windows.Forms.PictureBox();
            this.OpisKarte = new System.Windows.Forms.RichTextBox();
            this.ImeKarte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlikaKarte)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.CausesValidation = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKartaDataGridViewTextBoxColumn,
            this.imeKarteDataGridViewTextBoxColumn,
            this.opisKarteDataGridViewTextBoxColumn,
            this.slikaKarteDataGridViewTextBoxColumn,
            this.oglasDataGridViewTextBoxColumn,
            this.wishlistDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kartaBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(12, 88);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(446, 359);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
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
            this.oglasDataGridViewTextBoxColumn.HeaderText = "oglas";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Izaberite kartu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unesite cijenu karte:";
            // 
            // unosCijeneKarteObjaviOglas
            // 
            this.unosCijeneKarteObjaviOglas.Location = new System.Drawing.Point(211, 453);
            this.unosCijeneKarteObjaviOglas.Name = "unosCijeneKarteObjaviOglas";
            this.unosCijeneKarteObjaviOglas.Size = new System.Drawing.Size(120, 20);
            this.unosCijeneKarteObjaviOglas.TabIndex = 1;
            this.unosCijeneKarteObjaviOglas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.unosCijeneKarteObjaviOglas_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(88, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unesite količinu karata:";
            // 
            // unosKolicineKarteObjaviOglas
            // 
            this.unosKolicineKarteObjaviOglas.Location = new System.Drawing.Point(211, 492);
            this.unosKolicineKarteObjaviOglas.Name = "unosKolicineKarteObjaviOglas";
            this.unosKolicineKarteObjaviOglas.Size = new System.Drawing.Size(120, 20);
            this.unosKolicineKarteObjaviOglas.TabIndex = 2;
            this.unosKolicineKarteObjaviOglas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.unosKolicineKarteObjaviOglas_KeyPress);
            // 
            // buttonObjaviOglas
            // 
            this.buttonObjaviOglas.ForeColor = System.Drawing.Color.Black;
            this.buttonObjaviOglas.Location = new System.Drawing.Point(338, 453);
            this.buttonObjaviOglas.Name = "buttonObjaviOglas";
            this.buttonObjaviOglas.Size = new System.Drawing.Size(120, 56);
            this.buttonObjaviOglas.TabIndex = 3;
            this.buttonObjaviOglas.Text = "Objavi Oglas";
            this.buttonObjaviOglas.UseVisualStyleBackColor = true;
            this.buttonObjaviOglas.Click += new System.EventHandler(this.buttonObjaviOglas_Click);
            // 
            // pictureBoxSlikaKarte
            // 
            this.pictureBoxSlikaKarte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSlikaKarte.Location = new System.Drawing.Point(484, 88);
            this.pictureBoxSlikaKarte.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxSlikaKarte.Name = "pictureBoxSlikaKarte";
            this.pictureBoxSlikaKarte.Size = new System.Drawing.Size(267, 351);
            this.pictureBoxSlikaKarte.TabIndex = 6;
            this.pictureBoxSlikaKarte.TabStop = false;
            // 
            // OpisKarte
            // 
            this.OpisKarte.Location = new System.Drawing.Point(484, 464);
            this.OpisKarte.Margin = new System.Windows.Forms.Padding(2);
            this.OpisKarte.Name = "OpisKarte";
            this.OpisKarte.ReadOnly = true;
            this.OpisKarte.Size = new System.Drawing.Size(267, 81);
            this.OpisKarte.TabIndex = 7;
            this.OpisKarte.Text = "";
            // 
            // ImeKarte
            // 
            this.ImeKarte.AutoSize = true;
            this.ImeKarte.ForeColor = System.Drawing.Color.White;
            this.ImeKarte.Location = new System.Drawing.Point(482, 443);
            this.ImeKarte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ImeKarte.Name = "ImeKarte";
            this.ImeKarte.Size = new System.Drawing.Size(61, 13);
            this.ImeKarte.TabIndex = 8;
            this.ImeKarte.Text = "Naziv karte";
            // 
            // ObjaviOglas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1203, 603);
            this.Controls.Add(this.ImeKarte);
            this.Controls.Add(this.OpisKarte);
            this.Controls.Add(this.pictureBoxSlikaKarte);
            this.Controls.Add(this.buttonObjaviOglas);
            this.Controls.Add(this.unosKolicineKarteObjaviOglas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.unosCijeneKarteObjaviOglas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ObjaviOglas";
            this.Text = "ObjaviOglas";
            this.Load += new System.EventHandler(this.ObjaviOglas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlikaKarte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox unosCijeneKarteObjaviOglas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox unosKolicineKarteObjaviOglas;
        private System.Windows.Forms.Button buttonObjaviOglas;
        private System.Windows.Forms.PictureBox pictureBoxSlikaKarte;
        private System.Windows.Forms.RichTextBox OpisKarte;
        private System.Windows.Forms.Label ImeKarte;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKartaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeKarteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisKarteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slikaKarteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oglasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wishlistDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource kartaBindingSource;
    }
}