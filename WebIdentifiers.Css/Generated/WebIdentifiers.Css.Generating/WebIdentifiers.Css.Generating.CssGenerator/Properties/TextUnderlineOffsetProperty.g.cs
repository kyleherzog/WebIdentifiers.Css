﻿// <autogenerated/>
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the TextUnderlineOffset property.
/// </summary>
public partial class TextUnderlineOffsetProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a text-underline-offset CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public TextUnderlineOffsetProperty(string? value = null)
		: base(CssPropertyNames.TextUnderlineOffset, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>auto</c>. The UA chooses an appropriate offset for underlines. However, this offset must be zero if the computed value of text-underline-position is from-font and the UA was able to extract an appropriate metric to use from the font.
	/// </summary>
	public TextUnderlineOffsetProperty SetToAuto()
	{
		Value = CssValues.Auto;
		return this;
	}


}