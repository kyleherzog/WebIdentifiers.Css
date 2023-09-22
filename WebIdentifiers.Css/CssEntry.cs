using System;
using System.Collections.Generic;
using System.Text;

namespace WebIdentifiers.Css;
public struct CssEntry : IEquatable<CssEntry>
{
    public CssEntry(string property, string? value = null)
    {
        Property = property;
        Value = value;
    }

    /// <summary>
    /// Gets the name of the attribute.
    /// </summary>
    public string Property { get; }

    /// <summary>
    /// Gets the value of the attribute.
    /// </summary>
    public string? Value { get; }

    public CssEntry SetTo(string value)
    {
        return new CssEntry(Property, value);
    }

    public static implicit operator string(CssEntry entry) => entry.ToString();

    public static bool operator ==(CssEntry? left, CssEntry? right)
    {
        if (left is null && right is null)
        {
            return true;
        }

        return left?.Equals(right) ?? false;
    }

    public static bool operator !=(CssEntry? left, CssEntry? right)
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

    public bool Equals(CssEntry other)
    {
        return Equals((object)other);
    }
}
