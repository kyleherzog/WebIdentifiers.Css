﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the FontVariantEmoji property.
/// </summary>
public partial class FontVariantEmojiProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a font-variant-emoji CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public FontVariantEmojiProperty(string? value = null)
		: base(CssPropertyNames.FontVariantEmoji, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>emoji</c>. Code points are rendered as if U+FE0F VARIATION SELECTOR-16 was appended to every Presentation Participating Code Point.
	/// </summary>
	public FontVariantEmojiProperty SetToEmoji()
	{
		Value = CssValues.Emoji;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>normal</c>. User agents can choose to draw a Presentation Participating Code Point in either emoji style or text style. User agents typically follow platform conventions when performing this decision.
	/// </summary>
	public FontVariantEmojiProperty SetToNormal()
	{
		Value = CssValues.Normal;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>text</c>. Code points are rendered as if U+FE0E VARIATION SELECTOR-15 was appended to every Presentation Participating Code Point.
	/// </summary>
	public FontVariantEmojiProperty SetToText()
	{
		Value = CssValues.Text;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>unicode</c>. Code points are rendered in accordance with [UTS51] as either emoji-default, text-default, or text-only, depending on the values of the Emoji and Emoji_Presentation properties for each Presentation Participating Code Point. If present, FE0E VARIATION SELECTOR-15 and U+FE0F VARIATION SELECTOR-16 will override the default presentation of individual Presentation Participating Code Points.
	/// </summary>
	public FontVariantEmojiProperty SetToUnicode()
	{
		Value = CssValues.Unicode;
		return this;
	}


}