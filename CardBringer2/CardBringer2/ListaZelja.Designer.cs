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
            this.ListaZeljaGumbMakni = new System.Windows.Forms.Button();
            this.ListaZeljaButtonTrazi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ListaZeljaTrazi = new System.Windows.Forms.TextBox();
            this.SveKarteDatagrid = new System.Windows.Forms.DataGridView();
            this.ListaZeljaDataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SveKarteDatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaZeljaDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaZeljaGumbMakni
            // 
            this.ListaZeljaGumbMakni.Location = new System.Drawing.Point(583, 327);
            this.ListaZeljaGumbMakni.Name = "ListaZeljaGumbMakni";
            this.ListaZeljaGumbMakni.Size = new System.Drawing.Size(75, 23);
            this.ListaZeljaGumbMakni.TabIndex = 14;
            this.ListaZeljaGumbMakni.Text = "---> Makni";
            this.ListaZeljaGumbMakni.UseVisualStyleBackColor = true;
            // 
            // ListaZeljaButtonTrazi
            // 
            this.ListaZeljaButtonTrazi.Location = new System.Drawing.Point(1130, 73);
            this.ListaZeljaButtonTrazi.Name = "ListaZeljaButtonTrazi";
            this.ListaZeljaButtonTrazi.Size = new System.Drawing.Size(75, 23);
            this.ListaZeljaButtonTrazi.TabIndex = 13;
            this.ListaZeljaButtonTrazi.Text = "Trazi!";
            this.ListaZeljaButtonTrazi.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "<--- Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ListaZeljaTrazi
            // 
            this.ListaZeljaTrazi.Location = new System.Drawing.Point(953, 75);
            this.ListaZeljaTrazi.Name = "ListaZeljaTrazi";
            this.ListaZeljaTrazi.Size = new System.Drawing.Size(161, 20);
            this.ListaZeljaTrazi.TabIndex = 11;
            // 
            // SveKarteDatagrid
            // 
            this.SveKarteDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SveKarteDatagrid.Location = new System.Drawing.Point(725, 104);
            this.SveKarteDatagrid.Name = "SveKarteDatagrid";
            this.SveKarteDatagrid.Size = new System.Drawing.Size(485, 453);
            this.SveKarteDatagrid.TabIndex = 9;
            // 
            // ListaZeljaDataGrid
            // 
            this.ListaZeljaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaZeljaDataGrid.Location = new System.Drawing.Point(33, 104);
            this.ListaZeljaDataGrid.Name = "ListaZeljaDataGrid";
            this.ListaZeljaDataGrid.Size = new System.Drawing.Size(485, 453);
            this.ListaZeljaDataGrid.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(722, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sve Karte:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Karte na listi Zelja:";
            // 
            // ListaZelja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1251, 603);
            this.Controls.Add(this.ListaZeljaGumbMakni);
            this.Controls.Add(this.ListaZeljaButtonTrazi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListaZeljaTrazi);
            this.Controls.Add(this.SveKarteDatagrid);
            this.Controls.Add(this.ListaZeljaDataGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ListaZelja";
            this.Text = "ListaZelja";
            this.Load += new System.EventHandler(this.ListaZelja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SveKarteDatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaZeljaDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ListaZeljaGumbMakni;
        private System.Windows.Forms.Button ListaZeljaButtonTrazi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ListaZeljaTrazi;
        private System.Windows.Forms.DataGridView SveKarteDatagrid;
        private System.Windows.Forms.DataGridView ListaZeljaDataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}