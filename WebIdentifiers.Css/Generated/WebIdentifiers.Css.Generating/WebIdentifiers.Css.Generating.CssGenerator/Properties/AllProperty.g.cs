﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the All property.
/// </summary>
public partial class AllProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a all CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public AllProperty(string? value = null)
		: base(CssPropertyNames.All, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>inherit</c>. The inherit CSS-wide keyword represents the property’s computed value on the parent element.
	/// </summary>
	public AllProperty SetToInherit()
	{
		Value = CssValues.Inherit;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>initial</c>. The initial CSS-wide keyword represents the value defined as the property’s initial value.
	/// </summary>
	public AllProperty SetToInitial()
	{
		Value = CssValues.Initial;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>revert</c>. The revert CSS-wide keyword rolls back the cascade to the cascaded value of the earlier origin.
	/// </summary>
	public AllProperty SetToRevert()
	{
		Value = CssValues.Revert;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>revert-layer</c>. The revert-layer CSS-wide keyword rolls back the cascade similar to revert, except it works by cascade layer rather than by cascade origin.
	/// </summary>
	public AllProperty SetToRevertLayer()
	{
		Value = CssValues.RevertLayer;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>unset</c>. The unset CSS-wide keyword acts as either inherit or initial, depending on whether the property is inherited or not.
	/// </summary>
	public AllProperty SetToUnset()
	{
		Value = CssValues.Unset;
		return this;
	}


}