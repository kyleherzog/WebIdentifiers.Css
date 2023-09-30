﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the BorderColor property.
/// </summary>
public partial class BorderColorProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a border-color CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public BorderColorProperty(string? value = null)
		: base(CssPropertyNames.BorderColor, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>transparent</c>. The border is transparent (though it may have width).
	/// </summary>
	public BorderColorProperty SetToTransparent()
	{
		Value = CssValues.Transparent;
		return this;
	}


}