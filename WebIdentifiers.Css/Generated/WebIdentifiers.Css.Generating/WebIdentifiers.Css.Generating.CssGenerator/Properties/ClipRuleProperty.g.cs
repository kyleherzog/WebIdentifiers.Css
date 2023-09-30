﻿// <autogenerated/>
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the ClipRule property.
/// </summary>
public partial class ClipRuleProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a clip-rule CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public ClipRuleProperty(string? value = null)
		: base(CssPropertyNames.ClipRule, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>evenodd</c>. See description of fill-rule property [SVG11].
	/// </summary>
	public ClipRuleProperty SetToEvenodd()
	{
		Value = CssValues.Evenodd;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>nonzero</c>. See description of fill-rule property [SVG11].
	/// </summary>
	public ClipRuleProperty SetToNonzero()
	{
		Value = CssValues.Nonzero;
		return this;
	}


}