﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the MarkerSide property.
/// </summary>
public partial class MarkerSideProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a marker-side CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public MarkerSideProperty(string? value = null)
		: base(CssPropertyNames.MarkerSide, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>match-parent</c>. The marker box is positioned using the directionality of the ::marker’s originating element’s parent element.
	/// </summary>
	public MarkerSideProperty SetToMatchParent()
	{
		Value = CssValues.MatchParent;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>match-self</c>. The marker box is positioned using the directionality of the ::marker’s originating element.
	/// </summary>
	public MarkerSideProperty SetToMatchSelf()
	{
		Value = CssValues.MatchSelf;
		return this;
	}


}