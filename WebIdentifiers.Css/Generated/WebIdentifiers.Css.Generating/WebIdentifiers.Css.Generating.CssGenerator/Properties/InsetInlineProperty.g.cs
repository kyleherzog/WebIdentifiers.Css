﻿// <autogenerated/>
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the InsetInline property.
/// </summary>
public partial class InsetInlineProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a inset-inline CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public InsetInlineProperty(string? value = null)
		: base(CssPropertyNames.InsetInline, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>auto</c>. Represents an unconstrained inset; the exact meaning depends on the positioning scheme.
	/// </summary>
	public InsetInlineProperty SetToAuto()
	{
		Value = CssValues.Auto;
		return this;
	}


}