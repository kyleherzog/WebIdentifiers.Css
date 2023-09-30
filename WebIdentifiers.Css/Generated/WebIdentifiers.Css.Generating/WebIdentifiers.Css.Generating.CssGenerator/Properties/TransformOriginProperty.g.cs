﻿// <autogenerated/>
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the TransformOrigin property.
/// </summary>
public partial class TransformOriginProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a transform-origin CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public TransformOriginProperty(string? value = null)
		: base(CssPropertyNames.TransformOrigin, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>bottom</c>. Computes to 100% for the vertical position.
	/// </summary>
	public TransformOriginProperty SetToBottom()
	{
		Value = CssValues.Bottom;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>center</c>. Computes to 50% (left 50%) for the horizontal position if the horizontal position is not otherwise specified, or 50% (top 50%) for the vertical position if it is.
	/// </summary>
	public TransformOriginProperty SetToCenter()
	{
		Value = CssValues.Center;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>left</c>. Computes to 0% for the horizontal position.
	/// </summary>
	public TransformOriginProperty SetToLeft()
	{
		Value = CssValues.Left;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>right</c>. Computes to 100% for the horizontal position.
	/// </summary>
	public TransformOriginProperty SetToRight()
	{
		Value = CssValues.Right;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>top</c>. Computes to 0% for the vertical position.
	/// </summary>
	public TransformOriginProperty SetToTop()
	{
		Value = CssValues.Top;
		return this;
	}


}