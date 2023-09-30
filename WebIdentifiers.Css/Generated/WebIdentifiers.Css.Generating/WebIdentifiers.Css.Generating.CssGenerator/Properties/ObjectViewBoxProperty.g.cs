﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the ObjectViewBox property.
/// </summary>
public partial class ObjectViewBoxProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a object-view-box CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public ObjectViewBoxProperty(string? value = null)
		: base(CssPropertyNames.ObjectViewBox, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>none</c>. The element does not have a view box.
	/// </summary>
	public ObjectViewBoxProperty SetToNone()
	{
		Value = CssValues.None;
		return this;
	}


}