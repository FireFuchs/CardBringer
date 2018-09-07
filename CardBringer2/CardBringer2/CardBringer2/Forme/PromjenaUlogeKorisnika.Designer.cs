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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDodajAdmina = new System.Windows.Forms.Button();
            this.buttonMakniAdmina = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(602, 346);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonDodajAdmina
            // 
            this.buttonDodajAdmina.Location = new System.Drawing.Point(633, 127);
            this.buttonDodajAdmina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDodajAdmina.Name = "buttonDodajAdmina";
            this.buttonDodajAdmina.Size = new System.Drawing.Size(127, 58);
            this.buttonDodajAdmina.TabIndex = 1;
            this.buttonDodajAdmina.Text = "Daj administratorske privilegije";
            this.buttonDodajAdmina.UseVisualStyleBackColor = true;
            this.buttonDodajAdmina.Click += new System.EventHandler(this.buttonDodajAdmina_Click);
            // 
            // buttonMakniAdmina
            // 
            this.buttonMakniAdmina.Location = new System.Drawing.Point(633, 190);
            this.buttonMakniAdmina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMakniAdmina.Name = "buttonMakniAdmina";
            this.buttonMakniAdmina.Size = new System.Drawing.Size(127, 58);
            this.buttonMakniAdmina.TabIndex = 1;
            this.buttonMakniAdmina.Text = "Makni administratorske privilegije";
            this.buttonMakniAdmina.UseVisualStyleBackColor = true;
            this.buttonMakniAdmina.Click += new System.EventHandler(this.buttonMakniAdmina_Click);
            // 
            // PromjenaUlogeKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(838, 366);
            this.Controls.Add(this.buttonMakniAdmina);
            this.Controls.Add(this.buttonDodajAdmina);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PromjenaUlogeKorisnika";
            this.Text = "PromjenaUlogeKorisnika";
            this.Load += new System.EventHandler(this.PromjenaUlogeKorisnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDodajAdmina;
        private System.Windows.Forms.Button buttonMakniAdmina;
    }
}