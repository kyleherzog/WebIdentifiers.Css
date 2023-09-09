namespace WebIdentifiers.Css.Generating.Models;

public class CssProperty
{
    public string Name { get; set; }

    public string Value { get; set; }

    public string Initial { get; set; }

    public string AppliesTo { get; set; }

    public string Inherited { get; set; }

    public string Percentages { get; set; }

    public string ComputedValue { get; set; }

    public string CanonicalOrder { get; set; }

    public string Media { get; set; }

    public List<CssPropertyValue> Values { get; set; }

    public List<string> StyleDeclaration { get; set; }
}