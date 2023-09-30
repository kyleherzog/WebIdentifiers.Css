﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the TextOrientation property.
/// </summary>
public partial class TextOrientationProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a text-orientation CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public TextOrientationProperty(string? value = null)
		: base(CssPropertyNames.TextOrientation, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>mixed</c>. Typographic character units from horizontal-only scripts are typeset sideways, i.e. 90° clockwise from their standard orientation in horizontal text. Typographic character units from vertical scripts are typeset with their intrinsic orientation. See Vertical Orientations for further details. This value is typical for layout of dominantly vertical-script text.
	/// </summary>
	public TextOrientationProperty SetToMixed()
	{
		Value = CssValues.Mixed;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>sideways</c>. Causes all text to be typeset sideways, as if in a horizontal layout, but rotated 90° clockwise.
	/// </summary>
	public TextOrientationProperty SetToSideways()
	{
		Value = CssValues.Sideways;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>sideways-right</c>. UAs may accept sideways-right as a value that computes to sideways if needed for backward compatibility reasons.
	/// </summary>
	public TextOrientationProperty SetToSidewaysRight()
	{
		Value = CssValues.SidewaysRight;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>upright</c>. Typographic character units from horizontal-only scripts are typeset upright, i.e. in their standard horizontal orientation. Typographic character units from vertical scripts are typeset with their intrinsic orientation and shaped normally. See Vertical Orientations for further details. This value causes the used value of direction to be ltr, and for the purposes of bidi reordering, causes all characters to be treated as strong LTR.
	/// </summary>
	public TextOrientationProperty SetToUpright()
	{
		Value = CssValues.Upright;
		return this;
	}


}