﻿// <autogenerated/>
#nullable enable
namespace WebIdentifiers.Css.Values;

/// <summary>
/// Provides values which are valid for the <c>animation-play-state</c> property.
/// </summary>
public partial class AnimationPlayStateValues : PropertyValuesBase
{
	/// <summary>
	/// Gets the name of the <c>paused</c> property. While this property is set to paused, the animation is paused. The animation continues to apply to the element with the progress it had made before being paused. When unpaused (set back to running), it restarts from where it left off, as if the &quot;clock&quot; that controls the animation had stopped and started again. If the property is set to paused during the delay phase of the animation, the delay clock is also paused and resumes as soon as animation-play-state is set back to running.
	/// </summary>
	public string Paused => CssValues.Paused;

	/// <summary>
	/// Gets the name of the <c>running</c> property. While this property is set to running, the animation proceeds as normal.
	/// </summary>
	public string Running => CssValues.Running;

}