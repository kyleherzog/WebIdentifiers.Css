﻿// <autogenerated/>
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the MaskClip property.
/// </summary>
public partial class MaskClipProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a mask-clip CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public MaskClipProperty(string? value = null)
		: base(CssPropertyNames.MaskClip, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>border-box</c>. The painted content is restricted to (clipped to) the border box.
	/// </summary>
	public MaskClipProperty SetToBorderBox()
	{
		Value = CssValues.BorderBox;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>content-box</c>. The painted content is restricted to (clipped to) the content box.
	/// </summary>
	public MaskClipProperty SetToContentBox()
	{
		Value = CssValues.ContentBox;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>fill-box</c>. The painted content is restricted to (clipped to) the object bounding box.
	/// </summary>
	public MaskClipProperty SetToFillBox()
	{
		Value = CssValues.FillBox;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>no-clip</c>. The painted content is not restricted (not clipped).
	/// </summary>
	public MaskClipProperty SetToNoClip()
	{
		Value = CssValues.NoClip;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>padding-box</c>. The painted content is restricted to (clipped to) the padding box.
	/// </summary>
	public MaskClipProperty SetToPaddingBox()
	{
		Value = CssValues.PaddingBox;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>stroke-box</c>. The painted content is restricted to (clipped to) the stroke bounding box.
	/// </summary>
	public MaskClipProperty SetToStrokeBox()
	{
		Value = CssValues.StrokeBox;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>view-box</c>. Uses the nearest SVG viewport as reference box. If a viewBox attribute is specified for the SVG viewport creating element: The reference box is positioned at the origin of the coordinate system established by the viewBox attribute. The dimension of the reference box is set to the width and height values of the viewBox attribute.
	/// </summary>
	public MaskClipProperty SetToViewBox()
	{
		Value = CssValues.ViewBox;
		return this;
	}


}