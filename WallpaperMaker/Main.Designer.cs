namespace WindowsApplication1
{
    partial class Main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.picturePreview = new System.Windows.Forms.PictureBox();
			this.previewGroupBox = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.optionsGroupBox = new System.Windows.Forms.GroupBox();
			this.openPictureButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.widthLabel = new System.Windows.Forms.Label();
			this.heightLabel = new System.Windows.Forms.Label();
			this.widthTextBox = new System.Windows.Forms.TextBox();
			this.heightTextBox = new System.Windows.Forms.TextBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.savePictureButton = new System.Windows.Forms.Button();
			this.setWallpaperButton = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.setAsWallpaperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.extrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.jordanDunkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.picturePreview)).BeginInit();
			this.previewGroupBox.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.optionsGroupBox.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// picturePreview
			// 
			this.picturePreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.picturePreview.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picturePreview.InitialImage = null;
			this.picturePreview.Location = new System.Drawing.Point(3, 16);
			this.picturePreview.MinimumSize = new System.Drawing.Size(4, 150);
			this.picturePreview.Name = "picturePreview";
			this.picturePreview.Size = new System.Drawing.Size(328, 299);
			this.picturePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picturePreview.TabIndex = 0;
			this.picturePreview.TabStop = false;
			// 
			// previewGroupBox
			// 
			this.previewGroupBox.Controls.Add(this.picturePreview);
			this.previewGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.previewGroupBox.Location = new System.Drawing.Point(168, 3);
			this.previewGroupBox.Name = "previewGroupBox";
			this.tableLayoutPanel1.SetRowSpan(this.previewGroupBox, 2);
			this.previewGroupBox.Size = new System.Drawing.Size(334, 318);
			this.previewGroupBox.TabIndex = 1;
			this.previewGroupBox.TabStop = false;
			this.previewGroupBox.Text = "Preview";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.previewGroupBox, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.optionsGroupBox, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.61539F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.38462F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(505, 324);
			this.tableLayoutPanel1.TabIndex = 8;
			// 
			// optionsGroupBox
			// 
			this.optionsGroupBox.Controls.Add(this.openPictureButton);
			this.optionsGroupBox.Controls.Add(this.label1);
			this.optionsGroupBox.Controls.Add(this.comboBox1);
			this.optionsGroupBox.Controls.Add(this.button1);
			this.optionsGroupBox.Controls.Add(this.widthLabel);
			this.optionsGroupBox.Controls.Add(this.heightLabel);
			this.optionsGroupBox.Controls.Add(this.widthTextBox);
			this.optionsGroupBox.Controls.Add(this.heightTextBox);
			this.optionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.optionsGroupBox.Location = new System.Drawing.Point(3, 3);
			this.optionsGroupBox.Name = "optionsGroupBox";
			this.optionsGroupBox.Size = new System.Drawing.Size(159, 203);
			this.optionsGroupBox.TabIndex = 6;
			this.optionsGroupBox.TabStop = false;
			this.optionsGroupBox.Text = "Options";
			// 
			// openPictureButton
			// 
			this.openPictureButton.AutoSize = true;
			this.openPictureButton.Location = new System.Drawing.Point(9, 19);
			this.openPictureButton.Name = "openPictureButton";
			this.openPictureButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
			this.openPictureButton.Size = new System.Drawing.Size(140, 23);
			this.openPictureButton.TabIndex = 7;
			this.openPictureButton.Text = "Open Picture";
			this.openPictureButton.UseVisualStyleBackColor = true;
			this.openPictureButton.Click += new System.EventHandler(this.openPictureButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(30, 119);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Cropping option";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(9, 135);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(140, 21);
			this.comboBox1.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(9, 162);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(140, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "Change";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// widthLabel
			// 
			this.widthLabel.AutoSize = true;
			this.widthLabel.Location = new System.Drawing.Point(6, 59);
			this.widthLabel.Name = "widthLabel";
			this.widthLabel.Size = new System.Drawing.Size(35, 13);
			this.widthLabel.TabIndex = 4;
			this.widthLabel.Text = "Width";
			// 
			// heightLabel
			// 
			this.heightLabel.AutoSize = true;
			this.heightLabel.Location = new System.Drawing.Point(6, 85);
			this.heightLabel.Name = "heightLabel";
			this.heightLabel.Size = new System.Drawing.Size(38, 13);
			this.heightLabel.TabIndex = 5;
			this.heightLabel.Text = "Height";
			// 
			// widthTextBox
			// 
			this.widthTextBox.Location = new System.Drawing.Point(49, 56);
			this.widthTextBox.Name = "widthTextBox";
			this.widthTextBox.Size = new System.Drawing.Size(100, 20);
			this.widthTextBox.TabIndex = 2;
			// 
			// heightTextBox
			// 
			this.heightTextBox.Location = new System.Drawing.Point(49, 82);
			this.heightTextBox.Name = "heightTextBox";
			this.heightTextBox.Size = new System.Drawing.Size(100, 20);
			this.heightTextBox.TabIndex = 3;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.savePictureButton);
			this.flowLayoutPanel1.Controls.Add(this.setWallpaperButton);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 221);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(9, 12, 3, 3);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(149, 69);
			this.flowLayoutPanel1.TabIndex = 8;
			// 
			// savePictureButton
			// 
			this.savePictureButton.Location = new System.Drawing.Point(3, 3);
			this.savePictureButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
			this.savePictureButton.Name = "savePictureButton";
			this.savePictureButton.Size = new System.Drawing.Size(140, 23);
			this.savePictureButton.TabIndex = 8;
			this.savePictureButton.Text = "Save Picture";
			this.savePictureButton.UseVisualStyleBackColor = true;
			this.savePictureButton.Click += new System.EventHandler(this.savePictureButton_Click);
			// 
			// setWallpaperButton
			// 
			this.setWallpaperButton.Location = new System.Drawing.Point(3, 38);
			this.setWallpaperButton.Name = "setWallpaperButton";
			this.setWallpaperButton.Size = new System.Drawing.Size(140, 23);
			this.setWallpaperButton.TabIndex = 9;
			this.setWallpaperButton.Text = "Set As Wallpaper";
			this.setWallpaperButton.UseVisualStyleBackColor = true;
			this.setWallpaperButton.Click += new System.EventHandler(this.setWallpaperButton_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.extrasToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(505, 24);
			this.menuStrip1.TabIndex = 9;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.setAsWallpaperToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.saveAsToolStripMenuItem.Text = "Save As...";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// setAsWallpaperToolStripMenuItem
			// 
			this.setAsWallpaperToolStripMenuItem.Name = "setAsWallpaperToolStripMenuItem";
			this.setAsWallpaperToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.setAsWallpaperToolStripMenuItem.Text = "Set As Wallpaper";
			// 
			// extrasToolStripMenuItem
			// 
			this.extrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jordanDunkToolStripMenuItem});
			this.extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
			this.extrasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.extrasToolStripMenuItem.Text = "Extras";
			// 
			// jordanDunkToolStripMenuItem
			// 
			this.jordanDunkToolStripMenuItem.CheckOnClick = true;
			this.jordanDunkToolStripMenuItem.Name = "jordanDunkToolStripMenuItem";
			this.jordanDunkToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.jordanDunkToolStripMenuItem.Text = "Watch Jordan Dunk";
			this.jordanDunkToolStripMenuItem.Click += new System.EventHandler(this.jordanDunkToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.aboutToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem1
			// 
			this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
			this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
			this.aboutToolStripMenuItem1.Text = "About";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(505, 348);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Scott\'s Cool Wallpaper Maker";
			((System.ComponentModel.ISupportInitialize)(this.picturePreview)).EndInit();
			this.previewGroupBox.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.optionsGroupBox.ResumeLayout(false);
			this.optionsGroupBox.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picturePreview;
        private System.Windows.Forms.GroupBox previewGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button openPictureButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button savePictureButton;
        private System.Windows.Forms.Button setWallpaperButton;
        private System.Windows.Forms.GroupBox optionsGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem extrasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem jordanDunkToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem setAsWallpaperToolStripMenuItem;
    }
}

