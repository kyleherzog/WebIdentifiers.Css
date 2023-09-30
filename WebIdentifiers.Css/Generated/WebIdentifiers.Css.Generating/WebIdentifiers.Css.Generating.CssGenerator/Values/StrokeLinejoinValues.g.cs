﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Values;

/// <summary>
/// Provides values which are valid for the <c>stroke-linejoin</c> property.
/// </summary>
public partial class StrokeLinejoinValues : PropertyValuesBase
{
	/// <summary>
	/// Gets the name of the <c>arcs</c> property. An arcs corner is used to join path segments. The arcs shape is formed by extending the outer edges of the stroke at the join point with arcs that have the same curvature as the outer edges at the join point.
	/// </summary>
	public string Arcs => CssValues.Arcs;

	/// <summary>
	/// Gets the name of the <c>bevel</c> property. The corner is cropped at the stroke-miterlimit by the perpendicular to its diagonal.
	/// </summary>
	public string Bevel => CssValues.Bevel;

	/// <summary>
	/// Gets the name of the <c>crop</c> property. The stroke extends the minimal amount past the corner necessary to form a convex corner. This acts identically to miter, but forces stroke-miterlimit to behave as if it had its minimum value of 1.
	/// </summary>
	public string Crop => CssValues.Crop;

	/// <summary>
	/// Gets the name of the <c>fallback</c> property. When the stroke-miterlimit is exceeded, this behaves as if crop bevel were specified. Can we just remove fallback? It’s a stupid value, useful only because we didn’t have the clip-at-miterlimit behavior in SVG1. Question is if people are mostly just *accidentally* getting the bevel behavior right now, and would be okay with their joins extending up to the miterlimit and only getting the excess corners clipped, or if they actually wanted the discontinuous behavior currently specified. The breakpoint is between 29 and 30 degrees.
	/// </summary>
	public string Fallback => CssValues.Fallback;

	/// <summary>
	/// Gets the name of the <c>miter</c> property. A sharp corner is used to join path segments. The corner is formed by extending the outer edges of the stroke at the tangents of the path segments until they intersect.
	/// </summary>
	public string Miter => CssValues.Miter;

	/// <summary>
	/// Gets the name of the <c>round</c> property. The corner is cropped as for bevel, and a filled arc tangent to the truncated stroke edges is appended to round the corner.
	/// </summary>
	public string Round => CssValues.Round;

}