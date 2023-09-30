using CodeCasing;
using Microsoft.CodeAnalysis;
using WebIdentifiers.Css.Generating.Models;

namespace WebIdentifiers.Css.Generating;

internal static class CssPropertiesGenerator
{
    internal static string Generate(IEnumerable<CssReference> references)
    {
        var entriesWriter = new ClassWriter();

        entriesWriter.AddUsings("WebIdentifiers.Css.Properties");
        entriesWriter.AddLine("namespace WebIdentifiers.Css;");
        entriesWriter.AddLine();

        entriesWriter.AddXmlDocSummary("Provides access to specific CSS property entry objects.");
        entriesWriter.OpenClass("CssProperties", isStatic: true);

        var lastProperty = string.Empty;
        foreach (var property in references.Where(x => x.Properties is not null).SelectMany(x => x.Properties).OrderBy(x => x.Name))
        {
            if (!lastProperty.Equals(property.Name, StringComparison.Ordinal))
            {
                lastProperty = property.Name;
                entriesWriter.AddXmlDocSummary($"Gets a new <see cref=\"{property.Name.ToPascalCase()}Property\" /> instance, which represents a CSS property entry with a property name of <c>{property.Name}</c>.");
                entriesWriter.AddLine($"public static {property.Name.ToPascalCase()}Property {property.Name.ToPascalCase()} => new();");
                entriesWriter.AddLine();
            }
        }

        entriesWriter.CloseClass();

        return entriesWriter.ToString();
    }

    internal static Dictionary<string, string> GeneratePerProperty(IEnumerable<CssReference> references)
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

            writer.AddLine("namespace WebIdentifiers.Css.Properties;");
            writer.AddLine();

            var propertyName = $"{property.Key.ToPascalCase()}";
            var entryClassName = $"{propertyName}Property";

            writer.AddXmlDocSummary($"Provides a CSS entry for the {propertyName} property.");
            writer.OpenClass(entryClassName, "CssPropertyEntry");

            writer.AddXmlDocSummary($"Represents a {property.Key} CSS property entry.");
            writer.AddLine("/// <param name=\"value\">An optional value with which to initialize the CSS property entry.</param>");
            writer.AddLine($"public {entryClassName}(string? value = null)");
            writer.AddChildLine($": base(CssPropertyNames.{propertyName}, value)");
            writer.OpenBlock();
            writer.CloseBlock();

            if (values.Any())
            {
                var lastValue = string.Empty;
                foreach (var value in values)
                {
                    if (!lastValue.Equals(value.Name, StringComparison.OrdinalIgnoreCase))
                    {
                        lastValue = value.Name;
                        writer.AddXmlDocSummary($"Sets the value of the property entry to <c>{value.Name}</c>. {value.Prose.EscapeXml()}");
                        writer.AddLine($"public {entryClassName} SetTo{value.Name.ToPascalCase()}()");
                        writer.OpenBlock();
                        writer.AddLine($"Value = CssValues.{value.Name.ToPascalCase()};");
                        writer.AddLine("return this;");
                        writer.CloseBlock();
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
                var keyToUse = $"{coreName}Property{keySuffix}";
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