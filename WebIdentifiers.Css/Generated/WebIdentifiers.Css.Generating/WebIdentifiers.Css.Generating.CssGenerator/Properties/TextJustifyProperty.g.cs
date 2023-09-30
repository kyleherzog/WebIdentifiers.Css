﻿// <autogenerated/>
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the TextJustify property.
/// </summary>
public partial class TextJustifyProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a text-justify CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public TextJustifyProperty(string? value = null)
		: base(CssPropertyNames.TextJustify, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>auto</c>. The UA determines the justification algorithm to follow, based on a balance between performance and adequate presentation quality. Since justification rules vary by writing system and language, UAs should, where possible, use a justification algorithm appropriate to the text. For example, the UA could use by default a justification method that is a simple universal compromise for all writing systems—such as primarily expanding word separators and between CJK typographic letter units along with secondarily expanding between Southeast Asian typographic letter units. Then, in cases where the content language of the paragraph is known, it could choose a more language-tailored justification behavior e.g. following the Requirements for Japanese Text Layout for Japanese [JLREQ], using cursive elongation for Arabic, using inter-word for German, etc. An example of cursively-justified Arabic text, rendered by Tasmeem. Like English, Arabic can be justified by adjusting the spacing between words, but in most styles it can also be justified by calligraphically elongating or compressing the letterforms themselves. In this example, the upper text is extended to fill the line by the use of elongated (kashida) forms and swash forms, while the bottom line is compressed slightly by using a stacked combination for the characters between ت and م. By employing traditional calligraphic techniques, a typesetter can justify the line while preserving flow and color, providing a very high quality justification effect. However, this is by its nature a very script-specific effect. Mixed-script text with text-justify: auto: this interpretation uses a universal-compromise justification method, expanding at spaces as well as between CJK and Southeast Asian letters. This effectively uses inter-word + inter-ideograph spacing for lines that have word-separators and/or CJK characters and falls back to inter-cluster behavior for lines that don’t or for which the space stretches too far.
	/// </summary>
	public TextJustifyProperty SetToAuto()
	{
		Value = CssValues.Auto;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>distribute</c>. For legacy reasons, UAs must also support the alternate keyword distribute which must compute to inter-character, thus having the exact same meaning and behavior. UAs may treat this as a legacy value alias.
	/// </summary>
	public TextJustifyProperty SetToDistribute()
	{
		Value = CssValues.Distribute;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>inter-character</c>. Justification adjusts spacing between each pair of adjacent typographic character units (effectively varying the used letter-spacing on the line). This value is sometimes used in East Asian systems such as Japanese. Mixed-script text with text-justify: inter-character For legacy reasons, UAs must also support the alternate keyword distribute which must compute to inter-character, thus having the exact same meaning and behavior. UAs may treat this as a legacy value alias.
	/// </summary>
	public TextJustifyProperty SetToInterCharacter()
	{
		Value = CssValues.InterCharacter;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>inter-word</c>. Justification adjusts spacing at word separators only (effectively varying the used word-spacing on the line). This behavior is typical for languages that separate words using spaces, like English or Korean. Mixed-script text with text-justify: inter-word
	/// </summary>
	public TextJustifyProperty SetToInterWord()
	{
		Value = CssValues.InterWord;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>no-compress</c>. Justification must not compress spacing controlled by text-spacing-trim or text-autospace. (If this value is not specified, the justification process may reduce such spacing except when the spacing is at the start or end of the line.) This keyword used to be part of text-spacing; it might need renaming to be more specific now that it’s here, as it implies that e.g. U+0020 cannot be compressed. [Issue #7079]
	/// </summary>
	public TextJustifyProperty SetToNoCompress()
	{
		Value = CssValues.NoCompress;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>none</c>. Justification is disabled: there are no justification opportunities within the text. Mixed-script text with text-justify: none
	/// </summary>
	public TextJustifyProperty SetToNone()
	{
		Value = CssValues.None;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>ruby</c>. Justification adjusts spacing as for auto except: Justification opportunities are disabled at word separators. Justification opportunities are disabled between Bopomofo characters
	/// </summary>
	public TextJustifyProperty SetToRuby()
	{
		Value = CssValues.Ruby;
		return this;
	}


}