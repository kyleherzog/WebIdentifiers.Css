﻿// <autogenerated/>
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the FontKerning property.
/// </summary>
public partial class FontKerningProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a font-kerning CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public FontKerningProperty(string? value = null)
		: base(CssPropertyNames.FontKerning, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>auto</c>. Specifies that kerning is applied at the discretion of the user agent
	/// </summary>
	public FontKerningProperty SetToAuto()
	{
		Value = CssValues.Auto;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>none</c>. Specifies that kerning is not applied
	/// </summary>
	public FontKerningProperty SetToNone()
	{
		Value = CssValues.None;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>normal</c>. Specifies that kerning is applied
	/// </summary>
	public FontKerningProperty SetToNormal()
	{
		Value = CssValues.Normal;
		return this;
	}


}