﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the LetterSpacing property.
/// </summary>
public partial class LetterSpacingProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a letter-spacing CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public LetterSpacingProperty(string? value = null)
		: base(CssPropertyNames.LetterSpacing, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>normal</c>. No additional spacing is applied. Computes to zero.
	/// </summary>
	public LetterSpacingProperty SetToNormal()
	{
		Value = CssValues.Normal;
		return this;
	}


}