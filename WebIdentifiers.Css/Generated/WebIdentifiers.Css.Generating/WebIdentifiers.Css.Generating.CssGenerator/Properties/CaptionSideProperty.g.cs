﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the CaptionSide property.
/// </summary>
public partial class CaptionSideProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a caption-side CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public CaptionSideProperty(string? value = null)
		: base(CssPropertyNames.CaptionSide, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>bottom</c>. Positions the caption box below the table grid box.
	/// </summary>
	public CaptionSideProperty SetToBottom()
	{
		Value = CssValues.Bottom;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>top</c>. Positions the caption box above the table grid box.
	/// </summary>
	public CaptionSideProperty SetToTop()
	{
		Value = CssValues.Top;
		return this;
	}


}