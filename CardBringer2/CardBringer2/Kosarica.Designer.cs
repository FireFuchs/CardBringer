namespace CardBringer2
{
    partial class Kosarica
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.medjuspremnikKosaricaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database2DataSet = new CardBringer2.Database2DataSet();
            this.KosaricaLabelCijenaUnchanged = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.medjuspremnikKosaricaTableAdapter = new CardBringer2.Database2DataSetTableAdapters.medjuspremnikKosaricaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medjuspremnikKosaricaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Karte u košarici:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.CausesValidation = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.medjuspremnikKosaricaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(573, 447);
            this.dataGridView1.TabIndex = 1;
            // 
            // medjuspremnikKosaricaBindingSource
            // 
            this.medjuspremnikKosaricaBindingSource.DataMember = "medjuspremnikKosarica";
            this.medjuspremnikKosaricaBindingSource.DataSource = this.database2DataSet;
            // 
            // database2DataSet
            // 
            this.database2DataSet.DataSetName = "Database2DataSet";
            this.database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KosaricaLabelCijenaUnchanged
            // 
            this.KosaricaLabelCijenaUnchanged.AutoSize = true;
            this.KosaricaLabelCijenaUnchanged.Location = new System.Drawing.Point(622, 113);
            this.KosaricaLabelCijenaUnchanged.Name = "KosaricaLabelCijenaUnchanged";
            this.KosaricaLabelCijenaUnchanged.Size = new System.Drawing.Size(80, 13);
            this.KosaricaLabelCijenaUnchanged.TabIndex = 2;
            this.KosaricaLabelCijenaUnchanged.Text = "Ukupna Cijena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(729, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(640, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Broj Karata:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(729, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "-";
            // 
            // medjuspremnikKosaricaTableAdapter
            // 
            this.medjuspremnikKosaricaTableAdapter.ClearBeforeFill = true;
            // 
            // Kosarica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 534);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KosaricaLabelCijenaUnchanged);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Kosarica";
            this.Text = "Kosarica";
            this.Load += new System.EventHandler(this.Kosarica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medjuspremnikKosaricaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label KosaricaLabelCijenaUnchanged;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Database2DataSet database2DataSet;
        private System.Windows.Forms.BindingSource medjuspremnikKosaricaBindingSource;
        private Database2DataSetTableAdapters.medjuspremnikKosaricaTableAdapter medjuspremnikKosaricaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}