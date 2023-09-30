﻿// <autogenerated/>
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the FontVariant property.
/// </summary>
public partial class FontVariantProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a font-variant CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public FontVariantProperty(string? value = null)
		: base(CssPropertyNames.FontVariant, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>none</c>. The value normal resets all subproperties of font-variant to their initial value. The none value sets font-variant-ligatures to none and resets all other font feature properties to their initial value. Like other shorthands, using font-variant resets unspecified font-variant subproperties to their initial values.
	/// </summary>
	public FontVariantProperty SetToNone()
	{
		Value = CssValues.None;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>normal</c>. The value normal resets all subproperties of font-variant to their initial value. The none value sets font-variant-ligatures to none and resets all other font feature properties to their initial value. Like other shorthands, using font-variant resets unspecified font-variant subproperties to their initial values.
	/// </summary>
	public FontVariantProperty SetToNormal()
	{
		Value = CssValues.Normal;
		return this;
	}


}