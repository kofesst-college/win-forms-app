using System.ComponentModel;

namespace WinFormsApp1.Pages
{
    partial class DatesPage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDifference = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dpSecond = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panelA = new System.Windows.Forms.Panel();
            this.dpFirst = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelDifference);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panelA);
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(882, 693);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Difference between dates";
            // 
            // labelDifference
            // 
            this.labelDifference.AutoSize = true;
            this.labelDifference.Location = new System.Drawing.Point(220, 371);
            this.labelDifference.Name = "labelDifference";
            this.labelDifference.Size = new System.Drawing.Size(0, 25);
            this.labelDifference.TabIndex = 16;
            this.labelDifference.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.dpSecond);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(220, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 74);
            this.panel1.TabIndex = 15;
            // 
            // dpSecond
            // 
            this.dpSecond.Location = new System.Drawing.Point(0, 44);
            this.dpSecond.Name = "dpSecond";
            this.dpSecond.Size = new System.Drawing.Size(238, 30);
            this.dpSecond.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Second date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panelA
            // 
            this.panelA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelA.Controls.Add(this.dpFirst);
            this.panelA.Controls.Add(this.label3);
            this.panelA.Location = new System.Drawing.Point(220, 82);
            this.panelA.Name = "panelA";
            this.panelA.Size = new System.Drawing.Size(238, 74);
            this.panelA.TabIndex = 13;
            // 
            // dpFirst
            // 
            this.dpFirst.Location = new System.Drawing.Point(0, 44);
            this.dpFirst.Name = "dpFirst";
            this.dpFirst.Size = new System.Drawing.Size(238, 30);
            this.dpFirst.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "First date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCalculate.Location = new System.Drawing.Point(220, 302);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(238, 41);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // DatesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(882, 693);
            this.Name = "DatesPage";
            this.Size = new System.Drawing.Size(882, 693);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelA.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label labelDifference;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dpSecond;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel panelA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dpFirst;

        private System.Windows.Forms.Button btnCalculate;

        private System.Windows.Forms.GroupBox groupBox1;

        #endregion
    }
}