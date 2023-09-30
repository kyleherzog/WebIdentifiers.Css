﻿// <autogenerated/>
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the Bottom property.
/// </summary>
public partial class BottomProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a bottom CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public BottomProperty(string? value = null)
		: base(CssPropertyNames.Bottom, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>auto</c>. Represents an unconstrained inset; the exact meaning depends on the positioning scheme.
	/// </summary>
	public BottomProperty SetToAuto()
	{
		Value = CssValues.Auto;
		return this;
	}


}