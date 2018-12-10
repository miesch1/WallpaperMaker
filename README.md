# WallpaperMaker
This is a program I started with my brother Scott for his first program. That was in ca. 2013, so I figured it was about time
to finally finish it. He is the inspiration for the Jordan theme!

I am particular about the wallpapers I set on my Windows desktop. I like to properly size the images to the correct dimensions
before setting them. Yes, this is easy to do with image editing software such as Photoshop, etc. First, I have to scale an image
down to the lowest dimension of my screen (either horizontal or vertical), then crop off the extra pixels (either vertical or
horizontal). This process takes a non-negligible amount of time, so Scott and I decided to automate it.

WallpaperMaker started out as an easy way to save off the scaled and cropped images for my desktop slideshow. Since Windows 7,
I've had my desktop slideshow pointed at a folder of images that I am constantly adding to and removing from. Much better than a
single static background, in my opinion! However, WallpaperMaker supports adding the currently selected image as the static
background for those who disagree.

WallpaperMaker is intended to be as simple as possible. Point it to any image supported on your system. Choose a desired width
and height of your image (default is the resolution of your primary monitor). If the image needs to be cropped vertically, select
Top, Bottom, or leave the default Center option. If the image needs to be cropped horizontally, select Right, Left, or leave the 
default Center option. A preview box shows you the resulting image. If you want to save the modified picture, select Save Picture.
If you want to set the background with the currently modified image, click Set As Wallpaper. Easy as that.

![alt text](https://github.com/miesch1/WallpaperMaker/blob/master/screenshot.png "WallpaperMaker screenshot")

The API actually supports multiple options for setting the wallpaper, but the GUI does not expose those options. The image is
simply centered on all monitors. Future updates could expose those options, if necessary.

This application has several noteworthy features:
* Dynamically builds the list of supported image file types to open a save, based on available encoders and decoders on the system.
* Supports setting the desktop using the legacy API for OSs before Windows 8.
* Offers a COM interop solution for using the new IDesktopWallpaper API for OSs starting with Windows 8. Did not have to generate
the interop code myself. Rather, used an IDL file from the Windows 10 SDK to generate a TLB, then a DLL. Interop types are merged into
my application.

Current limitations:
* Have not tested on Vista, Windows 8, or Windows 8.1.
* Set As Wallpaper only supports setting static images.
* Set As Wallpaper always sets the same image to all monitors. Even though other positions are supported, Centered is used for how
Windows treats the wallpaper (as opposed to stretch, tile, etc.).

Special thanks:
* Used icons from the famfamfam silk v013 set.
* MJ for gracing the world with his amazing Foul Line Dunk, which you can view from the Extras dropdown.
