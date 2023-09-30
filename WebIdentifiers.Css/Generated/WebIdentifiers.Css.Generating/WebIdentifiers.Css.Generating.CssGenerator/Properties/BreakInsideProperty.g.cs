﻿// <autogenerated/>
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the BreakInside property.
/// </summary>
public partial class BreakInsideProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a break-inside CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public BreakInsideProperty(string? value = null)
		: base(CssPropertyNames.BreakInside, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>auto</c>. Impose no additional breaking constraints within the box.
	/// </summary>
	public BreakInsideProperty SetToAuto()
	{
		Value = CssValues.Auto;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>avoid</c>. Avoid breaks within the box.
	/// </summary>
	public BreakInsideProperty SetToAvoid()
	{
		Value = CssValues.Avoid;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>avoid-column</c>. Avoid a column break within the box.
	/// </summary>
	public BreakInsideProperty SetToAvoidColumn()
	{
		Value = CssValues.AvoidColumn;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>avoid-page</c>. Avoid a page break within the box.
	/// </summary>
	public BreakInsideProperty SetToAvoidPage()
	{
		Value = CssValues.AvoidPage;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>avoid-region</c>. Avoid a region break within the box.
	/// </summary>
	public BreakInsideProperty SetToAvoidRegion()
	{
		Value = CssValues.AvoidRegion;
		return this;
	}


}