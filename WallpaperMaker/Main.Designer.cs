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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.mPreviewGroupBox = new System.Windows.Forms.GroupBox();
			this.mPicturePreviewBox = new System.Windows.Forms.PictureBox();
			this.mTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.mOptionsGroupBox = new System.Windows.Forms.GroupBox();
			this.mCroppingOptionLabel = new System.Windows.Forms.Label();
			this.mCroppingOptionComboBox = new System.Windows.Forms.ComboBox();
			this.mWidthLabel = new System.Windows.Forms.Label();
			this.mHeightLabel = new System.Windows.Forms.Label();
			this.mWidthTextBox = new WindowsApplication1.UInt32NumericUpDown();
			this.mHeightTextBox = new WindowsApplication1.UInt32NumericUpDown();
			this.mActionsGroupBox = new System.Windows.Forms.GroupBox();
			this.mFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.mOpenPictureButton = new System.Windows.Forms.Button();
			this.mClosePictureButton = new System.Windows.Forms.Button();
			this.mSavePictureButton = new System.Windows.Forms.Button();
			this.mSetWallpaperButton = new System.Windows.Forms.Button();
			this.mMenuStrip = new System.Windows.Forms.MenuStrip();
			this.mFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mOpenPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mClosePictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mSavePictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mSetAsWallpaperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mExtrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mJordanDunkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mTimer = new System.Windows.Forms.Timer(this.components);
			this.mPreviewGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mPicturePreviewBox)).BeginInit();
			this.mTableLayoutPanel.SuspendLayout();
			this.mOptionsGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mWidthTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mHeightTextBox)).BeginInit();
			this.mActionsGroupBox.SuspendLayout();
			this.mFlowLayoutPanel.SuspendLayout();
			this.mMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// mPreviewGroupBox
			// 
			this.mPreviewGroupBox.Controls.Add(this.mPicturePreviewBox);
			this.mPreviewGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mPreviewGroupBox.Location = new System.Drawing.Point(168, 3);
			this.mPreviewGroupBox.Name = "mPreviewGroupBox";
			this.mTableLayoutPanel.SetRowSpan(this.mPreviewGroupBox, 2);
			this.mPreviewGroupBox.Size = new System.Drawing.Size(383, 306);
			this.mPreviewGroupBox.TabIndex = 1;
			this.mPreviewGroupBox.TabStop = false;
			this.mPreviewGroupBox.Text = "Preview";
			// 
			// mPicturePreviewBox
			// 
			this.mPicturePreviewBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.mPicturePreviewBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mPicturePreviewBox.InitialImage = null;
			this.mPicturePreviewBox.Location = new System.Drawing.Point(3, 16);
			this.mPicturePreviewBox.MinimumSize = new System.Drawing.Size(4, 50);
			this.mPicturePreviewBox.Name = "mPicturePreviewBox";
			this.mPicturePreviewBox.Size = new System.Drawing.Size(377, 287);
			this.mPicturePreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.mPicturePreviewBox.TabIndex = 0;
			this.mPicturePreviewBox.TabStop = false;
			// 
			// mTableLayoutPanel
			// 
			this.mTableLayoutPanel.AutoSize = true;
			this.mTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.mTableLayoutPanel.ColumnCount = 2;
			this.mTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
			this.mTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.mTableLayoutPanel.Controls.Add(this.mOptionsGroupBox, 0, 1);
			this.mTableLayoutPanel.Controls.Add(this.mActionsGroupBox, 0, 0);
			this.mTableLayoutPanel.Controls.Add(this.mPreviewGroupBox, 1, 0);
			this.mTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
			this.mTableLayoutPanel.Name = "mTableLayoutPanel";
			this.mTableLayoutPanel.RowCount = 2;
			this.mTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.97436F));
			this.mTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.02564F));
			this.mTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.mTableLayoutPanel.Size = new System.Drawing.Size(552, 312);
			this.mTableLayoutPanel.TabIndex = 8;
			// 
			// mOptionsGroupBox
			// 
			this.mOptionsGroupBox.Controls.Add(this.mCroppingOptionLabel);
			this.mOptionsGroupBox.Controls.Add(this.mCroppingOptionComboBox);
			this.mOptionsGroupBox.Controls.Add(this.mWidthLabel);
			this.mOptionsGroupBox.Controls.Add(this.mHeightLabel);
			this.mOptionsGroupBox.Controls.Add(this.mWidthTextBox);
			this.mOptionsGroupBox.Controls.Add(this.mHeightTextBox);
			this.mOptionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mOptionsGroupBox.Location = new System.Drawing.Point(3, 187);
			this.mOptionsGroupBox.Name = "mOptionsGroupBox";
			this.mOptionsGroupBox.Size = new System.Drawing.Size(159, 122);
			this.mOptionsGroupBox.TabIndex = 9;
			this.mOptionsGroupBox.TabStop = false;
			this.mOptionsGroupBox.Text = "Options";
			// 
			// mCroppingOptionLabel
			// 
			this.mCroppingOptionLabel.AutoSize = true;
			this.mCroppingOptionLabel.Location = new System.Drawing.Point(30, 76);
			this.mCroppingOptionLabel.Name = "mCroppingOptionLabel";
			this.mCroppingOptionLabel.Size = new System.Drawing.Size(81, 13);
			this.mCroppingOptionLabel.TabIndex = 8;
			this.mCroppingOptionLabel.Text = "Cropping option";
			// 
			// mCroppingOptionComboBox
			// 
			this.mCroppingOptionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.mCroppingOptionComboBox.Location = new System.Drawing.Point(8, 92);
			this.mCroppingOptionComboBox.Name = "mCroppingOptionComboBox";
			this.mCroppingOptionComboBox.Size = new System.Drawing.Size(140, 21);
			this.mCroppingOptionComboBox.TabIndex = 7;
			this.mCroppingOptionComboBox.SelectedIndexChanged += new System.EventHandler(this.CroppingOptionComboBox_SelectedIndexChanged);
			// 
			// mWidthLabel
			// 
			this.mWidthLabel.AutoSize = true;
			this.mWidthLabel.Location = new System.Drawing.Point(6, 23);
			this.mWidthLabel.Name = "mWidthLabel";
			this.mWidthLabel.Size = new System.Drawing.Size(35, 13);
			this.mWidthLabel.TabIndex = 4;
			this.mWidthLabel.Text = "Width";
			// 
			// mHeightLabel
			// 
			this.mHeightLabel.AutoSize = true;
			this.mHeightLabel.Location = new System.Drawing.Point(6, 49);
			this.mHeightLabel.Name = "mHeightLabel";
			this.mHeightLabel.Size = new System.Drawing.Size(38, 13);
			this.mHeightLabel.TabIndex = 5;
			this.mHeightLabel.Text = "Height";
			// 
			// mWidthTextBox
			// 
			this.mWidthTextBox.Location = new System.Drawing.Point(49, 20);
			this.mWidthTextBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.mWidthTextBox.Name = "mWidthTextBox";
			this.mWidthTextBox.Size = new System.Drawing.Size(99, 20);
			this.mWidthTextBox.TabIndex = 2;
			// 
			// mHeightTextBox
			// 
			this.mHeightTextBox.Location = new System.Drawing.Point(49, 46);
			this.mHeightTextBox.Name = "mHeightTextBox";
			this.mHeightTextBox.Size = new System.Drawing.Size(99, 20);
			this.mHeightTextBox.TabIndex = 3;
			// 
			// mActionsGroupBox
			// 
			this.mActionsGroupBox.Controls.Add(this.mFlowLayoutPanel);
			this.mActionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mActionsGroupBox.Location = new System.Drawing.Point(3, 3);
			this.mActionsGroupBox.Name = "mActionsGroupBox";
			this.mActionsGroupBox.Size = new System.Drawing.Size(159, 178);
			this.mActionsGroupBox.TabIndex = 8;
			this.mActionsGroupBox.TabStop = false;
			this.mActionsGroupBox.Text = "Actions";
			// 
			// mFlowLayoutPanel
			// 
			this.mFlowLayoutPanel.Controls.Add(this.mOpenPictureButton);
			this.mFlowLayoutPanel.Controls.Add(this.mClosePictureButton);
			this.mFlowLayoutPanel.Controls.Add(this.mSavePictureButton);
			this.mFlowLayoutPanel.Controls.Add(this.mSetWallpaperButton);
			this.mFlowLayoutPanel.Location = new System.Drawing.Point(5, 15);
			this.mFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(9, 12, 3, 3);
			this.mFlowLayoutPanel.Name = "mFlowLayoutPanel";
			this.mFlowLayoutPanel.Size = new System.Drawing.Size(149, 158);
			this.mFlowLayoutPanel.TabIndex = 10;
			// 
			// mOpenPictureButton
			// 
			this.mOpenPictureButton.AutoSize = true;
			this.mOpenPictureButton.Image = global::WindowsApplication1.Properties.Resources.Open;
			this.mOpenPictureButton.Location = new System.Drawing.Point(3, 3);
			this.mOpenPictureButton.Name = "mOpenPictureButton";
			this.mOpenPictureButton.Size = new System.Drawing.Size(140, 34);
			this.mOpenPictureButton.TabIndex = 7;
			this.mOpenPictureButton.Text = "Open Picture";
			this.mOpenPictureButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.mOpenPictureButton.UseVisualStyleBackColor = true;
			this.mOpenPictureButton.Click += new System.EventHandler(this.OpenPictureButton_Click);
			// 
			// mClosePictureButton
			// 
			this.mClosePictureButton.AutoSize = true;
			this.mClosePictureButton.Image = global::WindowsApplication1.Properties.Resources.Close;
			this.mClosePictureButton.Location = new System.Drawing.Point(3, 43);
			this.mClosePictureButton.Name = "mClosePictureButton";
			this.mClosePictureButton.Size = new System.Drawing.Size(140, 34);
			this.mClosePictureButton.TabIndex = 10;
			this.mClosePictureButton.Text = "Close Picture";
			this.mClosePictureButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.mClosePictureButton.UseVisualStyleBackColor = true;
			this.mClosePictureButton.Click += new System.EventHandler(this.ClosePictureButton_Click);
			// 
			// mSavePictureButton
			// 
			this.mSavePictureButton.Image = global::WindowsApplication1.Properties.Resources.Save;
			this.mSavePictureButton.Location = new System.Drawing.Point(3, 83);
			this.mSavePictureButton.Name = "mSavePictureButton";
			this.mSavePictureButton.Size = new System.Drawing.Size(140, 34);
			this.mSavePictureButton.TabIndex = 8;
			this.mSavePictureButton.Text = "Save Picture";
			this.mSavePictureButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.mSavePictureButton.UseVisualStyleBackColor = true;
			this.mSavePictureButton.Click += new System.EventHandler(this.SavePictureButton_Click);
			// 
			// mSetWallpaperButton
			// 
			this.mSetWallpaperButton.Image = global::WindowsApplication1.Properties.Resources.SetWallpaper;
			this.mSetWallpaperButton.Location = new System.Drawing.Point(3, 123);
			this.mSetWallpaperButton.Name = "mSetWallpaperButton";
			this.mSetWallpaperButton.Size = new System.Drawing.Size(140, 34);
			this.mSetWallpaperButton.TabIndex = 9;
			this.mSetWallpaperButton.Text = "Set As Wallpaper";
			this.mSetWallpaperButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.mSetWallpaperButton.UseVisualStyleBackColor = true;
			this.mSetWallpaperButton.Click += new System.EventHandler(this.SetAsWallpaperButton_Click);
			// 
			// mMenuStrip
			// 
			this.mMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFileToolStripMenuItem,
            this.mExtrasToolStripMenuItem,
            this.mHelpToolStripMenuItem});
			this.mMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.mMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mMenuStrip.Name = "mMenuStrip";
			this.mMenuStrip.Size = new System.Drawing.Size(552, 24);
			this.mMenuStrip.TabIndex = 9;
			this.mMenuStrip.Text = "menuStrip1";
			// 
			// mFileToolStripMenuItem
			// 
			this.mFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mOpenPictureToolStripMenuItem,
            this.mClosePictureToolStripMenuItem,
            this.mSavePictureToolStripMenuItem,
            this.mSetAsWallpaperToolStripMenuItem,
            this.mExitToolStripMenuItem});
			this.mFileToolStripMenuItem.Image = global::WindowsApplication1.Properties.Resources.File;
			this.mFileToolStripMenuItem.Name = "mFileToolStripMenuItem";
			this.mFileToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
			this.mFileToolStripMenuItem.Text = "File";
			// 
			// mOpenPictureToolStripMenuItem
			// 
			this.mOpenPictureToolStripMenuItem.Image = global::WindowsApplication1.Properties.Resources.Open;
			this.mOpenPictureToolStripMenuItem.Name = "mOpenPictureToolStripMenuItem";
			this.mOpenPictureToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.mOpenPictureToolStripMenuItem.Text = "Open";
			this.mOpenPictureToolStripMenuItem.Click += new System.EventHandler(this.OpenPictureToolStripMenuItem_Click);
			// 
			// mClosePictureToolStripMenuItem
			// 
			this.mClosePictureToolStripMenuItem.Image = global::WindowsApplication1.Properties.Resources.Close;
			this.mClosePictureToolStripMenuItem.Name = "mClosePictureToolStripMenuItem";
			this.mClosePictureToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.mClosePictureToolStripMenuItem.Text = "Close";
			this.mClosePictureToolStripMenuItem.Click += new System.EventHandler(this.ClosePictureToolStripMenuItem_Click);
			// 
			// mSavePictureToolStripMenuItem
			// 
			this.mSavePictureToolStripMenuItem.Image = global::WindowsApplication1.Properties.Resources.Save;
			this.mSavePictureToolStripMenuItem.Name = "mSavePictureToolStripMenuItem";
			this.mSavePictureToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.mSavePictureToolStripMenuItem.Text = "Save As...";
			this.mSavePictureToolStripMenuItem.Click += new System.EventHandler(this.SavePictureToolStripMenuItem_Click);
			// 
			// mSetAsWallpaperToolStripMenuItem
			// 
			this.mSetAsWallpaperToolStripMenuItem.Image = global::WindowsApplication1.Properties.Resources.SetWallpaper;
			this.mSetAsWallpaperToolStripMenuItem.Name = "mSetAsWallpaperToolStripMenuItem";
			this.mSetAsWallpaperToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.mSetAsWallpaperToolStripMenuItem.Text = "Set As Wallpaper";
			this.mSetAsWallpaperToolStripMenuItem.Click += new System.EventHandler(this.SetAsWallpaperToolStripMenuItem_Click);
			// 
			// mExitToolStripMenuItem
			// 
			this.mExitToolStripMenuItem.Name = "mExitToolStripMenuItem";
			this.mExitToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.mExitToolStripMenuItem.Text = "Exit";
			this.mExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// mExtrasToolStripMenuItem
			// 
			this.mExtrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mJordanDunkToolStripMenuItem});
			this.mExtrasToolStripMenuItem.Image = global::WindowsApplication1.Properties.Resources.Extras;
			this.mExtrasToolStripMenuItem.Name = "mExtrasToolStripMenuItem";
			this.mExtrasToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.mExtrasToolStripMenuItem.Text = "Extras";
			// 
			// mJordanDunkToolStripMenuItem
			// 
			this.mJordanDunkToolStripMenuItem.Image = global::WindowsApplication1.Properties.Resources.Watch;
			this.mJordanDunkToolStripMenuItem.Name = "mJordanDunkToolStripMenuItem";
			this.mJordanDunkToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.mJordanDunkToolStripMenuItem.Text = "Watch Jordan Dunk";
			this.mJordanDunkToolStripMenuItem.Click += new System.EventHandler(this.JordanDunkToolStripMenuItem_Click);
			// 
			// mHelpToolStripMenuItem
			// 
			this.mHelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAboutToolStripMenuItem});
			this.mHelpToolStripMenuItem.Image = global::WindowsApplication1.Properties.Resources.Help;
			this.mHelpToolStripMenuItem.Name = "mHelpToolStripMenuItem";
			this.mHelpToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.mHelpToolStripMenuItem.Text = "Help";
			// 
			// mAboutToolStripMenuItem
			// 
			this.mAboutToolStripMenuItem.Image = global::WindowsApplication1.Properties.Resources.About;
			this.mAboutToolStripMenuItem.Name = "mAboutToolStripMenuItem";
			this.mAboutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.mAboutToolStripMenuItem.Text = "About";
			this.mAboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
			// 
			// mTimer
			// 
			this.mTimer.Interval = 40;
			this.mTimer.Tick += new System.EventHandler(this.Timer_Tick);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(552, 336);
			this.Controls.Add(this.mTableLayoutPanel);
			this.Controls.Add(this.mMenuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.mMenuStrip;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Scott\'s Cool Wallpaper Maker";
			this.mPreviewGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mPicturePreviewBox)).EndInit();
			this.mTableLayoutPanel.ResumeLayout(false);
			this.mOptionsGroupBox.ResumeLayout(false);
			this.mOptionsGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.mWidthTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mHeightTextBox)).EndInit();
			this.mActionsGroupBox.ResumeLayout(false);
			this.mFlowLayoutPanel.ResumeLayout(false);
			this.mFlowLayoutPanel.PerformLayout();
			this.mMenuStrip.ResumeLayout(false);
			this.mMenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.GroupBox mPreviewGroupBox;
		private System.Windows.Forms.TableLayoutPanel mTableLayoutPanel;
		private System.Windows.Forms.MenuStrip mMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem mFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mExtrasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mHelpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mAboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mJordanDunkToolStripMenuItem;
		private System.Windows.Forms.GroupBox mActionsGroupBox;
		private System.Windows.Forms.PictureBox mPicturePreviewBox;
		private System.Windows.Forms.FlowLayoutPanel mFlowLayoutPanel;
		private System.Windows.Forms.Button mOpenPictureButton;
		private System.Windows.Forms.Button mClosePictureButton;
		private System.Windows.Forms.Button mSavePictureButton;
		private System.Windows.Forms.Button mSetWallpaperButton;
		private System.Windows.Forms.GroupBox mOptionsGroupBox;
		private System.Windows.Forms.Label mCroppingOptionLabel;
		private System.Windows.Forms.ComboBox mCroppingOptionComboBox;
		private System.Windows.Forms.Label mWidthLabel;
		private System.Windows.Forms.Label mHeightLabel;
		private WindowsApplication1.UInt32NumericUpDown mWidthTextBox;
		private WindowsApplication1.UInt32NumericUpDown mHeightTextBox;
		private System.Windows.Forms.ToolStripMenuItem mOpenPictureToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mClosePictureToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mSavePictureToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mSetAsWallpaperToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mExitToolStripMenuItem;
		private System.Windows.Forms.Timer mTimer;
    }
}

