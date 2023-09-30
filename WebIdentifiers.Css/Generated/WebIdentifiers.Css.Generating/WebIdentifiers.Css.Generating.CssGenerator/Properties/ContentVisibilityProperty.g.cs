﻿// <autogenerated/>
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the ContentVisibility property.
/// </summary>
public partial class ContentVisibilityProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a content-visibility CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public ContentVisibilityProperty(string? value = null)
		: base(CssPropertyNames.ContentVisibility, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>auto</c>. Changes the used value of the contain property so as to turn on layout containment, style containment, and paint containment for the element. If the element is not relevant to the user, it also skips its contents. Unlike hidden, the skipped contents must still be available as normal to user-agent features such as find-in-page, tab order navigation, etc., and must be focusable and selectable as normal.
	/// </summary>
	public ContentVisibilityProperty SetToAuto()
	{
		Value = CssValues.Auto;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>hidden</c>. The element skips its contents. The skipped contents must not be accessible to user-agent features, such as find-in-page, tab-order navigation, etc., nor be selectable or focusable.
	/// </summary>
	public ContentVisibilityProperty SetToHidden()
	{
		Value = CssValues.Hidden;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>visible</c>. No effect. The element’s contents are laid out and rendered as normal.
	/// </summary>
	public ContentVisibilityProperty SetToVisible()
	{
		Value = CssValues.Visible;
		return this;
	}


}