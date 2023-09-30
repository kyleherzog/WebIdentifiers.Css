﻿// <autogenerated/>
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the FontSynthesisWeight property.
/// </summary>
public partial class FontSynthesisWeightProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a font-synthesis-weight CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public FontSynthesisWeightProperty(string? value = null)
		: base(CssPropertyNames.FontSynthesisWeight, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>auto</c>. Synthesis of bold faces is allowed
	/// </summary>
	public FontSynthesisWeightProperty SetToAuto()
	{
		Value = CssValues.Auto;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>none</c>. Synthesis of bold faces is not allowed
	/// </summary>
	public FontSynthesisWeightProperty SetToNone()
	{
		Value = CssValues.None;
		return this;
	}


}