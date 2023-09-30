﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Values;

/// <summary>
/// Provides values which are valid for the <c>scroll-padding-block-start</c> property.
/// </summary>
public partial class ScrollPaddingBlockStartValues : PropertyValuesBase
{
	/// <summary>
	/// Gets the name of the <c>auto</c> property. Indicates that the offset for the corresponding edge of the scrollport is UA-determined. This should generally default to a used length of 0px, but UAs may use heuristics to detect when a non-zero value is more appropriate. For example, a UA could detect when a position:fixed element is being used as an opaque unscrollable “header” that obscures the content below it, and resolve the top offset to the height of that element so that a “page down” operation (such as pressing PgDn) automatically scrolls by one “visible page” of content.
	/// </summary>
	public string Auto => CssValues.Auto;

}