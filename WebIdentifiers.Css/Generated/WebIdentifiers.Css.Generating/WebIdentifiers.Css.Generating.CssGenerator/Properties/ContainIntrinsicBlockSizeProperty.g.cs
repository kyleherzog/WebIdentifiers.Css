﻿// <autogenerated/>
namespace WebIdentifiers.Css.Properties;

/// <summary>
/// Provides a CSS entry for the ContainIntrinsicBlockSize property.
/// </summary>
public partial class ContainIntrinsicBlockSizeProperty : CssPropertyEntry
{
	/// <summary>
	/// Represents a contain-intrinsic-block-size CSS property entry.
	/// </summary>
	/// <param name="value">An optional value with which to initialize the CSS property entry.</param>
	public ContainIntrinsicBlockSizeProperty(string? value = null)
		: base(CssPropertyNames.ContainIntrinsicBlockSize, value)
	{
	}

	/// <summary>
	/// Sets the value of the property entry to <c>auto</c>. If auto is specified and the element has a last remembered size and is currently skipping its contents, its explicit intrinsic inner size in the corresponding axis is the last remembered size in that axis. Otherwise, the corresponding axis either doesn’t have an explicit intrinsic inner size (if none is specified) or has an explicit intrinsic inner size of the specified <length>.
	/// </summary>
	public ContainIntrinsicBlockSizeProperty SetToAuto()
	{
		Value = CssValues.Auto;
		return this;
	}


	/// <summary>
	/// Sets the value of the property entry to <c>none</c>. If auto is specified and the element has a last remembered size and is currently skipping its contents, its explicit intrinsic inner size in the corresponding axis is the last remembered size in that axis. Otherwise, the corresponding axis either doesn’t have an explicit intrinsic inner size (if none is specified) or has an explicit intrinsic inner size of the specified <length>.
	/// </summary>
	public ContainIntrinsicBlockSizeProperty SetToNone()
	{
		Value = CssValues.None;
		return this;
	}


}