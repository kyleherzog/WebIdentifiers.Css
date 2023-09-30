﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the FontSize property.
/// </summary>
public partial class FontSizeProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a font-size CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public FontSizeProperty(string? value = null)
		: base(CssPropertyNames.FontSize, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>large</c>. [ xx-small | x-small | small | medium | large | x-large | xx-large ]
	/// </summary>
	public FontSizeProperty SetToLarge()
	{
		Value = CssValues.Large;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>math</c>. Special mathematical scaling rules must be applied when determining the computed value of the font-size property.
	/// </summary>
	public FontSizeProperty SetToMath()
	{
		Value = CssValues.Math;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>medium</c>. [ xx-small | x-small | small | medium | large | x-large | xx-large ]
	/// </summary>
	public FontSizeProperty SetToMedium()
	{
		Value = CssValues.Medium;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>small</c>. [ xx-small | x-small | small | medium | large | x-large | xx-large ]
	/// </summary>
	public FontSizeProperty SetToSmall()
	{
		Value = CssValues.Small;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>x-large</c>. [ xx-small | x-small | small | medium | large | x-large | xx-large ]
	/// </summary>
	public FontSizeProperty SetToXLarge()
	{
		Value = CssValues.XLarge;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>x-small</c>. [ xx-small | x-small | small | medium | large | x-large | xx-large ]
	/// </summary>
	public FontSizeProperty SetToXSmall()
	{
		Value = CssValues.XSmall;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>xx-large</c>. [ xx-small | x-small | small | medium | large | x-large | xx-large ]
	/// </summary>
	public FontSizeProperty SetToXxLarge()
	{
		Value = CssValues.XxLarge;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>xx-small</c>. [ xx-small | x-small | small | medium | large | x-large | xx-large ]
	/// </summary>
	public FontSizeProperty SetToXxSmall()
	{
		Value = CssValues.XxSmall;
		return this;
	}


}