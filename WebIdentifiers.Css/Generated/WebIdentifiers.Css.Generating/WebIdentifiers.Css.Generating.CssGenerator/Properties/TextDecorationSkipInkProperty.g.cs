﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the TextDecorationSkipInk property.
/// </summary>
public partial class TextDecorationSkipInkProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a text-decoration-skip-ink CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public TextDecorationSkipInkProperty(string? value = null)
		: base(CssPropertyNames.TextDecorationSkipInk, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>all</c>. UAs must interrupt underlines and overlines where the line would cross glyph ink and to some distance to either side of the glyph outline.
	/// </summary>
	public TextDecorationSkipInkProperty SetToAll()
	{
		Value = CssValues.All;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>auto</c>. UAs may interrupt underlines and overlines where the line would cross glyph ink and to some distance to either side of the glyph outline. UAs should consider the script of the text (see note below) when determining whether to apply ink-skipping behavior to a given range of content.
	/// </summary>
	public TextDecorationSkipInkProperty SetToAuto()
	{
		Value = CssValues.Auto;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>none</c>. UA must draw continuous underlines and overlines, without interruptions when they cross over a glyph.
	/// </summary>
	public TextDecorationSkipInkProperty SetToNone()
	{
		Value = CssValues.None;
		return this;
	}


}