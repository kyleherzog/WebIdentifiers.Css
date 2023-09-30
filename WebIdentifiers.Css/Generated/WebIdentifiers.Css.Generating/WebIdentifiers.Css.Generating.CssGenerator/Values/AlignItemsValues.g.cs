﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Values;

/// <summary>
/// Provides values which are valid for the <c>align-items</c> property.
/// </summary>
public partial class AlignItemsValues : PropertyValuesBase
{
	/// <summary>
	/// Gets the name of the <c>anchor-center</c> property. The new anchor-center value makes this case extremely simple: if the positioned element has a default anchor element, then it is aligned so as to center itself over the default anchor element in the appropriate axis. If this alignment would cause it to overflow its inset-modified containing block in the appropriate axis, it instead is aligned flush with the side that it would have overflowed; if it would overflow both sides, it’s instead aligned as for start.
	/// </summary>
	public string AnchorCenter => CssValues.AnchorCenter;

	/// <summary>
	/// Gets the name of the <c>auto</c> property. Defers cross-axis alignment control to the value of align-items on the parent box. (This is the initial value of align-self.)
	/// </summary>
	public string Auto => CssValues.Auto;

	/// <summary>
	/// Gets the name of the <c>baseline</c> property. The flex item participates in baseline alignment: all participating flex items on the line are aligned such that their baselines align, and the item with the largest distance between its baseline and its cross-start margin edge is placed flush against the cross-start edge of the line. If the item does not have a baseline in the necessary axis, then one is synthesized from the flex item’s border box.
	/// </summary>
	public string Baseline => CssValues.Baseline;

	/// <summary>
	/// Gets the name of the <c>center</c> property. The flex item’s margin box is centered in the cross axis within the line. (If the cross size of the flex line is less than that of the flex item, it will overflow equally in both directions.)
	/// </summary>
	public string Center => CssValues.Center;

	/// <summary>
	/// Gets the name of the <c>flex-end</c> property. The cross-end margin edge of the flex item is placed flush with the cross-end edge of the line.
	/// </summary>
	public string FlexEnd => CssValues.FlexEnd;

	/// <summary>
	/// Gets the name of the <c>flex-start</c> property. The cross-start margin edge of the flex item is placed flush with the cross-start edge of the line.
	/// </summary>
	public string FlexStart => CssValues.FlexStart;

	/// <summary>
	/// Gets the name of the <c>stretch</c> property. If the cross size property of the flex item computes to auto, and neither of the cross-axis margins are auto, the flex item is stretched. Its used value is the length necessary to make the cross size of the item’s margin box as close to the same size as the line as possible, while still respecting the constraints imposed by min-height/min-width/max-height/max-width. The cross-start margin edge of the flex item is placed flush with the cross-start edge of the line.
	/// </summary>
	public string Stretch => CssValues.Stretch;

}