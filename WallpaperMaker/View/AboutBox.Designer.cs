namespace WallpaperMaker.View
{
	partial class AboutBox
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
			if(disposing && (components != null))
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
			this.mTitleLabel = new System.Windows.Forms.Label();
			this.mVersionTextLabel = new System.Windows.Forms.Label();
			this.mVersionLabel = new System.Windows.Forms.Label();
			this.mCloseButton = new System.Windows.Forms.Button();
			this.mPictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.mPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// mTitleLabel
			// 
			this.mTitleLabel.AutoSize = true;
			this.mTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
			this.mTitleLabel.Location = new System.Drawing.Point(83, 13);
			this.mTitleLabel.Name = "mTitleLabel";
			this.mTitleLabel.Size = new System.Drawing.Size(268, 25);
			this.mTitleLabel.TabIndex = 3;
			this.mTitleLabel.Text = "Scott\'s Wallpaper Maker";
			this.mTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// mVersionTextLabel
			// 
			this.mVersionTextLabel.AutoSize = true;
			this.mVersionTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mVersionTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
			this.mVersionTextLabel.Location = new System.Drawing.Point(160, 57);
			this.mVersionTextLabel.Name = "mVersionTextLabel";
			this.mVersionTextLabel.Size = new System.Drawing.Size(75, 20);
			this.mVersionTextLabel.TabIndex = 4;
			this.mVersionTextLabel.Text = "Version:";
			this.mVersionTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// mVersionLabel
			// 
			this.mVersionLabel.AutoSize = true;
			this.mVersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mVersionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
			this.mVersionLabel.Location = new System.Drawing.Point(229, 57);
			this.mVersionLabel.Name = "mVersionLabel";
			this.mVersionLabel.Size = new System.Drawing.Size(64, 20);
			this.mVersionLabel.TabIndex = 5;
			this.mVersionLabel.Text = "0.0.0.0";
			this.mVersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// mCloseButton
			// 
			this.mCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
			this.mCloseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
			this.mCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.mCloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.mCloseButton.Location = new System.Drawing.Point(322, 95);
			this.mCloseButton.Name = "mCloseButton";
			this.mCloseButton.Size = new System.Drawing.Size(75, 23);
			this.mCloseButton.TabIndex = 6;
			this.mCloseButton.Text = "Close";
			this.mCloseButton.UseVisualStyleBackColor = false;
			this.mCloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// mPictureBox
			// 
			this.mPictureBox.Image = global::WallpaperMaker.Properties.Resources.JordanInverted;
			this.mPictureBox.Location = new System.Drawing.Point(13, 13);
			this.mPictureBox.Name = "mPictureBox";
			this.mPictureBox.Size = new System.Drawing.Size(64, 64);
			this.mPictureBox.TabIndex = 0;
			this.mPictureBox.TabStop = false;
			// 
			// AboutBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.ClientSize = new System.Drawing.Size(409, 130);
			this.Controls.Add(this.mCloseButton);
			this.Controls.Add(this.mVersionLabel);
			this.Controls.Add(this.mVersionTextLabel);
			this.Controls.Add(this.mTitleLabel);
			this.Controls.Add(this.mPictureBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AboutBox";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "AboutBox";
			((System.ComponentModel.ISupportInitialize)(this.mPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox mPictureBox;
		private System.Windows.Forms.Label mTitleLabel;
		private System.Windows.Forms.Label mVersionTextLabel;
		private System.Windows.Forms.Label mVersionLabel;
		private System.Windows.Forms.Button mCloseButton;
	}
}