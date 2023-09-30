﻿// <autogenerated/>
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the BoxSizing property.
/// </summary>
public partial class BoxSizingProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a box-sizing CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public BoxSizingProperty(string? value = null)
		: base(CssPropertyNames.BoxSizing, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>border-box</c>. Sizes specified on sizing properties as <length-percentage> represent the box’s visually-apparent sizes, including the borders/padding (but not margin): they are applied to the border box. The padding and border of the box are laid out and drawn inside the specified width and height, with the content box sized to fill the remaining space, floored at zero. The content width and height are calculated by subtracting the border and padding widths of the respective sides from the specified <length-percentage>. As the content width and height cannot be negative, this computation is floored at zero. Used values, as exposed for instance through getComputedStyle(), also refer to the border box.
	/// </summary>
	public BoxSizingProperty SetToBorderBox()
	{
		Value = CssValues.BorderBox;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>content-box</c>. Sizes specified on sizing properties as <length-percentage> represent the box’s inner sizes, excluding the margins/border/padding: they are applied to the content box. The padding and border of the box are laid out and drawn outside the specified width and height.
	/// </summary>
	public BoxSizingProperty SetToContentBox()
	{
		Value = CssValues.ContentBox;
		return this;
	}


}