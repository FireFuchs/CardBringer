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
            this.PocetanGumbDodajUKosaricu = new System.Windows.Forms.Button();
            this.PocetnaPretragaText = new System.Windows.Forms.TextBox();
            this.PocetnaPretragaGumbTrazi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PocetnaLabelSveKarte = new System.Windows.Forms.Label();
            this.PocetnaResetGumb = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSlikaKarte = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.opisKarte = new System.Windows.Forms.RichTextBox();
            this.cijenaKarte = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prodavacKarte = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.imeKarte = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kolicinaKarata = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlikaKarte)).BeginInit();
            this.SuspendLayout();
            // 
            // PocetanGumbDodajUKosaricu
            // 
            this.PocetanGumbDodajUKosaricu.Location = new System.Drawing.Point(903, 124);
            this.PocetanGumbDodajUKosaricu.Margin = new System.Windows.Forms.Padding(4);
            this.PocetanGumbDodajUKosaricu.Name = "PocetanGumbDodajUKosaricu";
            this.PocetanGumbDodajUKosaricu.Size = new System.Drawing.Size(111, 59);
            this.PocetanGumbDodajUKosaricu.TabIndex = 15;
            this.PocetanGumbDodajUKosaricu.Text = "U Kosaricu";
            this.PocetanGumbDodajUKosaricu.UseVisualStyleBackColor = true;
            this.PocetanGumbDodajUKosaricu.Click += new System.EventHandler(this.PocetanGumbDodajUKosaricu_Click);
            // 
            // PocetnaPretragaText
            // 
            this.PocetnaPretragaText.Location = new System.Drawing.Point(520, 75);
            this.PocetnaPretragaText.Margin = new System.Windows.Forms.Padding(4);
            this.PocetnaPretragaText.Name = "PocetnaPretragaText";
            this.PocetnaPretragaText.Size = new System.Drawing.Size(223, 22);
            this.PocetnaPretragaText.TabIndex = 14;
            this.PocetnaPretragaText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PocetnaPretragaText_KeyDown);
            // 
            // PocetnaPretragaGumbTrazi
            // 
            this.PocetnaPretragaGumbTrazi.Location = new System.Drawing.Point(752, 73);
            this.PocetnaPretragaGumbTrazi.Margin = new System.Windows.Forms.Padding(4);
            this.PocetnaPretragaGumbTrazi.Name = "PocetnaPretragaGumbTrazi";
            this.PocetnaPretragaGumbTrazi.Size = new System.Drawing.Size(64, 28);
            this.PocetnaPretragaGumbTrazi.TabIndex = 13;
            this.PocetnaPretragaGumbTrazi.Text = "Trazi!";
            this.PocetnaPretragaGumbTrazi.UseVisualStyleBackColor = true;
            this.PocetnaPretragaGumbTrazi.Click += new System.EventHandler(this.PocetnaPretragaGumbTrazi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.CausesValidation = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 105);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(879, 593);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // PocetnaLabelSveKarte
            // 
            this.PocetnaLabelSveKarte.AutoSize = true;
            this.PocetnaLabelSveKarte.ForeColor = System.Drawing.Color.White;
            this.PocetnaLabelSveKarte.Location = new System.Drawing.Point(12, 73);
            this.PocetnaLabelSveKarte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PocetnaLabelSveKarte.Name = "PocetnaLabelSveKarte";
            this.PocetnaLabelSveKarte.Size = new System.Drawing.Size(74, 17);
            this.PocetnaLabelSveKarte.TabIndex = 11;
            this.PocetnaLabelSveKarte.Text = "Sve Karte:";
            // 
            // PocetnaResetGumb
            // 
            this.PocetnaResetGumb.Location = new System.Drawing.Point(824, 73);
            this.PocetnaResetGumb.Margin = new System.Windows.Forms.Padding(4);
            this.PocetnaResetGumb.Name = "PocetnaResetGumb";
            this.PocetnaResetGumb.Size = new System.Drawing.Size(71, 28);
            this.PocetnaResetGumb.TabIndex = 16;
            this.PocetnaResetGumb.Text = "Reset";
            this.PocetnaResetGumb.UseVisualStyleBackColor = true;
            this.PocetnaResetGumb.Click += new System.EventHandler(this.PocetnaResetGumb_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 62);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxSlikaKarte
            // 
            this.pictureBoxSlikaKarte.Location = new System.Drawing.Point(1221, 28);
            this.pictureBoxSlikaKarte.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxSlikaKarte.Name = "pictureBoxSlikaKarte";
            this.pictureBoxSlikaKarte.Size = new System.Drawing.Size(289, 350);
            this.pictureBoxSlikaKarte.TabIndex = 18;
            this.pictureBoxSlikaKarte.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1236, 557);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cijena:";
            // 
            // opisKarte
            // 
            this.opisKarte.Location = new System.Drawing.Point(1221, 386);
            this.opisKarte.Margin = new System.Windows.Forms.Padding(4);
            this.opisKarte.Name = "opisKarte";
            this.opisKarte.Size = new System.Drawing.Size(288, 147);
            this.opisKarte.TabIndex = 20;
            this.opisKarte.Text = "";
            // 
            // cijenaKarte
            // 
            this.cijenaKarte.AutoSize = true;
            this.cijenaKarte.ForeColor = System.Drawing.Color.White;
            this.cijenaKarte.Location = new System.Drawing.Point(1297, 557);
            this.cijenaKarte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cijenaKarte.Name = "cijenaKarte";
            this.cijenaKarte.Size = new System.Drawing.Size(46, 17);
            this.cijenaKarte.TabIndex = 19;
            this.cijenaKarte.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1217, 601);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Prodavač:";
            // 
            // prodavacKarte
            // 
            this.prodavacKarte.AutoSize = true;
            this.prodavacKarte.ForeColor = System.Drawing.Color.White;
            this.prodavacKarte.Location = new System.Drawing.Point(1297, 601);
            this.prodavacKarte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prodavacKarte.Name = "prodavacKarte";
            this.prodavacKarte.Size = new System.Drawing.Size(46, 17);
            this.prodavacKarte.TabIndex = 19;
            this.prodavacKarte.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(953, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imeKarte
            // 
            this.imeKarte.AutoSize = true;
            this.imeKarte.ForeColor = System.Drawing.Color.White;
            this.imeKarte.Location = new System.Drawing.Point(1297, 632);
            this.imeKarte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imeKarte.Name = "imeKarte";
            this.imeKarte.Size = new System.Drawing.Size(46, 17);
            this.imeKarte.TabIndex = 19;
            this.imeKarte.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1217, 632);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ime karte:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1236, 578);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Količina:";
            // 
            // kolicinaKarata
            // 
            this.kolicinaKarata.AutoSize = true;
            this.kolicinaKarata.ForeColor = System.Drawing.Color.White;
            this.kolicinaKarata.Location = new System.Drawing.Point(1297, 578);
            this.kolicinaKarata.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kolicinaKarata.Name = "kolicinaKarata";
            this.kolicinaKarata.Size = new System.Drawing.Size(46, 17);
            this.kolicinaKarata.TabIndex = 19;
            this.kolicinaKarata.Text = "label1";
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1668, 742);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.opisKarte);
            this.Controls.Add(this.imeKarte);
            this.Controls.Add(this.prodavacKarte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kolicinaKarata);
            this.Controls.Add(this.cijenaKarte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxSlikaKarte);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PocetnaResetGumb);
            this.Controls.Add(this.PocetanGumbDodajUKosaricu);
            this.Controls.Add(this.PocetnaPretragaText);
            this.Controls.Add(this.PocetnaPretragaGumbTrazi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PocetnaLabelSveKarte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Pocetna";
            this.Text = "Pocetna";
            this.Load += new System.EventHandler(this.Pocetna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlikaKarte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PocetanGumbDodajUKosaricu;
        private System.Windows.Forms.TextBox PocetnaPretragaText;
        private System.Windows.Forms.Button PocetnaPretragaGumbTrazi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label PocetnaLabelSveKarte;
        private System.Windows.Forms.Button PocetnaResetGumb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxSlikaKarte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox opisKarte;
        private System.Windows.Forms.Label cijenaKarte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label prodavacKarte;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label imeKarte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label kolicinaKarata;
    }
}