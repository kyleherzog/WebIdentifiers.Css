﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the PointerEvents property.
/// </summary>
public partial class PointerEventsProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a pointer-events CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public PointerEventsProperty(string? value = null)
		: base(CssPropertyNames.PointerEvents, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>auto</c>. Hit-testing occurs normally.
	/// </summary>
	public PointerEventsProperty SetToAuto()
	{
		Value = CssValues.Auto;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>none</c>. Hit-testing acts as if the boxes generated by the element (see [CSS-DISPLAY-3]) were not there, effectively causing the element behind the pointer-events: none element to become the target of hit-testing based events instead. The statement above needs to be be qualified; for some purposes, hit-testing continues to take the element into account. For instance, clicking and dragging to start a text selection will continue to work as usual. What is the precise set of things for which hit-testing is affected by pointer-events?
	/// </summary>
	public PointerEventsProperty SetToNone()
	{
		Value = CssValues.None;
		return this;
	}


}