﻿namespace CardBringer2
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(12, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(646, 359);
            this.dataGridView1.TabIndex = 5;
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
            this.label1.Location = new System.Drawing.Point(302, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unesite cijenu karte:";
            // 
            // unosCijeneKarteObjaviOglas
            // 
            this.unosCijeneKarteObjaviOglas.Location = new System.Drawing.Point(410, 462);
            this.unosCijeneKarteObjaviOglas.Name = "unosCijeneKarteObjaviOglas";
            this.unosCijeneKarteObjaviOglas.Size = new System.Drawing.Size(120, 20);
            this.unosCijeneKarteObjaviOglas.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(288, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unesite količinu karata:";
            // 
            // unosKolicineKarteObjaviOglas
            // 
            this.unosKolicineKarteObjaviOglas.Location = new System.Drawing.Point(410, 500);
            this.unosKolicineKarteObjaviOglas.Name = "unosKolicineKarteObjaviOglas";
            this.unosKolicineKarteObjaviOglas.Size = new System.Drawing.Size(120, 20);
            this.unosKolicineKarteObjaviOglas.TabIndex = 2;
            // 
            // buttonObjaviOglas
            // 
            this.buttonObjaviOglas.ForeColor = System.Drawing.Color.Black;
            this.buttonObjaviOglas.Location = new System.Drawing.Point(538, 462);
            this.buttonObjaviOglas.Name = "buttonObjaviOglas";
            this.buttonObjaviOglas.Size = new System.Drawing.Size(120, 56);
            this.buttonObjaviOglas.TabIndex = 3;
            this.buttonObjaviOglas.Text = "Objavi Oglas";
            this.buttonObjaviOglas.UseVisualStyleBackColor = true;
            this.buttonObjaviOglas.Click += new System.EventHandler(this.buttonObjaviOglas_Click);
            // 
            // ObjaviOglas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1251, 603);
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
    }
}