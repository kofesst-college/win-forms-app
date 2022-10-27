using System.ComponentModel;

namespace WinFormsApp1.Pages
{
    partial class ReadOrderPage
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelOrder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.button1.Location = new System.Drawing.Point(0, 638);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(882, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Read order file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelOrder
            // 
            this.labelOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.labelOrder.Location = new System.Drawing.Point(0, 0);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(882, 638);
            this.labelOrder.TabIndex = 1;
            // 
            // ReadOrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.button1);
            this.MinimumSize = new System.Drawing.Size(882, 693);
            this.Name = "ReadOrderPage";
            this.Size = new System.Drawing.Size(882, 693);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label labelOrder;

        private System.Windows.Forms.Button button1;

        #endregion
    }
}