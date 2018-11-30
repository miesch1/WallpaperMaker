// http://jigneshon.blogspot.com/2013/08/c-tutorial-image-editing-saving.html

using System.Drawing;
using System.Drawing.Drawing2D;

namespace WindowsApplication1
{
	public class ImageEditing
	{
		#region Methods

		public static Image CropImage(Image img, Rectangle cropArea)
		{
			Bitmap bmpImage = new Bitmap(img);
			Bitmap bmpCrop = bmpImage.Clone(cropArea, bmpImage.PixelFormat);

			return (Image)(bmpCrop);
		}

		public static Image ScaleImage(Image img, Size scaledSize)
		{
			Bitmap bmpImage = new Bitmap(scaledSize.Width, scaledSize.Height);
			Graphics graphics = Graphics.FromImage((Image)bmpImage);
			graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

			graphics.DrawImage(img, 0, 0, scaledSize.Width, scaledSize.Height);
			graphics.Dispose();

			return bmpImage;
		}

		#endregion Methods
	}
}
