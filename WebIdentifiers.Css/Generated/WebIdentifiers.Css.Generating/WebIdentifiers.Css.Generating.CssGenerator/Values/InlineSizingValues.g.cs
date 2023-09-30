﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Values;

/// <summary>
/// Provides values which are valid for the <c>inline-sizing</c> property.
/// </summary>
public partial class InlineSizingValues : PropertyValuesBase
{
	/// <summary>
	/// Gets the name of the <c>normal</c> property. The content area of the inline box is sized and positioned to fit (possibly hypothetical) text from its first available font. This specification does not specify how. A UA may, e.g., use the maximum ascender and descender of the font. (This would ensure that glyphs with parts above or below the em-box still fall within the content area, but leads to differently sized boxes for different fonts.)
	/// </summary>
	public string Normal => CssValues.Normal;

	/// <summary>
	/// Gets the name of the <c>stretch</c> property. Once the line box has been sized and its contents positioned as for normal, the inline box’s box edges are shifted such that its over/under margin edges coincide with the corresponding line box’s edges, stretching the inline box’s inner logical height so that its block-axis outer size fills the line box. (The sizes and positions of its in-flow contents are not affected.)
	/// </summary>
	public string Stretch => CssValues.Stretch;

}