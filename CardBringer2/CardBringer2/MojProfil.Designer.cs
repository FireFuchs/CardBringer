namespace CardBringer2
{
    partial class MojProfil
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
            this.TipKorisnikaLabelUnchanged = new System.Windows.Forms.Label();
            this.MojProfilLabelTipKorisnika = new System.Windows.Forms.Label();
            this.MojProfilLabelAdresa = new System.Windows.Forms.Label();
            this.MojProfilLabelNickname = new System.Windows.Forms.Label();
            this.MojProfilLabelEmail = new System.Windows.Forms.Label();
            this.MojProfilLabelID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AdresaLabelUnchanged = new System.Windows.Forms.Label();
            this.NicknameLabelUnchanged = new System.Windows.Forms.Label();
            this.EmailLabelUnchanged = new System.Windows.Forms.Label();
            this.IDlabelUnchanged = new System.Windows.Forms.Label();
            this.KorisnikoveKarteLabelUnchanged = new System.Windows.Forms.Label();
            this.korisnikKartaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database2DataSet = new CardBringer2.Database2DataSet();
            this.korisnikKartaTableAdapter = new CardBringer2.Database2DataSetTableAdapters.korisnikKartaTableAdapter();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKorisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKarta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKorisnikKarta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikKartaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.CausesValidation = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cijenaDataGridViewTextBoxColumn,
            this.idKorisnik,
            this.idKarta,
            this.idKorisnikKarta,
            this.kolicinaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.korisnikKartaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(307, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(802, 491);
            this.dataGridView1.TabIndex = 14;
            // 
            // TipKorisnikaLabelUnchanged
            // 
            this.TipKorisnikaLabelUnchanged.AutoSize = true;
            this.TipKorisnikaLabelUnchanged.Location = new System.Drawing.Point(15, 179);
            this.TipKorisnikaLabelUnchanged.Name = "TipKorisnikaLabelUnchanged";
            this.TipKorisnikaLabelUnchanged.Size = new System.Drawing.Size(71, 13);
            this.TipKorisnikaLabelUnchanged.TabIndex = 8;
            this.TipKorisnikaLabelUnchanged.Text = "Tip Korisnika:";
            // 
            // MojProfilLabelTipKorisnika
            // 
            this.MojProfilLabelTipKorisnika.AutoSize = true;
            this.MojProfilLabelTipKorisnika.Location = new System.Drawing.Point(92, 179);
            this.MojProfilLabelTipKorisnika.Name = "MojProfilLabelTipKorisnika";
            this.MojProfilLabelTipKorisnika.Size = new System.Drawing.Size(10, 13);
            this.MojProfilLabelTipKorisnika.TabIndex = 9;
            this.MojProfilLabelTipKorisnika.Text = "-";
            // 
            // MojProfilLabelAdresa
            // 
            this.MojProfilLabelAdresa.AutoSize = true;
            this.MojProfilLabelAdresa.Location = new System.Drawing.Point(92, 152);
            this.MojProfilLabelAdresa.Name = "MojProfilLabelAdresa";
            this.MojProfilLabelAdresa.Size = new System.Drawing.Size(10, 13);
            this.MojProfilLabelAdresa.TabIndex = 10;
            this.MojProfilLabelAdresa.Text = "-";
            // 
            // MojProfilLabelNickname
            // 
            this.MojProfilLabelNickname.AutoSize = true;
            this.MojProfilLabelNickname.Location = new System.Drawing.Point(92, 95);
            this.MojProfilLabelNickname.Name = "MojProfilLabelNickname";
            this.MojProfilLabelNickname.Size = new System.Drawing.Size(10, 13);
            this.MojProfilLabelNickname.TabIndex = 11;
            this.MojProfilLabelNickname.Text = "-";
            // 
            // MojProfilLabelEmail
            // 
            this.MojProfilLabelEmail.AutoSize = true;
            this.MojProfilLabelEmail.Location = new System.Drawing.Point(92, 123);
            this.MojProfilLabelEmail.Name = "MojProfilLabelEmail";
            this.MojProfilLabelEmail.Size = new System.Drawing.Size(10, 13);
            this.MojProfilLabelEmail.TabIndex = 12;
            this.MojProfilLabelEmail.Text = "-";
            // 
            // MojProfilLabelID
            // 
            this.MojProfilLabelID.AutoSize = true;
            this.MojProfilLabelID.Location = new System.Drawing.Point(92, 66);
            this.MojProfilLabelID.Name = "MojProfilLabelID";
            this.MojProfilLabelID.Size = new System.Drawing.Size(10, 13);
            this.MojProfilLabelID.TabIndex = 13;
            this.MojProfilLabelID.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 3;
            // 
            // AdresaLabelUnchanged
            // 
            this.AdresaLabelUnchanged.AutoSize = true;
            this.AdresaLabelUnchanged.Location = new System.Drawing.Point(43, 152);
            this.AdresaLabelUnchanged.Name = "AdresaLabelUnchanged";
            this.AdresaLabelUnchanged.Size = new System.Drawing.Size(43, 13);
            this.AdresaLabelUnchanged.TabIndex = 4;
            this.AdresaLabelUnchanged.Text = "Adresa:";
            // 
            // NicknameLabelUnchanged
            // 
            this.NicknameLabelUnchanged.AutoSize = true;
            this.NicknameLabelUnchanged.Location = new System.Drawing.Point(28, 95);
            this.NicknameLabelUnchanged.Name = "NicknameLabelUnchanged";
            this.NicknameLabelUnchanged.Size = new System.Drawing.Size(58, 13);
            this.NicknameLabelUnchanged.TabIndex = 5;
            this.NicknameLabelUnchanged.Text = "Nickname:";
            // 
            // EmailLabelUnchanged
            // 
            this.EmailLabelUnchanged.AutoSize = true;
            this.EmailLabelUnchanged.Location = new System.Drawing.Point(51, 123);
            this.EmailLabelUnchanged.Name = "EmailLabelUnchanged";
            this.EmailLabelUnchanged.Size = new System.Drawing.Size(35, 13);
            this.EmailLabelUnchanged.TabIndex = 6;
            this.EmailLabelUnchanged.Text = "Email:";
            // 
            // IDlabelUnchanged
            // 
            this.IDlabelUnchanged.AutoSize = true;
            this.IDlabelUnchanged.Location = new System.Drawing.Point(65, 66);
            this.IDlabelUnchanged.Name = "IDlabelUnchanged";
            this.IDlabelUnchanged.Size = new System.Drawing.Size(21, 13);
            this.IDlabelUnchanged.TabIndex = 7;
            this.IDlabelUnchanged.Text = "ID:";
            // 
            // KorisnikoveKarteLabelUnchanged
            // 
            this.KorisnikoveKarteLabelUnchanged.AutoSize = true;
            this.KorisnikoveKarteLabelUnchanged.Location = new System.Drawing.Point(304, 50);
            this.KorisnikoveKarteLabelUnchanged.Name = "KorisnikoveKarteLabelUnchanged";
            this.KorisnikoveKarteLabelUnchanged.Size = new System.Drawing.Size(93, 13);
            this.KorisnikoveKarteLabelUnchanged.TabIndex = 15;
            this.KorisnikoveKarteLabelUnchanged.Text = "Korisnikove Karte:";
            // 
            // korisnikKartaBindingSource
            // 
            this.korisnikKartaBindingSource.DataMember = "korisnikKarta";
            this.korisnikKartaBindingSource.DataSource = this.database2DataSet;
            // 
            // database2DataSet
            // 
            this.database2DataSet.DataSetName = "Database2DataSet";
            this.database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // korisnikKartaTableAdapter
            // 
            this.korisnikKartaTableAdapter.ClearBeforeFill = true;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idKorisnik
            // 
            this.idKorisnik.DataPropertyName = "idKorisnik";
            this.idKorisnik.HeaderText = "idKorisnik";
            this.idKorisnik.Name = "idKorisnik";
            this.idKorisnik.ReadOnly = true;
            this.idKorisnik.Visible = false;
            // 
            // idKarta
            // 
            this.idKarta.DataPropertyName = "idKarta";
            this.idKarta.HeaderText = "idKarta";
            this.idKarta.Name = "idKarta";
            this.idKarta.ReadOnly = true;
            this.idKarta.Visible = false;
            // 
            // idKorisnikKarta
            // 
            this.idKorisnikKarta.DataPropertyName = "idKorisnikKarta";
            this.idKorisnikKarta.HeaderText = "idKorisnikKarta";
            this.idKorisnikKarta.Name = "idKorisnikKarta";
            this.idKorisnikKarta.ReadOnly = true;
            this.idKorisnikKarta.Visible = false;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MojProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 569);
            this.ControlBox = false;
            this.Controls.Add(this.KorisnikoveKarteLabelUnchanged);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TipKorisnikaLabelUnchanged);
            this.Controls.Add(this.MojProfilLabelTipKorisnika);
            this.Controls.Add(this.MojProfilLabelAdresa);
            this.Controls.Add(this.MojProfilLabelNickname);
            this.Controls.Add(this.MojProfilLabelEmail);
            this.Controls.Add(this.MojProfilLabelID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AdresaLabelUnchanged);
            this.Controls.Add(this.NicknameLabelUnchanged);
            this.Controls.Add(this.EmailLabelUnchanged);
            this.Controls.Add(this.IDlabelUnchanged);
            this.Name = "MojProfil";
            this.Text = "MojProfil";
            this.Load += new System.EventHandler(this.MojProfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikKartaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label TipKorisnikaLabelUnchanged;
        private System.Windows.Forms.Label MojProfilLabelTipKorisnika;
        private System.Windows.Forms.Label MojProfilLabelAdresa;
        private System.Windows.Forms.Label MojProfilLabelNickname;
        private System.Windows.Forms.Label MojProfilLabelEmail;
        private System.Windows.Forms.Label MojProfilLabelID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label AdresaLabelUnchanged;
        private System.Windows.Forms.Label NicknameLabelUnchanged;
        private System.Windows.Forms.Label EmailLabelUnchanged;
        private System.Windows.Forms.Label IDlabelUnchanged;
        private System.Windows.Forms.Label KorisnikoveKarteLabelUnchanged;
        private Database2DataSet database2DataSet;
        private System.Windows.Forms.BindingSource korisnikKartaBindingSource;
        private Database2DataSetTableAdapters.korisnikKartaTableAdapter korisnikKartaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKorisnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKarta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKorisnikKarta;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
    }
}