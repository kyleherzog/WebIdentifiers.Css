﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the BackgroundAttachment property.
/// </summary>
public partial class BackgroundAttachmentProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a background-attachment CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public BackgroundAttachmentProperty(string? value = null)
		: base(CssPropertyNames.BackgroundAttachment, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>fixed</c>. The background is fixed with regard to the viewport. In paged media where there is no viewport, a fixed background is fixed with respect to the page box and therefore replicated on every page.
	/// </summary>
	public BackgroundAttachmentProperty SetToFixed()
	{
		Value = CssValues.Fixed;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>local</c>. The background is fixed with regard to the element’s contents: if the element has a scrolling mechanism, the background scrolls with the element’s contents, and the background painting area and background positioning area are relative to the scrollable area of the element rather than to the border framing them. Because the scrollable area does not include the border area, for scrollable elements the border-box value of background-clip may be treated the same as padding-box.
	/// </summary>
	public BackgroundAttachmentProperty SetToLocal()
	{
		Value = CssValues.Local;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>scroll</c>. The background is fixed with regard to the element itself and does not scroll with its contents. (It is effectively attached to the element’s border.)
	/// </summary>
	public BackgroundAttachmentProperty SetToScroll()
	{
		Value = CssValues.Scroll;
		return this;
	}


}