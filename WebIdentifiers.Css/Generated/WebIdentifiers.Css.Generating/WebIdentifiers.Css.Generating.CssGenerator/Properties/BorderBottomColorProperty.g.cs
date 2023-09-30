﻿// <autogenerated/>
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the BorderBottomColor property.
/// </summary>
public partial class BorderBottomColorProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a border-bottom-color CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public BorderBottomColorProperty(string? value = null)
		: base(CssPropertyNames.BorderBottomColor, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>transparent</c>. The border is transparent (though it may have width).
	/// </summary>
	public BorderBottomColorProperty SetToTransparent()
	{
		Value = CssValues.Transparent;
		return this;
	}


}