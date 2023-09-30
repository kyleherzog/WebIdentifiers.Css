﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the ShapeOutside property.
/// </summary>
public partial class ShapeOutsideProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a shape-outside CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public ShapeOutsideProperty(string? value = null)
		: base(CssPropertyNames.ShapeOutside, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>none</c>. The float area is unaffected.
	/// </summary>
	public ShapeOutsideProperty SetToNone()
	{
		Value = CssValues.None;
		return this;
	}


}