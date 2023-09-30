﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Values;

/// <summary>
/// Provides values which are valid for the <c>margin-break</c> property.
/// </summary>
public partial class MarginBreakValues : PropertyValuesBase
{
	/// <summary>
	/// Gets the name of the <c>auto</c> property. When an unforced break occurs before or after the box, any margins adjoining the break truncate to the remaining fragmentainer extent before the break, and are truncated to zero after the break. When a forced break occurs there, adjoining margins before the break are truncated, but margins after the break are preserved. Cloned margins are always truncated to zero.
	/// </summary>
	public string Auto => CssValues.Auto;

	/// <summary>
	/// Gets the name of the <c>discard</c> property. Margins adjoining a fragmentation break are always truncated, including at the start and end of a fragmentation context.
	/// </summary>
	public string Discard => CssValues.Discard;

	/// <summary>
	/// Gets the name of the <c>keep</c> property. Margins adjoining a fragmentation break are not truncated.
	/// </summary>
	public string Keep => CssValues.Keep;

}