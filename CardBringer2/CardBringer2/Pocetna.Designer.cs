namespace CardBringer2
{
    partial class Pocetna
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
            this.PocetnaLabelSveKarte = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idKorisnikKartaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKorisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKartaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikKartaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database2DataSet = new CardBringer2.Database2DataSet();
            this.PocetnaPretragaGumbTrazi = new System.Windows.Forms.Button();
            this.PocetnaPretragaText = new System.Windows.Forms.TextBox();
            this.PocetanGumbDodajUKosaricu = new System.Windows.Forms.Button();
            this.korisnikKartaTableAdapter = new CardBringer2.Database2DataSetTableAdapters.korisnikKartaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikKartaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PocetnaLabelSveKarte
            // 
            this.PocetnaLabelSveKarte.AutoSize = true;
            this.PocetnaLabelSveKarte.Location = new System.Drawing.Point(9, 54);
            this.PocetnaLabelSveKarte.Name = "PocetnaLabelSveKarte";
            this.PocetnaLabelSveKarte.Size = new System.Drawing.Size(57, 13);
            this.PocetnaLabelSveKarte.TabIndex = 0;
            this.PocetnaLabelSveKarte.Text = "Sve Karte:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.CausesValidation = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKorisnikKartaDataGridViewTextBoxColumn,
            this.idKorisnikDataGridViewTextBoxColumn,
            this.idKartaDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.korisnikKartaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(659, 482);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idKorisnikKartaDataGridViewTextBoxColumn
            // 
            this.idKorisnikKartaDataGridViewTextBoxColumn.DataPropertyName = "idKorisnikKarta";
            this.idKorisnikKartaDataGridViewTextBoxColumn.HeaderText = "idKorisnikKarta";
            this.idKorisnikKartaDataGridViewTextBoxColumn.Name = "idKorisnikKartaDataGridViewTextBoxColumn";
            this.idKorisnikKartaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idKorisnikDataGridViewTextBoxColumn
            // 
            this.idKorisnikDataGridViewTextBoxColumn.DataPropertyName = "idKorisnik";
            this.idKorisnikDataGridViewTextBoxColumn.HeaderText = "idKorisnik";
            this.idKorisnikDataGridViewTextBoxColumn.Name = "idKorisnikDataGridViewTextBoxColumn";
            this.idKorisnikDataGridViewTextBoxColumn.ReadOnly = true;
            this.idKorisnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // idKartaDataGridViewTextBoxColumn
            // 
            this.idKartaDataGridViewTextBoxColumn.DataPropertyName = "idKarta";
            this.idKartaDataGridViewTextBoxColumn.HeaderText = "idKarta";
            this.idKartaDataGridViewTextBoxColumn.Name = "idKartaDataGridViewTextBoxColumn";
            this.idKartaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idKartaDataGridViewTextBoxColumn.Visible = false;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
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
            // PocetnaPretragaGumbTrazi
            // 
            this.PocetnaPretragaGumbTrazi.Location = new System.Drawing.Point(623, 52);
            this.PocetnaPretragaGumbTrazi.Name = "PocetnaPretragaGumbTrazi";
            this.PocetnaPretragaGumbTrazi.Size = new System.Drawing.Size(48, 23);
            this.PocetnaPretragaGumbTrazi.TabIndex = 3;
            this.PocetnaPretragaGumbTrazi.Text = "Trazi!";
            this.PocetnaPretragaGumbTrazi.UseVisualStyleBackColor = true;
            // 
            // PocetnaPretragaText
            // 
            this.PocetnaPretragaText.Location = new System.Drawing.Point(449, 54);
            this.PocetnaPretragaText.Name = "PocetnaPretragaText";
            this.PocetnaPretragaText.Size = new System.Drawing.Size(168, 20);
            this.PocetnaPretragaText.TabIndex = 4;
            this.PocetnaPretragaText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PocetanGumbDodajUKosaricu
            // 
            this.PocetanGumbDodajUKosaricu.Location = new System.Drawing.Point(677, 96);
            this.PocetanGumbDodajUKosaricu.Name = "PocetanGumbDodajUKosaricu";
            this.PocetanGumbDodajUKosaricu.Size = new System.Drawing.Size(83, 48);
            this.PocetanGumbDodajUKosaricu.TabIndex = 5;
            this.PocetanGumbDodajUKosaricu.Text = "U Kosaricu";
            this.PocetanGumbDodajUKosaricu.UseVisualStyleBackColor = true;
            this.PocetanGumbDodajUKosaricu.Click += new System.EventHandler(this.PocetanGumbDodajUKosaricu_Click);
            // 
            // korisnikKartaTableAdapter
            // 
            this.korisnikKartaTableAdapter.ClearBeforeFill = true;
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 603);
            this.ControlBox = false;
            this.Controls.Add(this.PocetanGumbDodajUKosaricu);
            this.Controls.Add(this.PocetnaPretragaText);
            this.Controls.Add(this.PocetnaPretragaGumbTrazi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PocetnaLabelSveKarte);
            this.Name = "Pocetna";
            this.Text = "Pocetna";
            this.Load += new System.EventHandler(this.Pocetna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikKartaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PocetnaLabelSveKarte;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button PocetnaPretragaGumbTrazi;
        private System.Windows.Forms.TextBox PocetnaPretragaText;
        private System.Windows.Forms.Button PocetanGumbDodajUKosaricu;
        private Database2DataSet database2DataSet;
        private System.Windows.Forms.BindingSource korisnikKartaBindingSource;
        private Database2DataSetTableAdapters.korisnikKartaTableAdapter korisnikKartaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKorisnikKartaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKorisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKartaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
    }
}