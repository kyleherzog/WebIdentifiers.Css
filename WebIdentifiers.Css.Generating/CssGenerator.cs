using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using CodeCasing;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using WebIdentifiers.Css.Generating.Models;
using static Microsoft.VisualStudio.Threading.AsyncReaderWriterLock;

namespace WebIdentifiers.Css.Generating
{
    [Generator]
    public class CssGenerator : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
            var references = LoadResources();

            context.AddSource("TypeValues.g.cs", GenerateTypeValues(references));

            context.AddSource("CssPropertyNames.g.cs", CssPropertyNamesGenerator.Generate(references));
            context.AddSource("CssValues.g.cs", CssPropertyValuesGenerator.Generate(references));
            context.AddSource("CssProperties.g.cs", CssPropertiesGenerator.Generate(references));

            var valuesPerProperty = CssPropertyValuesGenerator.GeneratePerProperty(references);
            foreach (var file in valuesPerProperty)
            {
                var fileName = $"Values/{file.Key}.g.cs";
                context.AddSource(fileName, file.Value);
            }

            var properties = CssPropertiesGenerator.GeneratePerProperty(references);
            foreach (var property in properties)
            {
                var fileName = $"Properties/{property.Key}.g.cs";
                context.AddSource(fileName, property.Value);
            }
        }

        internal static string GenerateTypeValues(IEnumerable<CssReference> references)
        {
            var propertiesWriter = new ClassWriter();

            propertiesWriter.AddLine("namespace WebIdentifiers.Css;");
            propertiesWriter.AddLine();

            var outerValues = references.Where(x => x.Values is not null)
                .SelectMany(x => x.Values)
                .Where(x => x.Type == "type" && x.Values is not null)
                .GroupBy(x => x.Name)
                .OrderBy(x => x.Key);

            foreach (var outerValue in outerValues)
            {
                var values = outerValue.SelectMany(x => x.Values).Where(x => x.Type == "value" && !x.Name.Contains("<") && !x.Name.Contains("(")).OrderBy(x => x.Name);
                if (values.Any())
                {
                    propertiesWriter.OpenClass($"{outerValue.Key.ToPascalCase().Replace("<", string.Empty).Replace(">", string.Empty)}TypeValue");
                    var lastName = string.Empty;
                    foreach (var entry in values)
                    {
                        if (lastName != entry.Name)
                        {
                            lastName = entry.Name;
                            //propertiesWriter.AddXmlDocSummary($"Gets the name of the <c>{property.Name}</c> property.");
                            propertiesWriter.AddLine($"public const string {entry.Name.ToPascalCase()} = \"{entry.Value}\";");
                            propertiesWriter.AddLine();
                        }

                    }
                    propertiesWriter.CloseClass();
                }

            }

            return propertiesWriter.ToString();
        }

        private IEnumerable<CssReference> LoadResources()
        {
            var results = new List<CssReference>();
            Assembly assembly = Assembly.GetExecutingAssembly(); // Use your assembly or another
            string[] resourceNames = assembly.GetManifestResourceNames();
            foreach (string resourceName in resourceNames)
            {
                using var stream = assembly.GetManifestResourceStream(resourceName);
                using var reader = new StreamReader(stream);
                var serialized = reader.ReadToEnd();
                results.Add(JsonConvert.DeserializeObject<CssReference>(serialized)
                    ?? throw new JsonSerializationException($"Unable to deserialize resource '{resourceName}'."));
            }

            return results;
        }

        public void Initialize(GeneratorInitializationContext context)
        {
            // required by ISourceGenerator
        }
    }
}
