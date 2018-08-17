namespace CardBringer2
{
    partial class MojeKupnje
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
            this.DataGridZaKupljene = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridZaKupljene)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridZaKupljene
            // 
            this.DataGridZaKupljene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridZaKupljene.Location = new System.Drawing.Point(61, 84);
            this.DataGridZaKupljene.Name = "DataGridZaKupljene";
            this.DataGridZaKupljene.Size = new System.Drawing.Size(708, 382);
            this.DataGridZaKupljene.TabIndex = 0;
            // 
            // MojeKupnje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1251, 603);
            this.Controls.Add(this.DataGridZaKupljene);
            this.Name = "MojeKupnje";
            this.Text = "MojeKupnje";
            this.Load += new System.EventHandler(this.MojeKupnje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridZaKupljene)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridZaKupljene;
    }
}