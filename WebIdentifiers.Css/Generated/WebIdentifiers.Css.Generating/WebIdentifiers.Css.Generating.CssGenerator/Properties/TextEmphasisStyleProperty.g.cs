﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the TextEmphasisStyle property.
/// </summary>
public partial class TextEmphasisStyleProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a text-emphasis-style CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public TextEmphasisStyleProperty(string? value = null)
		: base(CssPropertyNames.TextEmphasisStyle, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>circle</c>. Display large circles as marks. The filled circle is U+25CF &apos;●&apos;, and the open circle is U+25CB &apos;○&apos;.
	/// </summary>
	public TextEmphasisStyleProperty SetToCircle()
	{
		Value = CssValues.Circle;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>dot</c>. Display small circles as marks. The filled dot is U+2022 &apos;•&apos;, and the open dot is U+25E6 &apos;◦&apos;.
	/// </summary>
	public TextEmphasisStyleProperty SetToDot()
	{
		Value = CssValues.Dot;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>double-circle</c>. Display double circles as marks. The filled double-circle is U+25C9 &apos;◉&apos;, and the open double-circle is U+25CE &apos;◎&apos;.
	/// </summary>
	public TextEmphasisStyleProperty SetToDoubleCircle()
	{
		Value = CssValues.DoubleCircle;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>filled</c>. The shape is filled with solid color.
	/// </summary>
	public TextEmphasisStyleProperty SetToFilled()
	{
		Value = CssValues.Filled;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>none</c>. No emphasis marks.
	/// </summary>
	public TextEmphasisStyleProperty SetToNone()
	{
		Value = CssValues.None;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>sesame</c>. Display sesames as marks. The filled sesame is U+FE45 &apos;﹅&apos;, and the open sesame is U+FE46 &apos;﹆&apos;.
	/// </summary>
	public TextEmphasisStyleProperty SetToSesame()
	{
		Value = CssValues.Sesame;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>triangle</c>. Display triangles as marks. The filled triangle is U+25B2 &apos;▲&apos;, and the open triangle is U+25B3 &apos;△&apos;.
	/// </summary>
	public TextEmphasisStyleProperty SetToTriangle()
	{
		Value = CssValues.Triangle;
		return this;
	}


}