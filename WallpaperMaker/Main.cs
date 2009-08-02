using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsApplication1
{
	public partial class Main : Form
	{
		Image openedPicture;
		Image modifiedPicture;

		public Main()
		{
			InitializeComponent();
			heightTextBox.Text = SystemInformation.PrimaryMonitorSize.Height.ToString();
			widthTextBox.Text = SystemInformation.PrimaryMonitorSize.Width.ToString();

			DisableControls();
		}

		private void DisableControls()
		{
			heightTextBox.ReadOnly = true;
			widthTextBox.ReadOnly = true;
			flowLayoutPanel1.Enabled = false;
			comboBox1.Enabled = false;
			button1.Enabled = false;
			saveAsToolStripMenuItem.Enabled = false;
			setAsWallpaperToolStripMenuItem.Enabled = false;
		}

		private void openPictureButton_Click(object sender, EventArgs e)
		{
			OpenPictureForEditing();
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
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
				jordanDunkToolStripMenuItem.Checked = false;

				FileInfo fileInfo = new FileInfo(openPictureDialog.FileName);
				saveAsToolStripMenuItem.Text = "Save " + fileInfo.Name + " as...";
				openedPicture = Image.FromFile(openPictureDialog.FileName);
				openedPicture.Tag = fileInfo; // want to remember where it was located and what it's name is.

				int height = openedPicture.Height;
				int width = openedPicture.Width;

				previewGroupBox.Width = width * picturePreview.Height / height + previewGroupBox.Margin.Horizontal;

				// crop and scale the image
				modifiedPicture = ImageEditing.resizeImage(openedPicture, new Size(Convert.ToInt32(widthTextBox.Text), Convert.ToInt32(heightTextBox.Text)));

				picturePreview.Image = modifiedPicture;
			}
		}

		private void EnableControls()
		{
			heightTextBox.ReadOnly = false;
			widthTextBox.ReadOnly = false;
			flowLayoutPanel1.Enabled = true;
			comboBox1.Enabled = true;
			button1.Enabled = true;
			saveAsToolStripMenuItem.Enabled = true;
			setAsWallpaperToolStripMenuItem.Enabled = true;
		}

		private void jordanDunkToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(jordanDunkToolStripMenuItem.Checked)
			{
				// play the clip
				DisableControls();
				picturePreview.Image = null;
			}
			else
			{
				// stop the clip

				picturePreview.Image = modifiedPicture;
				EnableControls();

			}
		}

		private void savePictureButton_Click(object sender, EventArgs e)
		{
			SavePicture();
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
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
			saveDialog.FileName = FileNameBuilder
			(
				((FileInfo)openedPicture.Tag).Name,
				((FileInfo)openedPicture.Tag).Extension,
				"_" + modifiedPicture.Width + "x" + modifiedPicture.Height
			);

			if(saveDialog.ShowDialog() == DialogResult.OK)
			{

			}
		}

		/// <summary>
		///   If the replaceString is not found, the newString will be appended to the fileName.
		/// </summary>
		/// 
		/// <param name="fileName"></param>
		/// <param name="replaceString"></param>
		/// <param name="newString"></param>
		/// <returns></returns>
		private string FileNameBuilder(string fileName, string replaceString, string newString)
		{
			string returnString;

			if(replaceString != "" && fileName.Contains(replaceString))
				returnString = fileName.Replace(replaceString, newString);
			else
				returnString = fileName + newString;

			return returnString;
		}

		private void setWallpaperButton_Click(object sender, EventArgs e)
		{

		}
	}
}