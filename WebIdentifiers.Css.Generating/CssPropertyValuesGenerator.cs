using System.Xml.Linq;
using CodeCasing;
using WebIdentifiers.Css.Generating.Models;

namespace WebIdentifiers.Css.Generating;

internal static class CssPropertyValuesGenerator
{
    public static string Generate(IEnumerable<CssReference> references)
    {
        var valuesWriter = new ClassWriter();
        valuesWriter.AddUsings("WebIdentifiers.Css.Values");

        valuesWriter.AddLine("namespace WebIdentifiers.Css;");
        valuesWriter.AddLine();

        valuesWriter.AddXmlDocSummary("Provides predefined CSS values.");
        valuesWriter.OpenClass("CssValues", isStatic: true);

        var valuedProperties = references.Where(x => x.Properties is not null).SelectMany(x => x.Properties)
            .Where(x => x.Values is not null);
        var valueNames = valuedProperties
            .SelectMany(x => x.Values)
            .Select(x => x.Name)
            .Where(x => !x.Contains('<') && !x.Contains('|') && !x.StartsWith("[") && !x.EndsWith(")") && !x.StartsWith("/") && !x.Contains('&'))
            .Distinct()
            .OrderBy(x => x);

        foreach (var valueName in valueNames)
        {
            valuesWriter.AddXmlDocSummary($"Gets the name of the <c>{valueName}</c> property value.");
            valuesWriter.AddLine($"public const string {valueName.ToPascalCase()} = \"{valueName}\";");
            valuesWriter.AddLine();
        }

        foreach (var propertyName in references.Where(x => x.Properties is not null).SelectMany(x => x.Properties).Select(x => x.Name).Distinct())
        {
            valuesWriter.AddXmlDocSummary($"Gets values which are valid for the <c>{propertyName}</c> property.");
            valuesWriter.AddLine($"public static {propertyName.ToPascalCase()}Values For{propertyName.ToPascalCase()} = new();");
            valuesWriter.AddLine();
        }

        valuesWriter.CloseClass();
        return valuesWriter.ToString();
    }

    public static Dictionary<string, string> GeneratePerProperty(IEnumerable<CssReference> references)
    {
        var results = new Dictionary<string, string>();
        var keys = new Dictionary<string, int>();
        var propertyGroups = references.Where(x => x.Properties is not null).SelectMany(x => x.Properties).GroupBy(x => x.Name);

        foreach (var property in propertyGroups)
        {
            var values = property.Where(x => x.Values is not null).SelectMany(x => x.Values)
                ?.Where(x => !x.Name.Contains('<') && !x.Name.Contains('|') && !x.Name.StartsWith("[") && !x.Name.EndsWith(")") && !x.Name.StartsWith("/") && !x.Name.Contains('&'))
                .OrderBy(x => x.Name)
                ?? Enumerable.Empty<CssPropertyValue>();

            var writer = new ClassWriter();

            writer.AddLine("namespace WebIdentifiers.Css.Values;");
            writer.AddLine();

            writer.AddXmlDocSummary($"Provides values which are valid for the <c>{property.Key}</c> property.");
            writer.OpenClass($"{property.Key.ToPascalCase()}Values", "PropertyValuesBase");

            if (values.Any())
            {
                var lastValue = string.Empty;
                foreach (var value in values)
                {
                    if (!lastValue.Equals(value.Name, StringComparison.OrdinalIgnoreCase))
                    {
                        lastValue = value.Name;
                        writer.AddXmlDocSummary($"Gets the name of the <c>{value.Name}</c> property. {value.Prose.EscapeXml()}");
                        writer.AddLine($"public string {value.Name.ToPascalCase()} => CssValues.{value.Name.ToPascalCase()};");
                        writer.AddLine();
                    }

                }
            }

            writer.CloseClass();

            var keySuffix = string.Empty;
            var coreName = property.Key.ToPascalCase().Trim();
            var key = coreName.ToUpper();
            if (keys.ContainsKey(key))
            {
                keys[key] = keys[key] + 1;
            }
            else
            {
                keys[key] = 1;
            }

            if (keys[key] > 1)
            {
                keySuffix = keys[key].ToString();
            }

            try
            {
                var keyToUse = $"{coreName}Values{keySuffix}";
                results[keyToUse] = writer.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        return results;
    }
}