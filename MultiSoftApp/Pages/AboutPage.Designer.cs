using System.ComponentModel;

namespace MultiSoftApp.Pages
{
    partial class AboutPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.priceTextBox21 = new MultiSoftApp.Controls.PriceTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 393);
            this.label1.TabIndex = 0;
            this.label1.Text = "About program\r\n\r\nThis program contains navigation controller and three simple pag" + "es: Home, Calculator and About.";
            // 
            // priceTextBox21
            // 
            this.priceTextBox21.Location = new System.Drawing.Point(3, 187);
            this.priceTextBox21.Name = "priceTextBox21";
            this.priceTextBox21.Size = new System.Drawing.Size(200, 50);
            this.priceTextBox21.TabIndex = 1;
            this.priceTextBox21.Text = "00";
            this.priceTextBox21.Value = 0D;
            this.priceTextBox21.Visible = true;
            // 
            // AboutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.priceTextBox21);
            this.Controls.Add(this.label1);
            this.Name = "AboutPage";
            this.Size = new System.Drawing.Size(540, 393);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private MultiSoftApp.Controls.PriceTextBox priceTextBox21;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}