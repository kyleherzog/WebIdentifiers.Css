﻿// <autogenerated/>
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the FontSizeAdjust property.
/// </summary>
public partial class FontSizeAdjustProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a font-size-adjust CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public FontSizeAdjustProperty(string? value = null)
		: base(CssPropertyNames.FontSizeAdjust, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>cap-height</c>. Normalize the cap-height of the fonts, using the cap-height by the font size.
	/// </summary>
	public FontSizeAdjustProperty SetToCapHeight()
	{
		Value = CssValues.CapHeight;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>ch-width</c>. Normalize the horizontal narrow pitch of the fonts, using the advance width of “0” (ZERO, U+0030) divided by the font size.
	/// </summary>
	public FontSizeAdjustProperty SetToChWidth()
	{
		Value = CssValues.ChWidth;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>ex-height</c>. Normalize the aspect value of the fonts, using the x-height divided by the font size.
	/// </summary>
	public FontSizeAdjustProperty SetToExHeight()
	{
		Value = CssValues.ExHeight;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>from-font</c>. Computes to the <number> corresponding to the specified metric of the first available font. w3c/csswg-drafts/6384[css-fonts-5] font-size-adjust with missing metrics
	/// </summary>
	public FontSizeAdjustProperty SetToFromFont()
	{
		Value = CssValues.FromFont;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>ic-height</c>. Normalize the vertical wide pitch of the font, using the advance height of “水” (CJK water ideograph, U+6C34) divided by the font size.
	/// </summary>
	public FontSizeAdjustProperty SetToIcHeight()
	{
		Value = CssValues.IcHeight;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>ic-width</c>. Normalize the horizontal wide pitch of the font, using the advance width of “水” (CJK water ideograph, U+6C34) divided by the font size.
	/// </summary>
	public FontSizeAdjustProperty SetToIcWidth()
	{
		Value = CssValues.IcWidth;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>none</c>. No special font-size adjustment is applied.
	/// </summary>
	public FontSizeAdjustProperty SetToNone()
	{
		Value = CssValues.None;
		return this;
	}


}