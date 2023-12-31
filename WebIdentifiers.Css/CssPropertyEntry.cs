namespace WebIdentifiers.Css;

/// <summary>
/// Represents a CSS property/value entry.
/// </summary>
public class CssPropertyEntry
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CssPropertyEntry"/> class.
    /// </summary>
    /// <param name="property">The name of the property.</param>
    /// <param name="value">An optional value with which to initialize the CSS property value.</param>
    public CssPropertyEntry(string property, string? value = null)
    {
        Property = property;
        Value = value;
    }

    /// <summary>
    /// Gets the name of the CSS property entry.
    /// </summary>
    public string Property { get; }

    /// <summary>
    /// Gets the value of the CSS property.
    /// </summary>
    public string? Value { get; protected set; }

    /// <summary>
    /// Sets the property value to the value specified.
    /// </summary>
    /// <param name="value">The value to be applied.</param>
    /// <returns>This instance of <see cref="CssPropertyEntry"/>.</returns>
    public CssPropertyEntry SetTo(string value)
    {
        Value = value;
        return this;
    }

    public static implicit operator string(CssPropertyEntry entry) => entry.ToString();

    public static bool operator ==(CssPropertyEntry? left, CssPropertyEntry? right)
    {
        if (left is null && right is null)
        {
            return true;
        }

        return left?.Equals(right) ?? false;
    }

    public static bool operator !=(CssPropertyEntry? left, CssPropertyEntry? right)
    {
        return !(left == right);
    }

    /// <inheritdoc/>
    public override string ToString()
    {
        if (!string.IsNullOrEmpty(Value))
        {
            return $"{Property}: {Value};";
        }

        return Property;
    }

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        return ToString().GetHashCode();
    }

    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        if (obj is null)
        {
            return false;
        }

        if (obj is string otherString)
        {
            return ToString().Equals(otherString);
        }

        if (obj is CssPropertyEntry otherAttribute)
        {
            return Property == otherAttribute.Property
                && Value == otherAttribute.Value;
        }

        return false;
    }
}