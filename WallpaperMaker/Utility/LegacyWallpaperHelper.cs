// https://stackoverflow.com/questions/1061678/change-desktop-wallpaper-using-code-in-net
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace WallpaperMaker.Utility
{
	//---------------------------------------------------------------------------------------------------------------------------
	/// <summary>
	///   Provides methods that are used to manipulate the desktop wallpaper.
	/// </summary>
	/// 
	/// <remarks>For use only in Windows 7 and before.</remarks>
	//---------------------------------------------------------------------------------------------------------------------------
	public class LegacyWallpaperHelper
	{
		private const int SPI_SETDESKWALLPAPER = 0x14;
		private const int SPIF_UPDATEINIFILE = 0x01;
		private const int SPIF_SENDWININICHANGE = 0x02;

		public enum Style
		{
			Centered,
			Tiled,
			Stretched
		}

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

		public static void SetWallpaper(string fileName, Style style)
		{
			RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
			switch(style)
			{
				case Style.Tiled:
					key.SetValue(@"WallpaperStyle", 1.ToString());
					key.SetValue(@"TileWallpaper", 1.ToString());
					break;
				case Style.Stretched:
					key.SetValue(@"WallpaperStyle", 2.ToString());
					key.SetValue(@"TileWallpaper", 0.ToString());
					break;
				default: // Style.Centered:
					key.SetValue(@"WallpaperStyle", 1.ToString());
					key.SetValue(@"TileWallpaper", 0.ToString());
					break;
			}

			SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, fileName, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
		}
	}
}
