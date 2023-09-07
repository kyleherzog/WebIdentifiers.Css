using System;
using System.Collections.Generic;
using System.Text;

namespace WebIdentifiers.Css.Values;

/// <summary>
/// A base class for CSS property values.
/// </summary>
public abstract class PropertyValuesBase
{
    /// <summary>
    /// Gets the predefined <c>inherit</c> property value, which indicates that the value of the property should be inherited from the parent element.
    /// </summary>
    public string Inherit => "inherit";

    /// <summary>
    /// Gets the predefined <c>initial</c> property value, which indicates that the property should be set to its default value.
    /// </summary>
    public string Initial => "initial";
}