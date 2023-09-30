﻿// <autogenerated/>
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the BorderLeftColor property.
/// </summary>
public partial class BorderLeftColorProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a border-left-color CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public BorderLeftColorProperty(string? value = null)
		: base(CssPropertyNames.BorderLeftColor, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>transparent</c>. The border is transparent (though it may have width).
	/// </summary>
	public BorderLeftColorProperty SetToTransparent()
	{
		Value = CssValues.Transparent;
		return this;
	}


}