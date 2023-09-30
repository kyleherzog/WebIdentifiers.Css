﻿// <autogenerated/>
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the WordBreak property.
/// </summary>
public partial class WordBreakProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a word-break CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public WordBreakProperty(string? value = null)
		: base(CssPropertyNames.WordBreak, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>auto-phrase</c>. Behaves the same as normal, except that this value directs the user agent to perform language-specific content analysis to prioritize keeping natural phrases (of multiple words) together. If the content language of the element is unknown, or if the user agent does not know how to detect phrase boundaries for that particular language, this value must behave as normal. Otherwise, the user agent should detect phrase boundaries and suppress soft wrap opportunities within each phrase. Regardless of the content language and support for phrase boundary detection, hyphenation opportunities are suppressed as if hyphens: none had been specified.
	/// </summary>
	public WordBreakProperty SetToAutoPhrase()
	{
		Value = CssValues.AutoPhrase;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>break-all</c>. Breaking is allowed within “words”: specifically, in addition to soft wrap opportunities allowed for normal, any typographic letter units (and any typographic character units resolving to the NU (“numeric”), AL (“alphabetic”), or SA (“Southeast Asian”) line breaking classes [UAX14]) are instead treated as ID (“ideographic characters”) for the purpose of line-breaking. Hyphenation is not applied.
	/// </summary>
	public WordBreakProperty SetToBreakAll()
	{
		Value = CssValues.BreakAll;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>break-word</c>. For compatibility with legacy content, the word-break property also supports a deprecated break-word keyword. When specified, this has the same effect as word-break: normal and overflow-wrap: anywhere, regardless of the actual value of the overflow-wrap property.
	/// </summary>
	public WordBreakProperty SetToBreakWord()
	{
		Value = CssValues.BreakWord;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>keep-all</c>. Breaking is forbidden within “words”: implicit soft wrap opportunities between typographic letter units (or other typographic character units belonging to the NU, AL, AI, or ID Unicode line breaking classes [UAX14]) are suppressed, i.e. breaks are prohibited between pairs of such characters (regardless of line-break settings other than anywhere) except where opportunities exist due to § 6.1.1.1 Lexical Word Breaking. Otherwise this option is equivalent to normal. In this style, sequences of CJK characters do not break.
	/// </summary>
	public WordBreakProperty SetToKeepAll()
	{
		Value = CssValues.KeepAll;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>manual</c>. Behaves the same as normal, except that § 6.1.1.1 Lexical Word Breaking must not be performed. Specifically, typographic character units with class SA in [UAX14] must be treated as if they had class AL (i.e. assuming a value of line-break other than anywhere, there is no soft wrap opportunity between pairs of such characters). alternatively, this value could be based on keep-all rather than normal. Yet another variant is to merge this behavior with keep-all.
	/// </summary>
	public WordBreakProperty SetToManual()
	{
		Value = CssValues.Manual;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>normal</c>. Words break according to their customary rules, as described above. Korean, which commonly exhibits two different behaviors, allows breaks between any two consecutive Hangul/Hanja. For Ethiopic, which also exhibits two different behaviors, such breaks within words are not allowed. Some writing systems require specific processing to obtain the customarily expected soft wrap opportunities, as described in § 6.1.1 Analytical Word Breaking.
	/// </summary>
	public WordBreakProperty SetToNormal()
	{
		Value = CssValues.Normal;
		return this;
	}


}