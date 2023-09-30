﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the CounterIncrement property.
/// </summary>
public partial class CounterIncrementProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a counter-increment CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public CounterIncrementProperty(string? value = null)
		: base(CssPropertyNames.CounterIncrement, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>list-item</c>. In addition to any explicitly defined counters that authors write in their styles, list items automatically increment a special list-item counter, which is used when generating the default marker string on list items (see list-style-type).
	/// </summary>
	public CounterIncrementProperty SetToListItem()
	{
		Value = CssValues.ListItem;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>none</c>. This element does not alter the value of any counters.
	/// </summary>
	public CounterIncrementProperty SetToNone()
	{
		Value = CssValues.None;
		return this;
	}


}