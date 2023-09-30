using CodeCasing;
using Microsoft.CodeAnalysis;
using WebIdentifiers.Css.Generating.Models;

namespace WebIdentifiers.Css.Generating;
internal static class CssPropertyNamesGenerator
{
    internal static string Generate(IEnumerable<CssReference> references)
    {
        var propertiesWriter = new ClassWriter();

        propertiesWriter.AddLine("namespace WebIdentifiers.Css;");
        propertiesWriter.AddLine();

        propertiesWriter.AddXmlDocSummary("Provides the names of CSS properties.");
        propertiesWriter.OpenClass("CssPropertyNames", isStatic: true);

        var lastProperty = string.Empty;
        foreach (var property in references.Where(x => x.Properties is not null).SelectMany(x => x.Properties).OrderBy(x => x.Name))
        {
            if (!lastProperty.Equals(property.Name, StringComparison.Ordinal))
            {
                lastProperty = property.Name;
                propertiesWriter.AddXmlDocSummary($"Gets the name of the <c>{property.Name}</c> property.");
                propertiesWriter.AddLine($"public const string {property.Name.ToPascalCase()} = \"{property.Name}\";");
                propertiesWriter.AddLine();
            }
        }

        propertiesWriter.CloseClass();

        return propertiesWriter.ToString();
    }
}
