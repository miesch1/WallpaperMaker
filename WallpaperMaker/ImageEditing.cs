// http://jigneshon.blogspot.com/2013/08/c-tutorial-image-editing-saving.html
// https://docs.microsoft.com/en-us/dotnet/api/system.drawing.image.save?view=netframework-4.7.2#System_Drawing_Image_Save_System_String_System_Drawing_Imaging_ImageCodecInfo_System_Drawing_Imaging_EncoderParameters_

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace WindowsApplication1
{
	public class ImageEditing
	{
		#region Methods

		public static Image CropImage(Image img, Rectangle cropArea)
		{
			Bitmap bmpImage = new Bitmap(img);
			Bitmap bmpCrop = bmpImage.Clone(cropArea, bmpImage.PixelFormat);

			return (Image)bmpCrop;
		}

		private static ImageCodecInfo GetEncoderInfo(string mimeType)
		{
			int j;
			ImageCodecInfo[] encoders;
			encoders = ImageCodecInfo.GetImageEncoders();
			for(j = 0; j < encoders.Length; ++j)
			{
				if(encoders[j].MimeType == mimeType)
					return encoders[j];
			}
			return null;
		}

		public static void SaveImage(Image img, string fileName)
		{
			// Get an ImageCodecInfo object that represents the JPEG codec.
			ImageCodecInfo imageCodecInfo = GetEncoderInfo("image/jpeg");
			if(imageCodecInfo == null)
			{
				throw new InvalidOperationException("jpeg is not a supported image codec.");
			}

			// Create an Encoder object based on the GUID  for the Quality parameter category.
			Encoder encoder = Encoder.Quality;

			// Create an EncoderParameters object.
			// An EncoderParameters object has an array of EncoderParameter objects. In this case, there is only one EncoderParameter object in the array.
			EncoderParameters encoderParameters = new EncoderParameters(1);

			// Save the bitmap as a JPEG file with quality level 90.
			EncoderParameter encoderParameter = new EncoderParameter(encoder, 90L);
			encoderParameters.Param[0] = encoderParameter;

			img.Save(fileName, imageCodecInfo, encoderParameters);
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
