﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the Hyphens property.
/// </summary>
public partial class HyphensProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a hyphens CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public HyphensProperty(string? value = null)
		: base(CssPropertyNames.Hyphens, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>auto</c>. Words may be broken at hyphenation opportunities determined automatically by a language-appropriate hyphenation resource in addition to those indicated explicitly by a conditional hyphen. Automatic hyphenation opportunities elsewhere within a word must be ignored if the word contains a conditional hyphen (&amp;shy; or U+00AD SOFT HYPHEN), in favor of the conditional hyphen(s). However, if, even after breaking at such opportunities, a portion of that word is still too long to fit on one line, an automatic hyphenation opportunity may be used.
	/// </summary>
	public HyphensProperty SetToAuto()
	{
		Value = CssValues.Auto;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>manual</c>. Words are only hyphenated where there are characters inside the word that explicitly suggest hyphenation opportunities. The UA must use the appropriate language-specific hyphenation character(s) and should apply any appropriate spelling changes just as for automatic hyphenation at the same point. In Unicode, U+00AD is a conditional &quot;soft hyphen&quot; and U+2010 is an unconditional hyphen. Unicode Standard Annex #14 describes the role of soft hyphens in Unicode line breaking. [UAX14] In HTML, &amp;shy; represents the soft hyphen character, which suggests a hyphenation opportunity. ex&amp;shy;ample
	/// </summary>
	public HyphensProperty SetToManual()
	{
		Value = CssValues.Manual;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>none</c>. Words are not hyphenated, even if characters inside the word explicitly define hyphenation opportunities.
	/// </summary>
	public HyphensProperty SetToNone()
	{
		Value = CssValues.None;
		return this;
	}


}