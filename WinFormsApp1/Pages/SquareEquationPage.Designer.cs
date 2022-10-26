using System.ComponentModel;

namespace WinFormsApp1.Pages
{
    partial class SquareEquationPage
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
            this.squadEquationGroup = new System.Windows.Forms.GroupBox();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.panelA = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.panelB = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbB = new System.Windows.Forms.TextBox();
            this.panelC = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.squadEquationGroup.SuspendLayout();
            this.panelA.SuspendLayout();
            this.panelB.SuspendLayout();
            this.panelC.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // squadEquationGroup
            // 
            this.squadEquationGroup.Controls.Add(this.labelAnswer);
            this.squadEquationGroup.Controls.Add(this.panelA);
            this.squadEquationGroup.Controls.Add(this.panelB);
            this.squadEquationGroup.Controls.Add(this.panelC);
            this.squadEquationGroup.Controls.Add(this.label4);
            this.squadEquationGroup.Controls.Add(this.btnCalculate);
            this.squadEquationGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.squadEquationGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.squadEquationGroup.Location = new System.Drawing.Point(10, 10);
            this.squadEquationGroup.Margin = new System.Windows.Forms.Padding(10);
            this.squadEquationGroup.Name = "squadEquationGroup";
            this.squadEquationGroup.Size = new System.Drawing.Size(862, 673);
            this.squadEquationGroup.TabIndex = 0;
            this.squadEquationGroup.TabStop = false;
            this.squadEquationGroup.Text = "Squad equation";
            // 
            // labelAnswer
            // 
            this.labelAnswer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelAnswer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelAnswer.Location = new System.Drawing.Point(3, 455);
            this.labelAnswer.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.labelAnswer.Size = new System.Drawing.Size(856, 215);
            this.labelAnswer.TabIndex = 13;
            this.labelAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelA
            // 
            this.panelA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelA.Controls.Add(this.label1);
            this.panelA.Controls.Add(this.tbA);
            this.panelA.Location = new System.Drawing.Point(323, 93);
            this.panelA.Name = "panelA";
            this.panelA.Size = new System.Drawing.Size(212, 74);
            this.panelA.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "a coefficient";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(0, 40);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(212, 34);
            this.tbA.TabIndex = 0;
            // 
            // panelB
            // 
            this.panelB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelB.Controls.Add(this.label3);
            this.panelB.Controls.Add(this.tbB);
            this.panelB.Location = new System.Drawing.Point(323, 185);
            this.panelB.Name = "panelB";
            this.panelB.Size = new System.Drawing.Size(212, 74);
            this.panelB.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "b coefficient";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(0, 40);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(212, 34);
            this.tbB.TabIndex = 1;
            // 
            // panelC
            // 
            this.panelC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelC.Controls.Add(this.label2);
            this.panelC.Controls.Add(this.tbC);
            this.panelC.Location = new System.Drawing.Point(323, 274);
            this.panelC.Name = "panelC";
            this.panelC.Size = new System.Drawing.Size(212, 74);
            this.panelC.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "c coefficient";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(0, 40);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(212, 34);
            this.tbC.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label4.Location = new System.Drawing.Point(3, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(856, 60);
            this.label4.TabIndex = 8;
            this.label4.Text = "ax² + bx + c = 0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCalculate.Location = new System.Drawing.Point(323, 390);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(212, 47);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.squadEquationGroup, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(882, 693);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(882, 693);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // SquareEquationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Location = new System.Drawing.Point(15, 15);
            this.MinimumSize = new System.Drawing.Size(882, 693);
            this.Name = "SquareEquationPage";
            this.Size = new System.Drawing.Size(882, 693);
            this.squadEquationGroup.ResumeLayout(false);
            this.panelA.ResumeLayout(false);
            this.panelA.PerformLayout();
            this.panelB.ResumeLayout(false);
            this.panelB.PerformLayout();
            this.panelC.ResumeLayout(false);
            this.panelC.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label labelAnswer;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbA;

        private System.Windows.Forms.Panel panelC;

        private System.Windows.Forms.Panel panelA;
        private System.Windows.Forms.Panel panelB;
        private System.Windows.Forms.TextBox tbC;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculate;

        private System.Windows.Forms.GroupBox squadEquationGroup;

        #endregion
    }
}