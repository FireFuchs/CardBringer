namespace CardBringer2
{
    partial class HelpForm
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
            this.izlazHelpTextHelpForm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // izlazHelpTextHelpForm
            // 
            this.izlazHelpTextHelpForm.Location = new System.Drawing.Point(1, 0);
            this.izlazHelpTextHelpForm.Multiline = true;
            this.izlazHelpTextHelpForm.Name = "izlazHelpTextHelpForm";
            this.izlazHelpTextHelpForm.ReadOnly = true;
            this.izlazHelpTextHelpForm.Size = new System.Drawing.Size(285, 263);
            this.izlazHelpTextHelpForm.TabIndex = 0;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.izlazHelpTextHelpForm);
            this.Name = "HelpForm";
            this.Text = "HelpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox izlazHelpTextHelpForm;
    }
}