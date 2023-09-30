﻿// <autogenerated/>
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the OffsetPath property.
/// </summary>
public partial class OffsetPathProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a offset-path CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public OffsetPathProperty(string? value = null)
		: base(CssPropertyNames.OffsetPath, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>none</c>. The element does not have an offset transform.
	/// </summary>
	public OffsetPathProperty SetToNone()
	{
		Value = CssValues.None;
		return this;
	}


}