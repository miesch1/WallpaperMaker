using ShObjIdlCoreTypeLib;
using System;
using System.Runtime.InteropServices;
using WallpaperMaker.WinAPI;

namespace WallpaperMaker.Utility
{
	//---------------------------------------------------------------------------------------------------------------------------
	/// <summary>
	///   Provides methods that are used to manipulate the desktop wallpaper.
	/// </summary>
	/// 
	/// <remarks>Supported only in Windows 8 and beyond.</remarks>
	//---------------------------------------------------------------------------------------------------------------------------
	public class ShObjIdlCoreHelper
	{
		#region Fields

		//-----------------------------------------------------------------------------------------------------------------------
		/// <summary>
		///   COM interface used to manipulate the desktop wallpaper.
		/// </summary>
		//-----------------------------------------------------------------------------------------------------------------------
		private static IDesktopWallpaper mIDesktopWallpaper;

		#endregion Fields

		#region Methods

		//-----------------------------------------------------------------------------------------------------------------------
		/// <summary>
		///   Initializes a new instance of the <see cref="ShObjIdlCoreHelper"/> class.
		/// </summary>
		/// 
		/// <design>
		///   We are caching the IDesktopWallpaper for easy access later. This does not cache the current state of desktop
		///   wallpaper. This means that future changes could be made to the desktop wallpaper (external to this class,
		///   such a changing the background) and those changes would still reflect in calls into this object.
		/// </design>
		//-----------------------------------------------------------------------------------------------------------------------
		static ShObjIdlCoreHelper()
		{
			mIDesktopWallpaper = null;

			// Get the type of the IDesktopWallpaper COM object, or null if an error occurred.
			Type shObjIdlCoreType = Type.GetTypeFromCLSID(new Guid(ShObjIdlCoreAPI.CLSID_DesktopWallpaper), false);
			if(shObjIdlCoreType != null)
			{
				try
				{
					mIDesktopWallpaper = Activator.CreateInstance(shObjIdlCoreType) as IDesktopWallpaper;
				}
				catch(Exception)
				{
					// Do nothing. If CreateInstance failed, then IDesktopWallpaper is null.
				}
			}
		}

		//-----------------------------------------------------------------------------------------------------------------------
		/// <summary>
		///   Sets the wallpaper to the given <paramref name="fileName"/> for each monitor.
		/// </summary>
		/// 
		/// <exception cref="COMException">Could not create or interact with the required COM object.</exception>
		//-----------------------------------------------------------------------------------------------------------------------
		public static void SetWallpaper(string fileName, DESKTOP_WALLPAPER_POSITION position)
		{
			if(mIDesktopWallpaper == null)
				throw new COMException("Could not create IDesktopWallpaper COM object.");

			try
			{
				// The first parameter indicates the monitor by its identifier (obtained with GetMonitorDevicePathAt) and the
				// second a path to the wallpaper. If NULL is passed as the monitor identifier to SetWallpaper, then that
				// wallpaper will be set for all monitors.
				mIDesktopWallpaper.SetWallpaper(null, fileName);
				mIDesktopWallpaper.SetPosition(position);
			}
			catch(COMException)
			{
				throw;
			}
			catch(Exception e)
			{
				throw new COMException("Could not interact with the IDesktopWallpaper COM object.", e);
			}
		}

		#endregion Methods
	}
}
