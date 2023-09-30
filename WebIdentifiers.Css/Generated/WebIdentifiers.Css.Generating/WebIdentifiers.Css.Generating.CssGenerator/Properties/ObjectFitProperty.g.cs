﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the ObjectFit property.
/// </summary>
public partial class ObjectFitProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a object-fit CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public ObjectFitProperty(string? value = null)
		: base(CssPropertyNames.ObjectFit, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>contain</c>. The replaced content is sized to maintain its aspect ratio while fitting within the element’s content box: its concrete object size is resolved as a contain constraint against the element’s used width and height. If the scale-down flag is used, size the content as if none or contain were specified, whichever would result in a smaller concrete object size.
	/// </summary>
	public ObjectFitProperty SetToContain()
	{
		Value = CssValues.Contain;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>cover</c>. The replaced content is sized to maintain its aspect ratio while filling the element’s entire content box: its concrete object size is resolved as a cover constraint against the element’s used width and height. If the scale-down flag is used, size the content as if none or cover were specified, whichever would result in a smaller concrete object size.
	/// </summary>
	public ObjectFitProperty SetToCover()
	{
		Value = CssValues.Cover;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>fill</c>. The replaced content is sized to fill the element’s content box: the object’s concrete object size is the element’s used width and height.
	/// </summary>
	public ObjectFitProperty SetToFill()
	{
		Value = CssValues.Fill;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>none</c>. The replaced content is not resized to fit inside the element’s content box: determine the object’s concrete object size using the default sizing algorithm with no specified size, and a default object size equal to the replaced element’s used width and height.
	/// </summary>
	public ObjectFitProperty SetToNone()
	{
		Value = CssValues.None;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>scale-down</c>. Equivalent to contain scale-down.
	/// </summary>
	public ObjectFitProperty SetToScaleDown()
	{
		Value = CssValues.ScaleDown;
		return this;
	}


}