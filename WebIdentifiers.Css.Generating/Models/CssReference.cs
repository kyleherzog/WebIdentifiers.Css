using System.Runtime.Serialization;

namespace WebIdentifiers.Css.Generating.Models;

[DataContract]
public class CssReference
{
    [DataMember(Name = "properties")]
    public IList<CssProperty> Properties { get; } = new List<CssProperty>();

    [DataMember(Name = "values")]
    public IList<CssPropertyValue> Values { get; } = new List<CssPropertyValue>();
}