﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the FontSynthesisSmallCaps property.
/// </summary>
public partial class FontSynthesisSmallCapsProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a font-synthesis-small-caps CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public FontSynthesisSmallCapsProperty(string? value = null)
		: base(CssPropertyNames.FontSynthesisSmallCaps, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>auto</c>. Synthesis of small caps faces is allowed
	/// </summary>
	public FontSynthesisSmallCapsProperty SetToAuto()
	{
		Value = CssValues.Auto;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>none</c>. Synthesis of small caps faces is not allowed
	/// </summary>
	public FontSynthesisSmallCapsProperty SetToNone()
	{
		Value = CssValues.None;
		return this;
	}


}