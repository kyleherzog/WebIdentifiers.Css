﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the BaselineShift property.
/// </summary>
public partial class BaselineShiftProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a baseline-shift CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public BaselineShiftProperty(string? value = null)
		: base(CssPropertyNames.BaselineShift, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>baseline</c>. User agents may additionally support the keyword baseline as computing to 0 if is necessary for them to support legacy SVG content. This value is not allowed in the vertical-align shorthand.
	/// </summary>
	public BaselineShiftProperty SetToBaseline()
	{
		Value = CssValues.Baseline;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>bottom</c>. Align the line-under edge of the aligned subtree with the line-under edge of the line box.
	/// </summary>
	public BaselineShiftProperty SetToBottom()
	{
		Value = CssValues.Bottom;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>center</c>. Align the center of the aligned subtree with the center of the line box.
	/// </summary>
	public BaselineShiftProperty SetToCenter()
	{
		Value = CssValues.Center;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>sub</c>. Lower by the offset appropriate for subscripts of the parent’s box. The UA may use the parent’s font metrics to find this offset; otherwise it defaults to dropping by one fifth of the parent’s used font-size.
	/// </summary>
	public BaselineShiftProperty SetToSub()
	{
		Value = CssValues.Sub;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>super</c>. Raise by the offset appropriate for superscripts of the parent’s box. The UA may use the parent’s font metrics to find this offset; otherwise it defaults to raising by one third of the parent’s used font-size.
	/// </summary>
	public BaselineShiftProperty SetToSuper()
	{
		Value = CssValues.Super;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>top</c>. Align the line-over edge of the aligned subtree with the line-over edge of the line box.
	/// </summary>
	public BaselineShiftProperty SetToTop()
	{
		Value = CssValues.Top;
		return this;
	}


}