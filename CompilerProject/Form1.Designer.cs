namespace CompilerProject
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panalMenu = new Guna.UI2.WinForms.Guna2Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.btnScanner = new System.Windows.Forms.Button();
			this.panalLogo = new Guna.UI2.WinForms.Guna2Panel();
			this.panelTitleBar = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panelDesktop = new System.Windows.Forms.Panel();
			this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Start = new Guna.UI2.WinForms.Guna2Button();
			this.panalMenu.SuspendLayout();
			this.panelTitleBar.SuspendLayout();
			this.panelDesktop.SuspendLayout();
			this.SuspendLayout();
			// 
			// panalMenu
			// 
			this.panalMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
			this.panalMenu.Controls.Add(this.button2);
			this.panalMenu.Controls.Add(this.btnScanner);
			this.panalMenu.Controls.Add(this.panalLogo);
			this.panalMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panalMenu.Location = new System.Drawing.Point(0, 0);
			this.panalMenu.Name = "panalMenu";
			this.panalMenu.Size = new System.Drawing.Size(220, 545);
			this.panalMenu.TabIndex = 0;
			// 
			// button2
			// 
			this.button2.Dock = System.Windows.Forms.DockStyle.Top;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = System.Drawing.Color.Gainsboro;
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(0, 135);
			this.button2.Name = "button2";
			this.button2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
			this.button2.Size = new System.Drawing.Size(220, 60);
			this.button2.TabIndex = 2;
			this.button2.Text = "   Parser";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnScanner
			// 
			this.btnScanner.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnScanner.FlatAppearance.BorderSize = 0;
			this.btnScanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnScanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnScanner.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnScanner.Image = ((System.Drawing.Image)(resources.GetObject("btnScanner.Image")));
			this.btnScanner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnScanner.Location = new System.Drawing.Point(0, 75);
			this.btnScanner.Name = "btnScanner";
			this.btnScanner.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
			this.btnScanner.Size = new System.Drawing.Size(220, 60);
			this.btnScanner.TabIndex = 1;
			this.btnScanner.Text = "    Scanner";
			this.btnScanner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnScanner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnScanner.UseVisualStyleBackColor = true;
			this.btnScanner.Click += new System.EventHandler(this.btnScanner_Click);
			// 
			// panalLogo
			// 
			this.panalLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
			this.panalLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.panalLogo.Location = new System.Drawing.Point(0, 0);
			this.panalLogo.Name = "panalLogo";
			this.panalLogo.Size = new System.Drawing.Size(220, 75);
			this.panalLogo.TabIndex = 1;
			// 
			// panelTitleBar
			// 
			this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(115)))), ((int)(((byte)(158)))));
			this.panelTitleBar.Controls.Add(this.button1);
			this.panelTitleBar.Controls.Add(this.label1);
			this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
			this.panelTitleBar.Name = "panelTitleBar";
			this.panelTitleBar.Size = new System.Drawing.Size(942, 75);
			this.panelTitleBar.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(18, 22);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(41, 31);
			this.button1.TabIndex = 1;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Monotype Koufi", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(417, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Compiler";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelDesktop
			// 
			this.panelDesktop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelDesktop.BackgroundImage")));
			this.panelDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panelDesktop.Controls.Add(this.Start);
			this.panelDesktop.Controls.Add(this.guna2TextBox1);
			this.panelDesktop.Controls.Add(this.label2);
			this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelDesktop.Location = new System.Drawing.Point(220, 75);
			this.panelDesktop.Name = "panelDesktop";
			this.panelDesktop.Size = new System.Drawing.Size(942, 470);
			this.panelDesktop.TabIndex = 2;
			// 
			// guna2TextBox1
			// 
			this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.guna2TextBox1.DefaultText = "";
			this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2TextBox1.Location = new System.Drawing.Point(156, 92);
			this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.guna2TextBox1.Multiline = true;
			this.guna2TextBox1.Name = "guna2TextBox1";
			this.guna2TextBox1.PasswordChar = '\0';
			this.guna2TextBox1.PlaceholderText = "";
			this.guna2TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.guna2TextBox1.SelectedText = "";
			this.guna2TextBox1.Size = new System.Drawing.Size(600, 300);
			this.guna2TextBox1.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Monotype Koufi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label2.Location = new System.Drawing.Point(351, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(230, 39);
			this.label2.TabIndex = 3;
			this.label2.Text = "Drop Your Code ";
			// 
			// Start
			// 
			this.Start.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.Start.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.Start.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.Start.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.Start.FillColor = System.Drawing.Color.SteelBlue;
			this.Start.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Start.ForeColor = System.Drawing.Color.White;
			this.Start.Location = new System.Drawing.Point(377, 399);
			this.Start.Name = "Start";
			this.Start.Size = new System.Drawing.Size(180, 45);
			this.Start.TabIndex = 7;
			this.Start.Text = "Start!";
			this.Start.Click += new System.EventHandler(this.Start_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1162, 545);
			this.Controls.Add(this.panelDesktop);
			this.Controls.Add(this.panelTitleBar);
			this.Controls.Add(this.panalMenu);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panalMenu.ResumeLayout(false);
			this.panelTitleBar.ResumeLayout(false);
			this.panelTitleBar.PerformLayout();
			this.panelDesktop.ResumeLayout(false);
			this.panelDesktop.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panalMenu;
        private Guna.UI2.WinForms.Guna2Panel panalLogo;
        private System.Windows.Forms.Button btnScanner;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2Button Start;
	}
}

