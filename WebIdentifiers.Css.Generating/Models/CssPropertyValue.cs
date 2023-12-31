using System.Runtime.Serialization;

namespace WebIdentifiers.Css.Generating.Models;

[DataContract]
public record CssPropertyValue
{
    [DataMember(Name = "name")]
    public string Name { get; set; } = string.Empty;

    [DataMember(Name = "prose")]
    public string? Prose { get; set; }

    [DataMember(Name = "type")]
    public string? Type { get; set; }

    [DataMember(Name = "value")]
    public string? Value { get; set; }

    [DataMember(Name = "values")]
    public IList<CssPropertyValue> Values { get; set; }

    public bool IsUnitOfMeasure { get; set; }
}