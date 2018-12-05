namespace WallpaperMaker.View
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
			this.mWidthTextBox = new WallpaperMaker.View.UInt32NumericUpDown();
			this.mHeightTextBox = new WallpaperMaker.View.UInt32NumericUpDown();
			this.mPreviewGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mPicturePreviewBox)).BeginInit();
			this.mTableLayoutPanel.SuspendLayout();
			this.mOptionsGroupBox.SuspendLayout();
			this.mActionsGroupBox.SuspendLayout();
			this.mFlowLayoutPanel.SuspendLayout();
			this.mMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mWidthTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mHeightTextBox)).BeginInit();
			this.SuspendLayout();
			// 
			// mPreviewGroupBox
			// 
			this.mPreviewGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mPreviewGroupBox.AutoSize = true;
			this.mPreviewGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.mPreviewGroupBox.Controls.Add(this.mPicturePreviewBox);
			this.mPreviewGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mPreviewGroupBox.Location = new System.Drawing.Point(165, 3);
			this.mPreviewGroupBox.Name = "mPreviewGroupBox";
			this.mTableLayoutPanel.SetRowSpan(this.mPreviewGroupBox, 2);
			this.mPreviewGroupBox.Size = new System.Drawing.Size(386, 327);
			this.mPreviewGroupBox.TabIndex = 1;
			this.mPreviewGroupBox.TabStop = false;
			this.mPreviewGroupBox.Text = "Preview";
			// 
			// mPicturePreviewBox
			// 
			this.mPicturePreviewBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.mPicturePreviewBox.InitialImage = null;
			this.mPicturePreviewBox.Location = new System.Drawing.Point(7, 19);
			this.mPicturePreviewBox.MinimumSize = new System.Drawing.Size(4, 50);
			this.mPicturePreviewBox.Name = "mPicturePreviewBox";
			this.mPicturePreviewBox.Size = new System.Drawing.Size(372, 300);
			this.mPicturePreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.mPicturePreviewBox.TabIndex = 0;
			this.mPicturePreviewBox.TabStop = false;
			// 
			// mTableLayoutPanel
			// 
			this.mTableLayoutPanel.AutoSize = true;
			this.mTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.mTableLayoutPanel.ColumnCount = 2;
			this.mTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
			this.mTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.mTableLayoutPanel.Controls.Add(this.mOptionsGroupBox, 0, 1);
			this.mTableLayoutPanel.Controls.Add(this.mActionsGroupBox, 0, 0);
			this.mTableLayoutPanel.Controls.Add(this.mPreviewGroupBox, 1, 0);
			this.mTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
			this.mTableLayoutPanel.Name = "mTableLayoutPanel";
			this.mTableLayoutPanel.RowCount = 2;
			this.mTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 187F));
			this.mTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 146F));
			this.mTableLayoutPanel.Size = new System.Drawing.Size(554, 333);
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
			this.mOptionsGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mOptionsGroupBox.Location = new System.Drawing.Point(3, 190);
			this.mOptionsGroupBox.Name = "mOptionsGroupBox";
			this.mOptionsGroupBox.Size = new System.Drawing.Size(156, 140);
			this.mOptionsGroupBox.TabIndex = 9;
			this.mOptionsGroupBox.TabStop = false;
			this.mOptionsGroupBox.Text = "Options";
			// 
			// mCroppingOptionLabel
			// 
			this.mCroppingOptionLabel.AutoSize = true;
			this.mCroppingOptionLabel.Location = new System.Drawing.Point(24, 84);
			this.mCroppingOptionLabel.Name = "mCroppingOptionLabel";
			this.mCroppingOptionLabel.Size = new System.Drawing.Size(105, 17);
			this.mCroppingOptionLabel.TabIndex = 8;
			this.mCroppingOptionLabel.Text = "Cropping option";
			// 
			// mCroppingOptionComboBox
			// 
			this.mCroppingOptionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.mCroppingOptionComboBox.Location = new System.Drawing.Point(9, 107);
			this.mCroppingOptionComboBox.Name = "mCroppingOptionComboBox";
			this.mCroppingOptionComboBox.Size = new System.Drawing.Size(138, 25);
			this.mCroppingOptionComboBox.TabIndex = 6;
			this.mCroppingOptionComboBox.SelectedIndexChanged += new System.EventHandler(this.CroppingOptionComboBox_SelectedIndexChanged);
			// 
			// mWidthLabel
			// 
			this.mWidthLabel.AutoSize = true;
			this.mWidthLabel.Location = new System.Drawing.Point(5, 23);
			this.mWidthLabel.Name = "mWidthLabel";
			this.mWidthLabel.Size = new System.Drawing.Size(42, 17);
			this.mWidthLabel.TabIndex = 4;
			this.mWidthLabel.Text = "Width";
			// 
			// mHeightLabel
			// 
			this.mHeightLabel.AutoSize = true;
			this.mHeightLabel.Location = new System.Drawing.Point(5, 54);
			this.mHeightLabel.Name = "mHeightLabel";
			this.mHeightLabel.Size = new System.Drawing.Size(46, 17);
			this.mHeightLabel.TabIndex = 5;
			this.mHeightLabel.Text = "Height";
			// 
			// mActionsGroupBox
			// 
			this.mActionsGroupBox.Controls.Add(this.mFlowLayoutPanel);
			this.mActionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mActionsGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mActionsGroupBox.Location = new System.Drawing.Point(3, 3);
			this.mActionsGroupBox.Name = "mActionsGroupBox";
			this.mActionsGroupBox.Size = new System.Drawing.Size(156, 181);
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
			this.mOpenPictureButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mOpenPictureButton.Image = global::WallpaperMaker.Properties.Resources.Open;
			this.mOpenPictureButton.Location = new System.Drawing.Point(3, 3);
			this.mOpenPictureButton.Name = "mOpenPictureButton";
			this.mOpenPictureButton.Size = new System.Drawing.Size(140, 34);
			this.mOpenPictureButton.TabIndex = 0;
			this.mOpenPictureButton.Text = "Open Picture";
			this.mOpenPictureButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.mOpenPictureButton.UseVisualStyleBackColor = true;
			this.mOpenPictureButton.Click += new System.EventHandler(this.OpenPictureButton_Click);
			// 
			// mClosePictureButton
			// 
			this.mClosePictureButton.AutoSize = true;
			this.mClosePictureButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mClosePictureButton.Image = global::WallpaperMaker.Properties.Resources.Close;
			this.mClosePictureButton.Location = new System.Drawing.Point(3, 43);
			this.mClosePictureButton.Name = "mClosePictureButton";
			this.mClosePictureButton.Size = new System.Drawing.Size(140, 34);
			this.mClosePictureButton.TabIndex = 1;
			this.mClosePictureButton.Text = "Close Picture";
			this.mClosePictureButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.mClosePictureButton.UseVisualStyleBackColor = true;
			this.mClosePictureButton.Click += new System.EventHandler(this.ClosePictureButton_Click);
			// 
			// mSavePictureButton
			// 
			this.mSavePictureButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mSavePictureButton.Image = global::WallpaperMaker.Properties.Resources.Save;
			this.mSavePictureButton.Location = new System.Drawing.Point(3, 83);
			this.mSavePictureButton.Name = "mSavePictureButton";
			this.mSavePictureButton.Size = new System.Drawing.Size(140, 34);
			this.mSavePictureButton.TabIndex = 2;
			this.mSavePictureButton.Text = "Save Picture";
			this.mSavePictureButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.mSavePictureButton.UseVisualStyleBackColor = true;
			this.mSavePictureButton.Click += new System.EventHandler(this.SavePictureButton_Click);
			// 
			// mSetWallpaperButton
			// 
			this.mSetWallpaperButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mSetWallpaperButton.Image = global::WallpaperMaker.Properties.Resources.SetWallpaper;
			this.mSetWallpaperButton.Location = new System.Drawing.Point(3, 123);
			this.mSetWallpaperButton.Name = "mSetWallpaperButton";
			this.mSetWallpaperButton.Size = new System.Drawing.Size(140, 34);
			this.mSetWallpaperButton.TabIndex = 3;
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
			this.mMenuStrip.Size = new System.Drawing.Size(554, 24);
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
			this.mFileToolStripMenuItem.Image = global::WallpaperMaker.Properties.Resources.File;
			this.mFileToolStripMenuItem.Name = "mFileToolStripMenuItem";
			this.mFileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.mFileToolStripMenuItem.Text = "File";
			// 
			// mOpenPictureToolStripMenuItem
			// 
			this.mOpenPictureToolStripMenuItem.Image = global::WallpaperMaker.Properties.Resources.Open;
			this.mOpenPictureToolStripMenuItem.Name = "mOpenPictureToolStripMenuItem";
			this.mOpenPictureToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.mOpenPictureToolStripMenuItem.Text = "Open";
			this.mOpenPictureToolStripMenuItem.Click += new System.EventHandler(this.OpenPictureToolStripMenuItem_Click);
			// 
			// mClosePictureToolStripMenuItem
			// 
			this.mClosePictureToolStripMenuItem.Image = global::WallpaperMaker.Properties.Resources.Close;
			this.mClosePictureToolStripMenuItem.Name = "mClosePictureToolStripMenuItem";
			this.mClosePictureToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.mClosePictureToolStripMenuItem.Text = "Close";
			this.mClosePictureToolStripMenuItem.Click += new System.EventHandler(this.ClosePictureToolStripMenuItem_Click);
			// 
			// mSavePictureToolStripMenuItem
			// 
			this.mSavePictureToolStripMenuItem.Image = global::WallpaperMaker.Properties.Resources.Save;
			this.mSavePictureToolStripMenuItem.Name = "mSavePictureToolStripMenuItem";
			this.mSavePictureToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.mSavePictureToolStripMenuItem.Text = "Save As...";
			this.mSavePictureToolStripMenuItem.Click += new System.EventHandler(this.SavePictureToolStripMenuItem_Click);
			// 
			// mSetAsWallpaperToolStripMenuItem
			// 
			this.mSetAsWallpaperToolStripMenuItem.Image = global::WallpaperMaker.Properties.Resources.SetWallpaper;
			this.mSetAsWallpaperToolStripMenuItem.Name = "mSetAsWallpaperToolStripMenuItem";
			this.mSetAsWallpaperToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.mSetAsWallpaperToolStripMenuItem.Text = "Set As Wallpaper";
			this.mSetAsWallpaperToolStripMenuItem.Click += new System.EventHandler(this.SetAsWallpaperToolStripMenuItem_Click);
			// 
			// mExitToolStripMenuItem
			// 
			this.mExitToolStripMenuItem.Name = "mExitToolStripMenuItem";
			this.mExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.mExitToolStripMenuItem.Text = "Exit";
			this.mExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// mExtrasToolStripMenuItem
			// 
			this.mExtrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mJordanDunkToolStripMenuItem});
			this.mExtrasToolStripMenuItem.Image = global::WallpaperMaker.Properties.Resources.Extras;
			this.mExtrasToolStripMenuItem.Name = "mExtrasToolStripMenuItem";
			this.mExtrasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.mExtrasToolStripMenuItem.Text = "Extras";
			// 
			// mJordanDunkToolStripMenuItem
			// 
			this.mJordanDunkToolStripMenuItem.Image = global::WallpaperMaker.Properties.Resources.Watch;
			this.mJordanDunkToolStripMenuItem.Name = "mJordanDunkToolStripMenuItem";
			this.mJordanDunkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.mJordanDunkToolStripMenuItem.Text = "Watch Jordan Dunk";
			this.mJordanDunkToolStripMenuItem.Click += new System.EventHandler(this.JordanDunkToolStripMenuItem_Click);
			// 
			// mHelpToolStripMenuItem
			// 
			this.mHelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAboutToolStripMenuItem});
			this.mHelpToolStripMenuItem.Image = global::WallpaperMaker.Properties.Resources.Help;
			this.mHelpToolStripMenuItem.Name = "mHelpToolStripMenuItem";
			this.mHelpToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.mHelpToolStripMenuItem.Text = "Help";
			// 
			// mAboutToolStripMenuItem
			// 
			this.mAboutToolStripMenuItem.Image = global::WallpaperMaker.Properties.Resources.About;
			this.mAboutToolStripMenuItem.Name = "mAboutToolStripMenuItem";
			this.mAboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.mAboutToolStripMenuItem.Text = "About";
			this.mAboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
			// 
			// mTimer
			// 
			this.mTimer.Interval = 40;
			this.mTimer.Tick += new System.EventHandler(this.Timer_Tick);
			// 
			// mWidthTextBox
			// 
			this.mWidthTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mWidthTextBox.Location = new System.Drawing.Point(58, 21);
			this.mWidthTextBox.Name = "mWidthTextBox";
			this.mWidthTextBox.Size = new System.Drawing.Size(89, 25);
			this.mWidthTextBox.TabIndex = 4;
			// 
			// mHeightTextBox
			// 
			this.mHeightTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mHeightTextBox.Location = new System.Drawing.Point(58, 52);
			this.mHeightTextBox.Name = "mHeightTextBox";
			this.mHeightTextBox.Size = new System.Drawing.Size(89, 25);
			this.mHeightTextBox.TabIndex = 5;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(554, 357);
			this.Controls.Add(this.mTableLayoutPanel);
			this.Controls.Add(this.mMenuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.mMenuStrip;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Scott\'s Wallpaper Maker";
			this.mPreviewGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mPicturePreviewBox)).EndInit();
			this.mTableLayoutPanel.ResumeLayout(false);
			this.mTableLayoutPanel.PerformLayout();
			this.mOptionsGroupBox.ResumeLayout(false);
			this.mOptionsGroupBox.PerformLayout();
			this.mActionsGroupBox.ResumeLayout(false);
			this.mFlowLayoutPanel.ResumeLayout(false);
			this.mFlowLayoutPanel.PerformLayout();
			this.mMenuStrip.ResumeLayout(false);
			this.mMenuStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.mWidthTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mHeightTextBox)).EndInit();
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
		private WallpaperMaker.View.UInt32NumericUpDown mWidthTextBox;
		private WallpaperMaker.View.UInt32NumericUpDown mHeightTextBox;
		private System.Windows.Forms.ToolStripMenuItem mOpenPictureToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mClosePictureToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mSavePictureToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mSetAsWallpaperToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mExitToolStripMenuItem;
		private System.Windows.Forms.Timer mTimer;
	}
}

