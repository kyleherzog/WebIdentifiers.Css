﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the InitialLetterAlign property.
/// </summary>
public partial class InitialLetterAlignProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a initial-letter-align CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public InitialLetterAlignProperty(string? value = null)
		: base(CssPropertyNames.InitialLetterAlign, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>alphabetic</c>. Use the cap-height and alphabetic baselines of the surrounding text to align the initial letter.
	/// </summary>
	public InitialLetterAlignProperty SetToAlphabetic()
	{
		Value = CssValues.Alphabetic;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>border-box</c>. Use the initial letter box’s line-under and line-over border edges as the over and under alignment points, respectively.
	/// </summary>
	public InitialLetterAlignProperty SetToBorderBox()
	{
		Value = CssValues.BorderBox;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>hanging</c>. Use the hanging and alphabetic baselines of the surrounding text to align the initial letter.
	/// </summary>
	public InitialLetterAlignProperty SetToHanging()
	{
		Value = CssValues.Hanging;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>ideographic</c>. Use the ideographic-ink-over and ideographic-ink-under baselines of the surrounding text to align the initial letter.
	/// </summary>
	public InitialLetterAlignProperty SetToIdeographic()
	{
		Value = CssValues.Ideographic;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>leading</c>. Use the over/under half-leading edges (i.e. ascent/descent + half-leading) of the surrounding text to align the initial letter.
	/// </summary>
	public InitialLetterAlignProperty SetToLeading()
	{
		Value = CssValues.Leading;
		return this;
	}


}