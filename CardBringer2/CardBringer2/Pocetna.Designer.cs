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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OpisKarte = new System.Windows.Forms.RichTextBox();
            this.CijenaKarte = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProdavacKarte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PocetanGumbDodajUKosaricu
            // 
            this.PocetanGumbDodajUKosaricu.Location = new System.Drawing.Point(903, 124);
            this.PocetanGumbDodajUKosaricu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.PocetnaPretragaText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PocetnaPretragaText.Name = "PocetnaPretragaText";
            this.PocetnaPretragaText.Size = new System.Drawing.Size(223, 22);
            this.PocetnaPretragaText.TabIndex = 14;
            this.PocetnaPretragaText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PocetnaPretragaText_KeyDown);
            // 
            // PocetnaPretragaGumbTrazi
            // 
            this.PocetnaPretragaGumbTrazi.Location = new System.Drawing.Point(752, 73);
            this.PocetnaPretragaGumbTrazi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.PocetnaResetGumb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 62);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1221, 28);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(289, 350);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1217, 582);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cijena:";
            // 
            // OpisKarte
            // 
            this.OpisKarte.Location = new System.Drawing.Point(1221, 412);
            this.OpisKarte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OpisKarte.Name = "OpisKarte";
            this.OpisKarte.Size = new System.Drawing.Size(288, 147);
            this.OpisKarte.TabIndex = 20;
            this.OpisKarte.Text = "";
            // 
            // CijenaKarte
            // 
            this.CijenaKarte.AutoSize = true;
            this.CijenaKarte.Location = new System.Drawing.Point(1295, 582);
            this.CijenaKarte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CijenaKarte.Name = "CijenaKarte";
            this.CijenaKarte.Size = new System.Drawing.Size(46, 17);
            this.CijenaKarte.TabIndex = 19;
            this.CijenaKarte.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1217, 619);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Prodavač:";
            // 
            // ProdavacKarte
            // 
            this.ProdavacKarte.AutoSize = true;
            this.ProdavacKarte.Location = new System.Drawing.Point(1295, 619);
            this.ProdavacKarte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProdavacKarte.Name = "ProdavacKarte";
            this.ProdavacKarte.Size = new System.Drawing.Size(46, 17);
            this.ProdavacKarte.TabIndex = 19;
            this.ProdavacKarte.Text = "label1";
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1668, 742);
            this.Controls.Add(this.OpisKarte);
            this.Controls.Add(this.ProdavacKarte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CijenaKarte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PocetnaResetGumb);
            this.Controls.Add(this.PocetanGumbDodajUKosaricu);
            this.Controls.Add(this.PocetnaPretragaText);
            this.Controls.Add(this.PocetnaPretragaGumbTrazi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PocetnaLabelSveKarte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Pocetna";
            this.Text = "Pocetna";
            this.Load += new System.EventHandler(this.Pocetna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox OpisKarte;
        private System.Windows.Forms.Label CijenaKarte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ProdavacKarte;
    }
}