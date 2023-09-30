﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the Clear property.
/// </summary>
public partial class ClearProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a clear CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public ClearProperty(string? value = null)
		: base(CssPropertyNames.Clear, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>all</c>. Behave like both-block and both-inline.
	/// </summary>
	public ClearProperty SetToAll()
	{
		Value = CssValues.All;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>block-end</c>. If applied to a block-level element or an inline float, behaves like inline-end. If applied to a page float, the float reference in which the page float is placed will be seen as full when determining whether it can host subsequent page floats that float in the block-end direction.
	/// </summary>
	public ClearProperty SetToBlockEnd()
	{
		Value = CssValues.BlockEnd;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>block-start</c>. If applied to a block-level element or an inline float, behaves like inline-start. If applied to a page float, the float reference in which the page float is placed will be seen as full when determining whether it can host subsequent page floats that float in the block-start direction.
	/// </summary>
	public ClearProperty SetToBlockStart()
	{
		Value = CssValues.BlockStart;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>both</c>. Behave like both-inline.
	/// </summary>
	public ClearProperty SetToBoth()
	{
		Value = CssValues.Both;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>both-block</c>. Behave like block-start and block-end.
	/// </summary>
	public ClearProperty SetToBothBlock()
	{
		Value = CssValues.BothBlock;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>both-inline</c>. Behave like inline-start and inline-end.
	/// </summary>
	public ClearProperty SetToBothInline()
	{
		Value = CssValues.BothInline;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>bottom</c>. Behave like block-end or inline-end depending on the float containing block’s direction and writing-mode.
	/// </summary>
	public ClearProperty SetToBottom()
	{
		Value = CssValues.Bottom;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>inline-end</c>. If applied to a block-level element or an inline float, requires that the block-start outer edge of the box comes after the block-end outer edge of any inline-end-floats with an inline-end-float-reference that resulted from elements earlier in the source document. If applied to a page float, the float reference in which the page float is placed will be seen as full when determining whether it can host subsequent page floats that float in the inline-end direction.
	/// </summary>
	public ClearProperty SetToInlineEnd()
	{
		Value = CssValues.InlineEnd;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>inline-start</c>. If applied to an inline float, requires that the block-start outer edge of the box comes after the block-end outer edge of any inline-start-floats with an inline-start-float-reference that resulted from elements earlier in the source document. If applied to a page float, the float reference in which the page float is placed will be seen as full when determining whether it can host subsequent page floats that float in the inline-start direction.
	/// </summary>
	public ClearProperty SetToInlineStart()
	{
		Value = CssValues.InlineStart;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>left</c>. Behave like block-end, inline-start or inline-end depending on the float containing block’s direction and writing-mode.
	/// </summary>
	public ClearProperty SetToLeft()
	{
		Value = CssValues.Left;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>none</c>. No constraint on the box’s position with respect to floats.
	/// </summary>
	public ClearProperty SetToNone()
	{
		Value = CssValues.None;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>right</c>. Behave like block-start, inline-start or inline-end depending on the float containing block’s direction and writing-mode.
	/// </summary>
	public ClearProperty SetToRight()
	{
		Value = CssValues.Right;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>top</c>. Behave like block-start or inline-start depending on the float containing block’s direction and writing-mode.
	/// </summary>
	public ClearProperty SetToTop()
	{
		Value = CssValues.Top;
		return this;
	}


}