using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WindowsApplication1.Properties;

namespace WindowsApplication1
{
	public partial class Main : Form
	{
		#region Enumerations

		public enum HoriztonalCropping
		{
			Center = 0,
			Left = 1,
			Right = 2
		};

		public enum VerticalCropping
		{
			Bottom = 2,
			Center = 0,
			Top = 1
		};

		#endregion Enumerations

		#region Fields

		private Size mCropSize;

		private bool mIsPreviewBoxUpdating;

		private int mJordanDunkIndex;

		private Image[] mJordanDunks = new Image[mJordanDunkStopIndex - mJordanDunkStartIndex];

		private const int mJordanDunkStartIndex = 1645;

		private const int mJordanDunkStopIndex = 1832;

		private Image mModifiedImage;

		private Image mOpenImage;

		#endregion Fields

		#region Methods

		private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutBox aboutBox = new AboutBox();
			aboutBox.ShowDialog();
		}

		/// <summary>
		///   If the replaceString is not found, the newString will be appended to the fileName.
		/// </summary>
		/// 
		/// <param name="fileName"></param>
		/// <param name="replaceString"></param>
		/// <param name="newString"></param>
		/// <returns></returns>
		private string BuildFileName(string fileName, string replaceString, string newString)
		{
			string returnString;

			if(replaceString != "" && fileName.Contains(replaceString))
				returnString = fileName.Replace(replaceString, newString);
			else
				returnString = fileName + newString;

			return returnString;
		}

		private void ClosePicture()
		{
			DisableControls();
			mPicturePreviewBox.Image = null;
			mOpenImage = null;
		}

		private void ClosePictureButton_Click(object sender, EventArgs e)
		{
			ClosePicture();
		}

		private void ClosePictureToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ClosePicture();
		}

		private void CroppingOptionComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdatePreviewBox();
		}

		private void CropSizeTextBox_ValueChanged(object sender, EventArgs e)
		{
			mCropSize = new Size(Convert.ToInt32(mWidthTextBox.Text), Convert.ToInt32(mHeightTextBox.Text));

			UpdatePreviewBox();
		}

		private void DisableControls()
		{
			mOpenPictureButton.Focus();

			mHeightTextBox.ReadOnly = true;
			mWidthTextBox.ReadOnly = true;
			mClosePictureButton.Enabled = false;
			mSavePictureButton.Enabled = false;
			mSetWallpaperButton.Enabled = false;
			mCroppingOptionComboBox.Enabled = false;
			mWidthTextBox.Enabled = false;
			mHeightTextBox.Enabled = false;
			mClosePictureToolStripMenuItem.Enabled = false;
			mSavePictureToolStripMenuItem.Enabled = false;
			mSetAsWallpaperToolStripMenuItem.Enabled = false;
		}

		private void EnableControls()
		{
			mHeightTextBox.ReadOnly = false;
			mWidthTextBox.ReadOnly = false;
			mClosePictureButton.Enabled = true;
			mSavePictureButton.Enabled = true;
			mSetWallpaperButton.Enabled = true;
			mCroppingOptionComboBox.Enabled = true;
			mWidthTextBox.Enabled = true;
			mHeightTextBox.Enabled = true;
			mClosePictureToolStripMenuItem.Enabled = true;
			mSavePictureToolStripMenuItem.Enabled = true;
			mSetAsWallpaperToolStripMenuItem.Enabled = true;
		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(mTimer.Enabled)
			{
				mTimer.Stop();
			}

			this.Close();
		}

		private static Rectangle GetImageCropRectangle(Size imgSize, Size cropSize, HoriztonalCropping horizontalCropOption)
		{
			int x;
			int y;

			if(imgSize.Height != cropSize.Height)
			{
				throw new ArgumentException(string.Format
				(
					"For a horizontal crop, current height ({0}) must match desired cropped height ({1}).",
					imgSize.Height,
					cropSize.Height
				));
			}
			else if(imgSize.Width < cropSize.Width)
			{
				throw new ArgumentException(string.Format
				(
					"For a horizontal crop, current width ({0}) must be greater than desired cropped width ({1}).",
					imgSize.Width,
					cropSize.Width
				));
			}

			switch(horizontalCropOption)
			{
				case HoriztonalCropping.Left:
					x = 0;
					y = 0;
					break;
				case HoriztonalCropping.Right:
					x = imgSize.Width - cropSize.Width;
					y = 0;
					break;
				default: // HoriztonalCropping.Center
					x = (imgSize.Width - cropSize.Width) / 2;
					y = 0;
					break;
			}

			return new Rectangle(x, y, cropSize.Width, cropSize.Height);
		}

		private static Rectangle GetImageCropRectangle(Size imgSize, Size cropSize, VerticalCropping verticalCropOption)
		{
			int x;
			int y;

			if(imgSize.Width != cropSize.Width)
			{
				throw new ArgumentException(string.Format
				(
					"For a vertical crop, current width ({0}) must match desired cropped width ({1}).",
					imgSize.Width,
					cropSize.Width
				));
			}
			else if(imgSize.Height < cropSize.Height)
			{
				throw new ArgumentException(string.Format
				(
					"For a vertical crop, current height ({0}) must be greater than desired cropped height ({1}).",
					imgSize.Height,
					cropSize.Height
				));
			}

			switch(verticalCropOption)
			{
				case VerticalCropping.Top:
					x = 0;
					y = 0;
					break;
				case VerticalCropping.Bottom:
					x = 0;
					y = imgSize.Height - cropSize.Height;
					break;
				default: // VerticalCropping.Center:
					x = 0;
					y = (imgSize.Height - cropSize.Height) / 2;
					break;
			}

			return new Rectangle(x, y, cropSize.Width, cropSize.Height);
		}

		private static Size GetImageScaleSize(Size imgSize, Size croppedSize)
		{
			int sourceWidth = imgSize.Width;
			int sourceHeight = imgSize.Height;

			float nPercent = 0;
			float nPercentW = 0;
			float nPercentH = 0;

			nPercentW = ((float)croppedSize.Width / (float)sourceWidth);
			nPercentH = ((float)croppedSize.Height / (float)sourceHeight);

			int destWidth;
			int destHeight;

			if(nPercentH > nPercentW)
			{
				nPercent = nPercentH;
				destHeight = croppedSize.Height;
				destWidth = (int)(sourceWidth * nPercent);
			}
			else
			{
				nPercent = nPercentW;
				destHeight = (int)(sourceHeight * nPercent);
				destWidth = croppedSize.Width;
			}

			return new Size(destWidth, destHeight);
		}

		private void JordanDunkToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (mJordanDunkToolStripMenuItem.Text == "Watch Jordan Dunk")
			{
				StartJordanDunkClip();
			}
			else
			{
				StopJordanDunkClip();
			}
		}

		public Main()
		{
			InitializeComponent();
			DisableControls();
			PopulateJordanDunks();
			mCropSize = new Size(SystemInformation.PrimaryMonitorSize.Width, SystemInformation.PrimaryMonitorSize.Height);
			mWidthTextBox.Text = mCropSize.Width.ToString();
			mHeightTextBox.Text = mCropSize.Height.ToString();
			mHeightTextBox.ValueChanged += CropSizeTextBox_ValueChanged;
			mWidthTextBox.ValueChanged += CropSizeTextBox_ValueChanged;
		}

		private void OpenPicture()
		{
			OpenFileDialog openPictureDialog = new OpenFileDialog();
			openPictureDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
			openPictureDialog.Filter = "Picture files (*.jpg)|*.jpg|All files (*.*)|*.*";
			openPictureDialog.FilterIndex = 1;
			openPictureDialog.RestoreDirectory = false;

			if(openPictureDialog.ShowDialog() == DialogResult.OK)
			{
				EnableControls();

				FileInfo fileInfo = new FileInfo(openPictureDialog.FileName);
				mSavePictureToolStripMenuItem.Text = "Save " + fileInfo.Name + " as...";
				mOpenImage = Image.FromFile(openPictureDialog.FileName);
				mOpenImage.Tag = fileInfo; // want to remember where it was located and what it's name is.

				UpdatePreviewBox();
			}
		}

		private void OpenPictureButton_Click(object sender, EventArgs e)
		{
			OpenPicture();
		}

		private void OpenPictureToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenPicture();
		}

		private void PopulateJordanDunks()
		{
			for(int i = mJordanDunkStartIndex; i < mJordanDunkStopIndex; i++)
			{
				mJordanDunks[i - mJordanDunkStartIndex] = (Bitmap)(JordanDunk.ResourceManager.GetObject("dunks" + i));
			}
		}

		private void SavePicture()
		{
			SaveFileDialog saveDialog = new SaveFileDialog();
			saveDialog.InitialDirectory = Environment.CurrentDirectory;
			saveDialog.Filter = "Picture files (*.jpg)|*.jpg|All files (*.*)|*.*";
			saveDialog.FilterIndex = 1;
			saveDialog.RestoreDirectory = false;

			// remove the extension from the name and add the new dimensions to the new name.
			saveDialog.FileName = BuildFileName
			(
				((FileInfo)mOpenImage.Tag).Name,
				((FileInfo)mOpenImage.Tag).Extension,
				"_" + mModifiedImage.Width + "x" + mModifiedImage.Height
			);

			if(saveDialog.ShowDialog() == DialogResult.OK)
			{

			}
		}

		private void SavePictureButton_Click(object sender, EventArgs e)
		{
			SavePicture();
		}

		private void SavePictureToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SavePicture();
		}

		private void SetAsWallpaper()
		{

		}

		private void SetAsWallpaperButton_Click(object sender, EventArgs e)
		{
			SetAsWallpaper();
		}

		private void SetAsWallpaperToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SetAsWallpaper();
		}

		private void SetPictureBoxWidth(Image currentImage)
		{
			int height = currentImage.Height;
			int width = currentImage.Width;

			mPicturePreviewBox.Width = width * mPicturePreviewBox.Height / height;
		}

		private void StartJordanDunkClip()
		{
			if(mOpenImage != null)
			{
				DisableControls();
			}
			mPicturePreviewBox.Focus();
			mOpenPictureToolStripMenuItem.Enabled = false;
			mOpenPictureButton.Enabled = false;

			// play the clip
			mJordanDunkToolStripMenuItem.Text = "Stop Jordan Dunk";
			mJordanDunkIndex = 0;

			SetPictureBoxWidth(mJordanDunks[mJordanDunkIndex]);

			mTimer.Start();
		}

		private void StopJordanDunkClip()
		{
			if(mTimer.Enabled)
			{
				mTimer.Stop();
			}

			if(mOpenImage != null)
			{
				SetPictureBoxWidth(mModifiedImage);
				EnableControls();
			}
			mOpenPictureToolStripMenuItem.Enabled = true;
			mOpenPictureButton.Enabled = true;
			mOpenPictureButton.Focus();

			mPicturePreviewBox.Image = mModifiedImage;
			mJordanDunkToolStripMenuItem.Text = "Watch Jordan Dunk";
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			if(mJordanDunkIndex < mJordanDunks.Length)
				mPicturePreviewBox.Image = mJordanDunks[mJordanDunkIndex++];
			else
				StopJordanDunkClip();
		}

		private void UpdatePreviewBox()
		{
			// Prevent recurrency. This method is called from the selected cropping changed handler, which can be raised below.
			if(mIsPreviewBoxUpdating)
				return;

			mIsPreviewBoxUpdating = true;
			Size scaleSize = GetImageScaleSize(mOpenImage.Size, mCropSize);
			Rectangle cropArea = Rectangle.Empty;

			if(scaleSize.Width > mCropSize.Width) // Are we cropping vertically or horizontally
			{
				// Is this first time we are showing or is cropping option switching boundries
				if(mCroppingOptionComboBox.Tag == null || mCroppingOptionComboBox.Tag is VerticalCropping)
				{
					mCroppingOptionComboBox.Tag = HoriztonalCropping.Center;
					mCroppingOptionComboBox.DataSource = Enum.GetValues(typeof(HoriztonalCropping));
					mCroppingOptionComboBox.Text = Enum.GetName(typeof(HoriztonalCropping), mCroppingOptionComboBox.Tag);
				}
				else
				{
					mCroppingOptionComboBox.Tag = (HoriztonalCropping)Enum.Parse(typeof(HoriztonalCropping), mCroppingOptionComboBox.Text);
				}

				cropArea = GetImageCropRectangle(scaleSize, mCropSize, (HoriztonalCropping)mCroppingOptionComboBox.Tag);
			}
			else
			{
				// Is this first time we are showing or is cropping option switching boundries
				if(mCroppingOptionComboBox.Tag == null || mCroppingOptionComboBox.Tag is HoriztonalCropping)
				{
					mCroppingOptionComboBox.Tag = VerticalCropping.Center;
					mCroppingOptionComboBox.DataSource = Enum.GetValues(typeof(VerticalCropping));
					mCroppingOptionComboBox.Text = Enum.GetName(typeof(VerticalCropping), mCroppingOptionComboBox.Tag);
				}
				else
				{
					mCroppingOptionComboBox.Tag = (VerticalCropping)Enum.Parse(typeof(VerticalCropping), mCroppingOptionComboBox.Text);
				}

				cropArea = GetImageCropRectangle(scaleSize, mCropSize, (VerticalCropping)mCroppingOptionComboBox.Tag);
			}

			mModifiedImage = ImageEditing.ScaleImage(mOpenImage, scaleSize);
			mModifiedImage = ImageEditing.CropImage(mModifiedImage, cropArea);

			SetPictureBoxWidth(mModifiedImage);
			mPicturePreviewBox.Image = mModifiedImage;

			mIsPreviewBoxUpdating = false;
		}

		#endregion Methods

	}
}