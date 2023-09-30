﻿// <autogenerated/>
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the BackgroundRepeat property.
/// </summary>
public partial class BackgroundRepeatProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a background-repeat CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public BackgroundRepeatProperty(string? value = null)
		: base(CssPropertyNames.BackgroundRepeat, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>no-repeat</c>. The image is placed once and not repeated in this direction.
	/// </summary>
	public BackgroundRepeatProperty SetToNoRepeat()
	{
		Value = CssValues.NoRepeat;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>repeat</c>. The image is repeated in this direction as often as needed to cover the background painting area.
	/// </summary>
	public BackgroundRepeatProperty SetToRepeat()
	{
		Value = CssValues.Repeat;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>repeat-x</c>. Computes to repeat no-repeat.
	/// </summary>
	public BackgroundRepeatProperty SetToRepeatX()
	{
		Value = CssValues.RepeatX;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>repeat-y</c>. Computes to no-repeat repeat.
	/// </summary>
	public BackgroundRepeatProperty SetToRepeatY()
	{
		Value = CssValues.RepeatY;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>round</c>. The image is repeated as often as will fit within the background positioning area. If it doesn’t fit a whole number of times, it is rescaled so that it does. See the formula under background-size. If the background painting area is larger than the background positioning area, then the pattern repeats to fill the background painting area.
	/// </summary>
	public BackgroundRepeatProperty SetToRound()
	{
		Value = CssValues.Round;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>space</c>. The image is repeated as often as will fit within the background positioning area without being clipped and then the images are spaced out to fill the area. The first and last images touch the edges of the area. If the background painting area is larger than the background positioning area, then the pattern repeats to fill the background painting area. The value of background-position for this direction is ignored, unless there is not enough space for two copies of the image in this direction, in which case only one image is placed and background-position determines its position in this direction.
	/// </summary>
	public BackgroundRepeatProperty SetToSpace()
	{
		Value = CssValues.Space;
		return this;
	}


}