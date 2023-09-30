﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the BackgroundPosition property.
/// </summary>
public partial class BackgroundPositionProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a background-position CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public BackgroundPositionProperty(string? value = null)
		: base(CssPropertyNames.BackgroundPosition, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>bottom</c>. Computes to 100% for the vertical position if one or two values are given, otherwise specifies the bottom edge as the origin for the next offset.
	/// </summary>
	public BackgroundPositionProperty SetToBottom()
	{
		Value = CssValues.Bottom;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>center</c>. Computes to 50% (left 50%) for the horizontal position if the horizontal position is not otherwise specified, or 50% (top 50%) for the vertical position if it is.
	/// </summary>
	public BackgroundPositionProperty SetToCenter()
	{
		Value = CssValues.Center;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>left</c>. Computes to 0% for the horizontal position if one or two values are given, otherwise specifies the left edge as the origin for the next offset.
	/// </summary>
	public BackgroundPositionProperty SetToLeft()
	{
		Value = CssValues.Left;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>right</c>. Computes to 100% for the horizontal position if one or two values are given, otherwise specifies the right edge as the origin for the next offset.
	/// </summary>
	public BackgroundPositionProperty SetToRight()
	{
		Value = CssValues.Right;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>top</c>. Computes to 0% for the vertical position if one or two values are given, otherwise specifies the top edge as the origin for the next offset.
	/// </summary>
	public BackgroundPositionProperty SetToTop()
	{
		Value = CssValues.Top;
		return this;
	}


}