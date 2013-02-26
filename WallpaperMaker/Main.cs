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

		private int mJordanDunkIndex;

		private Image[] mJordanDunks = new Image[mJordanDunkStopIndex - mJordanDunkStartIndex];

		private const int mJordanDunkStartIndex = 1645;

		private const int mJordanDunkStopIndex = 1832;

		private Image mModifiedPicture;

		private Image mOpenedPicture;

		#endregion Fields

		#region Methods

		public Main()
		{
			InitializeComponent();
			mHeightTextBox.Text = SystemInformation.PrimaryMonitorSize.Height.ToString();
			mWidthTextBox.Text = SystemInformation.PrimaryMonitorSize.Width.ToString();
			DisableControls();
			PopulateJordanDunks();
		}

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

		private void ClosePictureButton_Click(object sender, EventArgs e)
		{
			DisableControls();
			mPicturePreviewBox.Image = null;
		}

		private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DisableControls();
			mPicturePreviewBox.Image = null;
		}

		private void CroppingOptionComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			Size newSize = new Size(Convert.ToInt32(mWidthTextBox.Text), Convert.ToInt32(mHeightTextBox.Text));

			// crop and scale the image
			if(newSize.Height > newSize.Width)
			{
				mModifiedPicture = ImageEditing.ResizeImage
				(
					mOpenedPicture,
					newSize,
					(VerticalCropping)Enum.Parse(typeof(VerticalCropping), mCroppingOptionComboBox.Text)
				);
			}
			else
			{
				mModifiedPicture = ImageEditing.ResizeImage
				(
					mOpenedPicture,
					newSize,
					(HoriztonalCropping)Enum.Parse(typeof(HoriztonalCropping), mCroppingOptionComboBox.Text)
				);
			}
		}

		private void EnableControls()
		{
			mHeightTextBox.ReadOnly = false;
			mWidthTextBox.ReadOnly = false;
			mClosePictureButton.Enabled = true;
			mSavePictureButton.Enabled = true;
			mSetWallpaperButton.Enabled = true;
			mCroppingOptionComboBox.Enabled = true;
			mCloseToolStripMenuItem.Enabled = true;
			mSaveAsToolStripMenuItem.Enabled = true;
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

		private void DisableControls()
		{
			mOpenPictureButton.Focus();

			mHeightTextBox.ReadOnly = true;
			mWidthTextBox.ReadOnly = true;
			mClosePictureButton.Enabled = false;
			mSavePictureButton.Enabled = false;
			mSetWallpaperButton.Enabled = false;
			mCroppingOptionComboBox.Enabled = false;
			mCloseToolStripMenuItem.Enabled = false;
			mSaveAsToolStripMenuItem.Enabled = false;
			mSetAsWallpaperToolStripMenuItem.Enabled = false;
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

		private void OpenPictureButton_Click(object sender, EventArgs e)
		{
			OpenPictureForEditing();
		}

		private void OpenPictureForEditing()
		{
			OpenFileDialog openPictureDialog = new OpenFileDialog();
			openPictureDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
			openPictureDialog.Filter = "Picture files (*.jpg)|*.jpg|All files (*.*)|*.*";
			openPictureDialog.FilterIndex = 1;
			openPictureDialog.RestoreDirectory = false;

			if(openPictureDialog.ShowDialog() == DialogResult.OK)
			{
				EnableControls();
				mJordanDunkToolStripMenuItem.Checked = false;

				FileInfo fileInfo = new FileInfo(openPictureDialog.FileName);
				mSaveAsToolStripMenuItem.Text = "Save " + fileInfo.Name + " as...";
				mOpenedPicture = Image.FromFile(openPictureDialog.FileName);
				mOpenedPicture.Tag = fileInfo; // want to remember where it was located and what it's name is.

				SetPictureBoxWidth(mOpenedPicture);

				if(mPreviewGroupBox.Height > mPreviewGroupBox.Width)
				{
					mCroppingOptionComboBox.DataSource = Enum.GetValues(typeof(VerticalCropping));
					mCroppingOptionComboBox.Text = Enum.GetName(typeof(VerticalCropping), VerticalCropping.Center);
				}
				else
				{
					mCroppingOptionComboBox.DataSource = Enum.GetValues(typeof(HoriztonalCropping));
					mCroppingOptionComboBox.Text = Enum.GetName(typeof(HoriztonalCropping), HoriztonalCropping.Center);
				}

				mPicturePreviewBox.Image = mModifiedPicture;
			}
		}

		private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenPictureForEditing();
		}

		private void PopulateJordanDunks()
		{
			for(int i = mJordanDunkStartIndex; i < mJordanDunkStopIndex; i++)
			{
				mJordanDunks[i - mJordanDunkStartIndex] = (Bitmap)(JordanDunk.ResourceManager.GetObject("dunks" + i));
			}
		}

		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SavePicture();
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
				((FileInfo)mOpenedPicture.Tag).Name,
				((FileInfo)mOpenedPicture.Tag).Extension,
				"_" + mModifiedPicture.Width + "x" + mModifiedPicture.Height
			);

			if(saveDialog.ShowDialog() == DialogResult.OK)
			{

			}
		}

		private void SavePictureButton_Click(object sender, EventArgs e)
		{
			SavePicture();
		}

		private void SetAsWallpaperButton_Click(object sender, EventArgs e)
		{

		}

		private void SetAsWallpaperToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void SetPictureBoxWidth(Image currentImage)
		{
			int height = currentImage.Height;
			int width = currentImage.Width;

			mPreviewGroupBox.Width = width * mPicturePreviewBox.Height / height + mPreviewGroupBox.Margin.Horizontal;
		}

		private void StartJordanDunkClip()
		{
			if(mOpenedPicture != null)
			{
				DisableControls();
			}
			mPicturePreviewBox.Focus();
			mOpenToolStripMenuItem.Enabled = false;
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

			if(mOpenedPicture != null)
			{
				SetPictureBoxWidth(mOpenedPicture);
				EnableControls();
			}
			mOpenToolStripMenuItem.Enabled = true;
			mOpenPictureButton.Enabled = true;
			mOpenPictureButton.Focus();

			mPicturePreviewBox.Image = mModifiedPicture;
			mJordanDunkToolStripMenuItem.Text = "Watch Jordan Dunk";
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			if(mJordanDunkIndex < mJordanDunks.Length)
				mPicturePreviewBox.Image = mJordanDunks[mJordanDunkIndex++];
			else
				StopJordanDunkClip();
		}

		#endregion Methods
	}
}