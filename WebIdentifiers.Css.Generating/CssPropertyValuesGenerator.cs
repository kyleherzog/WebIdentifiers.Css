using System.Xml.Linq;
using CodeCasing;
using WebIdentifiers.Css.Generating.CodeWriting;
using WebIdentifiers.Css.Generating.Models;

namespace WebIdentifiers.Css.Generating;

internal static class CssPropertyValuesGenerator
{
    public static string GenerateUnits(
        IEnumerable<CssReference> references,
        IDictionary<string, IEnumerable<CssPropertyValue>> typeValues)
    {
        var valuesWriter = new ClassWriter();
        valuesWriter.AddLine("namespace WebIdentifiers.Css;");
        valuesWriter.AddLine();

        valuesWriter.XmlDocs.AddSummary("Provides methods for generating CSS values using predefined CSS units of measure.");
        valuesWriter.OpenClass("CssUnits", isStatic: true);

        var unitTypeValues = typeValues.SelectMany(x => x.Value).Where(x => x.IsUnitOfMeasure);

        // filter suffixedTypeValues to distinct values by the Name property
        unitTypeValues = unitTypeValues.GroupBy(x => x.Name).Select(x => x.First()).ToList();

        foreach (var unitTypeValue in unitTypeValues)
        {
            valuesWriter.XmlDocs.AddSummary($"Generates a string with the given value suffixed with the <c>{unitTypeValue.Name}</c> identifier.");
            valuesWriter.XmlDocs.AddParam("value", "The value to be suffixed with the CSS unit of measure.");
            valuesWriter.XmlDocs.AddReturns("The value formatted with the CSS unit of measure.");
            valuesWriter.AddLine($"public static string {unitTypeValue.Name.ToPascalCase()}(object? value) => GetUnitValue(value, \"{unitTypeValue.Value}\");");
            valuesWriter.AddLine();
        }

        valuesWriter.AddLine($"private static string GetUnitValue(object? value, string unitOfMeasure)");
        valuesWriter.OpenBlock();

        valuesWriter.AddLine("if (value is null)");
        valuesWriter.OpenBlock();
        valuesWriter.AddLine("return string.Empty;");
        valuesWriter.CloseBlock(); // if

        valuesWriter.AddLine("var stringValue = value.ToString();");
        valuesWriter.AddLine("if (stringValue == \"0\")");
        valuesWriter.OpenBlock();
        valuesWriter.AddLine("return \"0\";");
        valuesWriter.CloseBlock(); // if

        valuesWriter.AddLine("return $\"{stringValue}{unitOfMeasure}\";");

        valuesWriter.CloseBlock(); // method
        valuesWriter.CloseClass();
        return valuesWriter.ToString();
    }

    public static string Generate(
        IEnumerable<CssReference> references,
        IDictionary<string, IEnumerable<CssPropertyValue>> typeValues)
    {
        var valuesWriter = new ClassWriter();
        valuesWriter.AddUsings("WebIdentifiers.Css.Values");

        valuesWriter.AddLine("namespace WebIdentifiers.Css;");
        valuesWriter.AddLine();

        valuesWriter.XmlDocs.AddSummary("Provides predefined CSS values.");
        valuesWriter.OpenClass("CssValues", isStatic: true);

        var valuedProperties = references.Where(x => x.Properties is not null).SelectMany(x => x.Properties)
            .Where(x => x.Values is not null);

        var valueNames = valuedProperties
            .SelectMany(x => x.Values)
            .Select(x => x.Name)
            .Where(x => !x.Contains('<') && !x.Contains('|') && !x.StartsWith("[") && !x.EndsWith(")") && !x.StartsWith("/") && !x.Contains('&'))
            .Distinct().ToList();

        var fullValues = typeValues.SelectMany(x => x.Value).Where(x => !x.IsUnitOfMeasure);

        valueNames.AddRange(fullValues.Select(x => x.Name));
        var ignoredValues = new[]
        {
            "last-baseline" //conflicts with "last baseline"
        };
        valueNames = valueNames.Where(x => !ignoredValues.Contains(x)).Distinct().OrderBy(x => x).ToList();

        foreach (var valueName in valueNames)
        {
            valuesWriter.XmlDocs.AddSummary($"Gets the name of the <c>{valueName}</c> property value.");
            valuesWriter.AddLine($"public const string {valueName.ToPascalCase()} = \"{valueName}\";");
            valuesWriter.AddLine();
        }

        foreach (var propertyName in references.Where(x => x.Properties is not null).SelectMany(x => x.Properties).Select(x => x.Name).Distinct())
        {
            valuesWriter.XmlDocs.AddSummary($"Gets values which are valid for the <c>{propertyName}</c> property.");
            valuesWriter.AddLine($"public static {propertyName.ToPascalCase()}Values For{propertyName.ToPascalCase()} = new();");
            valuesWriter.AddLine();
        }

        valuesWriter.CloseClass();
        return valuesWriter.ToString();
    }

    public static Dictionary<string, string> GeneratePerProperty(IEnumerable<CssReference> references, IDictionary<string, IEnumerable<CssPropertyValue>> typeValues)
    {
        var results = new Dictionary<string, string>();
        var keys = new Dictionary<string, int>();
        var propertyGroups = references.Where(x => x.Properties is not null).SelectMany(x => x.Properties).GroupBy(x => x.Name);

        foreach (var propertyGroup in propertyGroups)
        {
            var values = propertyGroup.Where(x => x.Values is not null).SelectMany(x => x.Values).ToList();

            var singleValues = values?.Where(x => !x.Name.Contains('<') && !x.Name.Contains('|') && !x.Name.StartsWith("[") && !x.Name.EndsWith(")") && !x.Name.StartsWith("/") && !x.Name.Contains('&'))
                .OrderBy(x => x.Name)
                ?? Enumerable.Empty<CssPropertyValue>();

            var writer = new ClassWriter();

            writer.AddLine("namespace WebIdentifiers.Css.Values;");
            writer.AddLine();

            writer.XmlDocs.AddSummary($"Provides values which are valid for the <c>{propertyGroup.Key}</c> property.");
            writer.OpenClass($"{propertyGroup.Key.ToPascalCase()}Values", "PropertyValuesBase");

            var addedNames = new List<string>();

            if (singleValues.Any())
            {
                foreach (var value in singleValues)
                {
                    if (!addedNames.Any(x => x.Equals(value.Name, StringComparison.OrdinalIgnoreCase)))
                    {
                        addedNames.Add(value.Name);
                        writer.XmlDocs.AddSummary($"Gets the name of the <c>{value.Name}</c> property. {value.Prose?.EscapeXml()}".TrimEnd());
                        writer.AddLine($"public string {value.Name.ToPascalCase()} => CssValues.{value.Name.ToPascalCase()};");
                        writer.AddLine();
                    }

                }
            }

            var valueVars = values?.Where(x => x.Name.Contains('<')).Select(x => x.Name.Split('|')).SelectMany(x => x).Where(x => x.Contains('<')).ToList()
                ?? new List<string>();
            valueVars.AddRange(propertyGroup.Select(x => x.Value ?? string.Empty).Where(x => x is not null).Select(x => x.Split('|')).SelectMany(x => x).Where(x => x.Contains('<')));

            foreach (var valueVar in valueVars)
            {
                if (typeValues.ContainsKey(valueVar))
                {
                    foreach (var value in typeValues[valueVar].Where(x => !x.IsUnitOfMeasure))
                    {
                        if (!addedNames.Any(x => x.Equals(value.Name, StringComparison.OrdinalIgnoreCase)))
                        {
                            addedNames.Add(value.Name);
                            writer.XmlDocs.AddSummary($"Gets the name of the <c>{value.Name}</c> property. {value.Prose?.EscapeXml()}".TrimEnd());
                            writer.AddLine($"public string {value.Name.ToPascalCase()} => CssValues.{value.Name.ToPascalCase()};");
                            writer.AddLine();
                        }
                    }
                }
            }



            writer.CloseClass();

            var keySuffix = string.Empty;
            var coreName = propertyGroup.Key.ToPascalCase().Trim();
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