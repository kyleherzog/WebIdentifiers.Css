﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the Translate property.
/// </summary>
public partial class TranslateProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a translate CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public TranslateProperty(string? value = null)
		: base(CssPropertyNames.Translate, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>none</c>. All three properties accept (and default to) the value none, which produces no transform at all. In particular, this value does not trigger the creation of a stacking context or containing block for all descendants, while all other values (including “identity” transforms like translate: 0px) create a stacking context and containing block for all descendants, per usual for transforms.
	/// </summary>
	public TranslateProperty SetToNone()
	{
		Value = CssValues.None;
		return this;
	}


}