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
			Bitmap bmpCrop = bmpImage.Clone(cropArea,
			bmpImage.PixelFormat);
			return (Image)(bmpCrop);
		}

		public static Image ResizeImage(Image imgToResize, Size size, Main.HoriztonalCropping horizontalCroppingOption)
		{
			int sourceWidth = imgToResize.Width;
			int sourceHeight = imgToResize.Height;

			float nPercent = 0;
			float nPercentW = 0;
			float nPercentH = 0;

			nPercentW = ((float)size.Width / (float)sourceWidth);
			nPercentH = ((float)size.Height / (float)sourceHeight);

			int destWidth;
			int destHeight;

			if(nPercentH > nPercentW)
			{
				nPercent = nPercentH;
				destHeight = size.Height;
				destWidth = (int)(sourceWidth * nPercent);
			}
			else
			{
				nPercent = nPercentW;
				destHeight = (int)(sourceHeight * nPercent);
				destWidth = size.Width;
			}

			Bitmap b = new Bitmap(destWidth, destHeight);
			Graphics g = Graphics.FromImage((Image)b);
			g.InterpolationMode = InterpolationMode.HighQualityBicubic;

			g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
			g.Dispose();

			return (Image)b;
		}

		public static Image ResizeImage(Image imgToResize, Size size, Main.VerticalCropping verticalCroppingOption)
		{
			int sourceWidth = imgToResize.Width;
			int sourceHeight = imgToResize.Height;

			float nPercent = 0;
			float nPercentW = 0;
			float nPercentH = 0;

			nPercentW = ((float)size.Width / (float)sourceWidth);
			nPercentH = ((float)size.Height / (float)sourceHeight);

			int destWidth;
			int destHeight;

			if(nPercentH > nPercentW)
			{
				nPercent = nPercentH;
				destHeight = size.Height;
				destWidth = (int)(sourceWidth * nPercent);
			}
			else
			{
				nPercent = nPercentW;
				destHeight = (int)(sourceHeight * nPercent);
				destWidth = size.Width;
			}

			Bitmap b = new Bitmap(destWidth, destHeight);
			Graphics g = Graphics.FromImage((Image)b);
			g.InterpolationMode = InterpolationMode.HighQualityBicubic;

			g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
			g.Dispose();

			return (Image)b;
		}

		#endregion Methods
	}
}
