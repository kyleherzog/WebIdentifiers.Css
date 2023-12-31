using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using System.Reflection;
using WebIdentifiers.Css.Generating.Models;

namespace WebIdentifiers.Css.Generating
{
    [Generator]
    public class CssGenerator : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
            var references = LoadResources();

            context.AddSource("CssPropertyNames.g.cs", CssPropertyNamesGenerator.Generate(references));

            var typeValues = GetTypesValues(references);
            context.AddSource("CssValues.g.cs", CssPropertyValuesGenerator.Generate(references, typeValues));
            context.AddSource("CssUnits.g.cs", CssPropertyValuesGenerator.GenerateUnits(references, typeValues));
            context.AddSource("CssProperties.g.cs", CssPropertiesGenerator.Generate(references));

            var valuesPerProperty = CssPropertyValuesGenerator.GeneratePerProperty(references, typeValues);
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

            //var typeValues = GenerateTypeValues(references);
            //foreach (var typeValue in typeValues)
            //{
            //    var fileName = $"TypeValues/{typeValue.Key}.g.cs";
            //    context.AddSource(fileName, typeValue.Value);
            //}
        }

        internal static Dictionary<string, IEnumerable<CssPropertyValue>> GetTypesValues(IEnumerable<CssReference> references)
        {
            var results = new Dictionary<string, IEnumerable<CssPropertyValue>>();

            var outerValues = references.Where(x => x.Values is not null)
                .SelectMany(x => x.Values)
                .Where(x => x.Type == "type" && x.Values is not null)
                .GroupBy(x => x.Name)
                .OrderBy(x => x.Key);

            var suffixTypes = new string[]
            {
                "<length>",
                "<angle>",
                "<time>",
                "<frequency>",
                "<resolution>",
            };


            foreach (var outerValue in outerValues)
            {
                var isSuffix = suffixTypes.Contains(outerValue.Key);
                var values = outerValue.SelectMany(x => x.Values).Where(x => x.Type == "value" && !x.Name.Contains("<") && !x.Name.Contains("(")).OrderBy(x => x.Name);
                if (values.Any())
                {
                    var propertyVars = values.GroupBy(x => x.Name).Select(x => x.First());
                    if (isSuffix)
                    {
                        foreach (var propertyVar in propertyVars)
                        {
                            propertyVar.IsUnitOfMeasure = true;
                        }
                    }
                    results.Add(outerValue.Key, propertyVars);
                }
            }

            return results;
        }

        //internal static Dictionary<string, string> GenerateTypeValues(IEnumerable<CssReference> references)
        //{
        //    var results = new Dictionary<string, string>();

        //    var outerValues = references.Where(x => x.Values is not null)
        //        .SelectMany(x => x.Values)
        //        .Where(x => x.Type == "type" && x.Values is not null)
        //        .GroupBy(x => x.Name)
        //        .OrderBy(x => x.Key);

        //    foreach (var outerValue in outerValues)
        //    {
        //        var values = outerValue.SelectMany(x => x.Values).Where(x => x.Type == "value" && !x.Name.Contains("<") && !x.Name.Contains("(")).OrderBy(x => x.Name);
        //        if (values.Any())
        //        {
        //            var propertiesWriter = new ClassWriter();

        //            propertiesWriter.AddLine("namespace WebIdentifiers.Css;");
        //            propertiesWriter.AddLine();

        //            var className = $"{outerValue.Key.ToPascalCase().Replace("<", string.Empty).Replace(">", string.Empty)}TypeValues";
        //            propertiesWriter.OpenClass(className);
        //            var lastName = string.Empty;
        //            foreach (var entry in values)
        //            {
        //                if (lastName != entry.Name)
        //                {
        //                    lastName = entry.Name;
        //                    //propertiesWriter.XmlDocs.AddSummary($"Gets the name of the <c>{property.Name}</c> property.");
        //                    propertiesWriter.AddLine($"public const string {entry.Name.ToPascalCase()} = \"{entry.Value}\";");
        //                    propertiesWriter.AddLine();
        //                }

        //            }
        //            propertiesWriter.CloseClass();

        //            results[className] = propertiesWriter.ToString();
        //        }
        //    }

        //    return results;
        //}

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