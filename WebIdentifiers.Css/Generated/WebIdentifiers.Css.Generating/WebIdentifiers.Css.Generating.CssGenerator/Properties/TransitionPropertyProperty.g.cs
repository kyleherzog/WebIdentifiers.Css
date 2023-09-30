﻿// <autogenerated/>
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the TransitionProperty property.
/// </summary>
public partial class TransitionPropertyProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a transition-property CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public TransitionPropertyProperty(string? value = null)
		: base(CssPropertyNames.TransitionProperty, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>all</c>. A value of none means that no property will transition. Otherwise, a list of properties to be transitioned, or the keyword all which indicates that all properties are to be transitioned, is given.
	/// </summary>
	public TransitionPropertyProperty SetToAll()
	{
		Value = CssValues.All;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>none</c>. A value of none means that no property will transition. Otherwise, a list of properties to be transitioned, or the keyword all which indicates that all properties are to be transitioned, is given.
	/// </summary>
	public TransitionPropertyProperty SetToNone()
	{
		Value = CssValues.None;
		return this;
	}


}