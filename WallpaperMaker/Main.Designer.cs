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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.openPictureButton = new System.Windows.Forms.Button();
            this.savePictureButton = new System.Windows.Forms.Button();
            this.setWallpaperButton = new System.Windows.Forms.Button();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.optionsGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).BeginInit();
            this.previewGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.optionsGroupBox.SuspendLayout();
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
            this.picturePreview.Size = new System.Drawing.Size(253, 290);
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
            this.previewGroupBox.Size = new System.Drawing.Size(259, 309);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.61539F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.38462F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(430, 315);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.savePictureButton);
            this.flowLayoutPanel1.Controls.Add(this.setWallpaperButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 215);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(9, 12, 3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(149, 69);
            this.flowLayoutPanel1.TabIndex = 8;
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
            // savePictureButton
            // 
            this.savePictureButton.Location = new System.Drawing.Point(3, 3);
            this.savePictureButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.savePictureButton.Name = "savePictureButton";
            this.savePictureButton.Size = new System.Drawing.Size(140, 23);
            this.savePictureButton.TabIndex = 8;
            this.savePictureButton.Text = "Save Picture";
            this.savePictureButton.UseVisualStyleBackColor = true;
            // 
            // setWallpaperButton
            // 
            this.setWallpaperButton.Location = new System.Drawing.Point(3, 38);
            this.setWallpaperButton.Name = "setWallpaperButton";
            this.setWallpaperButton.Size = new System.Drawing.Size(140, 23);
            this.setWallpaperButton.TabIndex = 9;
            this.setWallpaperButton.Text = "Set As Wallpaper";
            this.setWallpaperButton.UseVisualStyleBackColor = true;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(49, 82);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 3;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(49, 56);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 20);
            this.widthTextBox.TabIndex = 2;
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
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(6, 59);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(35, 13);
            this.widthLabel.TabIndex = 4;
            this.widthLabel.Text = "Width";
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 7;
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
            this.optionsGroupBox.Size = new System.Drawing.Size(159, 197);
            this.optionsGroupBox.TabIndex = 6;
            this.optionsGroupBox.TabStop = false;
            this.optionsGroupBox.Text = "Options";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(430, 315);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Scott\'s Cool Wallpaper Maker";
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).EndInit();
            this.previewGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.optionsGroupBox.ResumeLayout(false);
            this.optionsGroupBox.PerformLayout();
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
    }
}

