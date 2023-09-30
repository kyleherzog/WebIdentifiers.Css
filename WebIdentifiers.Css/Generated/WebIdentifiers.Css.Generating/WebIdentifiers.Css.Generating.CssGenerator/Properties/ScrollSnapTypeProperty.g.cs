﻿// <autogenerated/>
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the ScrollSnapType property.
/// </summary>
public partial class ScrollSnapTypeProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a scroll-snap-type CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public ScrollSnapTypeProperty(string? value = null)
		: base(CssPropertyNames.ScrollSnapType, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>block</c>. The scroll container snaps to snap positions in its block axis only.
	/// </summary>
	public ScrollSnapTypeProperty SetToBlock()
	{
		Value = CssValues.Block;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>both</c>. The scroll container snaps to snap positions in both of its axes independently (potentially snapping to different elements in each axis).
	/// </summary>
	public ScrollSnapTypeProperty SetToBoth()
	{
		Value = CssValues.Both;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>inline</c>. The scroll container snaps to snap positions in its inline axis only.
	/// </summary>
	public ScrollSnapTypeProperty SetToInline()
	{
		Value = CssValues.Inline;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>mandatory</c>. If specified on a scroll container, the scroll container is required to be snapped to a snap position when there are no active scrolling operations. If a valid snap position exists then the scroll container must snap at the termination of a scroll (if none exist then no snapping occurs).
	/// </summary>
	public ScrollSnapTypeProperty SetToMandatory()
	{
		Value = CssValues.Mandatory;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>none</c>. If specified on a scroll container, the scroll container must not snap.
	/// </summary>
	public ScrollSnapTypeProperty SetToNone()
	{
		Value = CssValues.None;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>proximity</c>. If specified on a scroll container, the scroll container may snap to a snap position at the termination of a scroll, at the discretion of the UA given the parameters of the scroll.
	/// </summary>
	public ScrollSnapTypeProperty SetToProximity()
	{
		Value = CssValues.Proximity;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>x</c>. The scroll container snaps to snap positions in its horizontal axis only.
	/// </summary>
	public ScrollSnapTypeProperty SetToX()
	{
		Value = CssValues.X;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>y</c>. The scroll container snaps to snap positions in its vertical axis only.
	/// </summary>
	public ScrollSnapTypeProperty SetToY()
	{
		Value = CssValues.Y;
		return this;
	}


}