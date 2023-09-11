using System;
using System.Text;
using CodeCasing;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using WebIdentifiers.Css.Generating.Models;

namespace WebIdentifiers.Css.Generating
{
    [Generator]
    public class CssGenerator : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
            var reference = JsonConvert.DeserializeObject<CssReference>(Properties.Resources.Css)
                ?? throw new JsonSerializationException("Unable to deserialize resource.");

            WritePropertiesClass(context, reference);

            var valuesWriter = new ClassWriter();
            valuesWriter.AddUsings("WebIdentifiers.Css.Values");

            valuesWriter.AddLine("namespace WebIdentifiers.Css;");
            valuesWriter.AddLine();

            valuesWriter.OpenClass("CssValues", isStatic: true);

            var valuedProperties = reference.Properties
                .Where(x => x.Values is not null);
            var valueNames = valuedProperties
                .SelectMany(x => x.Values)
                .Select(x => x.Name)
                .Where(x => !x.StartsWith("<") && !x.StartsWith("[") && !x.EndsWith(")"))
                .Distinct()
                .OrderBy(x => x);

            foreach (var valueName in valueNames)
            {
                valuesWriter.AddXmlDocSummary($"Gets the name of the <c>{valueName}</c> property.");
                valuesWriter.AddLine($"public const string {valueName.ToPascalCase()} = \"{valueName}\";");
                valuesWriter.AddLine();
            }

            foreach (var property in reference.Properties)
            {
                valuesWriter.AddXmlDocSummary($"Gets values which are valid for the <c>{property.Name}</c> property.");
                valuesWriter.AddLine($"public static {property.Name.ToPascalCase()}Values For{property.Name.ToPascalCase()} = new();");
                valuesWriter.AddLine();
            }

            valuesWriter.CloseClass();
            context.AddSource("CssValues.g.cs", valuesWriter.ToString());

            WritePropertySpecificValueClasses(context, reference);
        }

        private void WritePropertiesClass(GeneratorExecutionContext context, CssReference reference)
        {
            var propertiesWriter = new ClassWriter();
            propertiesWriter.AddLine("namespace WebIdentifiers.Css;");
            propertiesWriter.AddLine();

            propertiesWriter.OpenClass("CssProperties", isStatic: true);

            foreach (var property in reference.Properties.OrderBy(x => x.Name))
            {
                propertiesWriter.AddXmlDocSummary($"Gets the name of the <c>{property.Name}</c> property.");
                propertiesWriter.AddLine($"public const string {property.Name.ToPascalCase()} = \"{property.Name}\";");
                propertiesWriter.AddLine();
            }
            propertiesWriter.CloseClass();

            context.AddSource("CssProperties.g.cs", propertiesWriter.ToString());
        }

        private void WritePropertySpecificValueClasses(GeneratorExecutionContext context, CssReference reference)
        {
            foreach (var property in reference.Properties)
            {
                var writer = new ClassWriter();

                writer.AddLine("namespace WebIdentifiers.Css.Values;");
                writer.AddLine();

                writer.OpenClass($"{property.Name.ToPascalCase()}Values", "PropertyValuesBase");
                var values = property.Values
                    ?.Where(x => !x.Name.StartsWith("<") && !x.Name.StartsWith("[") && !x.Name.EndsWith(")"))
                    ?? Enumerable.Empty<CssPropertyValue>();
                if (values.Any())
                {
                    foreach (var value in values)
                    {
                        writer.AddXmlDocSummary($"Gets the name of the <c>{value.Name}</c> property. {value.Prose}");
                        writer.AddLine($"public string {value.Name.ToPascalCase()} => CssValues.{value.Name.ToPascalCase()};");
                        writer.AddLine();
                    }
                }

                writer.CloseClass();
                context.AddSource($"Values\\{property.Name.ToPascalCase()}Values.g.cs", writer.ToString());
            }
        }

        public void Initialize(GeneratorInitializationContext context)
        {
            // required by ISourceGenerator
        }
    }
}
