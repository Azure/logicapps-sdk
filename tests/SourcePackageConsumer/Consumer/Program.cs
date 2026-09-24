using Microsoft.Azure.Workflows.Sdk;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

var shippedLegacyTypes = typeof(WorkflowActions).Assembly.GetTypes()
    .Where(type => type.Namespace == "Microsoft.Azure.Workflows.Sdk.Expressions" ||
        type.FullName == "Microsoft.Azure.Workflows.Sdk.CSharpExpressionConverter" ||
        type.FullName == "Microsoft.Azure.Workflows.Sdk.ExpressionConverter")
    .Select(type => type.FullName)
    .ToArray();
if (shippedLegacyTypes.Length != 0)
{
    throw new InvalidOperationException($"Legacy expression-tree types are still shipped: {string.Join(", ", shippedLegacyTypes)}");
}

var descriptorApi = typeof(SourceExpression);
if (descriptorApi.GetMethod("TypeName", new[] { typeof(Type) }) is null)
{
    throw new InvalidOperationException("The packaged runtime is stale: SourceExpression.TypeName(Type) is missing.");
}
if (!descriptorApi.GetMethods().Any(method => method.Name == "Token" && method.IsGenericMethodDefinition))
{
    throw new InvalidOperationException("The packaged runtime is stale: SourceExpression.Token<T> is missing.");
}
if (!descriptorApi.GetMethods().Any(method => method.Name == "Value" && method.IsGenericMethodDefinition))
{
    throw new InvalidOperationException("The packaged runtime is stale: SourceExpression.Value<T> is missing.");
}
if (!descriptorApi.GetMethods().Any(method => method.Name == "Json") ||
    !descriptorApi.GetMethods().Any(method => method.Name == "Enum" && method.IsGenericMethodDefinition) ||
    !typeof(SourceBinding).GetMethods().Any(method => method.Name == "EnumWire"))
{
    throw new InvalidOperationException("The packaged runtime is stale: final Json/Enum/EnumWire APIs are missing.");
}

var createOverloads = descriptorApi.GetMethods().Where(method => method.Name == "Create").ToArray();
if (!createOverloads.Any(method => method.GetParameters().Any(parameter => parameter.Name == "nativeSegments")) ||
    !createOverloads.Any(method => method.GetParameters().Any(parameter => parameter.Name == "typeWitness")))
{
    throw new InvalidOperationException("The packaged runtime is stale: SourceExpression.Create nativeSegments/typeWitness parameters are missing.");
}

var suffix = "!";
var observedSource = new CountingSource { Name = "Source" };
IOutputWorkflowAction<string> source = observedSource;
var compose = WorkflowActions.BuiltIn.Compose(inputs: () => source.Output.ToUpperInvariant() + suffix);
suffix = "changed after construction";
var definition = ((WorkflowActionBase)compose).GetActionDefinition("PackageConsumer");
var expected = "#{outputs(\"Source\").ToObject<string>().ToUpperInvariant() + \"!\"}";
var actual = definition.Inputs?.ToString()
    ?.Replace("ToObject<global::System.String>()", "ToObject<string>()", StringComparison.Ordinal);
if (actual != expected)
{
    throw new InvalidOperationException($"Expected {expected}; actual {actual}");
}

var escapedCapture = "\"\\source.Output";
var captured = WorkflowActions.BuiltIn.Compose(inputs: () => source.Output + escapedCapture);
escapedCapture = "changed after construction";
var capturedDefinition = ((WorkflowActionBase)captured).GetActionDefinition("PackageConsumer");
var capturedText = capturedDefinition.Inputs?.ToString()
    ?.Replace("ToObject<global::System.String>()", "ToObject<string>()", StringComparison.Ordinal);
if (capturedText != """#{outputs("Source").ToObject<string>() + "\"\\source.Output"}""")
{
    throw new InvalidOperationException($"Escaped capture was not preserved as a construction-time snapshot: {capturedText}");
}

var interpolation = WorkflowActions.BuiltIn.Compose(inputs: () => $"{{Name}}: {source.Output}; again: {source.Output}");
var interpolationDefinition = ((WorkflowActionBase)interpolation).GetActionDefinition("PackageConsumer");
if (interpolationDefinition.Inputs?.ToString() != """#{$"{{Name}}: {outputs("Source").ToObject<string>()}; again: {outputs("Source").ToObject<string>()}"}""")
{
    throw new InvalidOperationException("Escaped interpolation changed its literal braces or workflow references.");
}

var structure = WorkflowActions.BuiltIn.Compose(input: () => new
{
    outer = new { enabled = true, name = source.Output },
    entries = new[] { new { label = "a" }, new { label = "b" } },
});
var structureDefinition = ((WorkflowActionBase)structure).GetActionDefinition("PackageConsumer");
if (!JToken.DeepEquals(JToken.FromObject(structureDefinition.Inputs), JObject.Parse("""
    {
        "outer": { "enabled": true, "name": "#{outputs(\"Source\")}" },
        "entries": [ { "label": "a" }, { "label": "b" } ]
    }
    """)))
{
    throw new InvalidOperationException("Anonymous structural values failed their compiler type-witness contract.");
}

var genericReference = ReferenceValue(source);
var genericDefinition = ((WorkflowActionBase)genericReference).GetActionDefinition("PackageConsumer");
if (genericDefinition.Inputs?.ToString() != "#{outputs(\"Source\")}")
{
    throw new InvalidOperationException("Generic workflow references did not retain their concrete CLR type.");
}

var tokenInput = WorkflowActions.BuiltIn.Compose<JToken>(() => source.Output.ToUpperInvariant());
var tokenDefinition = ((WorkflowActionBase)tokenInput).GetActionDefinition("PackageConsumer");
var tokenText = tokenDefinition.Inputs?.ToString()
    ?.Replace("ToObject<global::System.String>()", "ToObject<string>()", StringComparison.Ordinal);
if (tokenText != "#{outputs(\"Source\").ToObject<string>().ToUpperInvariant()}")
{
    throw new InvalidOperationException($"Trusted JToken conversion lost its inner source descriptor: {tokenText}");
}

var json = JsonConvert.SerializeObject(new[]
{
    definition, capturedDefinition, interpolationDefinition, structureDefinition, genericDefinition, tokenDefinition,
});
if (observedSource.OutputReads != 0)
{
    throw new InvalidOperationException($"Authoring lambda executed {observedSource.OutputReads} workflow output reads.");
}
_ = observedSource.Output;
if (observedSource.OutputReads != 1)
{
    throw new InvalidOperationException("The invocation-count sentinel did not observe its positive control.");
}
Console.WriteLine(json);

static IOutputWorkflowAction<T> ReferenceValue<T>(IOutputWorkflowAction<T> value) =>
    WorkflowActions.BuiltIn.Compose(input: () => value.Output);

sealed class CountingSource : WorkflowActionBase, IOutputWorkflowAction<string>
{
    public int OutputReads { get; private set; }
    public string Output { get { OutputReads++; return "source"; } }
    public override FlowTemplateAction GetActionDefinition(string flowName, FlowKind? flowKind = null) =>
        new FlowTemplateAction { Type = FlowTemplateOperationType.Compose, Inputs = "source" };
}
