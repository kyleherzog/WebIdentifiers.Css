﻿// <autogenerated/>
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the InsetBlockEnd property.
/// </summary>
public partial class InsetBlockEndProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a inset-block-end CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public InsetBlockEndProperty(string? value = null)
		: base(CssPropertyNames.InsetBlockEnd, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>auto</c>. Represents an unconstrained inset; the exact meaning depends on the positioning scheme.
	/// </summary>
	public InsetBlockEndProperty SetToAuto()
	{
		Value = CssValues.Auto;
		return this;
	}


}