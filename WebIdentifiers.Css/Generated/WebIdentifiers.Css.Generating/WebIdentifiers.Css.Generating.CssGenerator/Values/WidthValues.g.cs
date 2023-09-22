﻿// <autogenerated/>
namespace WebIdentifiers.Css.Values;

public partial class WidthValues : PropertyValuesBase
{
	/// <summary>
	/// Gets the name of the <c>auto</c> property. For width/height, specifies an automatic size (automatic block size/automatic inline size). See the relevant layout module for how to calculate this. For min-width/min-height, specifies an automatic minimum size. Unless otherwise defined by the relevant layout module, however, it resolves to a used value of 0. For backwards-compatibility, the resolved value of this keyword is zero for boxes of all [CSS2] display types: block and inline boxes, inline blocks, and all the table layout boxes. It also resolves to zero when no box is generated.
	/// </summary>
	public string Auto => CssValues.Auto;

	/// <summary>
	/// Gets the name of the <c>contain</c> property. If the box has a preferred aspect ratio, applies contain-fit sizing, attempting to fit into the box’s constraints while maintaining its preferred aspect ratio insofar as possible. See § 6.2 Contain-fit Sizing: stretching while maintaining an aspect ratio. If the box has no preferred aspect ratio, applies stretch-fit sizing.
	/// </summary>
	public string Contain => CssValues.Contain;

	/// <summary>
	/// Gets the name of the <c>fit-content</c> property. Essentially fit-content(stretch) i.e. min(max-content, max(min-content, stretch)).
	/// </summary>
	public string FitContent => CssValues.FitContent;

	/// <summary>
	/// Gets the name of the <c>max-content</c> property. Use the max-content size in the relevant axis; for a box’s block size, unless otherwise specified, this is equivalent to its automatic size.
	/// </summary>
	public string MaxContent => CssValues.MaxContent;

	/// <summary>
	/// Gets the name of the <c>min-content</c> property. Use the min-content size in the relevant axis; for a box’s block size, unless otherwise specified, this is equivalent to its automatic size.
	/// </summary>
	public string MinContent => CssValues.MinContent;

	/// <summary>
	/// Gets the name of the <c>stretch</c> property. Applies stretch-fit sizing, attempting to match the size of the box’s margin box to the size of its containing block. See § 6.1 Stretch-fit Sizing: filling the containing block.
	/// </summary>
	public string Stretch => CssValues.Stretch;

}