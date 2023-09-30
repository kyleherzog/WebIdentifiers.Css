﻿// <autogenerated/>
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the ScrollbarColor property.
/// </summary>
public partial class ScrollbarColorProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a scrollbar-color CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public ScrollbarColorProperty(string? value = null)
		: base(CssPropertyNames.ScrollbarColor, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>auto</c>. The user agent determines the colors of the scrollbar. It should follow platform conventions, but may adjust the colors in accordance with color-scheme or other contextual information to better suit the page.
	/// </summary>
	public ScrollbarColorProperty SetToAuto()
	{
		Value = CssValues.Auto;
		return this;
	}


}