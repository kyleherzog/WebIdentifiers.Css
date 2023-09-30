﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the MaxBlockSize property.
/// </summary>
public partial class MaxBlockSizeProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a max-block-size CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public MaxBlockSizeProperty(string? value = null)
		: base(CssPropertyNames.MaxBlockSize, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>contain</c>. If the box has a preferred aspect ratio, applies contain-fit sizing, attempting to fit into the box’s constraints while maintaining its preferred aspect ratio insofar as possible. See § 6.2 Contain-fit Sizing: stretching while maintaining an aspect ratio. If the box has no preferred aspect ratio, applies stretch-fit sizing.
	/// </summary>
	public MaxBlockSizeProperty SetToContain()
	{
		Value = CssValues.Contain;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>fit-content</c>. Essentially fit-content(stretch) i.e. min(max-content, max(min-content, stretch)).
	/// </summary>
	public MaxBlockSizeProperty SetToFitContent()
	{
		Value = CssValues.FitContent;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>stretch</c>. Applies stretch-fit sizing, attempting to match the size of the box’s margin box to the size of its containing block. See § 6.1 Stretch-fit Sizing: filling the containing block.
	/// </summary>
	public MaxBlockSizeProperty SetToStretch()
	{
		Value = CssValues.Stretch;
		return this;
	}


}