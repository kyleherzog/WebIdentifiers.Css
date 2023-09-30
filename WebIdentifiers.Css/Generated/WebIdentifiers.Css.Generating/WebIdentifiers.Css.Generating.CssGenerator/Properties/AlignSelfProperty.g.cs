﻿// <autogenerated/>
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the AlignSelf property.
/// </summary>
public partial class AlignSelfProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a align-self CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public AlignSelfProperty(string? value = null)
		: base(CssPropertyNames.AlignSelf, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>anchor-center</c>. The new anchor-center value makes this case extremely simple: if the positioned element has a default anchor element, then it is aligned so as to center itself over the default anchor element in the appropriate axis. If this alignment would cause it to overflow its inset-modified containing block in the appropriate axis, it instead is aligned flush with the side that it would have overflowed; if it would overflow both sides, it’s instead aligned as for start.
	/// </summary>
	public AlignSelfProperty SetToAnchorCenter()
	{
		Value = CssValues.AnchorCenter;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>auto</c>. Behaves as normal if the box has no parent, or when determining the actual position of an absolutely positioned box. It behaves as the computed align-items value of the parent box (minus any legacy keywords) otherwise (including when determining the static position of an absolutely positioned box).
	/// </summary>
	public AlignSelfProperty SetToAuto()
	{
		Value = CssValues.Auto;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>baseline</c>. The flex item participates in baseline alignment: all participating flex items on the line are aligned such that their baselines align, and the item with the largest distance between its baseline and its cross-start margin edge is placed flush against the cross-start edge of the line. If the item does not have a baseline in the necessary axis, then one is synthesized from the flex item’s border box.
	/// </summary>
	public AlignSelfProperty SetToBaseline()
	{
		Value = CssValues.Baseline;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>center</c>. The flex item’s margin box is centered in the cross axis within the line. (If the cross size of the flex line is less than that of the flex item, it will overflow equally in both directions.)
	/// </summary>
	public AlignSelfProperty SetToCenter()
	{
		Value = CssValues.Center;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>flex-end</c>. The cross-end margin edge of the flex item is placed flush with the cross-end edge of the line.
	/// </summary>
	public AlignSelfProperty SetToFlexEnd()
	{
		Value = CssValues.FlexEnd;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>flex-start</c>. The cross-start margin edge of the flex item is placed flush with the cross-start edge of the line.
	/// </summary>
	public AlignSelfProperty SetToFlexStart()
	{
		Value = CssValues.FlexStart;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>normal</c>. Represents the “default” alignment for the layout mode, as defined below.
	/// </summary>
	public AlignSelfProperty SetToNormal()
	{
		Value = CssValues.Normal;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>stretch</c>. As defined for justify-self in § 6.1 Inline-Axis (or Main-Axis) Alignment: the justify-self property.
	/// </summary>
	public AlignSelfProperty SetToStretch()
	{
		Value = CssValues.Stretch;
		return this;
	}


}