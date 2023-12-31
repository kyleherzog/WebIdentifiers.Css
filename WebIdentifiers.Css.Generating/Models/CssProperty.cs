using System.Runtime.Serialization;

namespace WebIdentifiers.Css.Generating.Models;

[DataContract]
public class CssProperty
{
    [DataMember(Name = "name")]
    public string Name { get; set; } = string.Empty;

    [DataMember(Name = "value")]
    public string? Value { get; set; }

    [DataMember(Name = "initial")]
    public string? Initial { get; set; }

    [DataMember(Name = "appliesTo")]
    public string? AppliesTo { get; set; }

    [DataMember(Name = "inherited")]
    public string? Inherited { get; set; }

    [DataMember(Name = "percentages")]
    public string? Percentages { get; set; }

    [DataMember(Name = "computedValue")]
    public string? ComputedValue { get; set; }

    [DataMember(Name = "canonicalOrder")]
    public string? CanonicalOrder { get; set; }

    [DataMember(Name = "media")]
    public string? Media { get; set; }

    [DataMember(Name = "values")]
    public List<CssPropertyValue> Values { get; set; }

    [DataMember(Name = "styleDeclaration")]
    public List<string>? StyleDeclaration { get; set; }
}