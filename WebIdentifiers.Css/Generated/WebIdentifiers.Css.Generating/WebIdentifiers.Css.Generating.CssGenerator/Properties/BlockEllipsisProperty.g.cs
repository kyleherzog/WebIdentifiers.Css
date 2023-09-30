﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the BlockEllipsis property.
/// </summary>
public partial class BlockEllipsisProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a block-ellipsis CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public BlockEllipsisProperty(string? value = null)
		: base(CssPropertyNames.BlockEllipsis, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>auto</c>. Render an ellipsis character (U+2026)—or a more typographically-appropriate equivalent—as the block overflow ellipsis at the end of the affected line box. UAs should use the conventions of the content language, writing system, and writing mode to determine the most appropriate ellipsis string.
	/// </summary>
	public BlockEllipsisProperty SetToAuto()
	{
		Value = CssValues.Auto;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>none</c>. The rendering is unaffected.
	/// </summary>
	public BlockEllipsisProperty SetToNone()
	{
		Value = CssValues.None;
		return this;
	}


}