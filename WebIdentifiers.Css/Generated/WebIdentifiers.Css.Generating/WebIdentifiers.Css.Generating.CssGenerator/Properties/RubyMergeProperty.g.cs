﻿// <autogenerated/>
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the RubyMerge property.
/// </summary>
public partial class RubyMergeProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a ruby-merge CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public RubyMergeProperty(string? value = null)
		: base(CssPropertyNames.RubyMerge, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>auto</c>. The user agent may use any algorithm to determine how each ruby annotation box is rendered to its corresponding base box, with the intention that if all annotations fit over their respective bases, the result is identical to separate, but if some annotations are wider than their bases the space is shared in some way to avoid imposing space between bases. ruby-merge: auto with center alignment
	/// </summary>
	public RubyMergeProperty SetToAuto()
	{
		Value = CssValues.Auto;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>merge</c>. All ruby annotation boxes within the same ruby segment on the same line are concatenated as inline boxes within their annotation container, and laid out in a single anonymous ruby annotation box spanning all their associated ruby base boxes. When laid out on a single line, this style renders similar to “group ruby” in [JLREQ]. However, when it breaks across lines, ruby annotations are kept together with their respective ruby bases. ruby-merge: merge with center alignment The following two lines render the same if both characters fit on one line: <p><ruby>無常<rt>むじょう</ruby> <p><ruby style="ruby-merge:merge"><rb>無<rb>常<rt>む<rt>じょう</ruby> However, the second one renders the same as ruby-position: separate when the two bases are split across lines.
	/// </summary>
	public RubyMergeProperty SetToMerge()
	{
		Value = CssValues.Merge;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>separate</c>. Each ruby annotation box is rendered within the same column(s) as its corresponding base box(es), i.e. without overlapping adjacent bases on either side. This style is called “mono ruby” in [JLREQ]. ruby-merge: separate with center alignment For example, the following two lines render the same: <p><ruby>無<rt>む</ruby><ruby>常<rt>じょう</ruby> <p><ruby style="ruby-merge:separate"><rb>無<rb>常<rt>む<rt>じょう</ruby>
	/// </summary>
	public RubyMergeProperty SetToSeparate()
	{
		Value = CssValues.Separate;
		return this;
	}


}