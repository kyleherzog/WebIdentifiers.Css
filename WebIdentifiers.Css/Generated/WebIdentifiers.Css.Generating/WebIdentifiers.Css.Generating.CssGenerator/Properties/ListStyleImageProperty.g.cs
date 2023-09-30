﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the ListStyleImage property.
/// </summary>
public partial class ListStyleImageProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a list-style-image CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public ListStyleImageProperty(string? value = null)
		: base(CssPropertyNames.ListStyleImage, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>none</c>. The element has no marker image.
	/// </summary>
	public ListStyleImageProperty SetToNone()
	{
		Value = CssValues.None;
		return this;
	}


}