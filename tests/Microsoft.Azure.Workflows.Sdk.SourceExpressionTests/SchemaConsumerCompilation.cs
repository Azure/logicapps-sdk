namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using System.Reflection;
using Microsoft.Azure.Workflows.Sdk.Build;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Newtonsoft.Json.Linq;

internal static class SchemaConsumerCompilation
{
    internal static string Fixture => File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "Fixtures", "catalog-destinations.schema.json"));

    internal static (CSharpCompilation Compilation, TransformationResult Transformation) Transform(string body, string? schema = null)
    {
        var generated = WorkflowSchemaGenerator.Generate(schema ?? Fixture);
        var consumer = ConsumerCompilation.Source(
            ConsumerCompilation.Handles + ConsumerCompilation.CoreHandles + body,
            imports: "using Catalog.Generated;");
        var original = ConsumerCompilation.Compile(consumer).AddSyntaxTrees(generated.Select(file =>
            CSharpSyntaxTree.ParseText(file.Value, new CSharpParseOptions(LanguageVersion.CSharp13), file.Key)));
        Assert.Empty(original.GetDiagnostics().Where(d => d.Severity == DiagnosticSeverity.Error));
        var transformed = ExpressionCompilationTransformer.Transform(original);
        return (original.RemoveAllSyntaxTrees().AddSyntaxTrees(transformed.Sources.Select(file =>
            CSharpSyntaxTree.ParseText(file.Value, new CSharpParseOptions(LanguageVersion.CSharp13), file.Key))), transformed);
    }

    internal static (JToken Value, Assembly Assembly, TransformationResult Transformation) Build(string invocation, string setup = "", string after = "", string? schema = null)
    {
        var compiled = Transform(setup + $$"""
            var action = {{invocation}};
            {{after}}
            return action.GetActionDefinition("SchemaCatalog");
            """, schema);
        Assert.Empty(compiled.Transformation.Diagnostics);
        var assembly = ConsumerCompilation.Load(compiled.Compilation);
        var definition = (FlowTemplateAction)ConsumerCompilation.Invoke(assembly, "Consumer", "Build")!;
        Assert.Equal(0, assembly.GetType("RuntimeValues")!.GetField("Calls")!.GetValue(null));
        return (ConsumerCompilation.Token(definition), assembly, compiled.Transformation);
    }
}
