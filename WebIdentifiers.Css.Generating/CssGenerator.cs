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
