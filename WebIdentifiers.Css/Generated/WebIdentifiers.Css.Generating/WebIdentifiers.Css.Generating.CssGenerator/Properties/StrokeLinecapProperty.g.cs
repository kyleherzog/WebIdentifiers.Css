﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the StrokeLinecap property.
/// </summary>
public partial class StrokeLinecapProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a stroke-linecap CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public StrokeLinecapProperty(string? value = null)
		: base(CssPropertyNames.StrokeLinecap, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>butt</c>. The stroke for each subpath does not extend beyond its two endpoints. (A zero length subpath will therefore not have any stroke.)
	/// </summary>
	public StrokeLinecapProperty SetToButt()
	{
		Value = CssValues.Butt;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>round</c>. At each end of each subpath, the stroke is extended by a half circle with a radius equal to half the stroke width. (The stroke for a zero-length subpath is a full circle centered at the subpath’s point.)
	/// </summary>
	public StrokeLinecapProperty SetToRound()
	{
		Value = CssValues.Round;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>square</c>. At the end of each subpath, the stroke is extended by a rectangle with the same width as the stroke width and whose length is half of the stroke width. (The stroke for a zero-length subpath is a square with side length equal to the stroke width, centered at the subpath’s point, and oriented such that two of its sides are parallel to the effective tangent at that subpath’s point. See § 4.6 Computing the Shape of the Stroke for details on how to determine the tangent at a zero-length subpath.) Adding a rectangle to the end of dashes on a curved outline looks bad. It should just extend the dash by stroke-width/2, following the outline.
	/// </summary>
	public StrokeLinecapProperty SetToSquare()
	{
		Value = CssValues.Square;
		return this;
	}


}