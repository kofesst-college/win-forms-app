namespace MultiSoftApp
{
    partial class Form1
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
            this.panelStatus = new System.Windows.Forms.Panel();
            this.labelPage = new System.Windows.Forms.Label();
            this.panelActions = new System.Windows.Forms.Panel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelPage = new System.Windows.Forms.Panel();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.panelStatus.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (98)))), ((int) (((byte) (102)))), ((int) (((byte) (244)))));
            this.panelStatus.Controls.Add(this.labelPage);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatus.ForeColor = System.Drawing.Color.White;
            this.panelStatus.Location = new System.Drawing.Point(0, 0);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(1182, 60);
            this.panelStatus.TabIndex = 0;
            // 
            // labelPage
            // 
            this.labelPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.labelPage.Location = new System.Drawing.Point(0, 0);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(1182, 60);
            this.labelPage.TabIndex = 0;
            this.labelPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (92)))), ((int) (((byte) (102)))), ((int) (((byte) (244)))));
            this.panelActions.Controls.Add(this.iconButton6);
            this.panelActions.Controls.Add(this.iconButton5);
            this.panelActions.Controls.Add(this.iconButton4);
            this.panelActions.Controls.Add(this.iconButton3);
            this.panelActions.Controls.Add(this.iconButton2);
            this.panelActions.Controls.Add(this.iconButton1);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelActions.ForeColor = System.Drawing.Color.White;
            this.panelActions.Location = new System.Drawing.Point(0, 60);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(300, 693);
            this.panelActions.TabIndex = 1;
            // 
            // iconButton5
            // 
            this.iconButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.iconButton5.IconColor = System.Drawing.Color.White;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 30;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(0, 160);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(300, 40);
            this.iconButton5.TabIndex = 4;
            this.iconButton5.Text = "Read order";
            this.iconButton5.UseVisualStyleBackColor = true;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 30;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(0, 120);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(300, 40);
            this.iconButton4.TabIndex = 3;
            this.iconButton4.Text = "Add order";
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 80);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(300, 40);
            this.iconButton3.TabIndex = 2;
            this.iconButton3.Text = "About";
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Keyboard;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 40);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(300, 40);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.Text = "Square Equation";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(300, 40);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Home";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panelPage
            // 
            this.panelPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPage.Location = new System.Drawing.Point(300, 60);
            this.panelPage.Name = "panelPage";
            this.panelPage.Size = new System.Drawing.Size(882, 693);
            this.panelPage.TabIndex = 2;
            // 
            // iconButton6
            // 
            this.iconButton6.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.iconButton6.IconColor = System.Drawing.Color.White;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 30;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.Location = new System.Drawing.Point(0, 200);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(300, 40);
            this.iconButton6.TabIndex = 5;
            this.iconButton6.Text = "Hex info";
            this.iconButton6.UseVisualStyleBackColor = true;
            this.iconButton6.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.panelPage);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.panelStatus);
            this.Location = new System.Drawing.Point(15, 15);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelStatus.ResumeLayout(false);
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private FontAwesome.Sharp.IconButton iconButton6;

        private FontAwesome.Sharp.IconButton iconButton5;

        private FontAwesome.Sharp.IconButton iconButton4;

        private System.Windows.Forms.Label labelPage;

        private System.Windows.Forms.Panel panelPage;

        private FontAwesome.Sharp.IconButton iconButton3;

        private FontAwesome.Sharp.IconButton iconButton2;

        private FontAwesome.Sharp.IconButton iconButton1;

        private System.Windows.Forms.Panel panelStatus;

        private System.Windows.Forms.Panel panelActions;

        #endregion
    }
}