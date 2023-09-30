﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the ClipPath property.
/// </summary>
public partial class ClipPathProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a clip-path CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public ClipPathProperty(string? value = null)
		: base(CssPropertyNames.ClipPath, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>fill-box</c>. Uses the object bounding box as reference box.
	/// </summary>
	public ClipPathProperty SetToFillBox()
	{
		Value = CssValues.FillBox;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>stroke-box</c>. Uses the stroke bounding box as reference box.
	/// </summary>
	public ClipPathProperty SetToStrokeBox()
	{
		Value = CssValues.StrokeBox;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>view-box</c>. Uses the nearest SVG viewport as reference box. If a viewBox attribute is specified for the SVG viewport creating element: The reference box is positioned at the origin of the coordinate system established by the viewBox attribute. The dimension of the reference box is set to the width and height values of the viewBox attribute.
	/// </summary>
	public ClipPathProperty SetToViewBox()
	{
		Value = CssValues.ViewBox;
		return this;
	}


}