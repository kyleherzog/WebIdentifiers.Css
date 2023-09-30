﻿// <autogenerated/>
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the RestAfter property.
/// </summary>
public partial class RestAfterProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a rest-after CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public RestAfterProperty(string? value = null)
		: base(CssPropertyNames.RestAfter, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>medium</c>. Expresses the rest by the strength of the prosodic break in speech output. The exact time is implementation-dependent. The values indicate monotonically non-decreasing (conceptually increasing) break strength between elements.
	/// </summary>
	public RestAfterProperty SetToMedium()
	{
		Value = CssValues.Medium;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>none</c>. Equivalent to 0ms. (No prosodic break is produced by the speech processor.)
	/// </summary>
	public RestAfterProperty SetToNone()
	{
		Value = CssValues.None;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>strong</c>. Expresses the rest by the strength of the prosodic break in speech output. The exact time is implementation-dependent. The values indicate monotonically non-decreasing (conceptually increasing) break strength between elements.
	/// </summary>
	public RestAfterProperty SetToStrong()
	{
		Value = CssValues.Strong;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>weak</c>. Expresses the rest by the strength of the prosodic break in speech output. The exact time is implementation-dependent. The values indicate monotonically non-decreasing (conceptually increasing) break strength between elements.
	/// </summary>
	public RestAfterProperty SetToWeak()
	{
		Value = CssValues.Weak;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>x-strong</c>. Expresses the rest by the strength of the prosodic break in speech output. The exact time is implementation-dependent. The values indicate monotonically non-decreasing (conceptually increasing) break strength between elements.
	/// </summary>
	public RestAfterProperty SetToXStrong()
	{
		Value = CssValues.XStrong;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>x-weak</c>. Expresses the rest by the strength of the prosodic break in speech output. The exact time is implementation-dependent. The values indicate monotonically non-decreasing (conceptually increasing) break strength between elements.
	/// </summary>
	public RestAfterProperty SetToXWeak()
	{
		Value = CssValues.XWeak;
		return this;
	}


}