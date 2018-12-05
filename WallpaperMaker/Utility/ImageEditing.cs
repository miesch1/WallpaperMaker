// http://jigneshon.blogspot.com/2013/08/c-tutorial-image-editing-saving.html
// https://docs.microsoft.com/en-us/dotnet/api/system.drawing.image.save?view=netframework-4.7.2#System_Drawing_Image_Save_System_String_System_Drawing_Imaging_ImageCodecInfo_System_Drawing_Imaging_EncoderParameters_

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace WallpaperMaker.Utility
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

		public static string GetSupportedDecodersFilter()
		{
			System.Text.StringBuilder filter = new System.Text.StringBuilder();
			ImageCodecInfo[] decoders = ImageCodecInfo.GetImageDecoders();

			// Add JPG first
			int i;
			for(i = 0; i < decoders.Length - 1; i++)
			{
				if(decoders[i].FormatDescription == "JPEG")
				{
					WriteSingleFilter(decoders[i], ref filter);
					filter.Append("|");

					break;
				}
			}

			// Add remaining
			for(int j = 0; j < decoders.Length - 1; j++)
			{
				// Skip JPG already added
				if(j == i)
					continue;

				WriteSingleFilter(decoders[j], ref filter);
				filter.Append("|");
			}

			filter.Append("All files (*.*)|*.*");
			return filter.ToString();
		}

		public static string GetSupportedEncodersFilter()
		{
			System.Text.StringBuilder filter = new System.Text.StringBuilder();
			ImageCodecInfo[] encoders = ImageCodecInfo.GetImageEncoders();

			// Add JPG first
			int i;
			for(i = 0; i < encoders.Length - 1; i++)
			{
				if(encoders[i].FormatDescription == "JPEG")
				{
					WriteSingleFilter(encoders[i], ref filter);
					filter.Append("|");

					break;
				}
			}

			// Add remaining
			for(int j = 0; j < encoders.Length - 1; j++)
			{
				// Skip JPG already added
				if(j == i)
					continue;

				WriteSingleFilter(encoders[j], ref filter);
				filter.Append("|");
			}

			filter.Append("All files (*.*)|*.*");
			return filter.ToString();
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
			string extension = Path.GetExtension(fileName);

			// Create an Encoder object based on the GUID  for the Quality parameter category.
			Encoder encoder = Encoder.Quality;

			ImageCodecInfo[] encoders = ImageCodecInfo.GetImageEncoders();
			ImageCodecInfo imageCodecInfo = null;
			EncoderParameter encoderParameter = null;
			for(int j = 0; j < encoders.Length - 1; j++)
			{
				if(encoders[j].FilenameExtension.IndexOf(extension, StringComparison.OrdinalIgnoreCase) >= 0)
				{
					imageCodecInfo = encoders[j];
					if(imageCodecInfo.FormatDescription == "JPEG")
					{
						// Save the jpg with quality level 90. (0-100)
						encoderParameter = new EncoderParameter(encoder, 90L);
					}
					else
					{
						// Value ignored, but need the encoder.
						encoderParameter = new EncoderParameter(encoder, 0L);
					}
					break;
				}
			}

			if(imageCodecInfo == null)
			{
				img.Save(fileName);
			}
			else
			{
				// Create an EncoderParameters object.
				// An EncoderParameters object has an array of EncoderParameter objects. In this case, there is only one EncoderParameter object in the array.
				EncoderParameters encoderParameters = new EncoderParameters(1);
				encoderParameters.Param[0] = encoderParameter;

				img.Save(fileName, imageCodecInfo, encoderParameters);
			}
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

		private static void WriteSingleFilter(ImageCodecInfo coder, ref System.Text.StringBuilder filter)
		{
			filter.Append(coder.FormatDescription);
			filter.Append(" (");
			filter.Append(coder.FilenameExtension);
			filter.Append(")|");
			filter.Append(coder.FilenameExtension);
		}

		#endregion Methods
	}
}
