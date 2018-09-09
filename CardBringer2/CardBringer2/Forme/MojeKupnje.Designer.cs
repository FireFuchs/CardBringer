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
            this.dgvMojeKupnjeDatagrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMojeKupnjeDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMojeKupnjeDatagrid
            // 
            this.dgvMojeKupnjeDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMojeKupnjeDatagrid.Location = new System.Drawing.Point(61, 84);
            this.dgvMojeKupnjeDatagrid.Name = "dgvMojeKupnjeDatagrid";
            this.dgvMojeKupnjeDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMojeKupnjeDatagrid.Size = new System.Drawing.Size(708, 382);
            this.dgvMojeKupnjeDatagrid.TabIndex = 0;
            // 
            // MojeKupnje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1203, 603);
            this.Controls.Add(this.dgvMojeKupnjeDatagrid);
            this.Name = "MojeKupnje";
            this.Text = "MojeKupnje";
            this.Load += new System.EventHandler(this.MojeKupnje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMojeKupnjeDatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMojeKupnjeDatagrid;
    }
}