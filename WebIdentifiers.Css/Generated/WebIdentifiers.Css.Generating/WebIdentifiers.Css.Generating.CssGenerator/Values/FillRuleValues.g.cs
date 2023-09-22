﻿// <autogenerated/>
namespace WebIdentifiers.Css.Values;

public partial class FillRuleValues : PropertyValuesBase
{
	/// <summary>
	/// Gets the name of the <c>evenodd</c> property. This rule determines the “insideness” of a point on the canvas by drawing a ray from that point to infinity in any direction and counting the number of path segments from the given shape that the ray crosses. If this number is odd, the point is inside; if even, the point is outside. The effect of an evenodd fill rule on paths with self-intersections and enclosed subpaths.
	/// </summary>
	public string Evenodd => CssValues.Evenodd;

	/// <summary>
	/// Gets the name of the <c>nonzero</c> property. This rule determines the “insideness” of a point on the canvas by drawing a ray from that point to infinity in any direction and then examining the places where a segment of the shape crosses the ray. Starting with a count of zero, add one each time a path segment crosses the ray from left to right and subtract one each time a path segment crosses the ray from right to left. After counting the crossings, if the result is zero then the point is outside the path. Otherwise, it is inside. The effect of a nonzero fill rule on paths with self-intersections and enclosed subpaths.
	/// </summary>
	public string Nonzero => CssValues.Nonzero;

}