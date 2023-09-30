﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the ColumnCount property.
/// </summary>
public partial class ColumnCountProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a column-count CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public ColumnCountProperty(string? value = null)
		: base(CssPropertyNames.ColumnCount, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>auto</c>. means that the number of columns will be determined by other properties (e.g., column-width, if it has a non-auto value).
	/// </summary>
	public ColumnCountProperty SetToAuto()
	{
		Value = CssValues.Auto;
		return this;
	}


}