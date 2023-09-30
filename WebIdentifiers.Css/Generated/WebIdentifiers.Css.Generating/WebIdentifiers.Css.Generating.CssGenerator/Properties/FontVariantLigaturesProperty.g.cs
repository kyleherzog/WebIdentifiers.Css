﻿// <autogenerated/>
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the FontVariantLigatures property.
/// </summary>
public partial class FontVariantLigaturesProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a font-variant-ligatures CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public FontVariantLigaturesProperty(string? value = null)
		: base(CssPropertyNames.FontVariantLigatures, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>common-ligatures</c>. Enables display of common ligatures (OpenType features: liga, clig). For OpenType fonts, common ligatures are enabled by default.
	/// </summary>
	public FontVariantLigaturesProperty SetToCommonLigatures()
	{
		Value = CssValues.CommonLigatures;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>contextual</c>. Enables display of contextual alternates (OpenType feature: calt). Although not strictly a ligature feature, like ligatures this feature is commonly used to harmonize the shapes of glyphs with the surrounding context. For OpenType fonts, this feature is on by default.
	/// </summary>
	public FontVariantLigaturesProperty SetToContextual()
	{
		Value = CssValues.Contextual;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>discretionary-ligatures</c>. Enables display of discretionary ligatures (OpenType feature: dlig). Which ligatures are discretionary or optional is decided by the type designer, so authors will need to refer to the documentation of a given font to understand which ligatures are considered discretionary.
	/// </summary>
	public FontVariantLigaturesProperty SetToDiscretionaryLigatures()
	{
		Value = CssValues.DiscretionaryLigatures;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>historical-ligatures</c>. Enables display of historical ligatures (OpenType feature: hlig).
	/// </summary>
	public FontVariantLigaturesProperty SetToHistoricalLigatures()
	{
		Value = CssValues.HistoricalLigatures;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>no-common-ligatures</c>. Disables display of common ligatures (OpenType features: liga, clig).
	/// </summary>
	public FontVariantLigaturesProperty SetToNoCommonLigatures()
	{
		Value = CssValues.NoCommonLigatures;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>no-contextual</c>. Disables display of contextual alternates (OpenType feature: calt).
	/// </summary>
	public FontVariantLigaturesProperty SetToNoContextual()
	{
		Value = CssValues.NoContextual;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>no-discretionary-ligatures</c>. Disables display of discretionary ligatures (OpenType feature: dlig).
	/// </summary>
	public FontVariantLigaturesProperty SetToNoDiscretionaryLigatures()
	{
		Value = CssValues.NoDiscretionaryLigatures;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>no-historical-ligatures</c>. Disables display of historical ligatures (OpenType feature: hlig).
	/// </summary>
	public FontVariantLigaturesProperty SetToNoHistoricalLigatures()
	{
		Value = CssValues.NoHistoricalLigatures;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>none</c>. Specifies that all types of ligatures and contextual forms covered by this property are explicitly disabled. In situations where ligatures are not considered necessary, this may improve the speed of text rendering.
	/// </summary>
	public FontVariantLigaturesProperty SetToNone()
	{
		Value = CssValues.None;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>normal</c>. A value of normal specifies that common default features are enabled, as described in detail in the next section. For OpenType fonts, common ligatures and contextual forms are on by default, discretionary and historical ligatures are not.
	/// </summary>
	public FontVariantLigaturesProperty SetToNormal()
	{
		Value = CssValues.Normal;
		return this;
	}


}