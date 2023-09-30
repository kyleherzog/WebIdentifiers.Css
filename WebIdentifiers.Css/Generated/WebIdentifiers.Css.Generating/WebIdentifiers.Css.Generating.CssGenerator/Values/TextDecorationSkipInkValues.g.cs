﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Values;

/// <summary>
/// Provides values which are valid for the <c>text-decoration-skip-ink</c> property.
/// </summary>
public partial class TextDecorationSkipInkValues : PropertyValuesBase
{
	/// <summary>
	/// Gets the name of the <c>all</c> property. UAs must interrupt underlines and overlines where the line would cross glyph ink and to some distance to either side of the glyph outline.
	/// </summary>
	public string All => CssValues.All;

	/// <summary>
	/// Gets the name of the <c>auto</c> property. UAs may interrupt underlines and overlines where the line would cross glyph ink and to some distance to either side of the glyph outline. UAs should consider the script of the text (see note below) when determining whether to apply ink-skipping behavior to a given range of content.
	/// </summary>
	public string Auto => CssValues.Auto;

	/// <summary>
	/// Gets the name of the <c>none</c> property. UA must draw continuous underlines and overlines, without interruptions when they cross over a glyph.
	/// </summary>
	public string None => CssValues.None;

}