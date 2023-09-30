﻿// <autogenerated/>
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the VerticalAlign property.
/// </summary>
public partial class VerticalAlignProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a vertical-align CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public VerticalAlignProperty(string? value = null)
		: base(CssPropertyNames.VerticalAlign, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>alphabetic</c>. Use the alphabetic baseline.
	/// </summary>
	public VerticalAlignProperty SetToAlphabetic()
	{
		Value = CssValues.Alphabetic;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>auto</c>. Specifies last-baseline alignment for inline-block, first-baseline alignment for everything else.
	/// </summary>
	public VerticalAlignProperty SetToAuto()
	{
		Value = CssValues.Auto;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>baseline</c>. Use the dominant baseline choice of the parent.
	/// </summary>
	public VerticalAlignProperty SetToBaseline()
	{
		Value = CssValues.Baseline;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>bottom</c>. Align the line-under edge of the aligned subtree with the line-under edge of the line box.
	/// </summary>
	public VerticalAlignProperty SetToBottom()
	{
		Value = CssValues.Bottom;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>center</c>. Align the center of the aligned subtree with the center of the line box.
	/// </summary>
	public VerticalAlignProperty SetToCenter()
	{
		Value = CssValues.Center;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>central</c>. Use the central baseline.
	/// </summary>
	public VerticalAlignProperty SetToCentral()
	{
		Value = CssValues.Central;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>first</c>. Specifies first-baseline alignment.
	/// </summary>
	public VerticalAlignProperty SetToFirst()
	{
		Value = CssValues.First;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>ideographic</c>. Use the ideographic-under baseline.
	/// </summary>
	public VerticalAlignProperty SetToIdeographic()
	{
		Value = CssValues.Ideographic;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>last</c>. Specifies last-baseline alignment.
	/// </summary>
	public VerticalAlignProperty SetToLast()
	{
		Value = CssValues.Last;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>mathematical</c>. Use the math baseline.
	/// </summary>
	public VerticalAlignProperty SetToMathematical()
	{
		Value = CssValues.Mathematical;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>middle</c>. In general, use the x-middle baselines; except under text-orientation: upright (where the alphabetic and x-height baselines are essentially meaningless) use the central baseline instead.
	/// </summary>
	public VerticalAlignProperty SetToMiddle()
	{
		Value = CssValues.Middle;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>sub</c>. Lower by the offset appropriate for subscripts of the parent’s box. The UA may use the parent’s font metrics to find this offset; otherwise it defaults to dropping by one fifth of the parent’s used font-size.
	/// </summary>
	public VerticalAlignProperty SetToSub()
	{
		Value = CssValues.Sub;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>super</c>. Raise by the offset appropriate for superscripts of the parent’s box. The UA may use the parent’s font metrics to find this offset; otherwise it defaults to raising by one third of the parent’s used font-size.
	/// </summary>
	public VerticalAlignProperty SetToSuper()
	{
		Value = CssValues.Super;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>text-bottom</c>. Use the text-under baseline.
	/// </summary>
	public VerticalAlignProperty SetToTextBottom()
	{
		Value = CssValues.TextBottom;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>text-top</c>. Use the text-over baseline.
	/// </summary>
	public VerticalAlignProperty SetToTextTop()
	{
		Value = CssValues.TextTop;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>top</c>. Align the line-over edge of the aligned subtree with the line-over edge of the line box.
	/// </summary>
	public VerticalAlignProperty SetToTop()
	{
		Value = CssValues.Top;
		return this;
	}


}