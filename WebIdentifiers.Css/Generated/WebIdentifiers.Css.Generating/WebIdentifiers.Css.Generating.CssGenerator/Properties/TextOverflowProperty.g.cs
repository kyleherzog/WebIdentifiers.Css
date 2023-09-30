﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the TextOverflow property.
/// </summary>
public partial class TextOverflowProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a text-overflow CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public TextOverflowProperty(string? value = null)
		: base(CssPropertyNames.TextOverflow, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>clip</c>. Clip inline content that overflows its block container element. Characters may be only partially rendered.
	/// </summary>
	public TextOverflowProperty SetToClip()
	{
		Value = CssValues.Clip;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>ellipsis</c>. Render an ellipsis character (U+2026) to represent clipped inline content. Implementations may substitute a more language, script, or writing-mode appropriate ellipsis character, or three dots &quot;...&quot; if the ellipsis character is unavailable.
	/// </summary>
	public TextOverflowProperty SetToEllipsis()
	{
		Value = CssValues.Ellipsis;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>fade</c>. Same as fade(), but the distance over which the fading effect is applied is determined by the UA. 1em is suggested as a reasonable value.
	/// </summary>
	public TextOverflowProperty SetToFade()
	{
		Value = CssValues.Fade;
		return this;
	}


}