﻿// <autogenerated/>
namespace WebIdentifiers.Css.Values;

public partial class ImageResolutionValues : PropertyValuesBase
{
	/// <summary>
	/// Gets the name of the <c>from-image</c> property. The image’s preferred resolution is taken as that specified by the image format (the natural resolution). If the image does not specify its own resolution, the explicitly specified resolution is used (if given), else it defaults to 1dppx.
	/// </summary>
	public string FromImage => CssValues.FromImage;

	/// <summary>
	/// Gets the name of the <c>snap</c> property. If the "snap" keyword is provided, the computed <resolution> (if any) is the specified resolution rounded to the nearest value that would map one image pixel to an integer number of device pixels. If the resolution is taken from the image, then the used natural resolution is the image’s native resolution similarly adjusted.
	/// </summary>
	public string Snap => CssValues.Snap;

}