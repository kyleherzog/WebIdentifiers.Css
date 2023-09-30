﻿// <autogenerated/>
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the BoxShadowPosition property.
/// </summary>
public partial class BoxShadowPositionProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a box-shadow-position CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public BoxShadowPositionProperty(string? value = null)
		: base(CssPropertyNames.BoxShadowPosition, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>inner box-shadow</c>. 
	/// </summary>
	public BoxShadowPositionProperty SetToInnerBoxShadow()
	{
		Value = CssValues.InnerBoxShadow;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>inset</c>. Causes the drop shadow to be an inner box-shadow. That means, one that shadows the canvas onto the box, as if the box were cut out of the canvas and shifted behind it.
	/// </summary>
	public BoxShadowPositionProperty SetToInset()
	{
		Value = CssValues.Inset;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>outer box-shadow</c>. 
	/// </summary>
	public BoxShadowPositionProperty SetToOuterBoxShadow()
	{
		Value = CssValues.OuterBoxShadow;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>outset</c>. Causes the drop shadow to be an outer box-shadow. That means, one that shadows the box onto the canvas, as if it were lifted above the canvas.
	/// </summary>
	public BoxShadowPositionProperty SetToOutset()
	{
		Value = CssValues.Outset;
		return this;
	}


}