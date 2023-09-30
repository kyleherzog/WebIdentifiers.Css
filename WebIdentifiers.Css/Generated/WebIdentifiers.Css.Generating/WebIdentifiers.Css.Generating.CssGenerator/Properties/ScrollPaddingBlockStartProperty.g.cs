﻿// <autogenerated/>
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the ScrollPaddingBlockStart property.
/// </summary>
public partial class ScrollPaddingBlockStartProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a scroll-padding-block-start CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public ScrollPaddingBlockStartProperty(string? value = null)
		: base(CssPropertyNames.ScrollPaddingBlockStart, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>auto</c>. Indicates that the offset for the corresponding edge of the scrollport is UA-determined. This should generally default to a used length of 0px, but UAs may use heuristics to detect when a non-zero value is more appropriate. For example, a UA could detect when a position:fixed element is being used as an opaque unscrollable “header” that obscures the content below it, and resolve the top offset to the height of that element so that a “page down” operation (such as pressing PgDn) automatically scrolls by one “visible page” of content.
	/// </summary>
	public ScrollPaddingBlockStartProperty SetToAuto()
	{
		Value = CssValues.Auto;
		return this;
	}


}