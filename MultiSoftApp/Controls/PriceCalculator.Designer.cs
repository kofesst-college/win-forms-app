using System.ComponentModel;

namespace MultiSoftApp.Controls
{
    partial class PriceCalculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonFraction = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.buttonSubtraction = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonNegative = new System.Windows.Forms.Button();
            this.buttonAddition = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button00 = new System.Windows.Forms.Button();
            this.priceTextBox21 = new MultiSoftApp.Controls.PriceTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.buttonOK, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonEquals, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonDiv, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonDot, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonDelete, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonFraction, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonMultiplication, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonPercent, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonSubtraction, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonC, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonNegative, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonAddition, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button0, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button00, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.priceTextBox21, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(234, 211);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonOK
            // 
            this.buttonOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOK.ForeColor = System.Drawing.Color.Red;
            this.buttonOK.Location = new System.Drawing.Point(192, 170);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(40, 39);
            this.buttonOK.TabIndex = 24;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEquals.ForeColor = System.Drawing.Color.Red;
            this.buttonEquals.Location = new System.Drawing.Point(154, 170);
            this.buttonEquals.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(34, 39);
            this.buttonEquals.TabIndex = 23;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            // 
            // buttonDiv
            // 
            this.buttonDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDiv.ForeColor = System.Drawing.Color.Salmon;
            this.buttonDiv.Location = new System.Drawing.Point(116, 170);
            this.buttonDiv.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(34, 39);
            this.buttonDiv.TabIndex = 22;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            // 
            // buttonDot
            // 
            this.buttonDot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDot.Location = new System.Drawing.Point(78, 170);
            this.buttonDot.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(34, 39);
            this.buttonDot.TabIndex = 21;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDelete.Location = new System.Drawing.Point(192, 128);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(40, 38);
            this.buttonDelete.TabIndex = 20;
            this.buttonDelete.Text = "←";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonFraction
            // 
            this.buttonFraction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFraction.Location = new System.Drawing.Point(154, 128);
            this.buttonFraction.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFraction.Name = "buttonFraction";
            this.buttonFraction.Size = new System.Drawing.Size(34, 38);
            this.buttonFraction.TabIndex = 19;
            this.buttonFraction.Text = "1/x";
            this.buttonFraction.UseVisualStyleBackColor = true;
            this.buttonFraction.Click += new System.EventHandler(this.buttonFraction_Click);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMultiplication.ForeColor = System.Drawing.Color.Red;
            this.buttonMultiplication.Location = new System.Drawing.Point(116, 128);
            this.buttonMultiplication.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(34, 38);
            this.buttonMultiplication.TabIndex = 18;
            this.buttonMultiplication.Text = "*";
            this.buttonMultiplication.UseVisualStyleBackColor = true;
            // 
            // buttonPercent
            // 
            this.buttonPercent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPercent.Location = new System.Drawing.Point(154, 86);
            this.buttonPercent.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(34, 38);
            this.buttonPercent.TabIndex = 16;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = true;
            // 
            // buttonSubtraction
            // 
            this.buttonSubtraction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSubtraction.ForeColor = System.Drawing.Color.Red;
            this.buttonSubtraction.Location = new System.Drawing.Point(116, 86);
            this.buttonSubtraction.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSubtraction.Name = "buttonSubtraction";
            this.buttonSubtraction.Size = new System.Drawing.Size(34, 38);
            this.buttonSubtraction.TabIndex = 15;
            this.buttonSubtraction.Text = "-";
            this.buttonSubtraction.UseVisualStyleBackColor = true;
            // 
            // buttonC
            // 
            this.buttonC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonC.ForeColor = System.Drawing.Color.Red;
            this.buttonC.Location = new System.Drawing.Point(192, 44);
            this.buttonC.Margin = new System.Windows.Forms.Padding(2);
            this.buttonC.Name = "buttonC";
            this.tableLayoutPanel1.SetRowSpan(this.buttonC, 2);
            this.buttonC.Size = new System.Drawing.Size(40, 80);
            this.buttonC.TabIndex = 14;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonNegative
            // 
            this.buttonNegative.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNegative.Location = new System.Drawing.Point(154, 44);
            this.buttonNegative.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNegative.Name = "buttonNegative";
            this.buttonNegative.Size = new System.Drawing.Size(34, 38);
            this.buttonNegative.TabIndex = 13;
            this.buttonNegative.Text = "+/-";
            this.buttonNegative.UseVisualStyleBackColor = true;
            this.buttonNegative.Click += new System.EventHandler(this.buttonNegative_Click);
            // 
            // buttonAddition
            // 
            this.buttonAddition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddition.ForeColor = System.Drawing.Color.Red;
            this.buttonAddition.Location = new System.Drawing.Point(116, 44);
            this.buttonAddition.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddition.Name = "buttonAddition";
            this.buttonAddition.Size = new System.Drawing.Size(34, 38);
            this.buttonAddition.TabIndex = 12;
            this.buttonAddition.Text = "+";
            this.buttonAddition.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(2, 128);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(40, 128);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(78, 128);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(2, 86);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 38);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Location = new System.Drawing.Point(40, 86);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(34, 38);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Location = new System.Drawing.Point(78, 86);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(34, 38);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Location = new System.Drawing.Point(2, 44);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(34, 38);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Location = new System.Drawing.Point(40, 44);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(34, 38);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Location = new System.Drawing.Point(78, 44);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(34, 38);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // button0
            // 
            this.button0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button0.Location = new System.Drawing.Point(2, 170);
            this.button0.Margin = new System.Windows.Forms.Padding(2);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(34, 39);
            this.button0.TabIndex = 9;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // button00
            // 
            this.button00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button00.Location = new System.Drawing.Point(40, 170);
            this.button00.Margin = new System.Windows.Forms.Padding(2);
            this.button00.Name = "button00";
            this.button00.Size = new System.Drawing.Size(34, 39);
            this.button00.TabIndex = 10;
            this.button00.Text = "00";
            this.button00.UseVisualStyleBackColor = true;
            this.button00.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // priceTextBox21
            // 
            this.priceTextBox21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.priceTextBox21, 6);
            this.priceTextBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.priceTextBox21.Location = new System.Drawing.Point(2, 6);
            this.priceTextBox21.Margin = new System.Windows.Forms.Padding(2);
            this.priceTextBox21.Name = "priceTextBox21";
            this.priceTextBox21.Size = new System.Drawing.Size(230, 29);
            this.priceTextBox21.TabIndex = 11;
            this.priceTextBox21.Text = "0";
            this.priceTextBox21.Value = 0D;
            // 
            // PriceCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(250, 250);
            this.MinimumSize = new System.Drawing.Size(250, 250);
            this.Name = "PriceCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonAddition;
        private System.Windows.Forms.Button buttonNegative;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonSubtraction;
        private System.Windows.Forms.Button buttonPercent;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button buttonFraction;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonOK;

        private MultiSoftApp.Controls.PriceTextBox priceTextBox21;

        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button00;

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}