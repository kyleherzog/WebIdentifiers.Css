﻿// <autogenerated/>
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the ColorInterpolationFilters property.
/// </summary>
public partial class ColorInterpolationFiltersProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a color-interpolation-filters CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public ColorInterpolationFiltersProperty(string? value = null)
		: base(CssPropertyNames.ColorInterpolationFilters, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>auto</c>. Indicates that the user agent can choose either the sRGB or linearRGB spaces for filter effects color operations. This option indicates that the author doesn’t require that color operations occur in a particular color space.
	/// </summary>
	public ColorInterpolationFiltersProperty SetToAuto()
	{
		Value = CssValues.Auto;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>linearRGB</c>. Indicates that filter effects color operations should occur in the linear-light sRGB color space.
	/// </summary>
	public ColorInterpolationFiltersProperty SetToLinearrgb()
	{
		Value = CssValues.Linearrgb;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>sRGB</c>. Indicates that filter effects color operations should occur in the gamma-encoded sRGB color space.
	/// </summary>
	public ColorInterpolationFiltersProperty SetToSrgb()
	{
		Value = CssValues.Srgb;
		return this;
	}


}