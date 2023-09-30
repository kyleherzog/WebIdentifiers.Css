﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the StrokeDasharray property.
/// </summary>
public partial class StrokeDasharrayProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a stroke-dasharray CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public StrokeDasharrayProperty(string? value = null)
		: base(CssPropertyNames.StrokeDasharray, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>none</c>. No dashing: the stroke is drawn continuously.
	/// </summary>
	public StrokeDasharrayProperty SetToNone()
	{
		Value = CssValues.None;
		return this;
	}


}