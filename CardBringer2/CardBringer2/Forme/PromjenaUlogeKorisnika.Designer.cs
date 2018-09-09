namespace CardBringer2
{
    partial class PromjenaUlogeKorisnika
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
            this.dgvPromjenaUlogeKorisnikaSviKorisnici = new System.Windows.Forms.DataGridView();
            this.btnPromjenaUlogeKorisnikaDajPrivilegije = new System.Windows.Forms.Button();
            this.btnPromjenaUlogeKorisnikaOduzmiPrivilegije = new System.Windows.Forms.Button();
            this.btnPromjenaUlogeKorisnikaHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromjenaUlogeKorisnikaSviKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPromjenaUlogeKorisnikaSviKorisnici
            // 
            this.dgvPromjenaUlogeKorisnikaSviKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromjenaUlogeKorisnikaSviKorisnici.Location = new System.Drawing.Point(9, 10);
            this.dgvPromjenaUlogeKorisnikaSviKorisnici.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPromjenaUlogeKorisnikaSviKorisnici.Name = "dgvPromjenaUlogeKorisnikaSviKorisnici";
            this.dgvPromjenaUlogeKorisnikaSviKorisnici.RowTemplate.Height = 24;
            this.dgvPromjenaUlogeKorisnikaSviKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPromjenaUlogeKorisnikaSviKorisnici.Size = new System.Drawing.Size(602, 346);
            this.dgvPromjenaUlogeKorisnikaSviKorisnici.TabIndex = 0;
            // 
            // btnPromjenaUlogeKorisnikaDajPrivilegije
            // 
            this.btnPromjenaUlogeKorisnikaDajPrivilegije.Location = new System.Drawing.Point(633, 127);
            this.btnPromjenaUlogeKorisnikaDajPrivilegije.Margin = new System.Windows.Forms.Padding(2);
            this.btnPromjenaUlogeKorisnikaDajPrivilegije.Name = "btnPromjenaUlogeKorisnikaDajPrivilegije";
            this.btnPromjenaUlogeKorisnikaDajPrivilegije.Size = new System.Drawing.Size(127, 58);
            this.btnPromjenaUlogeKorisnikaDajPrivilegije.TabIndex = 1;
            this.btnPromjenaUlogeKorisnikaDajPrivilegije.Text = "Daj administratorske privilegije";
            this.btnPromjenaUlogeKorisnikaDajPrivilegije.UseVisualStyleBackColor = true;
            this.btnPromjenaUlogeKorisnikaDajPrivilegije.Click += new System.EventHandler(this.btnPromjenaUlogeKorisnikaDajPrivilegije_Click);
            // 
            // btnPromjenaUlogeKorisnikaOduzmiPrivilegije
            // 
            this.btnPromjenaUlogeKorisnikaOduzmiPrivilegije.Location = new System.Drawing.Point(633, 190);
            this.btnPromjenaUlogeKorisnikaOduzmiPrivilegije.Margin = new System.Windows.Forms.Padding(2);
            this.btnPromjenaUlogeKorisnikaOduzmiPrivilegije.Name = "btnPromjenaUlogeKorisnikaOduzmiPrivilegije";
            this.btnPromjenaUlogeKorisnikaOduzmiPrivilegije.Size = new System.Drawing.Size(127, 58);
            this.btnPromjenaUlogeKorisnikaOduzmiPrivilegije.TabIndex = 1;
            this.btnPromjenaUlogeKorisnikaOduzmiPrivilegije.Text = "Makni administratorske privilegije";
            this.btnPromjenaUlogeKorisnikaOduzmiPrivilegije.UseVisualStyleBackColor = true;
            this.btnPromjenaUlogeKorisnikaOduzmiPrivilegije.Click += new System.EventHandler(this.btnPromjenaUlogeKorisnikaOduzmiPrivilegije_Click);
            // 
            // btnPromjenaUlogeKorisnikaHelp
            // 
            this.btnPromjenaUlogeKorisnikaHelp.Location = new System.Drawing.Point(751, 12);
            this.btnPromjenaUlogeKorisnikaHelp.Name = "btnPromjenaUlogeKorisnikaHelp";
            this.btnPromjenaUlogeKorisnikaHelp.Size = new System.Drawing.Size(75, 23);
            this.btnPromjenaUlogeKorisnikaHelp.TabIndex = 2;
            this.btnPromjenaUlogeKorisnikaHelp.Text = "Help";
            this.btnPromjenaUlogeKorisnikaHelp.UseVisualStyleBackColor = true;
            this.btnPromjenaUlogeKorisnikaHelp.Click += new System.EventHandler(this.btnPromjenaUlogeKorisnikaHelp_Click);
            // 
            // PromjenaUlogeKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(838, 366);
            this.Controls.Add(this.btnPromjenaUlogeKorisnikaHelp);
            this.Controls.Add(this.btnPromjenaUlogeKorisnikaOduzmiPrivilegije);
            this.Controls.Add(this.btnPromjenaUlogeKorisnikaDajPrivilegije);
            this.Controls.Add(this.dgvPromjenaUlogeKorisnikaSviKorisnici);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PromjenaUlogeKorisnika";
            this.Text = "PromjenaUlogeKorisnika";
            this.Load += new System.EventHandler(this.PromjenaUlogeKorisnika_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PromjenaUlogeKorisnika_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromjenaUlogeKorisnikaSviKorisnici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPromjenaUlogeKorisnikaSviKorisnici;
        private System.Windows.Forms.Button btnPromjenaUlogeKorisnikaDajPrivilegije;
        private System.Windows.Forms.Button btnPromjenaUlogeKorisnikaOduzmiPrivilegije;
        private System.Windows.Forms.Button btnPromjenaUlogeKorisnikaHelp;
    }
}