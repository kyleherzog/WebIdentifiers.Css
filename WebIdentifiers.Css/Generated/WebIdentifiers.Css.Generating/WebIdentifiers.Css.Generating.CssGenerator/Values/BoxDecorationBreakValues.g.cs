﻿// <autogenerated/>
namespace WebIdentifiers.Css.Values;

public partial class BoxDecorationBreakValues : PropertyValuesBase
{
	/// <summary>
	/// Gets the name of the <c>clone</c> property. Each box fragment is independently wrapped with the border, padding, and margin. The border-radius and border-image and box-shadow, if any, are applied to each fragment independently. The background is drawn independently in each fragment of the element. A no-repeat background image will thus be rendered once in each fragment of the element.
	/// </summary>
	public string Clone => CssValues.Clone;

	/// <summary>
	/// Gets the name of the <c>slice</c> property. The effect is as though the element were rendered with no breaks present, and then sliced by the breaks afterward: no border and no padding are inserted at a break; no box-shadow is drawn at a broken edge; and backgrounds, border-radius, and the border-image are applied to the geometry of the whole box as if it were unbroken.
	/// </summary>
	public string Slice => CssValues.Slice;

}