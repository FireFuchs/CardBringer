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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlikaKarte)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(16, 108);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(595, 442);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Izaberite kartu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(137, 558);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unesite cijenu karte:";
            // 
            // unosCijeneKarteObjaviOglas
            // 
            this.unosCijeneKarteObjaviOglas.Location = new System.Drawing.Point(281, 558);
            this.unosCijeneKarteObjaviOglas.Margin = new System.Windows.Forms.Padding(4);
            this.unosCijeneKarteObjaviOglas.Name = "unosCijeneKarteObjaviOglas";
            this.unosCijeneKarteObjaviOglas.Size = new System.Drawing.Size(159, 22);
            this.unosCijeneKarteObjaviOglas.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(118, 605);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unesite količinu karata:";
            // 
            // unosKolicineKarteObjaviOglas
            // 
            this.unosKolicineKarteObjaviOglas.Location = new System.Drawing.Point(281, 605);
            this.unosKolicineKarteObjaviOglas.Margin = new System.Windows.Forms.Padding(4);
            this.unosKolicineKarteObjaviOglas.Name = "unosKolicineKarteObjaviOglas";
            this.unosKolicineKarteObjaviOglas.Size = new System.Drawing.Size(159, 22);
            this.unosKolicineKarteObjaviOglas.TabIndex = 2;
            // 
            // buttonObjaviOglas
            // 
            this.buttonObjaviOglas.ForeColor = System.Drawing.Color.Black;
            this.buttonObjaviOglas.Location = new System.Drawing.Point(451, 558);
            this.buttonObjaviOglas.Margin = new System.Windows.Forms.Padding(4);
            this.buttonObjaviOglas.Name = "buttonObjaviOglas";
            this.buttonObjaviOglas.Size = new System.Drawing.Size(160, 69);
            this.buttonObjaviOglas.TabIndex = 3;
            this.buttonObjaviOglas.Text = "Objavi Oglas";
            this.buttonObjaviOglas.UseVisualStyleBackColor = true;
            this.buttonObjaviOglas.Click += new System.EventHandler(this.buttonObjaviOglas_Click);
            // 
            // pictureBoxSlikaKarte
            // 
            this.pictureBoxSlikaKarte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSlikaKarte.Location = new System.Drawing.Point(645, 108);
            this.pictureBoxSlikaKarte.Name = "pictureBoxSlikaKarte";
            this.pictureBoxSlikaKarte.Size = new System.Drawing.Size(355, 431);
            this.pictureBoxSlikaKarte.TabIndex = 6;
            this.pictureBoxSlikaKarte.TabStop = false;
            // 
            // OpisKarte
            // 
            this.OpisKarte.Location = new System.Drawing.Point(645, 571);
            this.OpisKarte.Name = "OpisKarte";
            this.OpisKarte.Size = new System.Drawing.Size(355, 99);
            this.OpisKarte.TabIndex = 7;
            this.OpisKarte.Text = "";
            // 
            // ImeKarte
            // 
            this.ImeKarte.AutoSize = true;
            this.ImeKarte.ForeColor = System.Drawing.Color.White;
            this.ImeKarte.Location = new System.Drawing.Point(642, 545);
            this.ImeKarte.Name = "ImeKarte";
            this.ImeKarte.Size = new System.Drawing.Size(79, 17);
            this.ImeKarte.TabIndex = 8;
            this.ImeKarte.Text = "Naziv karte";
            // 
            // ObjaviOglas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1668, 742);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ObjaviOglas";
            this.Text = "ObjaviOglas";
            this.Load += new System.EventHandler(this.ObjaviOglas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}