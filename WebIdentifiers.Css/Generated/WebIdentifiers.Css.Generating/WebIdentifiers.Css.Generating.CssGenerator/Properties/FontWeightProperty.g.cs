﻿// <autogenerated/>
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the FontWeight property.
/// </summary>
public partial class FontWeightProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a font-weight CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public FontWeightProperty(string? value = null)
		: base(CssPropertyNames.FontWeight, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>bold</c>. Same as 700.
	/// </summary>
	public FontWeightProperty SetToBold()
	{
		Value = CssValues.Bold;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>bolder</c>. Specifies a bolder weight than the inherited value. See § 2.2.1 Relative Weights.
	/// </summary>
	public FontWeightProperty SetToBolder()
	{
		Value = CssValues.Bolder;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>lighter</c>. Specifies a lighter weight than the inherited value. See § 2.2.1 Relative Weights.
	/// </summary>
	public FontWeightProperty SetToLighter()
	{
		Value = CssValues.Lighter;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>normal</c>. Same as 400.
	/// </summary>
	public FontWeightProperty SetToNormal()
	{
		Value = CssValues.Normal;
		return this;
	}


}