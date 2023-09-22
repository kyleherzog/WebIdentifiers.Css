﻿// <autogenerated/>
namespace WebIdentifiers.Css.Values;

public partial class HyphensValues : PropertyValuesBase
{
	/// <summary>
	/// Gets the name of the <c>auto</c> property. Words may be broken at hyphenation opportunities determined automatically by a language-appropriate hyphenation resource in addition to those indicated explicitly by a conditional hyphen. Automatic hyphenation opportunities elsewhere within a word must be ignored if the word contains a conditional hyphen (&shy; or U+00AD SOFT HYPHEN), in favor of the conditional hyphen(s). However, if, even after breaking at such opportunities, a portion of that word is still too long to fit on one line, an automatic hyphenation opportunity may be used.
	/// </summary>
	public string Auto => CssValues.Auto;

	/// <summary>
	/// Gets the name of the <c>manual</c> property. Words are only hyphenated where there are characters inside the word that explicitly suggest hyphenation opportunities. The UA must use the appropriate language-specific hyphenation character(s) and should apply any appropriate spelling changes just as for automatic hyphenation at the same point. In Unicode, U+00AD is a conditional "soft hyphen" and U+2010 is an unconditional hyphen. Unicode Standard Annex #14 describes the role of soft hyphens in Unicode line breaking. [UAX14] In HTML, &shy; represents the soft hyphen character, which suggests a hyphenation opportunity. ex&shy;ample
	/// </summary>
	public string Manual => CssValues.Manual;

	/// <summary>
	/// Gets the name of the <c>none</c> property. Words are not hyphenated, even if characters inside the word explicitly define hyphenation opportunities.
	/// </summary>
	public string None => CssValues.None;

}