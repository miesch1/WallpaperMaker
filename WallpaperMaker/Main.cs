using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

            heightTextBox.ReadOnly = true;
            widthTextBox.ReadOnly = true;
        }

        private void openPictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openPictureDialog = new OpenFileDialog();
            openPictureDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openPictureDialog.Filter = "Picture files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openPictureDialog.FilterIndex = 1;
            openPictureDialog.RestoreDirectory = true;

            if (openPictureDialog.ShowDialog() == DialogResult.OK)
            {
                heightTextBox.ReadOnly = false;
                widthTextBox.ReadOnly = false;

                openedPicture = Image.FromFile(openPictureDialog.FileName);

                int height = openedPicture.Height;
                int width = openedPicture.Width;

                previewGroupBox.Width = width * picturePreview.Height / height + previewGroupBox.Margin.Horizontal;

                // crop and scale the image
                modifiedPicture = ImageEditing.resizeImage(openedPicture, new Size(Convert.ToInt32(widthTextBox.Text), Convert.ToInt32(heightTextBox.Text)));

                picturePreview.Image = modifiedPicture;
            }


        }
    }
}